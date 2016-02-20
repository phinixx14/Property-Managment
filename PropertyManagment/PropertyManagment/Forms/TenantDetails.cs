using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PropertyManagment
{
    public partial class TenantDetails : Form
    {
        Tenant SelectedTenant;
        public MainForm creatingForm;

        public TenantDetails(Tenant tenant, MainForm form)
        {
            InitializeComponent();
            SelectedTenant = tenant;
            creatingForm = form;

            LoadImageAndLabels();
            LoadMaintenanceDGV();
            LoadNoteDGV();
            LoadFinanceDGV();
        }

        /*public void FillValues()
        {
            lbl_TenantName.Text = SelectedTenant.FirstName + " " + SelectedTenant.LastName;
            if (SelectedTenant.IsCurrentTenant)
            { lbl_Address.Text = SelectedTenant.Residence.StreetAddress.StreetAddress; }
            dgv_Information.Rows.Add(3);
            dgv_Information.Rows[0].Cells[0].Value = "DOB";
            dgv_Information.Rows[0].Cells[1].Value = SelectedTenant.DateOfBirth.ToString("dd MMM yyyy");
            dgv_Information.Rows[1].Cells[0].Value = "Phone";
            dgv_Information.Rows[1].Cells[1].Value = SelectedTenant.Phone;
            dgv_Information.Rows[2].Cells[0].Value = "Email";
            dgv_Information.Rows[2].Cells[1].Value = SelectedTenant.Email;

            img_Picture.Image = SelectedTenant.Image != null ? SelectedTenant.Image : Properties.Resources.unavailable;

            if (SelectedTenant.IsCurrentTenant)
            {
                foreach (MaintenanceItem item in MaintenanceItem.MaintenanceItems.Where(i => i.Location.PropertyID == SelectedTenant.Residence.PropertyID && i.TenantsInvolved.Contains(SelectedTenant)))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell() { Value = item.InstanceID };
                    DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell() { Value = item.InstanceName };
                    DataGridViewTextBoxCell Description = new DataGridViewTextBoxCell() { Value = item.Description };
                    DataGridViewTextBoxCell DueDate = new DataGridViewTextBoxCell() { Value = item.LatestDueDate.ToShortDateString() };
                    row.Cells.Add(ID);
                    row.Cells.Add(Name);
                    row.Cells.Add(Description);
                    row.Cells.Add(DueDate);

                    dgv_Maintenance.Rows.Add(row);
                }
            }
            else
            {
                foreach (MaintenanceItem item in MaintenanceItem.MaintenanceItems.Where(i => i.TenantsInvolved.Contains(SelectedTenant)))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell() { Value = item.InstanceID };
                    DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell() { Value = item.InstanceName };
                    DataGridViewTextBoxCell Description = new DataGridViewTextBoxCell() { Value = item.Description };
                    DataGridViewTextBoxCell DueDate = new DataGridViewTextBoxCell() { Value = item.LatestDueDate.ToShortDateString() };
                    row.Cells.Add(ID);
                    row.Cells.Add(Name);
                    row.Cells.Add(Description);
                    row.Cells.Add(DueDate);

                    dgv_Maintenance.Rows.Add(row);
                }
            }
        }*/
        public void LoadImageAndLabels()
        {
            lbl_TenantName.Text = SelectedTenant.FirstName + " " + SelectedTenant.LastName;
            lbl_Address.Text = SelectedTenant.IsCurrentTenant ? SelectedTenant.Residence.StreetAddress.StreetAddress : "No current address";
            img_Picture.Image = SelectedTenant.Image != null ? SelectedTenant.Image : Properties.Resources.unavailable;
        }
        /*public void LoadInformationDGV()
        {
            dgv_Information.Rows.Clear();
            int i = 0;
            if (SelectedTenant.IsRented)
            {
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Tenants:";
            }

            foreach (Tenant t in SelectedTenant.CurrentTenants)
            {
                if (i > 0)
                { dgv_Information.Rows.Add(); }
                dgv_Information.Rows[i].Cells[0].Value = t.TenantID;
                dgv_Information.Rows[i++].Cells[2].Value = string.Format(t.FirstName + " " + t.LastName);
            }

            foreach (PropertyInfo p in SelectedTenant.PropertyFeatures.GetType().GetProperties())
            {
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = p.Name;
                dgv_Information.Rows[i++].Cells[2].Value = p.GetValue(SelectedTenant.PropertyFeatures);
            }

            dgv_Information.Rows.Add();
            dgv_Information.Rows[i].Cells[1].Value = "Purchase Price";
            dgv_Information.Rows[i++].Cells[2].Value = string.Format("{0:C}", SelectedTenant.PurchasePrice);
            dgv_Information.Rows.Add();
            dgv_Information.Rows[i].Cells[1].Value = "Aquisition Date";
            dgv_Information.Rows[i++].Cells[2].Value = SelectedTenant.AquisitionDate.ToString("ddMMMyyyy");
            dgv_Information.Rows.Add();
            dgv_Information.Rows[i].Cells[1].Value = "Rent";
            dgv_Information.Rows[i++].Cells[2].Value = string.Format("{0:C}", SelectedTenant.Rent);
            if (SelectedTenant.IsRented)
            {
                dgv_Information.Rows.Add();
                dgv_Information.Rows[i].Cells[1].Value = "Lease Term";
                dgv_Information.Rows[i++].Cells[2].Value = SelectedTenant.CurrentLease.StartDate.ToString("ddMMMyyyy") + " - " + SelectedTenant.CurrentLease.EndDate.ToString("ddMMMyyyy");
            }
        }*/
        public void LoadMaintenanceDGV()
        {
            BindingList<MaintenanceItem> source = new BindingList<MaintenanceItem>(MaintenanceItem.MaintenanceItems.Where(m => m.TenantsInvolved.Select(t => t.TenantID).Contains(SelectedTenant.TenantID)).ToList());
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
            BindingList<Note> source = new BindingList<Note>(SelectedTenant.Notes);
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
            BindingList<IFinancial> source = new BindingList<IFinancial>(Occurence.Occurences.Where(i => i.TenantsInvolved.Select(t=>t.TenantID).Contains(SelectedTenant.TenantID) && (i is Incident || i is Payment)).ToList().ConvertAll(c => c as IFinancial));
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
            if (SelectedTenant.Image != null)
            {
                PictureView picView = new PictureView((Bitmap)img_Picture.Image) { obj = SelectedTenant, creatingForm = this };
                picView.Show();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (MemoryStream fStream = new MemoryStream())
                    {
                        openFileDialog1.OpenFile().CopyTo(fStream);
                        SelectedTenant.ImageData = fStream.GetBuffer();
                    }
                    img_Picture.Image = SelectedTenant.Image;
                    try
                    { creatingForm.LoadTenantPage(); }
                    catch (Exception exception)
                    { MessageBox.Show(exception.Message); }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == btn_MaintenanceAdd.Name)
            {
                if (SelectedTenant.IsCurrentTenant)
                {
                    NewMaintenanceForm dialog = new NewMaintenanceForm(SelectedTenant.Residence, false);
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    { LoadMaintenanceDGV(); }
                }
                else
                { MessageBox.Show("This tenant is not a current resident", "Notice", MessageBoxButtons.OK); }
            }
            if (((Button)sender).Name == btn_FinancesAdd.Name)
            {
                if (SelectedTenant.IsCurrentTenant)
                {
                    SimplePrompt prompt = new SimplePrompt("Income or Expense?", "Finance", "Income", "Expense");
                    prompt.ShowDialog();
                    if (prompt.DialogResult == DialogResult.Yes)
                    {
                        NewPaymentForm dialog = new NewPaymentForm(SelectedTenant.Residence);
                        dialog.ShowDialog();
                        if (dialog.DialogResult == DialogResult.OK)
                        { LoadFinanceDGV(); }
                    }
                    else if (prompt.DialogResult == DialogResult.No)
                    {
                        AddIncidentForm dialog = new AddIncidentForm(SelectedTenant.Residence);
                        dialog.ShowDialog();
                        if (dialog.DialogResult == DialogResult.OK)
                        { LoadFinanceDGV(); }
                    }
                }
                else
                { MessageBox.Show("This tenant is not a current resident", "Notice", MessageBoxButtons.OK); }
            }
            if (((Button)sender).Name == btn_NotesAdd.Name)
            {
                ViewNoteDataForm form = new ViewNoteDataForm(new Note(), dgv_Notes);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SelectedTenant.Notes.Add(form.note);
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
                    ViewTenantDataForm form = new ViewTenantDataForm(Tenant.GetTenantByID(SelectedTenant.TenantID));
                    if(form.ShowDialog() == DialogResult.Cancel)
                    {  }
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
                    SelectedTenant.Notes.Remove(SelectedTenant.Notes.Find(i => i.NoteID == dgv_Notes.SelectedRows[0].Cells[0].Value.ToString()));
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
                                if (form.ShowDialog() == DialogResult.OK)
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
                                ViewNoteDataForm form = new ViewNoteDataForm(SelectedTenant.Notes.Find(i => i.NoteID == ID), dgv_Notes);
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
        
        private void dgv_Finances_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            { e.Value = string.Format("{0:C}", e.Value); }
        }
    }
}
