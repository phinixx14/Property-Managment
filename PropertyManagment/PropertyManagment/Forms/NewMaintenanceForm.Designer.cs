namespace PropertyManagment
{
    partial class NewMaintenanceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EstCost = new System.Windows.Forms.TextBox();
            this.txt_EarliestDueDate = new System.Windows.Forms.DateTimePicker();
            this.txt_LatestDueDate = new System.Windows.Forms.DateTimePicker();
            this.cbx_Priority = new System.Windows.Forms.ComboBox();
            this.cbx_Requestor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Days = new System.Windows.Forms.NumericUpDown();
            this.txt_Hours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_ServiceCall = new System.Windows.Forms.CheckBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estimated Cost";
            // 
            // txt_EstCost
            // 
            this.txt_EstCost.Location = new System.Drawing.Point(132, 119);
            this.txt_EstCost.Name = "txt_EstCost";
            this.txt_EstCost.Size = new System.Drawing.Size(100, 20);
            this.txt_EstCost.TabIndex = 1;
            // 
            // txt_EarliestDueDate
            // 
            this.txt_EarliestDueDate.CustomFormat = "ddMMMyyyy";
            this.txt_EarliestDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_EarliestDueDate.Location = new System.Drawing.Point(333, 72);
            this.txt_EarliestDueDate.Name = "txt_EarliestDueDate";
            this.txt_EarliestDueDate.Size = new System.Drawing.Size(100, 20);
            this.txt_EarliestDueDate.TabIndex = 3;
            // 
            // txt_LatestDueDate
            // 
            this.txt_LatestDueDate.CustomFormat = "ddMMMyyyy";
            this.txt_LatestDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_LatestDueDate.Location = new System.Drawing.Point(333, 98);
            this.txt_LatestDueDate.Name = "txt_LatestDueDate";
            this.txt_LatestDueDate.Size = new System.Drawing.Size(100, 20);
            this.txt_LatestDueDate.TabIndex = 4;
            // 
            // cbx_Priority
            // 
            this.cbx_Priority.FormattingEnabled = true;
            this.cbx_Priority.Location = new System.Drawing.Point(57, 171);
            this.cbx_Priority.Name = "cbx_Priority";
            this.cbx_Priority.Size = new System.Drawing.Size(100, 21);
            this.cbx_Priority.TabIndex = 5;
            // 
            // cbx_Requestor
            // 
            this.cbx_Requestor.FormattingEnabled = true;
            this.cbx_Requestor.Location = new System.Drawing.Point(333, 126);
            this.cbx_Requestor.Name = "cbx_Requestor";
            this.cbx_Requestor.Size = new System.Drawing.Size(100, 21);
            this.cbx_Requestor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Earliest Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Latest Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Requested By";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(238, 171);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Hours);
            this.groupBox1.Controls.Add(this.txt_Days);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 54);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estimated Time Taken";
            // 
            // txt_Days
            // 
            this.txt_Days.Location = new System.Drawing.Point(43, 21);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(47, 20);
            this.txt_Days.TabIndex = 0;
            // 
            // txt_Hours
            // 
            this.txt_Hours.Location = new System.Drawing.Point(137, 21);
            this.txt_Hours.Name = "txt_Hours";
            this.txt_Hours.Size = new System.Drawing.Size(47, 20);
            this.txt_Hours.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Days";
            // 
            // chk_ServiceCall
            // 
            this.chk_ServiceCall.AutoSize = true;
            this.chk_ServiceCall.Location = new System.Drawing.Point(16, 148);
            this.chk_ServiceCall.Name = "chk_ServiceCall";
            this.chk_ServiceCall.Size = new System.Drawing.Size(82, 17);
            this.chk_ServiceCall.TabIndex = 14;
            this.chk_ServiceCall.Text = "Service Call";
            this.chk_ServiceCall.UseVisualStyleBackColor = true;
            this.chk_ServiceCall.CheckedChanged += new System.EventHandler(this.chk_ServiceCall_CheckedChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(77, 38);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(155, 75);
            this.txt_Description.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Description";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(77, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(155, 20);
            this.txt_Name.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Item Name";
            // 
            // NewSeviceCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 206);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk_ServiceCall);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Requestor);
            this.Controls.Add(this.cbx_Priority);
            this.Controls.Add(this.txt_LatestDueDate);
            this.Controls.Add(this.txt_EarliestDueDate);
            this.Controls.Add(this.txt_EstCost);
            this.Controls.Add(this.label1);
            this.Name = "NewSeviceCallForm";
            this.Text = "NewSeviceCallForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EstCost;
        private System.Windows.Forms.DateTimePicker txt_EarliestDueDate;
        private System.Windows.Forms.DateTimePicker txt_LatestDueDate;
        private System.Windows.Forms.ComboBox cbx_Priority;
        private System.Windows.Forms.ComboBox cbx_Requestor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_Hours;
        private System.Windows.Forms.NumericUpDown txt_Days;
        private System.Windows.Forms.CheckBox chk_ServiceCall;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label9;
    }
}