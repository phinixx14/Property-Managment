namespace WindowsFormsApplication1
{
    partial class CompleteMaintenanceItemForm
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_Hours = new System.Windows.Forms.NumericUpDown();
            this.txt_Days = new System.Windows.Forms.NumericUpDown();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.txt_CompletionDate = new System.Windows.Forms.DateTimePicker();
            this.txt_CompletedBy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Days)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(86, 202);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_Hours
            // 
            this.txt_Hours.Location = new System.Drawing.Point(161, 19);
            this.txt_Hours.Name = "txt_Hours";
            this.txt_Hours.Size = new System.Drawing.Size(50, 20);
            this.txt_Hours.TabIndex = 1;
            // 
            // txt_Days
            // 
            this.txt_Days.Location = new System.Drawing.Point(44, 19);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(50, 20);
            this.txt_Days.TabIndex = 2;
            // 
            // txt_Cost
            // 
            this.txt_Cost.Location = new System.Drawing.Point(110, 95);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(100, 20);
            this.txt_Cost.TabIndex = 3;
            // 
            // txt_CompletionDate
            // 
            this.txt_CompletionDate.CustomFormat = "ddMMMyyyy";
            this.txt_CompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_CompletionDate.Location = new System.Drawing.Point(110, 69);
            this.txt_CompletionDate.Name = "txt_CompletionDate";
            this.txt_CompletionDate.Size = new System.Drawing.Size(100, 20);
            this.txt_CompletionDate.TabIndex = 4;
            // 
            // txt_CompletedBy
            // 
            this.txt_CompletedBy.AcceptsReturn = true;
            this.txt_CompletedBy.Location = new System.Drawing.Point(110, 121);
            this.txt_CompletedBy.Multiline = true;
            this.txt_CompletedBy.Name = "txt_CompletedBy";
            this.txt_CompletedBy.Size = new System.Drawing.Size(125, 67);
            this.txt_CompletedBy.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Hours);
            this.groupBox1.Controls.Add(this.txt_Days);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Taken";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Completion Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Completed By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(One name per line)";
            // 
            // CompleteMaintenanceItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 235);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_CompletedBy);
            this.Controls.Add(this.txt_CompletionDate);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.btn_Submit);
            this.Name = "CompleteMaintenanceItemForm";
            this.Text = "CompleteMaintenanceItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Days)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.NumericUpDown txt_Hours;
        private System.Windows.Forms.NumericUpDown txt_Days;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.DateTimePicker txt_CompletionDate;
        private System.Windows.Forms.TextBox txt_CompletedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}