namespace PropertyManagment
{
    partial class TenantDetails
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
            this.dgv_Notes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_FinancesAdd = new System.Windows.Forms.Button();
            this.btn_FinancesEdit = new System.Windows.Forms.Button();
            this.btn_FinancesDelete = new System.Windows.Forms.Button();
            this.dgv_Finances = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_NotesAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_MaintenanceAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MaintenanceEdit = new System.Windows.Forms.Button();
            this.btn_MaintenanceDelete = new System.Windows.Forms.Button();
            this.dgv_Maintenance = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.img_Picture = new System.Windows.Forms.PictureBox();
            this.lbl_TenantName = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_InformationEdit = new System.Windows.Forms.Button();
            this.dgv_Information = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Finances)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maintenance)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Information)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Notes
            // 
            this.dgv_Notes.AllowUserToAddRows = false;
            this.dgv_Notes.AllowUserToDeleteRows = false;
            this.dgv_Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Notes, 2);
            this.dgv_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Notes.Location = new System.Drawing.Point(583, 53);
            this.dgv_Notes.MultiSelect = false;
            this.dgv_Notes.Name = "dgv_Notes";
            this.dgv_Notes.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgv_Notes, 2);
            this.dgv_Notes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Notes.Size = new System.Drawing.Size(251, 164);
            this.dgv_Notes.TabIndex = 13;
            this.dgv_Notes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Finances";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FinancesAdd
            // 
            this.btn_FinancesAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_FinancesAdd.Location = new System.Drawing.Point(70, 43);
            this.btn_FinancesAdd.Name = "btn_FinancesAdd";
            this.btn_FinancesAdd.Size = new System.Drawing.Size(59, 44);
            this.btn_FinancesAdd.TabIndex = 1;
            this.btn_FinancesAdd.Text = "Add";
            this.btn_FinancesAdd.UseVisualStyleBackColor = true;
            this.btn_FinancesAdd.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_FinancesEdit
            // 
            this.btn_FinancesEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FinancesEdit.Location = new System.Drawing.Point(190, 43);
            this.btn_FinancesEdit.Name = "btn_FinancesEdit";
            this.btn_FinancesEdit.Size = new System.Drawing.Size(59, 44);
            this.btn_FinancesEdit.TabIndex = 2;
            this.btn_FinancesEdit.Text = "Edit";
            this.btn_FinancesEdit.UseVisualStyleBackColor = true;
            this.btn_FinancesEdit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_FinancesDelete
            // 
            this.btn_FinancesDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_FinancesDelete.Location = new System.Drawing.Point(311, 43);
            this.btn_FinancesDelete.Name = "btn_FinancesDelete";
            this.btn_FinancesDelete.Size = new System.Drawing.Size(59, 44);
            this.btn_FinancesDelete.TabIndex = 3;
            this.btn_FinancesDelete.Text = "Delete";
            this.btn_FinancesDelete.UseVisualStyleBackColor = true;
            this.btn_FinancesDelete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_Finances
            // 
            this.dgv_Finances.AllowUserToAddRows = false;
            this.dgv_Finances.AllowUserToDeleteRows = false;
            this.dgv_Finances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.dgv_Finances, 3);
            this.dgv_Finances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Finances.Location = new System.Drawing.Point(3, 93);
            this.dgv_Finances.MultiSelect = false;
            this.dgv_Finances.Name = "dgv_Finances";
            this.dgv_Finances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Finances.Size = new System.Drawing.Size(436, 202);
            this.dgv_Finances.TabIndex = 4;
            this.dgv_Finances.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_FinancesAdd, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_FinancesEdit, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_FinancesDelete, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.dgv_Finances, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(442, 298);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btn_NotesAdd
            // 
            this.btn_NotesAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NotesAdd.Location = new System.Drawing.Point(759, 3);
            this.btn_NotesAdd.Name = "btn_NotesAdd";
            this.btn_NotesAdd.Size = new System.Drawing.Size(59, 44);
            this.btn_NotesAdd.TabIndex = 10;
            this.btn_NotesAdd.Text = "Add";
            this.btn_NotesAdd.UseVisualStyleBackColor = true;
            this.btn_NotesAdd.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 50);
            this.label2.TabIndex = 11;
            this.label2.Text = "Notes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(392, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 298);
            this.panel2.TabIndex = 12;
            // 
            // btn_MaintenanceAdd
            // 
            this.btn_MaintenanceAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_MaintenanceAdd.Location = new System.Drawing.Point(48, 43);
            this.btn_MaintenanceAdd.Name = "btn_MaintenanceAdd";
            this.btn_MaintenanceAdd.Size = new System.Drawing.Size(59, 44);
            this.btn_MaintenanceAdd.TabIndex = 1;
            this.btn_MaintenanceAdd.Text = "Add";
            this.btn_MaintenanceAdd.UseVisualStyleBackColor = true;
            this.btn_MaintenanceAdd.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_MaintenanceEdit
            // 
            this.btn_MaintenanceEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MaintenanceEdit.Location = new System.Drawing.Point(153, 43);
            this.btn_MaintenanceEdit.Name = "btn_MaintenanceEdit";
            this.btn_MaintenanceEdit.Size = new System.Drawing.Size(59, 44);
            this.btn_MaintenanceEdit.TabIndex = 2;
            this.btn_MaintenanceEdit.Text = "Edit";
            this.btn_MaintenanceEdit.UseVisualStyleBackColor = true;
            this.btn_MaintenanceEdit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_MaintenanceDelete
            // 
            this.btn_MaintenanceDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_MaintenanceDelete.Location = new System.Drawing.Point(259, 43);
            this.btn_MaintenanceDelete.Name = "btn_MaintenanceDelete";
            this.btn_MaintenanceDelete.Size = new System.Drawing.Size(59, 44);
            this.btn_MaintenanceDelete.TabIndex = 3;
            this.btn_MaintenanceDelete.Text = "Delete";
            this.btn_MaintenanceDelete.UseVisualStyleBackColor = true;
            this.btn_MaintenanceDelete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_Maintenance
            // 
            this.dgv_Maintenance.AllowUserToAddRows = false;
            this.dgv_Maintenance.AllowUserToDeleteRows = false;
            this.dgv_Maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel3.SetColumnSpan(this.dgv_Maintenance, 3);
            this.dgv_Maintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Maintenance.Location = new System.Drawing.Point(3, 93);
            this.dgv_Maintenance.MultiSelect = false;
            this.dgv_Maintenance.Name = "dgv_Maintenance";
            this.dgv_Maintenance.RowHeadersVisible = false;
            this.dgv_Maintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Maintenance.Size = new System.Drawing.Size(361, 202);
            this.dgv_Maintenance.TabIndex = 4;
            this.dgv_Maintenance.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_MaintenanceEdit, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_MaintenanceDelete, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.dgv_Maintenance, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_MaintenanceAdd, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(367, 298);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 298);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Controls.Add(this.img_Picture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TenantName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Address, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_NotesAdd, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Notes, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.9095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 532);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // img_Picture
            // 
            this.img_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_Picture.Location = new System.Drawing.Point(3, 3);
            this.img_Picture.Name = "img_Picture";
            this.tableLayoutPanel1.SetRowSpan(this.img_Picture, 3);
            this.img_Picture.Size = new System.Drawing.Size(176, 214);
            this.img_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Picture.TabIndex = 1;
            this.img_Picture.TabStop = false;
            this.img_Picture.Tag = "PropertyTenant";
            this.img_Picture.Click += new System.EventHandler(this.img_Picture_Click);
            // 
            // lbl_TenantName
            // 
            this.lbl_TenantName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_TenantName, 3);
            this.lbl_TenantName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenantName.Location = new System.Drawing.Point(185, 0);
            this.lbl_TenantName.Name = "lbl_TenantName";
            this.lbl_TenantName.Size = new System.Drawing.Size(392, 50);
            this.lbl_TenantName.TabIndex = 2;
            this.lbl_TenantName.Text = "label1";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_Address, 3);
            this.lbl_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(185, 50);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(392, 40);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "label2";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(185, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tenant Information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24509F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.7549F));
            this.tableLayoutPanel2.Controls.Add(this.btn_InformationEdit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgv_Information, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 105);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_InformationEdit
            // 
            this.btn_InformationEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InformationEdit.Location = new System.Drawing.Point(308, 55);
            this.btn_InformationEdit.Name = "btn_InformationEdit";
            this.btn_InformationEdit.Size = new System.Drawing.Size(59, 44);
            this.btn_InformationEdit.TabIndex = 1;
            this.btn_InformationEdit.Text = "Edit";
            this.btn_InformationEdit.UseVisualStyleBackColor = true;
            this.btn_InformationEdit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // dgv_Information
            // 
            this.dgv_Information.AllowUserToAddRows = false;
            this.dgv_Information.AllowUserToDeleteRows = false;
            this.dgv_Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Information.ColumnHeadersVisible = false;
            this.dgv_Information.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemValue});
            this.dgv_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Information.Location = new System.Drawing.Point(3, 3);
            this.dgv_Information.MultiSelect = false;
            this.dgv_Information.Name = "dgv_Information";
            this.dgv_Information.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dgv_Information, 2);
            this.dgv_Information.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Information.Size = new System.Drawing.Size(284, 99);
            this.dgv_Information.TabIndex = 2;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.FillWeight = 50F;
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // ItemValue
            // 
            this.ItemValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemValue.FillWeight = 50F;
            this.ItemValue.HeaderText = "ItemValue";
            this.ItemValue.Name = "ItemValue";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TenantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TenantDetails";
            this.Text = "TenantDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Finances)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maintenance)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Information)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Notes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox img_Picture;
        private System.Windows.Forms.Label lbl_TenantName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_InformationEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MaintenanceEdit;
        private System.Windows.Forms.Button btn_MaintenanceDelete;
        private System.Windows.Forms.DataGridView dgv_Maintenance;
        private System.Windows.Forms.Button btn_MaintenanceAdd;
        private System.Windows.Forms.Button btn_NotesAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_FinancesAdd;
        private System.Windows.Forms.Button btn_FinancesEdit;
        private System.Windows.Forms.Button btn_FinancesDelete;
        private System.Windows.Forms.DataGridView dgv_Finances;
        private System.Windows.Forms.DataGridView dgv_Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}