using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PropertyManagment
{
    public partial class NewPropertyForm : Form
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Rent { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime AquisitionDate { get; set; }
        public bool MoveInReady { get; set; }
        public byte[] ImageData { get; set; }
        public Features PropertyFeatures { get; set; }

        public NewPropertyForm()
        {
            InitializeComponent();
        }

        private void GetTextboxInformation()
        {
            StreetAddress = txtNPF_StreetAddress.Text;
            City = txtNPF_City.Text;
            State = txtNPF_State.Text;
            PropertyFeatures = new Features() { Bedrooms = Convert.ToInt32(txt_Bedrooms.Value), Bathrooms = Convert.ToInt32(txt_Bathrooms.Value), Floors = Convert.ToInt32(txt_Floors.Value), Basement = chk_Basement.Checked };
            Rent = Convert.ToDouble(txtNPF_Rent.Text);
            PurchasePrice = Convert.ToDouble(txtNPF_PurchasePrice.Text);
            AquisitionDate = txtNPF_AquisitionDate.Value.Date;
            if (chkNPF_MoveInReady.Checked)
            { MoveInReady = true; }
            else
            { MoveInReady = false; }
        }

        private bool FieldsAreValid()
        {
            bool IsValid = true;
            string numbersOnly = @"^\d+.??\d{0,2}$";
            List<TextBox> textboxes = new List<TextBox> { txtNPF_Rent, txtNPF_PurchasePrice };
            foreach (TextBox tb in textboxes)
            {
                if (!Regex.IsMatch(tb.Text, numbersOnly))
                {
                    tb.BackColor = Color.LightPink;
                    IsValid = false;
                }
                else
                { tb.BackColor = SystemColors.Window; }
            }
            if (!Regex.IsMatch(txtNPF_StreetAddress.Text, @"^[a-zA-Z0-9]+[ ]{1}[a-zA-Z]+[ ]{1}[a-zA-Z]+"))
            {
                txtNPF_StreetAddress.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { txtNPF_StreetAddress.BackColor = SystemColors.Window; }
            if (txtNPF_City.Text.Length == 0)
            {
                txtNPF_City.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { txtNPF_City.BackColor = SystemColors.Window; }

            return IsValid;
        }

        private void btnNPF_Finish_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GetTextboxInformation();
                Property.AddProperty(City, StreetAddress, PurchasePrice, AquisitionDate, PropertyFeatures, Rent, MoveInReady, State, ImageData);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnNPF_AddAnother_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GetTextboxInformation();
                Property.AddProperty(City, StreetAddress, PurchasePrice, AquisitionDate, PropertyFeatures, Rent, MoveInReady, State, ImageData);
                DialogResult = DialogResult.Retry;
            }
        }

        private void btnNPF_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnNPF_UploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnNPF_RemoveImage_Click(object sender, EventArgs e)
        {
            ImageData = null;
            imgNPF_Image.Image = Properties.Resources.unavailable;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (MemoryStream fStream = new MemoryStream())
            {
                openFileDialog1.OpenFile().CopyTo(fStream);
                ImageData = fStream.GetBuffer();
                imgNPF_Image.Image = new Bitmap(fStream);
            }
        }
    }
}