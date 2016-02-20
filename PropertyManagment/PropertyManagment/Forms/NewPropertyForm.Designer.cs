namespace PropertyManagment
{
    partial class NewPropertyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPF_StreetAddress = new System.Windows.Forms.TextBox();
            this.txtNPF_City = new System.Windows.Forms.TextBox();
            this.txtNPF_Rent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNPF_State = new System.Windows.Forms.ComboBox();
            this.txtNPF_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNPF_MoveInReady = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNPF_UploadImage = new System.Windows.Forms.Button();
            this.btnNPF_Finish = new System.Windows.Forms.Button();
            this.btnNPF_Cancel = new System.Windows.Forms.Button();
            this.btnNPF_AddAnother = new System.Windows.Forms.Button();
            this.btnNPF_RemoveImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imgNPF_Image = new System.Windows.Forms.PictureBox();
            this.txtNPF_AquisitionDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Bedrooms = new System.Windows.Forms.NumericUpDown();
            this.txt_Bathrooms = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Floors = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_Basement = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPF_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Floors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "State";
            // 
            // txtNPF_StreetAddress
            // 
            this.txtNPF_StreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPF_StreetAddress.Location = new System.Drawing.Point(79, 12);
            this.txtNPF_StreetAddress.Name = "txtNPF_StreetAddress";
            this.txtNPF_StreetAddress.Size = new System.Drawing.Size(276, 22);
            this.txtNPF_StreetAddress.TabIndex = 3;
            // 
            // txtNPF_City
            // 
            this.txtNPF_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPF_City.Location = new System.Drawing.Point(79, 40);
            this.txtNPF_City.Name = "txtNPF_City";
            this.txtNPF_City.Size = new System.Drawing.Size(176, 22);
            this.txtNPF_City.TabIndex = 4;
            // 
            // txtNPF_Rent
            // 
            this.txtNPF_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPF_Rent.Location = new System.Drawing.Point(79, 68);
            this.txtNPF_Rent.Name = "txtNPF_Rent";
            this.txtNPF_Rent.Size = new System.Drawing.Size(71, 22);
            this.txtNPF_Rent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rent";
            // 
            // txtNPF_State
            // 
            this.txtNPF_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPF_State.FormattingEnabled = true;
            this.txtNPF_State.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.txtNPF_State.Location = new System.Drawing.Point(309, 40);
            this.txtNPF_State.Name = "txtNPF_State";
            this.txtNPF_State.Size = new System.Drawing.Size(45, 24);
            this.txtNPF_State.TabIndex = 8;
            this.txtNPF_State.Text = "IL";
            // 
            // txtNPF_PurchasePrice
            // 
            this.txtNPF_PurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPF_PurchasePrice.Location = new System.Drawing.Point(261, 68);
            this.txtNPF_PurchasePrice.Name = "txtNPF_PurchasePrice";
            this.txtNPF_PurchasePrice.Size = new System.Drawing.Size(94, 22);
            this.txtNPF_PurchasePrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Purchase Price";
            // 
            // chkNPF_MoveInReady
            // 
            this.chkNPF_MoveInReady.AutoSize = true;
            this.chkNPF_MoveInReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNPF_MoveInReady.Location = new System.Drawing.Point(17, 98);
            this.chkNPF_MoveInReady.Name = "chkNPF_MoveInReady";
            this.chkNPF_MoveInReady.Size = new System.Drawing.Size(118, 20);
            this.chkNPF_MoveInReady.TabIndex = 11;
            this.chkNPF_MoveInReady.Text = "Move In Ready";
            this.chkNPF_MoveInReady.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aquisition Date";
            // 
            // btnNPF_UploadImage
            // 
            this.btnNPF_UploadImage.Location = new System.Drawing.Point(30, 186);
            this.btnNPF_UploadImage.Name = "btnNPF_UploadImage";
            this.btnNPF_UploadImage.Size = new System.Drawing.Size(94, 23);
            this.btnNPF_UploadImage.TabIndex = 14;
            this.btnNPF_UploadImage.Text = "Upload Image";
            this.btnNPF_UploadImage.UseVisualStyleBackColor = true;
            this.btnNPF_UploadImage.Click += new System.EventHandler(this.btnNPF_UploadImage_Click);
            // 
            // btnNPF_Finish
            // 
            this.btnNPF_Finish.Location = new System.Drawing.Point(12, 268);
            this.btnNPF_Finish.Name = "btnNPF_Finish";
            this.btnNPF_Finish.Size = new System.Drawing.Size(75, 23);
            this.btnNPF_Finish.TabIndex = 15;
            this.btnNPF_Finish.Text = "Finish";
            this.btnNPF_Finish.UseVisualStyleBackColor = true;
            this.btnNPF_Finish.Click += new System.EventHandler(this.btnNPF_Finish_Click);
            // 
            // btnNPF_Cancel
            // 
            this.btnNPF_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNPF_Cancel.Location = new System.Drawing.Point(275, 268);
            this.btnNPF_Cancel.Name = "btnNPF_Cancel";
            this.btnNPF_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btnNPF_Cancel.TabIndex = 16;
            this.btnNPF_Cancel.Text = "Cancel";
            this.btnNPF_Cancel.UseVisualStyleBackColor = true;
            this.btnNPF_Cancel.Click += new System.EventHandler(this.btnNPF_Cancel_Click);
            // 
            // btnNPF_AddAnother
            // 
            this.btnNPF_AddAnother.Location = new System.Drawing.Point(93, 268);
            this.btnNPF_AddAnother.Name = "btnNPF_AddAnother";
            this.btnNPF_AddAnother.Size = new System.Drawing.Size(75, 23);
            this.btnNPF_AddAnother.TabIndex = 17;
            this.btnNPF_AddAnother.Text = "Add Another";
            this.btnNPF_AddAnother.UseVisualStyleBackColor = true;
            this.btnNPF_AddAnother.Click += new System.EventHandler(this.btnNPF_AddAnother_Click);
            // 
            // btnNPF_RemoveImage
            // 
            this.btnNPF_RemoveImage.Location = new System.Drawing.Point(277, 186);
            this.btnNPF_RemoveImage.Name = "btnNPF_RemoveImage";
            this.btnNPF_RemoveImage.Size = new System.Drawing.Size(57, 35);
            this.btnNPF_RemoveImage.TabIndex = 19;
            this.btnNPF_RemoveImage.Text = "Remove Image";
            this.btnNPF_RemoveImage.UseVisualStyleBackColor = true;
            this.btnNPF_RemoveImage.Click += new System.EventHandler(this.btnNPF_RemoveImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "image files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.jpe;*.tif";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imgNPF_Image
            // 
            this.imgNPF_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgNPF_Image.Image = global::PropertyManagment.Properties.Resources.unavailable;
            this.imgNPF_Image.Location = new System.Drawing.Point(159, 186);
            this.imgNPF_Image.Name = "imgNPF_Image";
            this.imgNPF_Image.Size = new System.Drawing.Size(86, 76);
            this.imgNPF_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPF_Image.TabIndex = 18;
            this.imgNPF_Image.TabStop = false;
            // 
            // txtNPF_AquisitionDate
            // 
            this.txtNPF_AquisitionDate.CustomFormat = "ddMMMyyyy";
            this.txtNPF_AquisitionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNPF_AquisitionDate.Location = new System.Drawing.Point(261, 98);
            this.txtNPF_AquisitionDate.Name = "txtNPF_AquisitionDate";
            this.txtNPF_AquisitionDate.Size = new System.Drawing.Size(94, 20);
            this.txtNPF_AquisitionDate.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bedrooms";
            // 
            // txt_Bedrooms
            // 
            this.txt_Bedrooms.Location = new System.Drawing.Point(93, 124);
            this.txt_Bedrooms.Name = "txt_Bedrooms";
            this.txt_Bedrooms.Size = new System.Drawing.Size(42, 20);
            this.txt_Bedrooms.TabIndex = 22;
            this.txt_Bedrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_Bathrooms
            // 
            this.txt_Bathrooms.Location = new System.Drawing.Point(234, 124);
            this.txt_Bathrooms.Name = "txt_Bathrooms";
            this.txt_Bathrooms.Size = new System.Drawing.Size(42, 20);
            this.txt_Bathrooms.TabIndex = 24;
            this.txt_Bathrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Bathrooms";
            // 
            // txt_Floors
            // 
            this.txt_Floors.Location = new System.Drawing.Point(93, 150);
            this.txt_Floors.Name = "txt_Floors";
            this.txt_Floors.Size = new System.Drawing.Size(42, 20);
            this.txt_Floors.TabIndex = 26;
            this.txt_Floors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Floors";
            // 
            // chk_Basement
            // 
            this.chk_Basement.AutoSize = true;
            this.chk_Basement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Basement.Location = new System.Drawing.Point(160, 151);
            this.chk_Basement.Name = "chk_Basement";
            this.chk_Basement.Size = new System.Drawing.Size(88, 20);
            this.chk_Basement.TabIndex = 27;
            this.chk_Basement.Text = "Basement";
            this.chk_Basement.UseVisualStyleBackColor = true;
            // 
            // NewPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNPF_Cancel;
            this.ClientSize = new System.Drawing.Size(366, 300);
            this.Controls.Add(this.chk_Basement);
            this.Controls.Add(this.txt_Floors);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Bathrooms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Bedrooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNPF_AquisitionDate);
            this.Controls.Add(this.btnNPF_RemoveImage);
            this.Controls.Add(this.imgNPF_Image);
            this.Controls.Add(this.btnNPF_AddAnother);
            this.Controls.Add(this.btnNPF_Cancel);
            this.Controls.Add(this.btnNPF_Finish);
            this.Controls.Add(this.btnNPF_UploadImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkNPF_MoveInReady);
            this.Controls.Add(this.txtNPF_PurchasePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNPF_State);
            this.Controls.Add(this.txtNPF_Rent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNPF_City);
            this.Controls.Add(this.txtNPF_StreetAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewPropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPropertyForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgNPF_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Floors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPF_StreetAddress;
        private System.Windows.Forms.TextBox txtNPF_City;
        private System.Windows.Forms.TextBox txtNPF_Rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtNPF_State;
        private System.Windows.Forms.TextBox txtNPF_PurchasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNPF_MoveInReady;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNPF_UploadImage;
        private System.Windows.Forms.Button btnNPF_Finish;
        private System.Windows.Forms.Button btnNPF_Cancel;
        private System.Windows.Forms.Button btnNPF_AddAnother;
        private System.Windows.Forms.PictureBox imgNPF_Image;
        private System.Windows.Forms.Button btnNPF_RemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker txtNPF_AquisitionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txt_Bedrooms;
        private System.Windows.Forms.NumericUpDown txt_Bathrooms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txt_Floors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_Basement;
    }
}