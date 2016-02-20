namespace PropertyManagment
{
    partial class ViewNoteDataForm
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
            this.btn_Post = new System.Windows.Forms.Button();
            this.txt_Text = new System.Windows.Forms.RichTextBox();
            this.txt_WrittenBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DatePosted = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Post
            // 
            this.btn_Post.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Post.Location = new System.Drawing.Point(264, 195);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(70, 23);
            this.btn_Post.TabIndex = 0;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // txt_Text
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Text, 3);
            this.txt_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Text.Location = new System.Drawing.Point(3, 29);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(331, 160);
            this.txt_Text.TabIndex = 1;
            this.txt_Text.Text = "";
            // 
            // txt_WrittenBy
            // 
            this.txt_WrittenBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_WrittenBy, 2);
            this.txt_WrittenBy.Location = new System.Drawing.Point(99, 3);
            this.txt_WrittenBy.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txt_WrittenBy.Name = "txt_WrittenBy";
            this.txt_WrittenBy.Size = new System.Drawing.Size(228, 20);
            this.txt_WrittenBy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Written By:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.15493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.84507F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_DatePosted, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Text, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_WrittenBy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Post, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 221);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Posted:";
            // 
            // lbl_DatePosted
            // 
            this.lbl_DatePosted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_DatePosted.AutoSize = true;
            this.lbl_DatePosted.Location = new System.Drawing.Point(92, 201);
            this.lbl_DatePosted.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_DatePosted.Name = "lbl_DatePosted";
            this.lbl_DatePosted.Size = new System.Drawing.Size(28, 13);
            this.lbl_DatePosted.TabIndex = 5;
            this.lbl_DatePosted.Text = "date";
            // 
            // ViewNoteDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 221);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(209, 123);
            this.Name = "ViewNoteDataForm";
            this.Text = "ViewNoteDataForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Post;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_Text;
        private System.Windows.Forms.TextBox txt_WrittenBy;
        private System.Windows.Forms.Label lbl_DatePosted;
        private System.Windows.Forms.Label label2;
    }
}