using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace PropertyManagment
{
    public partial class NewTenantForm : Form
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }
        private string Phone { get; set; }
        private string Email { get; set; }
        private byte[] ImageData { get; set; }
        public Tenant NewTenant { get; set; }

        string phoneString = @"^(1?)[- ]?([2-9][0-9]{2})[- ]?(\d{3})[- ]?(\d{4})$";

        public NewTenantForm()
        {
            InitializeComponent();
        }

        private bool GetTextboxInformation()
        {
            bool IsOkay = true;
            FirstName = txtNTF_FirstName.Text;
            LastName = txtNTF_LastName.Text;
            DateOfBirth = txtNTF_DOB.Value;
            Match match = Regex.Match(txtNTF_Phone.Text, phoneString);
            Phone = String.Format("{0}-{1}-{2}", match.Groups[2].Value, match.Groups[3].Value, match.Groups[4].Value);
            Email = txtNTF_Email.Text;
            return IsOkay;
        }
        
        private bool FieldsAreValid()
        {
            string lettersOnly = @"^[a-zA-Z]+$";
            string emailString = @"^[a-zA-Z]+[a-zA-Z0-9-_+,<.>|\`~!#$%^&()]*@{1}[a-zA-Z0-9-_+,<.>|\`~!#$%^&()]+[.]{1}[a-zA-Z0-9]+$";
            bool IsValid = true;

            if (!Regex.IsMatch(txtNTF_FirstName.Text, lettersOnly))
            {
                IsValid = false;
                txtNTF_FirstName.BackColor = Color.LightPink;
            }
            else
            { txtNTF_FirstName.BackColor = SystemColors.Window; }

            if (!Regex.IsMatch(txtNTF_LastName.Text, lettersOnly))
            {
                IsValid = false;
                txtNTF_LastName.BackColor = Color.LightPink;
            }
            else
            { txtNTF_LastName.BackColor = SystemColors.Window; }

            if (!Regex.IsMatch(txtNTF_Phone.Text, phoneString) && txtNTF_Phone.Text != "")
            {
                IsValid = false;
                txtNTF_Phone.BackColor = Color.LightPink;
            }
            else
            { txtNTF_Phone.BackColor = SystemColors.Window; }

            if (!Regex.IsMatch(txtNTF_Email.Text, emailString) && txtNTF_Email.Text != "")
            {
                IsValid = false;
                txtNTF_Email.BackColor = Color.LightPink;
            }
            else
            { txtNTF_Email.BackColor = SystemColors.Window; }

            return IsValid;
        }

        private void btnNTF_Finish_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GetTextboxInformation();
                NewTenant = new Tenant(FirstName, LastName, DateOfBirth, Phone, Email, ImageData);
                Tenant.AddNewTenant(NewTenant);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnNTF_AddAnother_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GetTextboxInformation();
                NewTenant = new Tenant(FirstName, LastName, DateOfBirth, Phone, Email, ImageData);
                Tenant.AddNewTenant(NewTenant);
                DialogResult = DialogResult.Retry;
            }
        }
        
        private void btnNTF_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnNTF_UploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnNTF_RemoveImage_Click(object sender, EventArgs e)
        {
            ImageData = null;
            imgNTF_Image.Image = Properties.Resources.unavailable;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (MemoryStream fStream = new MemoryStream())
            {
                openFileDialog1.OpenFile().CopyTo(fStream);
                ImageData = fStream.GetBuffer();
                imgNTF_Image.Image = new Bitmap(fStream);
            }
        }
    }
}
