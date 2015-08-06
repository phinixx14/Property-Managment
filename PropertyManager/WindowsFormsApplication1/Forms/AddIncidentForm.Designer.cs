namespace WindowsFormsApplication1
{
    partial class AddIncidentForm
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
            this.txt_IncidentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_PetRelated = new System.Windows.Forms.CheckBox();
            this.chk_TenantLiable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MoneyChargedToTenant = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IncidentName
            // 
            this.txt_IncidentName.Location = new System.Drawing.Point(103, 12);
            this.txt_IncidentName.Name = "txt_IncidentName";
            this.txt_IncidentName.Size = new System.Drawing.Size(137, 20);
            this.txt_IncidentName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incident Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(103, 38);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(137, 56);
            this.txt_Description.TabIndex = 2;
            // 
            // txt_Date
            // 
            this.txt_Date.CustomFormat = "ddMMMyyyy";
            this.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_Date.Location = new System.Drawing.Point(103, 100);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(100, 20);
            this.txt_Date.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Incident Date";
            // 
            // chk_PetRelated
            // 
            this.chk_PetRelated.AutoSize = true;
            this.chk_PetRelated.Location = new System.Drawing.Point(121, 129);
            this.chk_PetRelated.Name = "chk_PetRelated";
            this.chk_PetRelated.Size = new System.Drawing.Size(82, 17);
            this.chk_PetRelated.TabIndex = 6;
            this.chk_PetRelated.Text = "Pet Related";
            this.chk_PetRelated.UseVisualStyleBackColor = true;
            // 
            // chk_TenantLiable
            // 
            this.chk_TenantLiable.AutoSize = true;
            this.chk_TenantLiable.Location = new System.Drawing.Point(15, 129);
            this.chk_TenantLiable.Name = "chk_TenantLiable";
            this.chk_TenantLiable.Size = new System.Drawing.Size(91, 17);
            this.chk_TenantLiable.TabIndex = 7;
            this.chk_TenantLiable.Text = "Tenant Liable";
            this.chk_TenantLiable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Money Charged \r\nTo Tenant";
            // 
            // txt_MoneyChargedToTenant
            // 
            this.txt_MoneyChargedToTenant.Location = new System.Drawing.Point(103, 155);
            this.txt_MoneyChargedToTenant.Name = "txt_MoneyChargedToTenant";
            this.txt_MoneyChargedToTenant.Size = new System.Drawing.Size(100, 20);
            this.txt_MoneyChargedToTenant.TabIndex = 8;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(89, 181);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 213);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MoneyChargedToTenant);
            this.Controls.Add(this.chk_TenantLiable);
            this.Controls.Add(this.chk_PetRelated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IncidentName);
            this.Name = "AddIncidentForm";
            this.Text = "AddIncidentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IncidentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.DateTimePicker txt_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_PetRelated;
        private System.Windows.Forms.CheckBox chk_TenantLiable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MoneyChargedToTenant;
        private System.Windows.Forms.Button btn_Submit;
    }
}