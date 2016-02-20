namespace PropertyManagment
{
    partial class MainForm
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
            this.pnl_MainToolbar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btn_Property = new System.Windows.Forms.Button();
            this.btn_Finance = new System.Windows.Forms.Button();
            this.btn_Tenant = new System.Windows.Forms.Button();
            this.btn_Maintenance = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Property = new System.Windows.Forms.TabPage();
            this.dgv_Properties = new System.Windows.Forms.DataGridView();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.PropertyStreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_DeleteProperty = new System.Windows.Forms.Button();
            this.btn_EditProperty = new System.Windows.Forms.Button();
            this.btn_AddProperty = new System.Windows.Forms.Button();
            this.tab_Maintenance = new System.Windows.Forms.TabPage();
            this.dgv_Maintenance = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddMaintenance = new System.Windows.Forms.Button();
            this.btn_EditMaintenance = new System.Windows.Forms.Button();
            this.btn_DeleteMaintenance = new System.Windows.Forms.Button();
            this.tab_Finance = new System.Windows.Forms.TabPage();
            this.dgv_Finance = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddFinance = new System.Windows.Forms.Button();
            this.btn_EditFinance = new System.Windows.Forms.Button();
            this.btn_DeleteFinance = new System.Windows.Forms.Button();
            this.tab_Tenant = new System.Windows.Forms.TabPage();
            this.dgv_Tenant = new System.Windows.Forms.DataGridView();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_DeleteTenant = new System.Windows.Forms.Button();
            this.btn_EditTenant = new System.Windows.Forms.Button();
            this.btn_AddTenant = new System.Windows.Forms.Button();
            this.pnl_MainToolbar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Property.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tab_Maintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maintenance)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tab_Finance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Finance)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tab_Tenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tenant)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MainToolbar
            // 
            this.pnl_MainToolbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_MainToolbar.BackColor = System.Drawing.Color.LightGray;
            this.pnl_MainToolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_MainToolbar.Controls.Add(this.tableLayoutPanel1);
            this.pnl_MainToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MainToolbar.Location = new System.Drawing.Point(0, 78);
            this.pnl_MainToolbar.MinimumSize = new System.Drawing.Size(280, 70);
            this.pnl_MainToolbar.Name = "pnl_MainToolbar";
            this.pnl_MainToolbar.Size = new System.Drawing.Size(905, 70);
            this.pnl_MainToolbar.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Property, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Finance, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Tenant, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Maintenance, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 66);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red Rock Properties";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(689, 82);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(164, 23);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnl_MainToolbar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lbl_Date);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(909, 152);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(909, 177);
            this.toolStripContainer1.TabIndex = 11;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btn_Property
            // 
            this.btn_Property.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Property.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Property.BackColor = System.Drawing.Color.White;
            this.btn_Property.BackgroundImage = global::PropertyManagment.Properties.Resources.Home_icon;
            this.btn_Property.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Property.FlatAppearance.BorderSize = 0;
            this.btn_Property.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Property.Location = new System.Drawing.Point(77, 3);
            this.btn_Property.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_Property.Name = "btn_Property";
            this.btn_Property.Size = new System.Drawing.Size(70, 60);
            this.btn_Property.TabIndex = 0;
            this.btn_Property.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Property.UseVisualStyleBackColor = false;
            this.btn_Property.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // btn_Finance
            // 
            this.btn_Finance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Finance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Finance.BackColor = System.Drawing.Color.White;
            this.btn_Finance.BackgroundImage = global::PropertyManagment.Properties.Resources.dollarSign;
            this.btn_Finance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Finance.FlatAppearance.BorderSize = 0;
            this.btn_Finance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finance.Location = new System.Drawing.Point(753, 3);
            this.btn_Finance.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_Finance.Name = "btn_Finance";
            this.btn_Finance.Size = new System.Drawing.Size(70, 60);
            this.btn_Finance.TabIndex = 3;
            this.btn_Finance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Finance.UseVisualStyleBackColor = false;
            this.btn_Finance.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // btn_Tenant
            // 
            this.btn_Tenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tenant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tenant.BackColor = System.Drawing.Color.White;
            this.btn_Tenant.BackgroundImage = global::PropertyManagment.Properties.Resources.AddTenantIcon;
            this.btn_Tenant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Tenant.FlatAppearance.BorderSize = 0;
            this.btn_Tenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tenant.Location = new System.Drawing.Point(302, 3);
            this.btn_Tenant.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_Tenant.Name = "btn_Tenant";
            this.btn_Tenant.Size = new System.Drawing.Size(70, 60);
            this.btn_Tenant.TabIndex = 1;
            this.btn_Tenant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Tenant.UseVisualStyleBackColor = false;
            this.btn_Tenant.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // btn_Maintenance
            // 
            this.btn_Maintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Maintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Maintenance.BackColor = System.Drawing.Color.White;
            this.btn_Maintenance.BackgroundImage = global::PropertyManagment.Properties.Resources.Maintenance;
            this.btn_Maintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Maintenance.FlatAppearance.BorderSize = 0;
            this.btn_Maintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maintenance.Location = new System.Drawing.Point(527, 3);
            this.btn_Maintenance.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_Maintenance.Name = "btn_Maintenance";
            this.btn_Maintenance.Size = new System.Drawing.Size(70, 60);
            this.btn_Maintenance.TabIndex = 2;
            this.btn_Maintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Maintenance.UseVisualStyleBackColor = false;
            this.btn_Maintenance.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.BackgroundImage = global::PropertyManagment.Properties.Resources.Rocks;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 171);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.52631F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.47368F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(909, 380);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tab_Property);
            this.tabControl1.Controls.Add(this.tab_Maintenance);
            this.tabControl1.Controls.Add(this.tab_Finance);
            this.tabControl1.Controls.Add(this.tab_Tenant);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(1, 1);
            this.tabControl1.Location = new System.Drawing.Point(184, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(1, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 281);
            this.tabControl1.TabIndex = 12;
            // 
            // tab_Property
            // 
            this.tab_Property.BackColor = System.Drawing.Color.Transparent;
            this.tab_Property.Controls.Add(this.dgv_Properties);
            this.tab_Property.Controls.Add(this.tableLayoutPanel4);
            this.tab_Property.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_Property.Location = new System.Drawing.Point(4, 5);
            this.tab_Property.Name = "tab_Property";
            this.tab_Property.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Property.Size = new System.Drawing.Size(531, 272);
            this.tab_Property.TabIndex = 0;
            // 
            // dgv_Properties
            // 
            this.dgv_Properties.AllowUserToAddRows = false;
            this.dgv_Properties.AllowUserToDeleteRows = false;
            this.dgv_Properties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Properties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Properties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyID,
            this.PropertyImage,
            this.PropertyStreetAddress,
            this.PropertyFeatures,
            this.PropertyRent,
            this.PropertyStatus});
            this.dgv_Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Properties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Properties.Location = new System.Drawing.Point(3, 3);
            this.dgv_Properties.MultiSelect = false;
            this.dgv_Properties.Name = "dgv_Properties";
            this.dgv_Properties.RowHeadersVisible = false;
            this.dgv_Properties.RowHeadersWidth = 30;
            this.dgv_Properties.RowTemplate.Height = 200;
            this.dgv_Properties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Properties.Size = new System.Drawing.Size(525, 222);
            this.dgv_Properties.TabIndex = 0;
            this.dgv_Properties.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // PropertyID
            // 
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.Visible = false;
            // 
            // PropertyImage
            // 
            this.PropertyImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PropertyImage.HeaderText = "Image";
            this.PropertyImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.PropertyImage.Name = "PropertyImage";
            this.PropertyImage.Width = 70;
            // 
            // PropertyStreetAddress
            // 
            this.PropertyStreetAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyStreetAddress.FillWeight = 60F;
            this.PropertyStreetAddress.HeaderText = "Street Address";
            this.PropertyStreetAddress.Name = "PropertyStreetAddress";
            this.PropertyStreetAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyStreetAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PropertyFeatures
            // 
            this.PropertyFeatures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyFeatures.FillWeight = 40F;
            this.PropertyFeatures.HeaderText = "Features";
            this.PropertyFeatures.Name = "PropertyFeatures";
            // 
            // PropertyRent
            // 
            this.PropertyRent.FillWeight = 20F;
            this.PropertyRent.HeaderText = "Rent";
            this.PropertyRent.Name = "PropertyRent";
            // 
            // PropertyStatus
            // 
            this.PropertyStatus.FillWeight = 20F;
            this.PropertyStatus.HeaderText = "Status";
            this.PropertyStatus.Name = "PropertyStatus";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.btn_DeleteProperty, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_EditProperty, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_AddProperty, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(525, 44);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_DeleteProperty
            // 
            this.btn_DeleteProperty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteProperty.Location = new System.Drawing.Point(400, 3);
            this.btn_DeleteProperty.Name = "btn_DeleteProperty";
            this.btn_DeleteProperty.Size = new System.Drawing.Size(75, 38);
            this.btn_DeleteProperty.TabIndex = 2;
            this.btn_DeleteProperty.Text = "Delete";
            this.btn_DeleteProperty.UseVisualStyleBackColor = true;
            this.btn_DeleteProperty.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_EditProperty
            // 
            this.btn_EditProperty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditProperty.Location = new System.Drawing.Point(225, 3);
            this.btn_EditProperty.Name = "btn_EditProperty";
            this.btn_EditProperty.Size = new System.Drawing.Size(75, 38);
            this.btn_EditProperty.TabIndex = 1;
            this.btn_EditProperty.Text = "Edit";
            this.btn_EditProperty.UseVisualStyleBackColor = true;
            this.btn_EditProperty.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddProperty
            // 
            this.btn_AddProperty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddProperty.Location = new System.Drawing.Point(50, 3);
            this.btn_AddProperty.Name = "btn_AddProperty";
            this.btn_AddProperty.Size = new System.Drawing.Size(75, 38);
            this.btn_AddProperty.TabIndex = 0;
            this.btn_AddProperty.Text = "Add";
            this.btn_AddProperty.UseVisualStyleBackColor = true;
            this.btn_AddProperty.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tab_Maintenance
            // 
            this.tab_Maintenance.BackColor = System.Drawing.Color.Transparent;
            this.tab_Maintenance.Controls.Add(this.dgv_Maintenance);
            this.tab_Maintenance.Controls.Add(this.tableLayoutPanel5);
            this.tab_Maintenance.Location = new System.Drawing.Point(4, 5);
            this.tab_Maintenance.Name = "tab_Maintenance";
            this.tab_Maintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Maintenance.Size = new System.Drawing.Size(531, 272);
            this.tab_Maintenance.TabIndex = 2;
            // 
            // dgv_Maintenance
            // 
            this.dgv_Maintenance.AllowUserToAddRows = false;
            this.dgv_Maintenance.AllowUserToDeleteRows = false;
            this.dgv_Maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Maintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Maintenance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Maintenance.Location = new System.Drawing.Point(3, 3);
            this.dgv_Maintenance.MultiSelect = false;
            this.dgv_Maintenance.Name = "dgv_Maintenance";
            this.dgv_Maintenance.RowHeadersVisible = false;
            this.dgv_Maintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Maintenance.Size = new System.Drawing.Size(525, 222);
            this.dgv_Maintenance.TabIndex = 1;
            this.dgv_Maintenance.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btn_AddMaintenance, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_EditMaintenance, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_DeleteMaintenance, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(525, 44);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btn_AddMaintenance
            // 
            this.btn_AddMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddMaintenance.Location = new System.Drawing.Point(50, 3);
            this.btn_AddMaintenance.Name = "btn_AddMaintenance";
            this.btn_AddMaintenance.Size = new System.Drawing.Size(75, 38);
            this.btn_AddMaintenance.TabIndex = 0;
            this.btn_AddMaintenance.Text = "Add";
            this.btn_AddMaintenance.UseVisualStyleBackColor = true;
            this.btn_AddMaintenance.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_EditMaintenance
            // 
            this.btn_EditMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditMaintenance.Location = new System.Drawing.Point(225, 3);
            this.btn_EditMaintenance.Name = "btn_EditMaintenance";
            this.btn_EditMaintenance.Size = new System.Drawing.Size(75, 38);
            this.btn_EditMaintenance.TabIndex = 1;
            this.btn_EditMaintenance.Text = "Edit";
            this.btn_EditMaintenance.UseVisualStyleBackColor = true;
            this.btn_EditMaintenance.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_DeleteMaintenance
            // 
            this.btn_DeleteMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteMaintenance.Location = new System.Drawing.Point(400, 3);
            this.btn_DeleteMaintenance.Name = "btn_DeleteMaintenance";
            this.btn_DeleteMaintenance.Size = new System.Drawing.Size(75, 38);
            this.btn_DeleteMaintenance.TabIndex = 2;
            this.btn_DeleteMaintenance.Text = "Delete";
            this.btn_DeleteMaintenance.UseVisualStyleBackColor = true;
            this.btn_DeleteMaintenance.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tab_Finance
            // 
            this.tab_Finance.BackColor = System.Drawing.Color.Transparent;
            this.tab_Finance.Controls.Add(this.dgv_Finance);
            this.tab_Finance.Controls.Add(this.tableLayoutPanel6);
            this.tab_Finance.Location = new System.Drawing.Point(4, 5);
            this.tab_Finance.Name = "tab_Finance";
            this.tab_Finance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Finance.Size = new System.Drawing.Size(531, 272);
            this.tab_Finance.TabIndex = 3;
            // 
            // dgv_Finance
            // 
            this.dgv_Finance.AllowUserToAddRows = false;
            this.dgv_Finance.AllowUserToDeleteRows = false;
            this.dgv_Finance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Finance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Finance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Finance.Location = new System.Drawing.Point(3, 3);
            this.dgv_Finance.MultiSelect = false;
            this.dgv_Finance.Name = "dgv_Finance";
            this.dgv_Finance.ReadOnly = true;
            this.dgv_Finance.RowHeadersVisible = false;
            this.dgv_Finance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Finance.Size = new System.Drawing.Size(525, 222);
            this.dgv_Finance.TabIndex = 1;
            this.dgv_Finance.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btn_AddFinance, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_EditFinance, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_DeleteFinance, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(525, 44);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btn_AddFinance
            // 
            this.btn_AddFinance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddFinance.Location = new System.Drawing.Point(50, 3);
            this.btn_AddFinance.Name = "btn_AddFinance";
            this.btn_AddFinance.Size = new System.Drawing.Size(75, 38);
            this.btn_AddFinance.TabIndex = 0;
            this.btn_AddFinance.Text = "Add";
            this.btn_AddFinance.UseVisualStyleBackColor = true;
            this.btn_AddFinance.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_EditFinance
            // 
            this.btn_EditFinance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditFinance.Location = new System.Drawing.Point(225, 3);
            this.btn_EditFinance.Name = "btn_EditFinance";
            this.btn_EditFinance.Size = new System.Drawing.Size(75, 38);
            this.btn_EditFinance.TabIndex = 1;
            this.btn_EditFinance.Text = "Edit";
            this.btn_EditFinance.UseVisualStyleBackColor = true;
            this.btn_EditFinance.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_DeleteFinance
            // 
            this.btn_DeleteFinance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteFinance.Location = new System.Drawing.Point(400, 3);
            this.btn_DeleteFinance.Name = "btn_DeleteFinance";
            this.btn_DeleteFinance.Size = new System.Drawing.Size(75, 38);
            this.btn_DeleteFinance.TabIndex = 2;
            this.btn_DeleteFinance.Text = "Delete";
            this.btn_DeleteFinance.UseVisualStyleBackColor = true;
            this.btn_DeleteFinance.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tab_Tenant
            // 
            this.tab_Tenant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_Tenant.Controls.Add(this.dgv_Tenant);
            this.tab_Tenant.Controls.Add(this.tableLayoutPanel3);
            this.tab_Tenant.Location = new System.Drawing.Point(4, 5);
            this.tab_Tenant.Name = "tab_Tenant";
            this.tab_Tenant.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tenant.Size = new System.Drawing.Size(531, 272);
            this.tab_Tenant.TabIndex = 1;
            // 
            // dgv_Tenant
            // 
            this.dgv_Tenant.AllowUserToAddRows = false;
            this.dgv_Tenant.AllowUserToDeleteRows = false;
            this.dgv_Tenant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenantID,
            this.TenantImage,
            this.FirstName,
            this.LastName,
            this.TenantPhone,
            this.TenantEmail});
            this.dgv_Tenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Tenant.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Tenant.Location = new System.Drawing.Point(3, 3);
            this.dgv_Tenant.MultiSelect = false;
            this.dgv_Tenant.Name = "dgv_Tenant";
            this.dgv_Tenant.RowHeadersVisible = false;
            this.dgv_Tenant.RowHeadersWidth = 80;
            this.dgv_Tenant.RowTemplate.Height = 80;
            this.dgv_Tenant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tenant.Size = new System.Drawing.Size(525, 222);
            this.dgv_Tenant.TabIndex = 1;
            this.dgv_Tenant.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // TenantID
            // 
            this.TenantID.HeaderText = "TenantID";
            this.TenantID.Name = "TenantID";
            this.TenantID.Visible = false;
            // 
            // TenantImage
            // 
            this.TenantImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenantImage.HeaderText = "Image";
            this.TenantImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.TenantImage.Name = "TenantImage";
            this.TenantImage.Width = 80;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.FillWeight = 40F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastName
            // 
            this.LastName.FillWeight = 40F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // TenantPhone
            // 
            this.TenantPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenantPhone.FillWeight = 30F;
            this.TenantPhone.HeaderText = "Phone";
            this.TenantPhone.Name = "TenantPhone";
            // 
            // TenantEmail
            // 
            this.TenantEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenantEmail.FillWeight = 30F;
            this.TenantEmail.HeaderText = "Email";
            this.TenantEmail.Name = "TenantEmail";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.btn_DeleteTenant, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_EditTenant, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_AddTenant, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(525, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_DeleteTenant
            // 
            this.btn_DeleteTenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteTenant.Location = new System.Drawing.Point(400, 3);
            this.btn_DeleteTenant.Name = "btn_DeleteTenant";
            this.btn_DeleteTenant.Size = new System.Drawing.Size(75, 38);
            this.btn_DeleteTenant.TabIndex = 2;
            this.btn_DeleteTenant.Text = "Delete";
            this.btn_DeleteTenant.UseVisualStyleBackColor = true;
            this.btn_DeleteTenant.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_EditTenant
            // 
            this.btn_EditTenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditTenant.Location = new System.Drawing.Point(225, 3);
            this.btn_EditTenant.Name = "btn_EditTenant";
            this.btn_EditTenant.Size = new System.Drawing.Size(75, 38);
            this.btn_EditTenant.TabIndex = 1;
            this.btn_EditTenant.Text = "Edit";
            this.btn_EditTenant.UseVisualStyleBackColor = true;
            this.btn_EditTenant.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddTenant
            // 
            this.btn_AddTenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddTenant.Location = new System.Drawing.Point(50, 3);
            this.btn_AddTenant.Name = "btn_AddTenant";
            this.btn_AddTenant.Size = new System.Drawing.Size(75, 38);
            this.btn_AddTenant.TabIndex = 0;
            this.btn_AddTenant.Text = "Add";
            this.btn_AddTenant.UseVisualStyleBackColor = true;
            this.btn_AddTenant.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 551);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "NewMainForm";
            this.Text = "NewMainForm";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMainForm_FormClosing);
            this.pnl_MainToolbar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_Property.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tab_Maintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maintenance)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tab_Finance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Finance)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tab_Tenant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tenant)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Property;
        private System.Windows.Forms.Button btn_Tenant;
        private System.Windows.Forms.Button btn_Maintenance;
        private System.Windows.Forms.Button btn_Finance;
        private System.Windows.Forms.Panel pnl_MainToolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Property;
        private System.Windows.Forms.DataGridView dgv_Properties;
        private System.Windows.Forms.TabPage tab_Maintenance;
        private System.Windows.Forms.TabPage tab_Finance;
        private System.Windows.Forms.TabPage tab_Tenant;
        private System.Windows.Forms.DataGridView dgv_Tenant;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_DeleteProperty;
        private System.Windows.Forms.Button btn_EditProperty;
        private System.Windows.Forms.Button btn_AddProperty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_DeleteTenant;
        private System.Windows.Forms.Button btn_EditTenant;
        private System.Windows.Forms.Button btn_AddTenant;
        private System.Windows.Forms.DataGridView dgv_Maintenance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_AddMaintenance;
        private System.Windows.Forms.Button btn_EditMaintenance;
        private System.Windows.Forms.Button btn_DeleteMaintenance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_AddFinance;
        private System.Windows.Forms.Button btn_EditFinance;
        private System.Windows.Forms.Button btn_DeleteFinance;
        private System.Windows.Forms.DataGridView dgv_Finance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewImageColumn PropertyImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyStreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyFeatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyRent;
        private System.Windows.Forms.DataGridViewImageColumn PropertyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private System.Windows.Forms.DataGridViewImageColumn TenantImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantEmail;
    }
}