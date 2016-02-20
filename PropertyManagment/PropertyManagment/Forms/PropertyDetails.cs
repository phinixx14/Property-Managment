using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace PropertyManagment
{
    public partial class PropertyDetails : Form
    {
        Property SelectedProperty;
        public MainForm creatingForm;

        public PropertyDetails(Property property, MainForm form)
        {
            InitializeComponent();
            SelectedProperty = property;
            creatingForm = form;
            
            //sample
            //SelectedProperty.PropertyFeatures = new Features() { Basement = true, Bathrooms = 2, Bedrooms = 3, Floors = 3 };
            //end sample

            LoadImageAndLabels();
            LoadInformationDGV();
            LoadMaintenanceDGV();
            LoadNoteDGV();
            LoadFinanceDGV();
        }
        public void LoadImageAndLabels()
        {
            lbl_StreetAddress.Text = SelectedProperty.StreetAddress.StreetAddress;
            lbl_CityStateZip.Text = SelectedProperty.StreetAddress.City + ", " + SelectedProperty.StreetAddress.State;
            img_Picture.Image = SelectedProperty.Image != null ? SelectedProperty.Image : Properties.Resources.unavailable;
            btn_Move.Text = SelectedProperty.IsRented ? "Move Out" : "Move In";
        }
        public void LoadInformationDGV()
        {
            dgv_Information.Rows.Clear();
            int i = 0;
            if (SelectedProperty.IsRented)
            {
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Tenants:";
            }

            foreach (Tenant t in SelectedProperty.CurrentTenants)
            {
                if (i > 0)
                { dgv_Information.Rows.Add(); }
                dgv_Information.Rows[i].Cells[0].Value = t.TenantID;
                dgv_Information.Rows[i++].Cells[2].Value = string.Format(t.FirstName + " " + t.LastName);
            }
            if (!ReferenceEquals(null, SelectedProperty.PropertyFeatures))
            {
                foreach (PropertyInfo p in SelectedProperty.PropertyFeatures.GetType().GetProperties())
                {
                    dgv_Information.Rows.Add();
                    dgv_Information.Rows[i].Cells[1].Value = p.Name;
                    dgv_Information.Rows[i++].Cells[2].Value = p.GetValue(SelectedProperty.PropertyFeatures);
                }

                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Purchase Price";
                dgv_Information.Rows[i++].Cells[2].Value = string.Format("{0:C}", SelectedProperty.PurchasePrice);
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Aquisition Date";
                dgv_Information.Rows[i++].Cells[2].Value = SelectedProperty.AquisitionDate.ToString("ddMMMyyyy");
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Rent";
                dgv_Information.Rows[i++].Cells[2].Value = string.Format("{0:C}", SelectedProperty.Rent);
            }
            if (SelectedProperty.IsRented)
            {
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Lease Term";
                dgv_Information.Rows[i++].Cells[2].Value = SelectedProperty.CurrentLease.StartDate.ToString("ddMMMyyyy") + " - " + SelectedProperty.CurrentLease.EndDate.ToString("ddMMMyyyy");
            }
        }
        public void LoadMaintenanceDGV()
        {
            BindingList<MaintenanceItem> source = new BindingList<MaintenanceItem>(MaintenanceItem.MaintenanceItems.Where(m => m.Location.PropertyID == SelectedProperty.PropertyID).ToList());
            dgv_Maintenance.DataSource = source;
            dgv_Maintenance.AutoGenerateColumns = false;
            dgv_Maintenance.Columns.Clear();
            foreach (string s in new string[] { "InstanceID", "Instance Name", "Description", "LatestDueDate" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dgv_Maintenance.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20, Selected = false });
            }
            dgv_Maintenance.Columns[0].Visible = false;
            dgv_Maintenance.AutoResizeColumns();
        }
        public void LoadNoteDGV()
        {
            BindingList<Note> source = new BindingList<Note>(SelectedProperty.Notes);
            dgv_Notes.DataSource = source;
            dgv_Notes.AutoGenerateColumns = false;
            dgv_Notes.Columns.Clear();
            foreach (string s in new string[] { "NoteID", "Text", "Written By", "CreationDate" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dgv_Notes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20, Selected = false });
            }
            dgv_Notes.Columns[0].Visible = false;
            dgv_Notes.AutoResizeColumns();
        }
        public void LoadFinanceDGV()
        {
            BindingList<IFinancial> source = new BindingList<IFinancial>(Occurence.Occurences.Where(i => i.Location.PropertyID == SelectedProperty.PropertyID && (i is Incident || i is Payment)).ToList().ConvertAll(c => c as IFinancial));
            dgv_Finances.DataSource = source;
            dgv_Finances.AutoGenerateColumns = false;
            dgv_Finances.Columns.Clear();
            foreach (string s in new string[] { "InstanceID", "Instance Name", "Description", "IncidentDate", "Amount" }) 
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dgv_Finances.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dgv_Finances.Columns[0].Visible = false;
            dgv_Finances.AutoResizeColumns();
        }

        private void img_Picture_Click(object sender, EventArgs e)
        {
            if (SelectedProperty.Image != null)
            {
                PictureView picView = new PictureView((Bitmap)img_Picture.Image) { obj = SelectedProperty, creatingForm = this };
                picView.Show();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (MemoryStream fStream = new MemoryStream())
                    {
                        openFileDialog1.OpenFile().CopyTo(fStream);
                        SelectedProperty.ImageData = fStream.GetBuffer();
                    }
                    img_Picture.Image = SelectedProperty.Image;
                    try
                    { creatingForm.LoadPropertyPage(); }
                    catch(Exception exception)
                    { MessageBox.Show(exception.Message); }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Name == btn_MaintenanceAdd.Name)
            {
                NewMaintenanceForm dialog = new NewMaintenanceForm(SelectedProperty, false);
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                { LoadMaintenanceDGV(); }
            }
            if (((Button)sender).Name == btn_FinancesAdd.Name)
            {
                SimplePrompt prompt = new SimplePrompt("Income or Expense?", "Finance", "Income", "Expense");
                prompt.ShowDialog();
                if (prompt.DialogResult == DialogResult.Yes)
                {
                    NewPaymentForm dialog = new NewPaymentForm(SelectedProperty);
                    dialog.ShowDialog();
                    if(dialog.DialogResult== DialogResult.OK)
                    { LoadFinanceDGV(); }
                }
                else if (prompt.DialogResult == DialogResult.No)
                {
                    AddIncidentForm dialog = new AddIncidentForm(SelectedProperty);
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    { LoadFinanceDGV(); }
                }
            }
            if (((Button)sender).Name == btn_NotesAdd.Name)
            {
                ViewNoteDataForm form = new ViewNoteDataForm(new Note(), dgv_Notes);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SelectedProperty.Notes.Add(form.note);
                    LoadNoteDGV();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == btn_MaintenanceEdit.Name)
            {
                try
                {
                    ViewOccurenceDataForm form = new ViewOccurenceDataForm(Occurence.GetOccurenceByID(dgv_Maintenance.SelectedRows[0].Cells[0].Value.ToString()));
                    if (form.ShowDialog() == DialogResult.Cancel)
                    { LoadMaintenanceDGV(); }
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_FinancesEdit.Name)
            {
                try
                {
                    ViewOccurenceDataForm form = new ViewOccurenceDataForm(Occurence.GetOccurenceByID(dgv_Finances.SelectedRows[0].Cells[0].Value.ToString()));
                    if (form.ShowDialog() == DialogResult.Cancel)
                    { LoadFinanceDGV(); }
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_InformationEdit.Name)
            {
                try
                {
                    ViewPropertyDataForm form = new ViewPropertyDataForm(Property.GetPropertyByID(SelectedProperty.PropertyID));
                    if (form.ShowDialog() == DialogResult.Cancel)
                    { LoadInformationDGV(); }
                }
                catch (ArgumentOutOfRangeException) { }
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == btn_MaintenanceDelete.Name)
            {
                try
                {
                    Occurence.Occurences.Remove(Occurence.GetOccurenceByID(dgv_Maintenance.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadMaintenanceDGV();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_FinancesDelete.Name)
            {
                try
                {
                    Occurence.Occurences.Remove(Occurence.GetOccurenceByID(dgv_Finances.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadFinanceDGV();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_NotesAdd.Name)
            {
                try
                {
                    SelectedProperty.Notes.Remove(SelectedProperty.Notes.Find(i => i.NoteID == dgv_Notes.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadNoteDGV();
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hti = ((DataGridView)sender).HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                if (sender is DataGridView)
                {
                    DataGridView source = (DataGridView)sender;
                    string ID = source.SelectedRows[0].Cells[0].Value.ToString();

                    string IDType = new string(ID.Take(ID.IndexOf('_')).ToArray());

                    switch (IDType)
                    {
                        case "Prop":
                            {
                                break;
                            }
                        case "Ten":
                            {
                                break;
                            }
                        case "Occ":
                            {
                                break;
                            }
                        case "Mnt":
                            {
                                ViewOccurenceDataForm form = new ViewOccurenceDataForm(MaintenanceItem.GetOccurenceByID(ID));
                                if (form.ShowDialog() == DialogResult.OK)
                                { LoadMaintenanceDGV(); }
                                break;
                            }
                        case "Inc":
                            {
                                ViewOccurenceDataForm form = new ViewOccurenceDataForm(Incident.GetOccurenceByID(ID));
                                if(form.ShowDialog() == DialogResult.OK)
                                { LoadFinanceDGV(); }
                                break;
                            }
                        case "Pay":
                            {
                                ViewOccurenceDataForm form = new ViewOccurenceDataForm(Incident.GetOccurenceByID(ID));
                                if (form.ShowDialog() == DialogResult.OK)
                                { LoadFinanceDGV(); }
                                break;
                            }
                        case "Note":
                            {
                                ViewNoteDataForm form = new ViewNoteDataForm(SelectedProperty.Notes.Find(i => i.NoteID == ID), dgv_Notes);
                                if (form.ShowDialog() == DialogResult.OK)
                                { LoadNoteDGV(); }
                                break;
                            }
                    }
                }
            }
        }
        
        private void dgv_Maintenance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = ((DateTime)e.Value).ToString("ddMMMyyyy");
            }
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            Form dialog;

            if (SelectedProperty.IsRented)
            { dialog = new MoveOutForm(SelectedProperty); }
            else
            { dialog = new MoveInForm(SelectedProperty); }

            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                LoadInformationDGV();
                LoadImageAndLabels();
            }
        }

        private void dgv_Finances_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            { e.Value = string.Format("{0:C}", e.Value); }
        }
    }
}