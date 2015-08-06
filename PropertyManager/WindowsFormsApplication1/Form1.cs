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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        object SelectedObject = null;
        string PageType = "";
        Bitmap ImageUnavailable = Properties.Resources.unavailable;

        public Form1()
        {
            InitializeComponent();
            ///*
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
            //*/
            //LoadAllData();

            LoadHomePage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Properties", "Properties");
            treeView1.Nodes.Add("Tenants", "Tenants");
            treeView1.Nodes.Add("Maintenance", "Maintenance");

            foreach (Property p in Property.PropertyList)
            { treeView1.Nodes["Properties"].Nodes.Add(p.StreetAddress.StreetAddress); }
            foreach (Tenant t in Tenant.TenantList)
            { treeView1.Nodes["Tenants"].Nodes.Add(t.FirstName + " " + t.LastName); }

            //Set icons for tree view
            foreach (TreeNode node in treeView1.Nodes["Properties"].Nodes)
            {
                Property prop = Property.GetPropertyByStreetAddress(node.Text);
                if (prop.IsRented)
                {
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    node.StateImageIndex = 1;
                }
                else
                {
                    if (prop.IsReadyToRent)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 2;
                        node.StateImageIndex = 2;
                    }
                    else
                    {
                        node.ImageIndex = 3;
                        node.SelectedImageIndex = 3;
                        node.StateImageIndex = 3;
                    }
                }
            }
        }
        private void ChangePageType(Control ctrl, string pageType)
        {
            PageType = pageType;
            if (ctrl.Parent == splitContainer1.Panel2)
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() != "")
                {
                    if (ctrl.Tag.ToString().Contains(pageType))
                    {
                        if (ctrl is Label)
                        {
                            if (ctrl.Name.Substring(ctrl.Name.Length - 5, 5) != "Label")
                            { ctrl.Text = ""; }
                        }
                        ctrl.Visible = true;
                    }
                    else
                    { ctrl.Visible = false; }
                }
                else
                { }
            }
            else
            { }

            foreach (Control child in ctrl.Controls)
            { ChangePageType(child, pageType); }

            switch (pageType)
            {
                case "Home":
                    {
                        //add specifics
                        break;
                    }
                case "PropH":
                    {
                        break;
                    }
                case "Property":
                    {
                        
                        break;
                    }
                case "Tenant":
                    {
                        break;
                    }
                case "Maintenance":
                    {
                        break;
                    }
            }
        }
        private void LoadHomePage()
        { ChangePageType(splitContainer1.Panel2, "Home"); }
        private void LoadPropertyHomePage()
        {
            ChangePageType(splitContainer1.Panel2, "PropH");

            lbl_HistoryLabel.Location = new Point(65, 246);
            dataGrid_History.Location = new Point(63, 286);
            lblMNT_ServiceCallsLabel.Location = new Point(65, 19);
            dgvMNT_ServiceCalls.Location = new Point(63, 59);

            lblMNT_ServiceCallsLabel.Text = "Properties";
            dgvMNT_ServiceCalls.DataSource = Property.PropertyList.Select(i => new { i.StreetAddress.StreetAddress, i.Rent, Tenants = String.Join(", ", i.CurrentTenants.Select(t => t.FirstName + " " + t.LastName)), AcceptPayment = (!ReferenceEquals(null, i.CurrentLease)) ? "Accept Payment" : "No Lease" }).ToList();
            dgvMNT_ServiceCalls.ContextMenuStrip = null;
            for (int i = 0; i < dgvMNT_ServiceCalls.Rows.Count; i++)
            {
                dgvMNT_ServiceCalls.Rows[i].Cells[dgvMNT_ServiceCalls.Columns["AcceptPayment"].Index].Style.ForeColor = Color.Blue;
                dgvMNT_ServiceCalls.Rows[i].Cells[dgvMNT_ServiceCalls.Columns["AcceptPayment"].Index].Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Underline);
                dgvMNT_ServiceCalls.Rows[i].Cells[0].Style.ForeColor = Color.Blue;
                dgvMNT_ServiceCalls.Rows[i].Cells[0].Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Underline);
                Property p = Property.GetPropertyByStreetAddress(dgvMNT_ServiceCalls.Rows[i].Cells[0].Value.ToString());
                if (!ReferenceEquals(null,p.CurrentLease))
                {
                    if (p.CurrentLease.PaymentIsLate(DateTime.Today.Date))
                    { dgvMNT_ServiceCalls.Rows[i].Cells[1].Style.ForeColor = Color.Red; }
                    if (p.CurrentLease.ThisMonthIsPaid(DateTime.Today))
                    { dgvMNT_ServiceCalls.Rows[i].Cells[1].Style.ForeColor = Color.Green; }
                }
            }
        }
        private void LoadPropertyPage(Property property)
        {
            ChangePageType(splitContainer1.Panel2, "Property");

            lbl_HistoryLabel.Location = new Point(65, 540);
            dataGrid_History.Location = new Point(63, 580);
            lblMNT_ServiceCallsLabel.Location = new Point(65, 266);
            dgvMNT_ServiceCalls.Location = new Point(63, 306);

            List<MaintenanceItem> ServiceCalls = MaintenanceItem.MaintenanceItems.Where(i => i.IsServiceCall == true &&
            i.Status == Occurence.Statuses.Active &&
            i.Location.StreetAddress.StreetAddress == property.StreetAddress.StreetAddress &&
            i.EarliestDueDate.Date <= DateTime.Today.Date).OrderBy(i => i.LatestDueDate.Date).ToList();

            lblMNT_ServiceCallsLabel.Text = "Service Calls";
            dgvMNT_ServiceCalls.DataSource = ServiceCalls.Select(i => new { i.Location.StreetAddress.StreetAddress, i.InstanceName, i.Description, i.LatestDueDate,i.InstanceID }).ToList();
            dgvMNT_ServiceCalls.Columns["InstanceID"].Visible = false;
            dgvMNT_ServiceCalls.ContextMenuStrip = cms_Maintenancedgv;

            lbl_Title.Text = property.StreetAddress.StreetAddress;
            lbl_Rent.ForeColor = SystemColors.ControlText;
            if (property.Rent == 0)
            { lbl_Rent.Text = "TBD"; }
            else
            {
                lbl_Rent.Text = String.Format("{0:C}", property.Rent);
                if (!ReferenceEquals(null, property.CurrentLease))
                {
                    if (property.CurrentLease.PaymentIsLate(DateTime.Today.Date))
                    { lbl_Rent.ForeColor = Color.Red; }
                    else if (property.CurrentLease.ThisMonthIsPaid(DateTime.Today))
                    { lbl_Rent.ForeColor = Color.Green; }
                    else
                    { lbl_Rent.ForeColor = SystemColors.ControlText; }
                }
            }
            Control[] TennantLabels = { lblProp_Tenant1, lblProp_Tenant2, lblProp_Tenant3, lblProp_Tenant4 };
            for (int i = 0; i < property.CurrentTenants.Count(); i++)
            { TennantLabels[i].Text = String.Format(property.CurrentTenants.ElementAt(i).FirstName + " " + property.CurrentTenants.ElementAt(i).LastName); }
            if (ReferenceEquals(null, property.CurrentLease))
            { lblProp_MoveInDate.Text = "Available"; }
            else
            { lblProp_MoveInDate.Text = property.CurrentLease.StartDate.ToShortDateString(); }
            if (ReferenceEquals(null, property.CurrentLease))
            { lblProp_MoveOutDate.Text = ""; }
            else
            { lblProp_MoveOutDate.Text = property.CurrentLease.EndDate.ToShortDateString(); }

            lbl_Status.Text = property.Status;
            dataGrid_History.DataSource = Occurence.Occurences.Where(i => i.Location.StreetAddress.StreetAddress == property.StreetAddress.StreetAddress).OrderByDescending(i => i.IncidentDate).ToList();
            if (property.Image != null)
            { img_Picture.Image = property.Image; }
            else
            { img_Picture.Image = ImageUnavailable; }

            if (!ReferenceEquals(null, property.CurrentLease))
            {
                if (property.CurrentLease.ImageData == null)
                { lbl_CurrentLeaseLabel.Text = "Attach Lease file"; }
                else
                { lbl_CurrentLeaseLabel.Text = "Open Lease file"; }
                lbl_Deposit.Text = property.CurrentLease.Deposit + "/" + property.CurrentLease.DepositRemaining;
                lbl_PetDeposit.Text = property.CurrentLease.PetDeposit + "/" + property.CurrentLease.PetDepositRemaining;
            }
            else
            { lbl_CurrentLeaseLabel.Text = "No current Lease"; }
        }
        private void LoadTenantPage(Tenant tenant)
        {
            ChangePageType(splitContainer1.Panel2, "Tenant");
            lbl_Title.Text = tenant.FirstName + " " + tenant.LastName;
            if (tenant.Residence == null)
            {
                lblTen_Residence.Text = "Residence Unknown";
                lblTen_Residence.Enabled = false;
                lbl_Rent.Text = "";
            }
            else
            {
                lblTen_Residence.Text = tenant.Residence.StreetAddress.StreetAddress;
                lblTen_Residence.Enabled = true;
                lbl_Rent.Text = String.Format("{0:C}", tenant.Residence.Rent);
            }
            lbl_Status.Text = tenant.Status;
            lblTen_Age.Text = tenant.Age.ToString();
            lblTen_Email.Text = tenant.Email;
            lblTen_Phone.Text = tenant.Phone;

            dataGrid_History.Location = new Point(65, 286);
            lbl_HistoryLabel.Location = new Point(65, 246);

            dataGrid_History.DataSource = Occurence.Occurences.Where(i => i.TenantsInvolved.Select(t => new { t.FirstName, t.LastName }).Contains(new { tenant.FirstName, tenant.LastName })).OrderByDescending(x => x.IncidentDate).ToList();
            if (!ReferenceEquals(null,tenant.CurrentLease))
            {
                if (tenant.CurrentLease.ImageData == null)
                { lbl_CurrentLeaseLabel.Text = "Attach Lease file"; }
                else
                { lbl_CurrentLeaseLabel.Text = "Open Lease file"; }
            }
            if (tenant.Image != null)
            { img_Picture.Image = tenant.Image; }
            else
            { img_Picture.Image = ImageUnavailable; }
        }
        private void LoadMaintenanceHomePage()
        {
            //TODO: Allow for custom date/location parameters
            ChangePageType(splitContainer1.Panel2, "Maintenance");

            lbl_HistoryLabel.Location = new Point(65, 246);
            dataGrid_History.Location = new Point(63, 286);
            lblMNT_ServiceCallsLabel.Location = new Point(65, 19);
            dgvMNT_ServiceCalls.Location = new Point(63, 59);

            lblMNT_ServiceCallsLabel.Text = "Service Calls";

            List<MaintenanceItem> ServiceCalls = MaintenanceItem.MaintenanceItems.Where(i => i.IsServiceCall == true && 
            i.Status == Occurence.Statuses.Active && 
            i.EarliestDueDate.Date <= DateTime.Today.Date /*&& i.LatestDueDate < DateTime.Today.AddDays(2).Date*/).OrderBy(i => i.LatestDueDate.Date).ThenBy(i => i.Location).ToList();
            List<MaintenanceItem> MaintenanceItems = MaintenanceItem.MaintenanceItems.Where(i => i.IsServiceCall == false && i.EarliestDueDate <= DateTime.Today && i.Status == Occurence.Statuses.Active).OrderBy(i => i.LatestDueDate.Date).ThenBy(i => i.Location.StreetAddress.StreetAddress).ToList();
            
            dgvMNT_ServiceCalls.DataSource = ServiceCalls.Select(i => new { i.Location.StreetAddress.StreetAddress, i.InstanceName, i.Description, i.LatestDueDate,i.InstanceID }).ToList();
            dgvMNT_ServiceCalls.Columns["InstanceID"].Visible = false;
            dgvMNT_ServiceCalls.ContextMenuStrip = cms_Maintenancedgv;
            dgvMNT_RoutineMaintenance.DataSource = MaintenanceItems.Where(i=>i.Status== Occurence.Statuses.Active).Select(i => new { i.Location.StreetAddress.StreetAddress, i.InstanceName, i.Description, i.LatestDueDate,i.InstanceID }).ToList();
            dgvMNT_RoutineMaintenance.Columns["InstanceID"].Visible = false;
            dgvMNT_RoutineMaintenance.ContextMenuStrip = cms_Maintenancedgv;
            dgv_PastMaintenance.DataSource= MaintenanceItem.MaintenanceItems.Where(i => i.Status == Occurence.Statuses.Resolved).Select(i => new { i.Location.StreetAddress.StreetAddress, i.InstanceName, i.Description, i.LatestDueDate,i.CompletionDate,i.InstanceID }).OrderByDescending(i=>i.CompletionDate).ToList();
            dgv_PastMaintenance.Columns["InstanceID"].Visible = false;
        }
        private void ReloadCurrentPage(string pageType)
        {
            switch (pageType)
            {
                case "Home":
                    {
                        LoadHomePage();
                        break;
                    }
                case "PropH":
                    {
                        LoadPropertyHomePage();
                        break;
                    }
                case "Property":
                    {
                        LoadPropertyPage((Property)SelectedObject);
                        break;
                    }
                case "Tenant":
                    {
                        LoadTenantPage((Tenant)SelectedObject);
                        break;
                    }
                case "Maintenance":
                    {
                        LoadMaintenanceHomePage();
                        break;
                    }
            }
        }

        private void AddNewProperty()
        {
            bool loop;
            do
            {
                loop = false;
                NewPropertyForm dialog = new NewPropertyForm();
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.Retry)
                { loop = true; }
                Form1_Load(null, null);
                ReloadCurrentPage(PageType);
            } while (loop);
        }
        private void AddNewTenant()
        {
            bool loop;
            do
            {
                loop = false;
                NewTenantForm dialog = new NewTenantForm();
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.Retry)
                { loop = true; }
                Form1_Load(null, null);
                ReloadCurrentPage(PageType);
            } while (loop);
        }
        private void MoveInTenants(Property property)
        {
            MoveInForm dialog = new MoveInForm(property);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                Form1_Load(null, null);
                ReloadCurrentPage(PageType);
            }
        }
        private void MoveOutTenants(Property property)
        {
            MoveOutForm dialog = new MoveOutForm(property);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                Form1_Load(null, null);
                ReloadCurrentPage(PageType);
            }
        }
        private void AddNewIncident(Property property)
        {
            AddIncidentForm dialog = new AddIncidentForm(property);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            { ReloadCurrentPage(PageType); }
        }
        private void AddNewMaintenanceItem(Property property)
        {
            NewMaintenanceForm dialog = new NewMaintenanceForm(property, false);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            { ReloadCurrentPage(PageType); }
        }
        private void CompleteMaintenanceItem(MaintenanceItem item)
        {
            CompleteMaintenanceItemForm dialog = new CompleteMaintenanceItemForm(item);
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK)
            { ReloadCurrentPage(PageType); }
        }
        private void CancelMaintenanceItem(MaintenanceItem item)
        {
            item.CancelMaintenanceRequest();
            ReloadCurrentPage(PageType);
        }
        private void AddNewServiceCall(Property property)
        {
            NewMaintenanceForm dialog = new NewMaintenanceForm(property, true);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            { ReloadCurrentPage(PageType); }
        }
        private void AcceptPayment(Property property)
        {
            if (!ReferenceEquals(null, property.CurrentLease))
            {
                NewPaymentForm dialog = new NewPaymentForm(property);
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                { ReloadCurrentPage(PageType); }
            }
            else
            { MessageBox.Show("This property is currently not rented:"); }
        }
        private void ShowPropertyTenantImage(object obj)
        {
            if (img_Picture.Image != ImageUnavailable)
            {
                PictureView picView = new PictureView((Bitmap)img_Picture.Image);
                picView.Show();
            }
            else
            {
                openFileDialogPropTenImage.Tag = obj;
                openFileDialogPropTenImage.ShowDialog();
            }
        }
        private void ShowCurentLeaseImage(object obj)
        {
            if (obj is Property)
            {
                Property property = (Property)obj;

                if (property.CurrentLease == null)
                { MessageBox.Show("This property does not curently have a lease", "No Lease"); }
                else
                {
                    if (property.CurrentLease.ImageData == null)
                    {
                        openFileDialogLeaseImage.Tag = property;
                        openFileDialogLeaseImage.ShowDialog();
                    }
                    else
                    {
                        PictureView picView = new PictureView(property.CurrentLease.Image);
                        picView.Show();
                    }
                }
            }
            if (obj is Tenant)
            {
                Tenant tenant = (Tenant)obj;
                if (tenant.CurrentLease == null)
                { MessageBox.Show("This tenant does not curently have a lease", "No Lease"); }
                else
                {
                    if (tenant.CurrentLease.ImageData == null)
                    {
                        openFileDialogLeaseImage.Tag = tenant;
                        openFileDialogLeaseImage.ShowDialog();
                    }
                    else
                    {
                        PictureView picView = new PictureView(tenant.CurrentLease.Image);
                        picView.Show();
                    }
                }
            }

        }
        private void ShowPastLeases(Property property)
        {
            if (property.PastLeases.Count() == 0)
            { MessageBox.Show("This property does not have and past leases", "No Past Leases"); }
            else
            {
                ListForm listForm = new ListForm(SelectedObject);
                listForm.Show();
            }
        }
        private void ShowFloorPlanImage(Property property)
        {
            if (property.CurrentLease == null)
            { MessageBox.Show("This property does not curently have a Floor Plan", "No Floor Plan"); }
            else
            {
                if (property.FloorPlan == null)
                {
                    openFileDialogFloorPlanImage.Tag = property;
                    openFileDialogFloorPlanImage.ShowDialog();
                }
                else
                {
                    PictureView picView = new PictureView(property.FloorPlan);
                    picView.Show();
                }
            }
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

        #region Events
        /// <summary>
        /// Calls appropriate page load method for item selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode RootNode = e.Node;
            while (RootNode.Level > 0)
            { RootNode = RootNode.Parent; }

            if (e.Button == MouseButtons.Right)
            {
                if (RootNode.Text == "Properties")
                { treeView1.ContextMenuStrip = contextMenuStripProperty; }
                if (RootNode.Text == "Tenants")
                { treeView1.ContextMenuStrip = contextMenuStripTenant; }
            }
            if (e.Node.Level > 0)
            {
                if (RootNode.Text == "Properties")
                {
                    SelectedObject = Property.GetPropertyByStreetAddress(e.Node.Text);
                    LoadPropertyPage((Property)SelectedObject);
                }
                if (RootNode.Text == "Tenants")
                {
                    string[] Name = e.Node.Text.Split(' ');
                    SelectedObject = Tenant.GetTenantByName(Name[0], Name[1]);
                    LoadTenantPage((Tenant)SelectedObject);
                }
                if (RootNode.Text == "Maintenance")
                {
                    //might not use this
                }
            }
            if (e.Location.X > 20) //ignore if expanding tree view
            {
                if (e.Node.Text == "Maintenance")
                { LoadMaintenanceHomePage(); }
                if (e.Node.Text == "Properties")
                { LoadPropertyHomePage(); }
            }
        }
        /// <summary>
        /// Calls LoadHomePage method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        { LoadHomePage(); }
        /// <summary>
        /// Calls AddNewProperty method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        { AddNewProperty(); }
        /// <summary>
        /// Calls AddNewProperty method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_AddProperty_Click(object sender, EventArgs e)
        { AddNewProperty(); }
        /// <summary>
        /// Calls AddNewTenant method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewTenantToolStripMenuItem_Click(object sender, EventArgs e)
        { AddNewTenant(); }
        /// <summary>
        /// Calls AddNewTenant method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_AddTenant_Click(object sender, EventArgs e)
        { AddNewTenant(); }
        /// <summary>
        /// Calls MoveInTenants method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnProp_MoveInTenants_Click(object sender, EventArgs e)
        { MoveInTenants((Property)SelectedObject); }
        /// <summary>
        /// Calls MoveOutTenants method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnProp_MoveOutTenants_Click(object sender, EventArgs e)
        { MoveOutTenants((Property)SelectedObject); }
        /// <summary>
        /// Calls AddNewIncident method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnProp_AddIncident_Click(object sender, EventArgs e)
        { AddNewIncident((Property)SelectedObject); }
        /// <summary>
        /// Calls AddNewMaintenanceItem method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnProp_AddMaintenanceItem_Click(object sender, EventArgs e)
        { AddNewMaintenanceItem((Property)SelectedObject); }
        /// <summary>
        /// Calls AddNewServiceCall method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnProp_AddServiceCall_Click(object sender, EventArgs e)
        { AddNewServiceCall((Property)SelectedObject); }
        /// <summary>
        /// Calls AcceptPayment method with selected address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMNT_ServiceCalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PageType == "PropH")
            {
                Property p = Property.GetPropertyByStreetAddress(dgvMNT_ServiceCalls.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (e.RowIndex >= 0 && e.ColumnIndex == dgvMNT_ServiceCalls.Columns["AcceptPayment"].Index)
                {
                    AcceptPayment(p);
                }
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    SelectedObject = p;
                    LoadPropertyPage(p);
                }
            }
            if(PageType == "Maintenance")
            {
                
            }
        }
        /// <summary>
        /// Calls AcceptPayment method with selected address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnProp_AddPayment_Click(object sender, EventArgs e)
        { AcceptPayment((Property)SelectedObject); }
        /// <summary>
        /// Calls CompleteMaintenaceItem method with selected MaintenanceItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_MaintenanceComplete_Click(object sender, EventArgs e)
        {
            int ID = ((MaintenanceItem)((ToolStripMenuItem)sender).Owner.Tag).InstanceID;
            CompleteMaintenanceItem((MaintenanceItem)Occurence.GetOccurenceByID(ID));
        }
        /// <summary>
        /// Calls CancelMaintenanceItem method with selected MaintenanceItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_MaintenanceCancel_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvMNT_ServiceCalls.SelectedRows[0].Cells[dgvMNT_ServiceCalls.Columns["InstanceID"].Index].Value);
            CancelMaintenanceItem((MaintenanceItem)Occurence.GetOccurenceByID(ID));
        }
        /// <summary>
        /// Calls ShowPastLeases method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_PreviousLeases_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { ShowPastLeases((Property)SelectedObject); }
        /// <summary>
        /// Calls ShowPropertyTenantImage method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_OpenPropTenImage_Click(object sender, EventArgs e)
        { ShowPropertyTenantImage(SelectedObject); }
        /// <summary>
        /// Calls ShowCurentLeaseImage method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_OpenLeaseImage_Click(object sender, EventArgs e)
        { ShowCurentLeaseImage(SelectedObject); }
        /// <summary>
        /// Calls ShowCurentLeaseImage method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_CurrentLease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { ShowCurentLeaseImage(SelectedObject); }
        }
        /// <summary>
        /// Calls ShowFloorPlanImage method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_FloorPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { ShowFloorPlanImage((Property)SelectedObject); }
        }
        /// <summary>
        /// Calls ShowFloorPlanImage method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_OpenFloorPlanImage_Click(object sender, EventArgs e)
        { ShowFloorPlanImage((Property)SelectedObject); }
        /// <summary>
        /// Calls SaveAllData method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { SaveAllData(); }
        /// <summary>
        /// Calls SaveAllData method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        { SaveAllData(); }
        /// <summary>
        /// Opens dialog to change Image of selected Lease
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_ChangeLeaseImage_Click(object sender, EventArgs e)
        {
            openFileDialogLeaseImage.Tag = SelectedObject;
            openFileDialogLeaseImage.ShowDialog();
        }
        /// <summary>
        /// Opens dialog to change Image of selected Property/Tenant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_ChangePropTenImage_Click(object sender, EventArgs e)
        {
            openFileDialogPropTenImage.Tag = SelectedObject;
            openFileDialogPropTenImage.ShowDialog();
        }
        /// <summary>
        /// Opens dialog to change FloorPlanImage of selected property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmi_ChangeFloorPlanImage_Click(object sender, EventArgs e)
        {
            openFileDialogFloorPlanImage.Tag = SelectedObject;
            openFileDialogFloorPlanImage.ShowDialog();
        }
        /// <summary>
        /// Opens a new form displaying Image of selected Property/Tenant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void img_Picture_Click(object sender, EventArgs e)
        { ShowPropertyTenantImage(SelectedObject); }
        /// <summary>
        /// Opens new form with information about selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMNT_ServiceCalls_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hti = ((DataGridView)sender).HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                if (sender is DataGridView)
                {
                    ViewDataForm form = null;
                    DataGridView source = (DataGridView)sender;
                    dynamic d = source.SelectedRows[0].DataBoundItem;
                    switch (PageType)
                    {
                        case "PropH":
                            {
                                Property property = Property.GetPropertyByStreetAddress(d.StreetAddress);
                                form = new ViewDataForm(property);
                                break;
                            }
                        case "Property":
                            {
                                Occurence occurence = Occurence.GetOccurenceByID(d.InstanceID);
                                form = new ViewDataForm(occurence);
                                break;
                            }
                        case "Tenant":
                            {
                                Occurence occurence = Occurence.GetOccurenceByID(d.InstanceID);
                                form = new ViewDataForm(occurence);
                                break;
                            }
                        case "Maintenance":
                            {
                                Occurence occurence = Occurence.GetOccurenceByID(d.InstanceID);
                                form = new ViewDataForm(occurence);
                                break;
                            }
                    }
                    form.Show();
                }
            }
        }
        /// <summary>
        /// Selects clicked row when right clicked and sets ContextMenuStrip tag property to selected row if valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Maintenance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = ((DataGridView)sender).HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
                {
                    ((DataGridView)sender).ContextMenuStrip = cms_Maintenancedgv;
                    ((DataGridView)sender).ClearSelection();
                    ((DataGridView)sender).Rows[hti.RowIndex].Selected = true;
                    ((DataGridView)sender).ContextMenuStrip.Tag = ((DataGridView)sender).SelectedRows[0].DataBoundItem;
                }
                else
                { ((DataGridView)sender).ContextMenuStrip = null; }
            }
        }
        /// <summary>
        /// Changes cursor to Hand for relavent cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMNT_ServiceCalls_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (PageType == "PropH")
            {
                if (e.ColumnIndex == dgvMNT_ServiceCalls.Columns["AcceptPayment"].Index | e.ColumnIndex == 0 && e.RowIndex >= 0)
                { dgvMNT_ServiceCalls.Cursor = Cursors.Hand; }
                else
                {
                    dgvMNT_ServiceCalls.Cursor = Cursors.Default;
                }
            }
        }
        /// <summary>
        /// Changes cursor to default when leaving "link" cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMNT_ServiceCalls_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvMNT_ServiceCalls.Cursor = Cursors.Default;
        }
        /// <summary>
        /// Removes dotted lines from splitter after repositioning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainer1.Enabled = false;
            splitContainer1.Enabled = true;
        }
        /// <summary>
        /// Loads Property/Tenant page for item selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblProp_Tenant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SelectedObject is Property)
            {
                string[] Name = ((LinkLabel)sender).Text.Split(' ');
                SelectedObject = Tenant.GetTenantByName(Name[0], Name[1]);
                LoadTenantPage((Tenant)SelectedObject);
            }
            else if (SelectedObject is Tenant)
            {
                SelectedObject = Property.GetPropertyByStreetAddress(((LinkLabel)sender).Text);
                LoadPropertyPage((Property)SelectedObject);
            }
        }
        /// <summary>
        /// Assigns selected file to Image of selected Lease
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialogLeaseImage_FileOk(object sender, CancelEventArgs e)
        {
            using (MemoryStream fStream = new MemoryStream())
            {
                openFileDialogLeaseImage.OpenFile().CopyTo(fStream);
                if (openFileDialogLeaseImage.Tag is Property)
                {
                    ((Property)openFileDialogLeaseImage.Tag).CurrentLease.ImageData = fStream.GetBuffer();
                    LoadPropertyPage((Property)SelectedObject);
                }
                if (openFileDialogLeaseImage.Tag is Tenant)
                {
                    ((Tenant)openFileDialogLeaseImage.Tag).CurrentLease.ImageData = fStream.GetBuffer();
                    LoadTenantPage((Tenant)SelectedObject);
                }
            }
        }
        /// <summary>
        /// Assigns selected file to Image of selected Property/Tenant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialogPropTenImage_FileOk(object sender, CancelEventArgs e)
        {
            using (MemoryStream fStream = new MemoryStream())
            {
                openFileDialogPropTenImage.OpenFile().CopyTo(fStream);
                if (openFileDialogPropTenImage.Tag is Property)
                {
                    ((Property)openFileDialogPropTenImage.Tag).ImageData = fStream.GetBuffer();
                    LoadPropertyPage((Property)SelectedObject);
                }
                if (openFileDialogPropTenImage.Tag is Tenant)
                {
                    ((Tenant)openFileDialogPropTenImage.Tag).ImageData = fStream.GetBuffer();
                    LoadTenantPage((Tenant)SelectedObject);
                }
            }
        }
        /// <summary>
        /// Assigns selected file to FloorPlanData of selected Property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialogFloorPlanImage_FileOk(object sender, CancelEventArgs e)
        {
            using (MemoryStream fStream = new MemoryStream())
            {
                openFileDialogFloorPlanImage.OpenFile().CopyTo(fStream);

                ((Property)openFileDialogFloorPlanImage.Tag).FloorPlanData = fStream.GetBuffer();
                LoadPropertyPage((Property)SelectedObject);
            }
        }
        /// <summary>
        /// Delete Occurence from History
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_History_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                object obj = (Occurence)((DataGridView)sender).SelectedRows[0].DataBoundItem;
                Occurence occurence = (Occurence)obj;
                Occurence.Occurences.Remove(occurence);
                ReloadCurrentPage(PageType);
            }
        }
        #endregion
    }
}