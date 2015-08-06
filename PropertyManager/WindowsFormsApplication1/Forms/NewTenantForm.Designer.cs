namespace WindowsFormsApplication1
{
    partial class NewTenantForm
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
            this.txtNTF_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNTF_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgNTF_Image = new System.Windows.Forms.PictureBox();
            this.btnNTF_UploadImage = new System.Windows.Forms.Button();
            this.btnNTF_RemoveImage = new System.Windows.Forms.Button();
            this.btnNTF_AddAnother = new System.Windows.Forms.Button();
            this.btnNTF_Cancel = new System.Windows.Forms.Button();
            this.btnNTF_Finish = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtNTF_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNTF_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNTF_DOB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.imgNTF_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtNTF_FirstName
            // 
            this.txtNTF_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTF_FirstName.Location = new System.Drawing.Point(218, 12);
            this.txtNTF_FirstName.Name = "txtNTF_FirstName";
            this.txtNTF_FirstName.Size = new System.Drawing.Size(109, 22);
            this.txtNTF_FirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtNTF_LastName
            // 
            this.txtNTF_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTF_LastName.Location = new System.Drawing.Point(218, 40);
            this.txtNTF_LastName.Name = "txtNTF_LastName";
            this.txtNTF_LastName.Size = new System.Drawing.Size(109, 22);
            this.txtNTF_LastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Birth";
            // 
            // imgNTF_Image
            // 
            this.imgNTF_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgNTF_Image.Image = global::WindowsFormsApplication1.Properties.Resources.unavailable;
            this.imgNTF_Image.Location = new System.Drawing.Point(13, 12);
            this.imgNTF_Image.Name = "imgNTF_Image";
            this.imgNTF_Image.Size = new System.Drawing.Size(100, 93);
            this.imgNTF_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNTF_Image.TabIndex = 6;
            this.imgNTF_Image.TabStop = false;
            // 
            // btnNTF_UploadImage
            // 
            this.btnNTF_UploadImage.Location = new System.Drawing.Point(19, 111);
            this.btnNTF_UploadImage.Name = "btnNTF_UploadImage";
            this.btnNTF_UploadImage.Size = new System.Drawing.Size(89, 23);
            this.btnNTF_UploadImage.TabIndex = 7;
            this.btnNTF_UploadImage.Text = "Upload Image";
            this.btnNTF_UploadImage.UseVisualStyleBackColor = true;
            this.btnNTF_UploadImage.Click += new System.EventHandler(this.btnNTF_UploadImage_Click);
            // 
            // btnNTF_RemoveImage
            // 
            this.btnNTF_RemoveImage.Location = new System.Drawing.Point(32, 140);
            this.btnNTF_RemoveImage.Name = "btnNTF_RemoveImage";
            this.btnNTF_RemoveImage.Size = new System.Drawing.Size(55, 42);
            this.btnNTF_RemoveImage.TabIndex = 8;
            this.btnNTF_RemoveImage.Text = "Remove Image";
            this.btnNTF_RemoveImage.UseVisualStyleBackColor = true;
            this.btnNTF_RemoveImage.Click += new System.EventHandler(this.btnNTF_RemoveImage_Click);
            // 
            // btnNTF_AddAnother
            // 
            this.btnNTF_AddAnother.Location = new System.Drawing.Point(93, 214);
            this.btnNTF_AddAnother.Name = "btnNTF_AddAnother";
            this.btnNTF_AddAnother.Size = new System.Drawing.Size(75, 23);
            this.btnNTF_AddAnother.TabIndex = 20;
            this.btnNTF_AddAnother.Text = "Add Another";
            this.btnNTF_AddAnother.UseVisualStyleBackColor = true;
            this.btnNTF_AddAnother.Click += new System.EventHandler(this.btnNTF_AddAnother_Click);
            // 
            // btnNTF_Cancel
            // 
            this.btnNTF_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNTF_Cancel.Location = new System.Drawing.Point(249, 214);
            this.btnNTF_Cancel.Name = "btnNTF_Cancel";
            this.btnNTF_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btnNTF_Cancel.TabIndex = 19;
            this.btnNTF_Cancel.Text = "Cancel";
            this.btnNTF_Cancel.UseVisualStyleBackColor = true;
            this.btnNTF_Cancel.Click += new System.EventHandler(this.btnNTF_Cancel_Click);
            // 
            // btnNTF_Finish
            // 
            this.btnNTF_Finish.Location = new System.Drawing.Point(12, 214);
            this.btnNTF_Finish.Name = "btnNTF_Finish";
            this.btnNTF_Finish.Size = new System.Drawing.Size(75, 23);
            this.btnNTF_Finish.TabIndex = 18;
            this.btnNTF_Finish.Text = "Finish";
            this.btnNTF_Finish.UseVisualStyleBackColor = true;
            this.btnNTF_Finish.Click += new System.EventHandler(this.btnNTF_Finish_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "image files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.jpe;*.tif";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtNTF_Phone
            // 
            this.txtNTF_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTF_Phone.Location = new System.Drawing.Point(209, 96);
            this.txtNTF_Phone.Name = "txtNTF_Phone";
            this.txtNTF_Phone.Size = new System.Drawing.Size(118, 22);
            this.txtNTF_Phone.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phone";
            // 
            // txtNTF_Email
            // 
            this.txtNTF_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTF_Email.Location = new System.Drawing.Point(209, 124);
            this.txtNTF_Email.Name = "txtNTF_Email";
            this.txtNTF_Email.Size = new System.Drawing.Size(118, 22);
            this.txtNTF_Email.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // txtNTF_DOB
            // 
            this.txtNTF_DOB.CustomFormat = "ddMMMyyyy";
            this.txtNTF_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNTF_DOB.Location = new System.Drawing.Point(219, 71);
            this.txtNTF_DOB.Name = "txtNTF_DOB";
            this.txtNTF_DOB.Size = new System.Drawing.Size(108, 20);
            this.txtNTF_DOB.TabIndex = 25;
            // 
            // NewTenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 249);
            this.Controls.Add(this.txtNTF_DOB);
            this.Controls.Add(this.txtNTF_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNTF_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNTF_AddAnother);
            this.Controls.Add(this.btnNTF_Cancel);
            this.Controls.Add(this.btnNTF_Finish);
            this.Controls.Add(this.btnNTF_RemoveImage);
            this.Controls.Add(this.btnNTF_UploadImage);
            this.Controls.Add(this.imgNTF_Image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNTF_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNTF_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "NewTenantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTenantForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgNTF_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNTF_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNTF_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgNTF_Image;
        private System.Windows.Forms.Button btnNTF_UploadImage;
        private System.Windows.Forms.Button btnNTF_RemoveImage;
        private System.Windows.Forms.Button btnNTF_AddAnother;
        private System.Windows.Forms.Button btnNTF_Cancel;
        private System.Windows.Forms.Button btnNTF_Finish;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtNTF_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNTF_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtNTF_DOB;
    }
}