namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tenants");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Maintenance");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStripProperty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgv_PastMaintenance = new System.Windows.Forms.DataGridView();
            this.lbl_PastMaintenanceLabel = new System.Windows.Forms.Label();
            this.lbl_FloorPlanLabel = new System.Windows.Forms.LinkLabel();
            this.FloorPlanContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_PetDeposit = new System.Windows.Forms.Label();
            this.lbl_Deposit = new System.Windows.Forms.Label();
            this.lbl_PetDepositLabel = new System.Windows.Forms.Label();
            this.lbl_DepositLabel = new System.Windows.Forms.Label();
            this.lblTen_Email = new System.Windows.Forms.Label();
            this.lblTen_EmailLabel = new System.Windows.Forms.Label();
            this.lblTen_Phone = new System.Windows.Forms.Label();
            this.lblTen_PhoneLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnProp_MoveInTenants = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProp_MoveOutTenants = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProp_AddIncident = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProp_AddPayment = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProp_AddServiceCall = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProp_AddMaintenanceItem = new System.Windows.Forms.ToolStripButton();
            this.lbl_CurrentLeaseLabel = new System.Windows.Forms.LinkLabel();
            this.CurrentLeaseContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProp_PreviousLeasesLabel = new System.Windows.Forms.LinkLabel();
            this.img_Picture = new System.Windows.Forms.PictureBox();
            this.PropTenImageContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMNT_RoutineMaintenance = new System.Windows.Forms.DataGridView();
            this.lblMNT_ServiceCallsLabel = new System.Windows.Forms.Label();
            this.lblMNT_RoutineMaintenanceLabel = new System.Windows.Forms.Label();
            this.lblTen_Age = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lblTen_AgeLabel = new System.Windows.Forms.Label();
            this.lbl_Rent = new System.Windows.Forms.Label();
            this.lblTen_Residence = new System.Windows.Forms.LinkLabel();
            this.lblProp_MoveInDateLabel = new System.Windows.Forms.Label();
            this.lblTen_ResidenceLabel = new System.Windows.Forms.Label();
            this.lblProp_MoveOutDateLabel = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lblProp_TenantsLabel = new System.Windows.Forms.Label();
            this.lbl_StatusLabel = new System.Windows.Forms.Label();
            this.lblProp_MoveInDate = new System.Windows.Forms.Label();
            this.lblProp_Tenant4 = new System.Windows.Forms.LinkLabel();
            this.lblProp_MoveOutDate = new System.Windows.Forms.Label();
            this.lblProp_Tenant3 = new System.Windows.Forms.LinkLabel();
            this.dataGrid_History = new System.Windows.Forms.DataGridView();
            this.instanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProp_Tenant2 = new System.Windows.Forms.LinkLabel();
            this.lbl_HistoryLabel = new System.Windows.Forms.Label();
            this.lblProp_Tenant1 = new System.Windows.Forms.LinkLabel();
            this.lbl_RentLabel = new System.Windows.Forms.Label();
            this.dgvMNT_ServiceCalls = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripTenant = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtn_AddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtn_AddTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogLeaseImage = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogFloorPlanImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPropTenImage = new System.Windows.Forms.OpenFileDialog();
            this.cms_Maintenancedgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmi_MaintenanceComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmi_MaintenanceCancel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PastMaintenance)).BeginInit();
            this.FloorPlanContextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.CurrentLeaseContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Picture)).BeginInit();
            this.PropTenImageContextStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMNT_RoutineMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMNT_ServiceCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripTenant.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.cms_Maintenancedgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.dgv_PastMaintenance);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_PastMaintenanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_FloorPlanLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_PetDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Deposit);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_PetDepositLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_DepositLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_Email);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_EmailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_Phone);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_PhoneLabel);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_CurrentLeaseLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_PreviousLeasesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.img_Picture);
            this.splitContainer1.Panel2.Controls.Add(this.dgvMNT_RoutineMaintenance);
            this.splitContainer1.Panel2.Controls.Add(this.lblMNT_ServiceCallsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblMNT_RoutineMaintenanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_Age);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Title);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_AgeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Rent);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_Residence);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_MoveInDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblTen_ResidenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_MoveOutDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Status);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_TenantsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_StatusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_MoveInDate);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_Tenant4);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_MoveOutDate);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_Tenant3);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid_History);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_Tenant2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_HistoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lblProp_Tenant1);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_RentLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dgvMNT_ServiceCalls);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 766);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStripProperty;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageKey = "Folder_c.gif";
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Properties";
            treeNode1.SelectedImageIndex = -2;
            treeNode1.Text = "Properties";
            treeNode2.Name = "Tenants";
            treeNode2.Text = "Tenants";
            treeNode3.Name = "Maintenance";
            treeNode3.Text = "Maintenance";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(209, 762);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStripProperty
            // 
            this.contextMenuStripProperty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPropertyToolStripMenuItem,
            this.removePropertyToolStripMenuItem});
            this.contextMenuStripProperty.Name = "contextMenuStrip1";
            this.contextMenuStripProperty.Size = new System.Drawing.Size(172, 48);
            // 
            // addNewPropertyToolStripMenuItem
            // 
            this.addNewPropertyToolStripMenuItem.Name = "addNewPropertyToolStripMenuItem";
            this.addNewPropertyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewPropertyToolStripMenuItem.Text = "Add New Property";
            this.addNewPropertyToolStripMenuItem.Click += new System.EventHandler(this.addNewPropertyToolStripMenuItem_Click);
            // 
            // removePropertyToolStripMenuItem
            // 
            this.removePropertyToolStripMenuItem.Name = "removePropertyToolStripMenuItem";
            this.removePropertyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removePropertyToolStripMenuItem.Text = "Remove Property";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.gif");
            this.imageList1.Images.SetKeyName(1, "Home-Blue.bmp");
            this.imageList1.Images.SetKeyName(2, "Home-Green.bmp");
            this.imageList1.Images.SetKeyName(3, "Home-Red.bmp");
            // 
            // dgv_PastMaintenance
            // 
            this.dgv_PastMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PastMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PastMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PastMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PastMaintenance.Location = new System.Drawing.Point(63, 642);
            this.dgv_PastMaintenance.MultiSelect = false;
            this.dgv_PastMaintenance.Name = "dgv_PastMaintenance";
            this.dgv_PastMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PastMaintenance.Size = new System.Drawing.Size(796, 263);
            this.dgv_PastMaintenance.TabIndex = 42;
            this.dgv_PastMaintenance.Tag = "Maintenance";
            this.dgv_PastMaintenance.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMNT_ServiceCalls_MouseDoubleClick);
            // 
            // lbl_PastMaintenanceLabel
            // 
            this.lbl_PastMaintenanceLabel.AutoSize = true;
            this.lbl_PastMaintenanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PastMaintenanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PastMaintenanceLabel.Location = new System.Drawing.Point(65, 602);
            this.lbl_PastMaintenanceLabel.Name = "lbl_PastMaintenanceLabel";
            this.lbl_PastMaintenanceLabel.Size = new System.Drawing.Size(288, 37);
            this.lbl_PastMaintenanceLabel.TabIndex = 41;
            this.lbl_PastMaintenanceLabel.Tag = "Maintenance";
            this.lbl_PastMaintenanceLabel.Text = "Past Maintenance";
            this.lbl_PastMaintenanceLabel.Visible = false;
            // 
            // lbl_FloorPlanLabel
            // 
            this.lbl_FloorPlanLabel.AutoSize = true;
            this.lbl_FloorPlanLabel.ContextMenuStrip = this.FloorPlanContextMenu;
            this.lbl_FloorPlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FloorPlanLabel.Location = new System.Drawing.Point(49, 208);
            this.lbl_FloorPlanLabel.Name = "lbl_FloorPlanLabel";
            this.lbl_FloorPlanLabel.Size = new System.Drawing.Size(69, 16);
            this.lbl_FloorPlanLabel.TabIndex = 39;
            this.lbl_FloorPlanLabel.TabStop = true;
            this.lbl_FloorPlanLabel.Tag = "Property";
            this.lbl_FloorPlanLabel.Text = "Floor Plan";
            this.lbl_FloorPlanLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_FloorPlan_LinkClicked);
            // 
            // FloorPlanContextMenu
            // 
            this.FloorPlanContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.FloorPlanContextMenu.Name = "CurrentLeaseContextMenu";
            this.FloorPlanContextMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.cmi_OpenFloorPlanImage_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem4.Text = "Change File";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.cmi_ChangeFloorPlanImage_Click);
            // 
            // lbl_PetDeposit
            // 
            this.lbl_PetDeposit.AutoSize = true;
            this.lbl_PetDeposit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PetDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PetDeposit.Location = new System.Drawing.Point(666, 232);
            this.lbl_PetDeposit.Name = "lbl_PetDeposit";
            this.lbl_PetDeposit.Size = new System.Drawing.Size(99, 20);
            this.lbl_PetDeposit.TabIndex = 38;
            this.lbl_PetDeposit.Tag = "Property";
            this.lbl_PetDeposit.Text = "petdepositlbl";
            // 
            // lbl_Deposit
            // 
            this.lbl_Deposit.AutoSize = true;
            this.lbl_Deposit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deposit.Location = new System.Drawing.Point(666, 201);
            this.lbl_Deposit.Name = "lbl_Deposit";
            this.lbl_Deposit.Size = new System.Drawing.Size(76, 20);
            this.lbl_Deposit.TabIndex = 37;
            this.lbl_Deposit.Tag = "Property";
            this.lbl_Deposit.Text = "depositlbl";
            // 
            // lbl_PetDepositLabel
            // 
            this.lbl_PetDepositLabel.AutoSize = true;
            this.lbl_PetDepositLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PetDepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PetDepositLabel.Location = new System.Drawing.Point(433, 232);
            this.lbl_PetDepositLabel.Name = "lbl_PetDepositLabel";
            this.lbl_PetDepositLabel.Size = new System.Drawing.Size(227, 20);
            this.lbl_PetDepositLabel.TabIndex = 36;
            this.lbl_PetDepositLabel.Tag = "Property";
            this.lbl_PetDepositLabel.Text = "Pet Deposit (Initial/Remaining):";
            // 
            // lbl_DepositLabel
            // 
            this.lbl_DepositLabel.AutoSize = true;
            this.lbl_DepositLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DepositLabel.Location = new System.Drawing.Point(461, 201);
            this.lbl_DepositLabel.Name = "lbl_DepositLabel";
            this.lbl_DepositLabel.Size = new System.Drawing.Size(199, 20);
            this.lbl_DepositLabel.TabIndex = 35;
            this.lbl_DepositLabel.Tag = "Property";
            this.lbl_DepositLabel.Text = "Deposit (Initial/Remaining):";
            // 
            // lblTen_Email
            // 
            this.lblTen_Email.AutoSize = true;
            this.lblTen_Email.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Email.Location = new System.Drawing.Point(575, 157);
            this.lblTen_Email.Name = "lblTen_Email";
            this.lblTen_Email.Size = new System.Drawing.Size(61, 20);
            this.lblTen_Email.TabIndex = 34;
            this.lblTen_Email.Tag = "Tenant";
            this.lblTen_Email.Text = "emaillbl";
            // 
            // lblTen_EmailLabel
            // 
            this.lblTen_EmailLabel.AutoSize = true;
            this.lblTen_EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_EmailLabel.Location = new System.Drawing.Point(517, 157);
            this.lblTen_EmailLabel.Name = "lblTen_EmailLabel";
            this.lblTen_EmailLabel.Size = new System.Drawing.Size(52, 20);
            this.lblTen_EmailLabel.TabIndex = 33;
            this.lblTen_EmailLabel.Tag = "Tenant";
            this.lblTen_EmailLabel.Text = "Email:";
            // 
            // lblTen_Phone
            // 
            this.lblTen_Phone.AutoSize = true;
            this.lblTen_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Phone.Location = new System.Drawing.Point(575, 128);
            this.lblTen_Phone.Name = "lblTen_Phone";
            this.lblTen_Phone.Size = new System.Drawing.Size(69, 20);
            this.lblTen_Phone.TabIndex = 32;
            this.lblTen_Phone.Tag = "Tenant";
            this.lblTen_Phone.Text = "phonelbl";
            // 
            // lblTen_PhoneLabel
            // 
            this.lblTen_PhoneLabel.AutoSize = true;
            this.lblTen_PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_PhoneLabel.Location = new System.Drawing.Point(510, 128);
            this.lblTen_PhoneLabel.Name = "lblTen_PhoneLabel";
            this.lblTen_PhoneLabel.Size = new System.Drawing.Size(59, 20);
            this.lblTen_PhoneLabel.TabIndex = 31;
            this.lblTen_PhoneLabel.Tag = "Tenant";
            this.lblTen_PhoneLabel.Text = "Phone:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnProp_MoveInTenants,
            this.tsbtnProp_MoveOutTenants,
            this.tsbtnProp_AddIncident,
            this.tsbtnProp_AddPayment,
            this.tsbtnProp_AddServiceCall,
            this.tsbtnProp_AddMaintenanceItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(952, 27);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Tag = "Property";
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnProp_MoveInTenants
            // 
            this.tsbtnProp_MoveInTenants.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProp_MoveInTenants.Image = global::WindowsFormsApplication1.Properties.Resources.add_small;
            this.tsbtnProp_MoveInTenants.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProp_MoveInTenants.Name = "tsbtnProp_MoveInTenants";
            this.tsbtnProp_MoveInTenants.Size = new System.Drawing.Size(24, 24);
            this.tsbtnProp_MoveInTenants.Text = "Move In Tenants";
            this.tsbtnProp_MoveInTenants.ToolTipText = "Move In Tenants";
            this.tsbtnProp_MoveInTenants.Click += new System.EventHandler(this.tsbtnProp_MoveInTenants_Click);
            // 
            // tsbtnProp_MoveOutTenants
            // 
            this.tsbtnProp_MoveOutTenants.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProp_MoveOutTenants.Image = global::WindowsFormsApplication1.Properties.Resources.Remove;
            this.tsbtnProp_MoveOutTenants.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProp_MoveOutTenants.Name = "tsbtnProp_MoveOutTenants";
            this.tsbtnProp_MoveOutTenants.Size = new System.Drawing.Size(24, 24);
            this.tsbtnProp_MoveOutTenants.Text = "Move Out Tenants";
            this.tsbtnProp_MoveOutTenants.Click += new System.EventHandler(this.tsbtnProp_MoveOutTenants_Click);
            // 
            // tsbtnProp_AddIncident
            // 
            this.tsbtnProp_AddIncident.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProp_AddIncident.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProp_AddIncident.Image")));
            this.tsbtnProp_AddIncident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProp_AddIncident.Name = "tsbtnProp_AddIncident";
            this.tsbtnProp_AddIncident.Size = new System.Drawing.Size(24, 24);
            this.tsbtnProp_AddIncident.Text = "Add Incident";
            this.tsbtnProp_AddIncident.Click += new System.EventHandler(this.tsbtnProp_AddIncident_Click);
            // 
            // tsbtnProp_AddPayment
            // 
            this.tsbtnProp_AddPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProp_AddPayment.Image = global::WindowsFormsApplication1.Properties.Resources.dollarSign;
            this.tsbtnProp_AddPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProp_AddPayment.Name = "tsbtnProp_AddPayment";
            this.tsbtnProp_AddPayment.Size = new System.Drawing.Size(24, 24);
            this.tsbtnProp_AddPayment.Text = "Add Payment";
            this.tsbtnProp_AddPayment.Click += new System.EventHandler(this.tsbtnProp_AddPayment_Click);
            // 
            // tsbtnProp_AddServiceCall
            // 
            this.tsbtnProp_AddServiceCall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProp_AddServiceCall.Image = global::WindowsFormsApplication1.Properties.Resources.Telephone;
            this.tsbtnProp_AddServiceCall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProp_AddServiceCall.Name = "tsbtnProp_AddServiceCall";
            this.tsbtnProp_AddServiceCall.Size = new System.Drawing.Size(24, 24);
            this.tsbtnProp_AddServiceCall.Text = "Add Service Call";
            this.tsbtnProp_AddServiceCall.Click += new System.EventHandler(this.tsbtnProp_AddServiceCall_Click);
            // 
            // tsbtnProp_AddMaintenanceItem
            // 
            this.tsbtnProp_AddMaintenanceItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProp_AddMaintenanceItem.Image = global::WindowsFormsApplication1.Properties.Resources.Maintenance;
            this.tsbtnProp_AddMaintenanceItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProp_AddMaintenanceItem.Name = "tsbtnProp_AddMaintenanceItem";
            this.tsbtnProp_AddMaintenanceItem.Size = new System.Drawing.Size(24, 24);
            this.tsbtnProp_AddMaintenanceItem.Text = "Add Maintenance Item";
            this.tsbtnProp_AddMaintenanceItem.Click += new System.EventHandler(this.tsbtnProp_AddMaintenanceItem_Click);
            // 
            // lbl_CurrentLeaseLabel
            // 
            this.lbl_CurrentLeaseLabel.AutoSize = true;
            this.lbl_CurrentLeaseLabel.ContextMenuStrip = this.CurrentLeaseContextMenu;
            this.lbl_CurrentLeaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentLeaseLabel.Location = new System.Drawing.Point(223, 204);
            this.lbl_CurrentLeaseLabel.Name = "lbl_CurrentLeaseLabel";
            this.lbl_CurrentLeaseLabel.Size = new System.Drawing.Size(91, 16);
            this.lbl_CurrentLeaseLabel.TabIndex = 29;
            this.lbl_CurrentLeaseLabel.TabStop = true;
            this.lbl_CurrentLeaseLabel.Tag = "PropertyTenant";
            this.lbl_CurrentLeaseLabel.Text = "Current Lease";
            this.lbl_CurrentLeaseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_CurrentLease_LinkClicked);
            // 
            // CurrentLeaseContextMenu
            // 
            this.CurrentLeaseContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.changeFileToolStripMenuItem});
            this.CurrentLeaseContextMenu.Name = "CurrentLeaseContextMenu";
            this.CurrentLeaseContextMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.cmi_OpenLeaseImage_Click);
            // 
            // changeFileToolStripMenuItem
            // 
            this.changeFileToolStripMenuItem.Name = "changeFileToolStripMenuItem";
            this.changeFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.changeFileToolStripMenuItem.Text = "Change File";
            this.changeFileToolStripMenuItem.Click += new System.EventHandler(this.cmi_ChangeLeaseImage_Click);
            // 
            // lblProp_PreviousLeasesLabel
            // 
            this.lblProp_PreviousLeasesLabel.AutoSize = true;
            this.lblProp_PreviousLeasesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_PreviousLeasesLabel.Location = new System.Drawing.Point(223, 235);
            this.lblProp_PreviousLeasesLabel.Name = "lblProp_PreviousLeasesLabel";
            this.lblProp_PreviousLeasesLabel.Size = new System.Drawing.Size(109, 16);
            this.lblProp_PreviousLeasesLabel.TabIndex = 28;
            this.lblProp_PreviousLeasesLabel.TabStop = true;
            this.lblProp_PreviousLeasesLabel.Tag = "Property";
            this.lblProp_PreviousLeasesLabel.Text = "Previous Leases";
            this.lblProp_PreviousLeasesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_PreviousLeases_LinkClicked);
            // 
            // img_Picture
            // 
            this.img_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Picture.ContextMenuStrip = this.PropTenImageContextStrip;
            this.img_Picture.Location = new System.Drawing.Point(16, 31);
            this.img_Picture.Name = "img_Picture";
            this.img_Picture.Size = new System.Drawing.Size(146, 174);
            this.img_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Picture.TabIndex = 0;
            this.img_Picture.TabStop = false;
            this.img_Picture.Tag = "PropertyTenant";
            this.img_Picture.Click += new System.EventHandler(this.img_Picture_Click);
            // 
            // PropTenImageContextStrip
            // 
            this.PropTenImageContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.PropTenImageContextStrip.Name = "CurrentLeaseContextMenu";
            this.PropTenImageContextStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem5.Text = "Open";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.cmi_OpenPropTenImage_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem6.Text = "Change File";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.cmi_ChangePropTenImage_Click);
            // 
            // dgvMNT_RoutineMaintenance
            // 
            this.dgvMNT_RoutineMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMNT_RoutineMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMNT_RoutineMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMNT_RoutineMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMNT_RoutineMaintenance.Location = new System.Drawing.Point(63, 335);
            this.dgvMNT_RoutineMaintenance.MultiSelect = false;
            this.dgvMNT_RoutineMaintenance.Name = "dgvMNT_RoutineMaintenance";
            this.dgvMNT_RoutineMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMNT_RoutineMaintenance.Size = new System.Drawing.Size(796, 250);
            this.dgvMNT_RoutineMaintenance.TabIndex = 27;
            this.dgvMNT_RoutineMaintenance.Tag = "Maintenance";
            this.dgvMNT_RoutineMaintenance.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMNT_ServiceCalls_MouseDoubleClick);
            this.dgvMNT_RoutineMaintenance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_Maintenance_MouseDown);
            // 
            // lblMNT_ServiceCallsLabel
            // 
            this.lblMNT_ServiceCallsLabel.AutoSize = true;
            this.lblMNT_ServiceCallsLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblMNT_ServiceCallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMNT_ServiceCallsLabel.Location = new System.Drawing.Point(65, 19);
            this.lblMNT_ServiceCallsLabel.Name = "lblMNT_ServiceCallsLabel";
            this.lblMNT_ServiceCallsLabel.Size = new System.Drawing.Size(214, 37);
            this.lblMNT_ServiceCallsLabel.TabIndex = 25;
            this.lblMNT_ServiceCallsLabel.Tag = "PropertyMaintenancePropH";
            this.lblMNT_ServiceCallsLabel.Text = "Service Calls";
            this.lblMNT_ServiceCallsLabel.Visible = false;
            // 
            // lblMNT_RoutineMaintenanceLabel
            // 
            this.lblMNT_RoutineMaintenanceLabel.AutoSize = true;
            this.lblMNT_RoutineMaintenanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblMNT_RoutineMaintenanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMNT_RoutineMaintenanceLabel.Location = new System.Drawing.Point(65, 295);
            this.lblMNT_RoutineMaintenanceLabel.Name = "lblMNT_RoutineMaintenanceLabel";
            this.lblMNT_RoutineMaintenanceLabel.Size = new System.Drawing.Size(336, 37);
            this.lblMNT_RoutineMaintenanceLabel.TabIndex = 26;
            this.lblMNT_RoutineMaintenanceLabel.Tag = "Maintenance";
            this.lblMNT_RoutineMaintenanceLabel.Text = "Routine Maintenance";
            this.lblMNT_RoutineMaintenanceLabel.Visible = false;
            // 
            // lblTen_Age
            // 
            this.lblTen_Age.AutoSize = true;
            this.lblTen_Age.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Age.Location = new System.Drawing.Point(299, 128);
            this.lblTen_Age.Name = "lblTen_Age";
            this.lblTen_Age.Size = new System.Drawing.Size(51, 20);
            this.lblTen_Age.TabIndex = 23;
            this.lblTen_Age.Tag = "Tenant";
            this.lblTen_Age.Text = "agelbl";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(169, 39);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(157, 37);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Tag = "PropertyTenant";
            this.lbl_Title.Text = "headerlbl";
            // 
            // lblTen_AgeLabel
            // 
            this.lblTen_AgeLabel.AutoSize = true;
            this.lblTen_AgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_AgeLabel.Location = new System.Drawing.Point(251, 128);
            this.lblTen_AgeLabel.Name = "lblTen_AgeLabel";
            this.lblTen_AgeLabel.Size = new System.Drawing.Size(42, 20);
            this.lblTen_AgeLabel.TabIndex = 22;
            this.lblTen_AgeLabel.Tag = "Tenant";
            this.lblTen_AgeLabel.Text = "Age:";
            // 
            // lbl_Rent
            // 
            this.lbl_Rent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Rent.AutoSize = true;
            this.lbl_Rent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rent.Location = new System.Drawing.Point(708, 49);
            this.lbl_Rent.Name = "lbl_Rent";
            this.lbl_Rent.Size = new System.Drawing.Size(71, 25);
            this.lbl_Rent.TabIndex = 2;
            this.lbl_Rent.Tag = "PropertyTenant";
            this.lbl_Rent.Text = "rentlbl";
            // 
            // lblTen_Residence
            // 
            this.lblTen_Residence.AutoSize = true;
            this.lblTen_Residence.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Residence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Residence.Location = new System.Drawing.Point(299, 97);
            this.lblTen_Residence.Name = "lblTen_Residence";
            this.lblTen_Residence.Size = new System.Drawing.Size(93, 20);
            this.lblTen_Residence.TabIndex = 16;
            this.lblTen_Residence.TabStop = true;
            this.lblTen_Residence.Tag = "Tenant";
            this.lblTen_Residence.Text = "residencelbl";
            this.lblTen_Residence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProp_Tenant_LinkClicked);
            // 
            // lblProp_MoveInDateLabel
            // 
            this.lblProp_MoveInDateLabel.AutoSize = true;
            this.lblProp_MoveInDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_MoveInDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_MoveInDateLabel.Location = new System.Drawing.Point(185, 97);
            this.lblProp_MoveInDateLabel.Name = "lblProp_MoveInDateLabel";
            this.lblProp_MoveInDateLabel.Size = new System.Drawing.Size(108, 20);
            this.lblProp_MoveInDateLabel.TabIndex = 3;
            this.lblProp_MoveInDateLabel.Tag = "Property";
            this.lblProp_MoveInDateLabel.Text = "Move In Date:";
            // 
            // lblTen_ResidenceLabel
            // 
            this.lblTen_ResidenceLabel.AutoSize = true;
            this.lblTen_ResidenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_ResidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_ResidenceLabel.Location = new System.Drawing.Point(204, 97);
            this.lblTen_ResidenceLabel.Name = "lblTen_ResidenceLabel";
            this.lblTen_ResidenceLabel.Size = new System.Drawing.Size(89, 20);
            this.lblTen_ResidenceLabel.TabIndex = 21;
            this.lblTen_ResidenceLabel.Tag = "Tenant";
            this.lblTen_ResidenceLabel.Text = "Residence:";
            // 
            // lblProp_MoveOutDateLabel
            // 
            this.lblProp_MoveOutDateLabel.AutoSize = true;
            this.lblProp_MoveOutDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_MoveOutDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_MoveOutDateLabel.Location = new System.Drawing.Point(173, 128);
            this.lblProp_MoveOutDateLabel.Name = "lblProp_MoveOutDateLabel";
            this.lblProp_MoveOutDateLabel.Size = new System.Drawing.Size(120, 20);
            this.lblProp_MoveOutDateLabel.TabIndex = 4;
            this.lblProp_MoveOutDateLabel.Tag = "Property";
            this.lblProp_MoveOutDateLabel.Text = "Move Out Date:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(299, 157);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(68, 20);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Tag = "PropertyTenant";
            this.lbl_Status.Text = "statuslbl";
            // 
            // lblProp_TenantsLabel
            // 
            this.lblProp_TenantsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp_TenantsLabel.AutoSize = true;
            this.lblProp_TenantsLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_TenantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_TenantsLabel.Location = new System.Drawing.Point(631, 97);
            this.lblProp_TenantsLabel.Name = "lblProp_TenantsLabel";
            this.lblProp_TenantsLabel.Size = new System.Drawing.Size(71, 20);
            this.lblProp_TenantsLabel.TabIndex = 5;
            this.lblProp_TenantsLabel.Tag = "Property";
            this.lblProp_TenantsLabel.Text = "Tenants:";
            // 
            // lbl_StatusLabel
            // 
            this.lbl_StatusLabel.AutoSize = true;
            this.lbl_StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusLabel.Location = new System.Drawing.Point(233, 157);
            this.lbl_StatusLabel.Name = "lbl_StatusLabel";
            this.lbl_StatusLabel.Size = new System.Drawing.Size(60, 20);
            this.lbl_StatusLabel.TabIndex = 19;
            this.lbl_StatusLabel.Tag = "PropertyTenant";
            this.lbl_StatusLabel.Text = "Status:";
            // 
            // lblProp_MoveInDate
            // 
            this.lblProp_MoveInDate.AutoSize = true;
            this.lblProp_MoveInDate.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_MoveInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_MoveInDate.Location = new System.Drawing.Point(299, 97);
            this.lblProp_MoveInDate.Name = "lblProp_MoveInDate";
            this.lblProp_MoveInDate.Size = new System.Drawing.Size(74, 20);
            this.lblProp_MoveInDate.TabIndex = 10;
            this.lblProp_MoveInDate.Tag = "Property";
            this.lblProp_MoveInDate.Text = "moveinlbl";
            // 
            // lblProp_Tenant4
            // 
            this.lblProp_Tenant4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp_Tenant4.AutoSize = true;
            this.lblProp_Tenant4.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_Tenant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_Tenant4.Location = new System.Drawing.Point(708, 157);
            this.lblProp_Tenant4.Name = "lblProp_Tenant4";
            this.lblProp_Tenant4.Size = new System.Drawing.Size(0, 20);
            this.lblProp_Tenant4.TabIndex = 18;
            this.lblProp_Tenant4.Tag = "Property";
            this.lblProp_Tenant4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProp_Tenant_LinkClicked);
            // 
            // lblProp_MoveOutDate
            // 
            this.lblProp_MoveOutDate.AutoSize = true;
            this.lblProp_MoveOutDate.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_MoveOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_MoveOutDate.Location = new System.Drawing.Point(299, 128);
            this.lblProp_MoveOutDate.Name = "lblProp_MoveOutDate";
            this.lblProp_MoveOutDate.Size = new System.Drawing.Size(85, 20);
            this.lblProp_MoveOutDate.TabIndex = 11;
            this.lblProp_MoveOutDate.Tag = "Property";
            this.lblProp_MoveOutDate.Text = "moveoutlbl";
            // 
            // lblProp_Tenant3
            // 
            this.lblProp_Tenant3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp_Tenant3.AutoSize = true;
            this.lblProp_Tenant3.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_Tenant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_Tenant3.Location = new System.Drawing.Point(708, 137);
            this.lblProp_Tenant3.Name = "lblProp_Tenant3";
            this.lblProp_Tenant3.Size = new System.Drawing.Size(0, 20);
            this.lblProp_Tenant3.TabIndex = 17;
            this.lblProp_Tenant3.Tag = "Property";
            this.lblProp_Tenant3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProp_Tenant_LinkClicked);
            // 
            // dataGrid_History
            // 
            this.dataGrid_History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_History.AutoGenerateColumns = false;
            this.dataGrid_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_History.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instanceNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.incidentDateDataGridViewTextBoxColumn});
            this.dataGrid_History.DataSource = this.incidentBindingSource;
            this.dataGrid_History.Location = new System.Drawing.Point(63, 286);
            this.dataGrid_History.MultiSelect = false;
            this.dataGrid_History.Name = "dataGrid_History";
            this.dataGrid_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_History.Size = new System.Drawing.Size(796, 313);
            this.dataGrid_History.TabIndex = 12;
            this.dataGrid_History.Tag = "PropertyTenant";
            this.dataGrid_History.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_History_KeyDown);
            this.dataGrid_History.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMNT_ServiceCalls_MouseDoubleClick);
            // 
            // instanceNameDataGridViewTextBoxColumn
            // 
            this.instanceNameDataGridViewTextBoxColumn.DataPropertyName = "InstanceName";
            this.instanceNameDataGridViewTextBoxColumn.HeaderText = "InstanceName";
            this.instanceNameDataGridViewTextBoxColumn.Name = "instanceNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // incidentDateDataGridViewTextBoxColumn
            // 
            this.incidentDateDataGridViewTextBoxColumn.DataPropertyName = "IncidentDate";
            this.incidentDateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.incidentDateDataGridViewTextBoxColumn.HeaderText = "IncidentDate";
            this.incidentDateDataGridViewTextBoxColumn.Name = "incidentDateDataGridViewTextBoxColumn";
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(WindowsFormsApplication1.Occurence);
            // 
            // lblProp_Tenant2
            // 
            this.lblProp_Tenant2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp_Tenant2.AutoSize = true;
            this.lblProp_Tenant2.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_Tenant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_Tenant2.Location = new System.Drawing.Point(708, 117);
            this.lblProp_Tenant2.Name = "lblProp_Tenant2";
            this.lblProp_Tenant2.Size = new System.Drawing.Size(0, 20);
            this.lblProp_Tenant2.TabIndex = 16;
            this.lblProp_Tenant2.Tag = "Property";
            this.lblProp_Tenant2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProp_Tenant_LinkClicked);
            // 
            // lbl_HistoryLabel
            // 
            this.lbl_HistoryLabel.AutoSize = true;
            this.lbl_HistoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HistoryLabel.Location = new System.Drawing.Point(65, 246);
            this.lbl_HistoryLabel.Name = "lbl_HistoryLabel";
            this.lbl_HistoryLabel.Size = new System.Drawing.Size(123, 37);
            this.lbl_HistoryLabel.TabIndex = 13;
            this.lbl_HistoryLabel.Tag = "PropertyTenant";
            this.lbl_HistoryLabel.Text = "History";
            // 
            // lblProp_Tenant1
            // 
            this.lblProp_Tenant1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp_Tenant1.AutoSize = true;
            this.lblProp_Tenant1.BackColor = System.Drawing.Color.Transparent;
            this.lblProp_Tenant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp_Tenant1.Location = new System.Drawing.Point(708, 97);
            this.lblProp_Tenant1.Name = "lblProp_Tenant1";
            this.lblProp_Tenant1.Size = new System.Drawing.Size(0, 20);
            this.lblProp_Tenant1.TabIndex = 15;
            this.lblProp_Tenant1.Tag = "Property";
            this.lblProp_Tenant1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProp_Tenant_LinkClicked);
            // 
            // lbl_RentLabel
            // 
            this.lbl_RentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RentLabel.AutoSize = true;
            this.lbl_RentLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentLabel.Location = new System.Drawing.Point(639, 49);
            this.lbl_RentLabel.Name = "lbl_RentLabel";
            this.lbl_RentLabel.Size = new System.Drawing.Size(63, 25);
            this.lbl_RentLabel.TabIndex = 14;
            this.lbl_RentLabel.Tag = "PropertyTenant";
            this.lbl_RentLabel.Text = "Rent:";
            // 
            // dgvMNT_ServiceCalls
            // 
            this.dgvMNT_ServiceCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMNT_ServiceCalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMNT_ServiceCalls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMNT_ServiceCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMNT_ServiceCalls.Location = new System.Drawing.Point(63, 59);
            this.dgvMNT_ServiceCalls.MultiSelect = false;
            this.dgvMNT_ServiceCalls.Name = "dgvMNT_ServiceCalls";
            this.dgvMNT_ServiceCalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMNT_ServiceCalls.Size = new System.Drawing.Size(796, 216);
            this.dgvMNT_ServiceCalls.TabIndex = 24;
            this.dgvMNT_ServiceCalls.Tag = "PropertyMaintenancePropH";
            this.dgvMNT_ServiceCalls.Visible = false;
            this.dgvMNT_ServiceCalls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMNT_ServiceCalls_CellContentClick);
            this.dgvMNT_ServiceCalls.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMNT_ServiceCalls_CellMouseEnter);
            this.dgvMNT_ServiceCalls.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMNT_ServiceCalls_CellMouseLeave);
            this.dgvMNT_ServiceCalls.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMNT_ServiceCalls_MouseDoubleClick);
            this.dgvMNT_ServiceCalls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_Maintenance_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.RedBoulder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 905);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Home";
            // 
            // contextMenuStripTenant
            // 
            this.contextMenuStripTenant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTenantToolStripMenuItem,
            this.toolStripMenuItem3});
            this.contextMenuStripTenant.Name = "contextMenuStrip1";
            this.contextMenuStripTenant.Size = new System.Drawing.Size(164, 48);
            // 
            // addNewTenantToolStripMenuItem
            // 
            this.addNewTenantToolStripMenuItem.Name = "addNewTenantToolStripMenuItem";
            this.addNewTenantToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addNewTenantToolStripMenuItem.Text = "Add New Tenant";
            this.addNewTenantToolStripMenuItem.Click += new System.EventHandler(this.addNewTenantToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem3.Text = "Remove Tenant";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.tsbtn_AddProperty,
            this.tsbtn_AddTenant});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.ShowItemToolTips = true;
            this.MenuStrip.Size = new System.Drawing.Size(1190, 46);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoToolTip = true;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 42);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.ToolTipText = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // tsbtn_AddProperty
            // 
            this.tsbtn_AddProperty.AutoToolTip = true;
            this.tsbtn_AddProperty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtn_AddProperty.Image = global::WindowsFormsApplication1.Properties.Resources.AddPropertyIcon;
            this.tsbtn_AddProperty.Name = "tsbtn_AddProperty";
            this.tsbtn_AddProperty.Size = new System.Drawing.Size(86, 42);
            this.tsbtn_AddProperty.Text = "Add Property";
            this.tsbtn_AddProperty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_AddProperty.ToolTipText = "Add Property";
            this.tsbtn_AddProperty.Click += new System.EventHandler(this.tsbtn_AddProperty_Click);
            // 
            // tsbtn_AddTenant
            // 
            this.tsbtn_AddTenant.AutoToolTip = true;
            this.tsbtn_AddTenant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtn_AddTenant.Image = global::WindowsFormsApplication1.Properties.Resources.AddTenantIcon;
            this.tsbtn_AddTenant.Name = "tsbtn_AddTenant";
            this.tsbtn_AddTenant.Size = new System.Drawing.Size(78, 42);
            this.tsbtn_AddTenant.Text = "Add Tenant";
            this.tsbtn_AddTenant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_AddTenant.ToolTipText = "Add Tenant";
            this.tsbtn_AddTenant.Click += new System.EventHandler(this.tsbtn_AddTenant_Click);
            // 
            // openFileDialogLeaseImage
            // 
            this.openFileDialogLeaseImage.FileName = "openFileDialogLeaseImage";
            this.openFileDialogLeaseImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLeaseImage_FileOk);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialogFloorPlanImage
            // 
            this.openFileDialogFloorPlanImage.FileName = "openFileDialogFloorPlanImage";
            this.openFileDialogFloorPlanImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogFloorPlanImage_FileOk);
            // 
            // openFileDialogPropTenImage
            // 
            this.openFileDialogPropTenImage.FileName = "openFileDialogPropTenImage";
            this.openFileDialogPropTenImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogPropTenImage_FileOk);
            // 
            // cms_Maintenancedgv
            // 
            this.cms_Maintenancedgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmi_MaintenanceComplete,
            this.cmi_MaintenanceCancel});
            this.cms_Maintenancedgv.Name = "cms_Maintenancedgv";
            this.cms_Maintenancedgv.Size = new System.Drawing.Size(127, 48);
            // 
            // cmi_MaintenanceComplete
            // 
            this.cmi_MaintenanceComplete.Name = "cmi_MaintenanceComplete";
            this.cmi_MaintenanceComplete.Size = new System.Drawing.Size(126, 22);
            this.cmi_MaintenanceComplete.Text = "Complete";
            this.cmi_MaintenanceComplete.Click += new System.EventHandler(this.cmi_MaintenanceComplete_Click);
            // 
            // cmi_MaintenanceCancel
            // 
            this.cmi_MaintenanceCancel.Name = "cmi_MaintenanceCancel";
            this.cmi_MaintenanceCancel.Size = new System.Drawing.Size(126, 22);
            this.cmi_MaintenanceCancel.Text = "Cancel";
            this.cmi_MaintenanceCancel.Click += new System.EventHandler(this.cmi_MaintenanceCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 812);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PastMaintenance)).EndInit();
            this.FloorPlanContextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CurrentLeaseContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Picture)).EndInit();
            this.PropTenImageContextStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMNT_RoutineMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMNT_ServiceCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripTenant.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.cms_Maintenancedgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblProp_TenantsLabel;
        private System.Windows.Forms.Label lblProp_MoveOutDateLabel;
        private System.Windows.Forms.Label lblProp_MoveInDateLabel;
        private System.Windows.Forms.Label lbl_Rent;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox img_Picture;
        private System.Windows.Forms.Label lbl_HistoryLabel;
        private System.Windows.Forms.DataGridView dataGrid_History;
        private System.Windows.Forms.Label lblProp_MoveOutDate;
        private System.Windows.Forms.Label lblProp_MoveInDate;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_RentLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProperty;
        private System.Windows.Forms.ToolStripMenuItem addNewPropertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePropertyToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblProp_Tenant1;
        private System.Windows.Forms.LinkLabel lblProp_Tenant4;
        private System.Windows.Forms.LinkLabel lblProp_Tenant3;
        private System.Windows.Forms.LinkLabel lblProp_Tenant2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_StatusLabel;
        private System.Windows.Forms.Label lblTen_ResidenceLabel;
        private System.Windows.Forms.LinkLabel lblTen_Residence;
        private System.Windows.Forms.Label lblTen_Age;
        private System.Windows.Forms.Label lblTen_AgeLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTenant;
        private System.Windows.Forms.ToolStripMenuItem addNewTenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsbtn_AddProperty;
        private System.Windows.Forms.DataGridView dgvMNT_RoutineMaintenance;
        private System.Windows.Forms.Label lblMNT_RoutineMaintenanceLabel;
        private System.Windows.Forms.DataGridView dgvMNT_ServiceCalls;
        private System.Windows.Forms.Label lblMNT_ServiceCallsLabel;
        private System.Windows.Forms.LinkLabel lblProp_PreviousLeasesLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialogLeaseImage;
        private System.Windows.Forms.LinkLabel lbl_CurrentLeaseLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnProp_MoveInTenants;
        private System.Windows.Forms.ToolStripButton tsbtnProp_MoveOutTenants;
        private System.Windows.Forms.ToolStripMenuItem tsbtn_AddTenant;
        private System.Windows.Forms.ContextMenuStrip CurrentLeaseContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label lblTen_Email;
        private System.Windows.Forms.Label lblTen_EmailLabel;
        private System.Windows.Forms.Label lblTen_Phone;
        private System.Windows.Forms.Label lblTen_PhoneLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_PetDeposit;
        private System.Windows.Forms.Label lbl_Deposit;
        private System.Windows.Forms.Label lbl_PetDepositLabel;
        private System.Windows.Forms.Label lbl_DepositLabel;
        private System.Windows.Forms.ToolStripButton tsbtnProp_AddIncident;
        private System.Windows.Forms.ToolStripButton tsbtnProp_AddPayment;
        private System.Windows.Forms.ToolStripButton tsbtnProp_AddServiceCall;
        private System.Windows.Forms.ToolStripButton tsbtnProp_AddMaintenanceItem;
        private System.Windows.Forms.LinkLabel lbl_FloorPlanLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialogFloorPlanImage;
        private System.Windows.Forms.ContextMenuStrip FloorPlanContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialogPropTenImage;
        private System.Windows.Forms.ContextMenuStrip PropTenImageContextStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip cms_Maintenancedgv;
        private System.Windows.Forms.ToolStripMenuItem cmi_MaintenanceComplete;
        private System.Windows.Forms.ToolStripMenuItem cmi_MaintenanceCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_PastMaintenance;
        private System.Windows.Forms.Label lbl_PastMaintenanceLabel;
    }
}

