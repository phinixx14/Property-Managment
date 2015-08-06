namespace WindowsFormsApplication1
{
    partial class NewPaymentForm
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
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_AmountReceived = new System.Windows.Forms.TextBox();
            this.txt_AmountExpected = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.chk_IsRent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.group_PaymentInfo = new System.Windows.Forms.GroupBox();
            this.group_PaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(59, 108);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(80, 19);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(100, 20);
            this.txt_Reason.TabIndex = 1;
            this.txt_Reason.Text = "Rent Payment";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(80, 45);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(100, 20);
            this.txt_Description.TabIndex = 2;
            this.txt_Description.Text = "X Month(s) Paid";
            // 
            // txt_AmountReceived
            // 
            this.txt_AmountReceived.Location = new System.Drawing.Point(105, 38);
            this.txt_AmountReceived.Name = "txt_AmountReceived";
            this.txt_AmountReceived.Size = new System.Drawing.Size(100, 20);
            this.txt_AmountReceived.TabIndex = 4;
            // 
            // txt_AmountExpected
            // 
            this.txt_AmountExpected.Enabled = false;
            this.txt_AmountExpected.Location = new System.Drawing.Point(105, 12);
            this.txt_AmountExpected.Name = "txt_AmountExpected";
            this.txt_AmountExpected.Size = new System.Drawing.Size(100, 20);
            this.txt_AmountExpected.TabIndex = 5;
            // 
            // txt_Date
            // 
            this.txt_Date.CustomFormat = "ddMMMyyyy";
            this.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_Date.Location = new System.Drawing.Point(105, 64);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(100, 20);
            this.txt_Date.TabIndex = 6;
            this.txt_Date.ValueChanged += new System.EventHandler(this.txt_Date_ValueChanged);
            // 
            // chk_IsRent
            // 
            this.chk_IsRent.AutoSize = true;
            this.chk_IsRent.Checked = true;
            this.chk_IsRent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IsRent.Location = new System.Drawing.Point(228, 13);
            this.chk_IsRent.Name = "chk_IsRent";
            this.chk_IsRent.Size = new System.Drawing.Size(93, 17);
            this.chk_IsRent.TabIndex = 7;
            this.chk_IsRent.Text = "Rent Payment";
            this.chk_IsRent.UseVisualStyleBackColor = true;
            this.chk_IsRent.CheckedChanged += new System.EventHandler(this.chk_IsRent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount Expected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount Received";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date Received";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reason";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // group_PaymentInfo
            // 
            this.group_PaymentInfo.Controls.Add(this.txt_Reason);
            this.group_PaymentInfo.Controls.Add(this.label5);
            this.group_PaymentInfo.Controls.Add(this.txt_Description);
            this.group_PaymentInfo.Controls.Add(this.label4);
            this.group_PaymentInfo.Enabled = false;
            this.group_PaymentInfo.Location = new System.Drawing.Point(211, 62);
            this.group_PaymentInfo.Name = "group_PaymentInfo";
            this.group_PaymentInfo.Size = new System.Drawing.Size(186, 75);
            this.group_PaymentInfo.TabIndex = 14;
            this.group_PaymentInfo.TabStop = false;
            this.group_PaymentInfo.Text = "Payment Info";
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 149);
            this.Controls.Add(this.chk_IsRent);
            this.Controls.Add(this.group_PaymentInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_AmountExpected);
            this.Controls.Add(this.txt_AmountReceived);
            this.Controls.Add(this.btn_Submit);
            this.Name = "NewPaymentForm";
            this.Text = "NewPaymentForm";
            this.group_PaymentInfo.ResumeLayout(false);
            this.group_PaymentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_AmountReceived;
        private System.Windows.Forms.TextBox txt_AmountExpected;
        private System.Windows.Forms.DateTimePicker txt_Date;
        private System.Windows.Forms.CheckBox chk_IsRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox group_PaymentInfo;
    }
}