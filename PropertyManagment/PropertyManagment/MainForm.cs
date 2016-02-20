using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*
            #region Load Sample Data
            Property.AddProperty("Belleville", "142 E. Lincoln St.", 55000, Convert.ToDateTime("1/1/2014"));
            Property.AddProperty("Shiloh", "4207 Coleman Ave.", 65000, Convert.ToDateTime("4/23/2013"));
            Property.AddProperty("Belleville", "123 N. Belt Ave.", 58000, Convert.ToDateTime("12/1/2014"), 450, true);

            Property prop = Property.PropertyList.Find(i => i.StreetAddress.StreetAddress == "123 N. Belt Ave.");
            Tenant PaulN = new Tenant("Paul", "Newman", Convert.ToDateTime("05/23/1986"), "309-425-8845", "Name@place.com");
            Tenant.AddNewTenant(PaulN);
            prop.MoveInNewTenants(new List<Tenant>() { PaulN }, Convert.ToDateTime("7/1/2014"), 12, 500, 450, 300, null);
            prop.MoveOutOldTenants("Move Out Tenants", "End of Lease", Convert.ToDateTime("7/1/2015"), false);
            Tenant GregS = new Tenant("Greg", "Schultz", Convert.ToDateTime("07/20/1985"), "442-685-1844", "thisguy@domain.net");
            Tenant.AddNewTenant(GregS);
            prop.MoveInNewTenants(new List<Tenant>() { GregS }, Convert.ToDateTime("7/1/2015"), 12, 500, 450, 0, null);
            Payment.AcceptPayment("Rent Payment", "$500 Paid", Convert.ToDateTime("7/5/2015"), prop, 500, 500, true);
            MaintenanceItem.SubmitMaintenanceRequest("Replace water heater", "Internal component broken", Convert.ToDateTime("7/24/2015"), prop, Occurence.Statuses.Active, new List<Tenant>() { Tenant.GetTenantByName("Paul", "Newman") }, MaintenanceItem.RequestorTypes.Tenant, 300, Convert.ToDateTime("7/24/2015"), Convert.ToDateTime("7/28/2015"), MaintenanceItem.Priorities.High, TimeSpan.FromHours(5));
            MaintenanceItem.SubmitMaintenanceRequest("Fix deck", "Rail broken", Convert.ToDateTime("7/25/2015"), prop, Occurence.Statuses.Active, new List<Tenant>() { Tenant.GetTenantByName("Paul", "Newman") }, MaintenanceItem.RequestorTypes.Tenant, 300, Convert.ToDateTime("7/25/2015"), Convert.ToDateTime("7/30/2015"), MaintenanceItem.Priorities.Meduim, TimeSpan.FromHours(3));

            prop = Property.PropertyList.Find(i => i.StreetAddress.StreetAddress == "4207 Coleman Ave.");
            Tenant TerryF = new Tenant("Terry", "Fletcher", Convert.ToDateTime("02/11/1985"), "618-633-4877", "misterrman@seascape.com");
            Tenant BarryK = new Tenant("Barry", "Kripkey", Convert.ToDateTime("12/08/1989"), "309-772-3288", null);
            Tenant.AddNewTenant(TerryF);
            Tenant.AddNewTenant(BarryK);
            prop.MoveInNewTenants(new List<Tenant>() { TerryF, BarryK }, Convert.ToDateTime("1/1/2015"), 6, 550, 550, 0, null);
            MaintenanceItem.SubmitMaintenanceRequest("Replace broken window", "Single window pane broken", Convert.ToDateTime("7/21/2015"), prop, Occurence.Statuses.Active, new List<Tenant>() { Tenant.GetTenantByName("Barry", "Kripkey") }, MaintenanceItem.RequestorTypes.Tenant, 300, Convert.ToDateTime("7/21/2015"), Convert.ToDateTime("7/25/2015"), MaintenanceItem.Priorities.High, TimeSpan.FromHours(2));
            MaintenanceItem.getListOfAllActiveItems()[0].CompleteMaintenance(TimeSpan.FromHours(3), 115, new string[] { "Micah Jessen" }, Convert.ToDateTime("7/24/2015"));

            SaveAllData();
            #endregion
            */
            LoadAllData();

            this.MinimumSize = new Size((btn_Property.Width * 4), 0);
            lbl_Date.Text = DateTime.Now.DayOfWeek.ToString() + " " + DateTime.Now.ToString("dd MMM yyyy");
            LoadPropertyPage();
        }
        public void LoadPropertyPage()
        {
            dgv_Properties.Rows.Clear();

            foreach (var a in Property.PropertyList.OrderBy(i => i.StreetAddress.State).ThenBy(i => i.StreetAddress.City).ThenBy(i => i.StreetAddress.StreetAddress.Substring(i.StreetAddress.StreetAddress.IndexOf(" ") + 1)))
            {
                Bitmap statusImg = null;
                if (a.Status == "Rented")
                { statusImg = Properties.Resources.Home_Green; }
                if (a.Status == "Ready to rent")
                { statusImg = Properties.Resources.Home_Yellow; }
                if (a.Status == "Not Ready to rent")
                { statusImg = Properties.Resources.Home_Red; }

                DataGridViewRow row = new DataGridViewRow() { Height = 80 };
                DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell() { Value = a.PropertyID };
                DataGridViewImageCell Image = new DataGridViewImageCell() { Value = a.Image, ImageLayout = a.Image == null ? DataGridViewImageCellLayout.Normal : DataGridViewImageCellLayout.Zoom };
                DataGridViewTextBoxCell Address = new DataGridViewTextBoxCell() { Value = a.StreetAddress.StreetAddress };
                DataGridViewTextBoxCell Features = new DataGridViewTextBoxCell() { Value = a.PropertyFeatures != null ? a.PropertyFeatures.Bedrooms + "bed " + a.PropertyFeatures.Bathrooms + "bath" : "n/a" };
                DataGridViewTextBoxCell Rent = new DataGridViewTextBoxCell() { Value = !ReferenceEquals(null, a.CurrentLease) ? string.Format("{0:C}", a.CurrentLease.Rent) : "n/a" };
                DataGridViewImageCell Status = new DataGridViewImageCell() { Value = statusImg };
                row.Cells.Add(ID);
                row.Cells.Add(Image);
                row.Cells.Add(Address);
                row.Cells.Add(Features);
                row.Cells.Add(Rent);
                row.Cells.Add(Status);
                dgv_Properties.Rows.Add(row);
            }
        }

        public void LoadTenantPage()
        {
            dgv_Tenant.Rows.Clear();

            foreach (var b in Tenant.TenantList.OrderBy(i => i.LastName))
            {
                DataGridViewRow row = new DataGridViewRow() { Height = 80 };
                DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell() { Value = b.TenantID };
                DataGridViewImageCell Image = new DataGridViewImageCell() { Value = b.Image, ImageLayout = b.Image == null ? DataGridViewImageCellLayout.Normal : DataGridViewImageCellLayout.Zoom };
                DataGridViewTextBoxCell FirstName = new DataGridViewTextBoxCell() { Value = b.FirstName };
                DataGridViewTextBoxCell LastName = new DataGridViewTextBoxCell() { Value = b.LastName };
                DataGridViewTextBoxCell Phone = new DataGridViewTextBoxCell() { Value = b.Phone };
                DataGridViewTextBoxCell Email = new DataGridViewTextBoxCell() { Value = b.Email };
                row.Cells.Add(ID);
                row.Cells.Add(Image);
                row.Cells.Add(FirstName);
                row.Cells.Add(LastName);
                row.Cells.Add(Phone);
                row.Cells.Add(Email);
                dgv_Tenant.Rows.Add(row);
            }
        }

        public void LoadMaintenancePage()
        {
            List<MaintenanceItem> source = MaintenanceItem.MaintenanceItems.OrderByDescending(i => i.Status).ThenBy(i => i.Priority).ToList();
            dgv_Maintenance.DataSource = source;
            dgv_Maintenance.AutoGenerateColumns = false;
            dgv_Maintenance.Columns.Clear();
            foreach (string s in new string[] { "Instance ID", "Instance Name", "Description", "Incident Date", "Status", "IsServiceCall", "EarliestDueDate", "LatestDueDate" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dgv_Maintenance.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dgv_Maintenance.Columns[0].Visible = false;
            dgv_Maintenance.AutoResizeColumns();
        }

        public void LoadFinancePage()
        {
            List<IFinancial> source = Occurence.Occurences.Where(i => i is IFinancial).OrderByDescending(i => i.IncidentDate).ThenBy(i => i.Location.StreetAddress.StreetAddress).ToList().ConvertAll(i => i as IFinancial);
            dgv_Finance.DataSource = source;
            dgv_Finance.AutoGenerateColumns = false;
            dgv_Finance.Columns.Clear();
            foreach (string s in new string[] { "Instance ID", "Instance Name", "Description", "Incident Date", "Amount" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dgv_Finance.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dgv_Finance.Columns[0].Visible = false;
            dgv_Finance.AutoResizeColumns();
        }

        private void OpenDetailPage(string ID)
        {
            string IDType = new string(ID.Take(ID.IndexOf('_')).ToArray());

            switch (IDType)
            {
                case "Prop":
                    {
                        PropertyDetails form = new PropertyDetails(Property.PropertyList.Find(i => i.PropertyID == ID), this);
                        form.Show();
                        break;
                    }
                case "Ten":
                    {
                        TenantDetails form = new TenantDetails(Tenant.TenantList.Find(t => t.TenantID == ID), this);
                        form.Show();
                        break;
                    }
                case "Occ":
                case "Mnt":
                case "Inc":
                case "Pay":
                    {
                        ViewOccurenceDataForm form = new ViewOccurenceDataForm(Occurence.GetOccurenceByID(ID));
                        form.Show();
                        break;
                    }
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            string name = new string(((Control)sender).Name.Skip(4).ToArray());
            tabControl1.SelectTab(String.Format("tab_{0}", name));
            if (name == "Property")
            { LoadPropertyPage(); }
            if (name == "Tenant")
            { LoadTenantPage(); }
            if (name == "Maintenance")
            { LoadMaintenancePage(); }
            if (name == "Finance")
            { LoadFinancePage(); }
        }

        private void SaveAllData()
        {
            SerializationClass.SaveData(Property.PropertyList, SerializationClass.classNames.Property);
            SerializationClass.SaveData(Tenant.TenantList, SerializationClass.classNames.Tenant);
            SerializationClass.SaveData(Lease.Leases, SerializationClass.classNames.Lease);
            SerializationClass.SaveData(Occurence.Occurences, SerializationClass.classNames.Occurence);
        }
        private void LoadAllData()
        {
            SerializationClass.LoadData(Property.PropertyList, SerializationClass.classNames.Property);
            SerializationClass.LoadData(Tenant.TenantList, SerializationClass.classNames.Tenant);
            SerializationClass.LoadData(Lease.Leases, SerializationClass.classNames.Lease);
            SerializationClass.LoadData(Occurence.Occurences, SerializationClass.classNames.Occurence);
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hti = ((DataGridView)sender).HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                if (sender is DataGridView)
                {
                    DataGridView source = (DataGridView)sender;
                    OpenDetailPage(source.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == btn_AddProperty.Name)
            {
                bool loop;
                do
                {
                    loop = false;
                    NewPropertyForm dialog = new NewPropertyForm();
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.Retry)
                    { loop = true; }
                    LoadPropertyPage();
                } while (loop);
            }
            if (((Button)sender).Name == btn_AddTenant.Name)
            {
                bool loop;
                do
                {
                    loop = false;
                    NewTenantForm dialog = new NewTenantForm();
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.Retry)
                    { loop = true; }
                    LoadTenantPage();
                } while (loop);
            }
            if (((Button)sender).Name == btn_AddMaintenance.Name)
            {
                PropertySelector ps = new PropertySelector();
                if (ps.ShowDialog() == DialogResult.OK)
                {
                    NewMaintenanceForm dialog = new NewMaintenanceForm(ps.selection, false);
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    { LoadMaintenancePage(); }
                }
            }
            if (((Button)sender).Name == btn_AddFinance.Name)
            {
                try
                {
                    PropertySelector ps = new PropertySelector();
                    if (ps.ShowDialog() == DialogResult.OK)
                    {
                        SimplePrompt prompt = new SimplePrompt("Income or Expense?", "Finance", "Income", "Expense");
                        prompt.ShowDialog();
                        if (prompt.DialogResult == DialogResult.Yes)
                        {
                            NewPaymentForm dialog = new NewPaymentForm(ps.selection);
                            dialog.ShowDialog();
                            if (dialog.DialogResult == DialogResult.OK)
                            { LoadFinancePage(); }
                        }
                        else if (prompt.DialogResult == DialogResult.No)
                        {
                            AddIncidentForm dialog = new AddIncidentForm(ps.selection);
                            dialog.ShowDialog();
                            if (dialog.DialogResult == DialogResult.OK)
                            { LoadFinancePage(); }
                        }
                    }
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == btn_EditProperty.Name)
            {
                try
                {
                    ViewPropertyDataForm form = new ViewPropertyDataForm(Property.GetPropertyByID(dgv_Properties.SelectedRows[0].Cells[0].Value.ToString()));
                    form.Show();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_EditTenant.Name)
            {
                try
                {
                    ViewTenantDataForm form = new ViewTenantDataForm(Tenant.GetTenantByID(dgv_Tenant.SelectedRows[0].Cells[0].Value.ToString()));
                    form.Show();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_EditMaintenance.Name)
            {
                try
                {
                    ViewOccurenceDataForm form = new ViewOccurenceDataForm(Occurence.GetOccurenceByID(dgv_Maintenance.SelectedRows[0].Cells[0].Value.ToString()));
                    form.Show();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            if (((Button)sender).Name == btn_EditFinance.Name)
            {
                try
                {
                    ViewOccurenceDataForm form = new ViewOccurenceDataForm(Occurence.GetOccurenceByID(dgv_Finance.SelectedRows[0].Cells[0].Value.ToString()));
                    form.Show();
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == btn_DeleteProperty.Name)
            {
                if (dgv_Properties.SelectedRows.Count>0&& MessageBox.Show("Warning: Deleting a Property will remove all data associated with that Property.\nThis cannot be undone! \nDo you want to delete this Property?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Property p = Property.PropertyList.Find(i => i.PropertyID == dgv_Properties.SelectedRows[0].Cells[0].Value.ToString());
                        foreach (Tenant t in Tenant.TenantList.Where(t => (!ReferenceEquals(null, t.Residence)) && t.Residence.PropertyID == p.PropertyID))
                        { t.CurrentLease = null; }
                        foreach (Lease l in Lease.Leases.Where(l => l.PropertyLeased.PropertyID == p.PropertyID))
                        { Lease.Leases.Remove(l); }
                        Property.PropertyList.Remove(p);
                        LoadPropertyPage();
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
            if (((Button)sender).Name == btn_DeleteTenant.Name)
            {
                if (MessageBox.Show("Warning: Deleting a Tenant will remove all data associated with thatTenant.\nThis cannot be undone! \nDo you want to delete this Tenant?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Tenant t = Tenant.GetTenantByID(dgv_Tenant.SelectedRows[0].Cells[0].Value.ToString());
                        foreach (Occurence o in Occurence.Occurences.Where(i => i.TenantsInvolved.Select(n => n.TenantID).Contains(t.TenantID)))
                        { o.TenantsInvolved.Remove(t); }
                        foreach (Lease l in Lease.Leases.Where(i => i.Tenants.Select(n => n.TenantID).Contains(t.TenantID)))
                        { l.Tenants.Remove(t); }
                        Tenant.TenantList.Remove(t);
                        LoadTenantPage();
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
            if (((Button)sender).Name == btn_DeleteMaintenance.Name)
            {
                if (MessageBox.Show("Warning: Deleting a Maintenance Item will remove all data associated with that Maintenance Item.\nThis cannot be undone! \nDo you want to delete this Maintenance Item?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Occurence.Occurences.Remove(Occurence.GetOccurenceByID(dgv_Maintenance.SelectedRows[0].Cells[0].Value.ToString()));
                        LoadMaintenancePage();
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
            if (((Button)sender).Name == btn_DeleteFinance.Name)
            {
                if (MessageBox.Show("Warning: Deleting a Finance Item will remove all data associated with that Finance Item.\nThis cannot be undone! \nDo you want to delete this Finance Item?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Occurence.Occurences.Remove(Occurence.GetOccurenceByID(dgv_Finance.SelectedRows[0].Cells[0].Value.ToString()));
                        LoadFinancePage();
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
        }

        private void NewMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllData();
        }
    }
}