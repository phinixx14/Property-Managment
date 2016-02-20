namespace PropertyManagment
{
    partial class MoveOutForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_EndOfLeaseDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MoveOutDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_SameAsEndOfLease = new System.Windows.Forms.CheckBox();
            this.chk_ProrateFinalMonth = new System.Windows.Forms.CheckBox();
            this.txt_MoveOutReason = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_ProrateAmount = new System.Windows.Forms.Label();
            this.rad_Evicted = new System.Windows.Forms.RadioButton();
            this.rad_EndOfLease = new System.Windows.Forms.RadioButton();
            this.rad_Other = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_EndOfLeaseDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MoveOutDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chk_SameAsEndOfLease);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move Out Date";
            // 
            // lbl_EndOfLeaseDate
            // 
            this.lbl_EndOfLeaseDate.AutoSize = true;
            this.lbl_EndOfLeaseDate.Location = new System.Drawing.Point(90, 44);
            this.lbl_EndOfLeaseDate.Name = "lbl_EndOfLeaseDate";
            this.lbl_EndOfLeaseDate.Size = new System.Drawing.Size(69, 13);
            this.lbl_EndOfLeaseDate.TabIndex = 6;
            this.lbl_EndOfLeaseDate.Text = "endofleaselbl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Of Lease";
            // 
            // txt_MoveOutDate
            // 
            this.txt_MoveOutDate.CustomFormat = "ddMMMyyyy";
            this.txt_MoveOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_MoveOutDate.Location = new System.Drawing.Point(93, 64);
            this.txt_MoveOutDate.Name = "txt_MoveOutDate";
            this.txt_MoveOutDate.Size = new System.Drawing.Size(99, 20);
            this.txt_MoveOutDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move Out Date";
            // 
            // chk_SameAsEndOfLease
            // 
            this.chk_SameAsEndOfLease.AutoSize = true;
            this.chk_SameAsEndOfLease.Location = new System.Drawing.Point(10, 19);
            this.chk_SameAsEndOfLease.Name = "chk_SameAsEndOfLease";
            this.chk_SameAsEndOfLease.Size = new System.Drawing.Size(135, 17);
            this.chk_SameAsEndOfLease.TabIndex = 0;
            this.chk_SameAsEndOfLease.Text = "Same as End Of Lease";
            this.chk_SameAsEndOfLease.UseVisualStyleBackColor = true;
            this.chk_SameAsEndOfLease.CheckedChanged += new System.EventHandler(this.chk_SameAsEndOfLease_CheckedChanged);
            // 
            // chk_ProrateFinalMonth
            // 
            this.chk_ProrateFinalMonth.AutoSize = true;
            this.chk_ProrateFinalMonth.Location = new System.Drawing.Point(23, 217);
            this.chk_ProrateFinalMonth.Name = "chk_ProrateFinalMonth";
            this.chk_ProrateFinalMonth.Size = new System.Drawing.Size(118, 17);
            this.chk_ProrateFinalMonth.TabIndex = 3;
            this.chk_ProrateFinalMonth.Text = "Prorate Final Month";
            this.chk_ProrateFinalMonth.UseVisualStyleBackColor = true;
            this.chk_ProrateFinalMonth.CheckedChanged += new System.EventHandler(this.chk_ProrateFinalMonth_CheckedChanged);
            // 
            // txt_MoveOutReason
            // 
            this.txt_MoveOutReason.Enabled = false;
            this.txt_MoveOutReason.Location = new System.Drawing.Point(102, 19);
            this.txt_MoveOutReason.Multiline = true;
            this.txt_MoveOutReason.Name = "txt_MoveOutReason";
            this.txt_MoveOutReason.Size = new System.Drawing.Size(139, 71);
            this.txt_MoveOutReason.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(97, 251);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_ProrateAmount
            // 
            this.lbl_ProrateAmount.AutoSize = true;
            this.lbl_ProrateAmount.Location = new System.Drawing.Point(162, 218);
            this.lbl_ProrateAmount.Name = "lbl_ProrateAmount";
            this.lbl_ProrateAmount.Size = new System.Drawing.Size(13, 13);
            this.lbl_ProrateAmount.TabIndex = 7;
            this.lbl_ProrateAmount.Text = "0";
            // 
            // rad_Evicted
            // 
            this.rad_Evicted.AutoSize = true;
            this.rad_Evicted.Location = new System.Drawing.Point(6, 20);
            this.rad_Evicted.Name = "rad_Evicted";
            this.rad_Evicted.Size = new System.Drawing.Size(61, 17);
            this.rad_Evicted.TabIndex = 8;
            this.rad_Evicted.TabStop = true;
            this.rad_Evicted.Text = "Evicted";
            this.rad_Evicted.UseVisualStyleBackColor = true;
            this.rad_Evicted.CheckedChanged += new System.EventHandler(this.rad_Evicted_CheckedChanged);
            // 
            // rad_EndOfLease
            // 
            this.rad_EndOfLease.AutoSize = true;
            this.rad_EndOfLease.Location = new System.Drawing.Point(6, 43);
            this.rad_EndOfLease.Name = "rad_EndOfLease";
            this.rad_EndOfLease.Size = new System.Drawing.Size(90, 17);
            this.rad_EndOfLease.TabIndex = 9;
            this.rad_EndOfLease.TabStop = true;
            this.rad_EndOfLease.Text = "End Of Lease";
            this.rad_EndOfLease.UseVisualStyleBackColor = true;
            this.rad_EndOfLease.CheckedChanged += new System.EventHandler(this.rad_EndOfLease_CheckedChanged);
            // 
            // rad_Other
            // 
            this.rad_Other.AutoSize = true;
            this.rad_Other.Location = new System.Drawing.Point(6, 66);
            this.rad_Other.Name = "rad_Other";
            this.rad_Other.Size = new System.Drawing.Size(51, 17);
            this.rad_Other.TabIndex = 10;
            this.rad_Other.TabStop = true;
            this.rad_Other.Text = "Other";
            this.rad_Other.UseVisualStyleBackColor = true;
            this.rad_Other.CheckedChanged += new System.EventHandler(this.red_Other_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.rad_Evicted);
            this.groupBox2.Controls.Add(this.rad_Other);
            this.groupBox2.Controls.Add(this.txt_MoveOutReason);
            this.groupBox2.Controls.Add(this.rad_EndOfLease);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reason";
            // 
            // MoveOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_ProrateAmount);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.chk_ProrateFinalMonth);
            this.Controls.Add(this.groupBox1);
            this.Name = "MoveOutForm";
            this.Text = "MoveOutForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txt_MoveOutDate;
        private System.Windows.Forms.CheckBox chk_ProrateFinalMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_SameAsEndOfLease;
        private System.Windows.Forms.Label lbl_EndOfLeaseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MoveOutReason;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_ProrateAmount;
        private System.Windows.Forms.RadioButton rad_Evicted;
        private System.Windows.Forms.RadioButton rad_EndOfLease;
        private System.Windows.Forms.RadioButton rad_Other;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}