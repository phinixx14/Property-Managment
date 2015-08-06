using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewPaymentForm : Form
    {
        Property property { get; set; }
        double AmountReceived { get; set; }
        double AmountExpected { get; set; }
        string Description { get; set; }
        string Reason { get; set; }
        DateTime Date { get; set; }

        public NewPaymentForm(Property p)
        {
            InitializeComponent();
            property = p;
            group_PaymentInfo.Enabled = false;
            txt_Reason.Text = "Rent Payment";
            txt_Description.Text = "Amount Paid";
            txt_AmountExpected.Text = property.CurrentLease.CalculateExpectedRent(txt_Date.Value.Date).ToString();
        }
        private bool FieldsAreValid()
        {
            bool IsValid = true;
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\d+.??\d{0,2}$");
            TextBox[] txts = { txt_AmountExpected, txt_AmountReceived };
            foreach (TextBox txt in txts)
            {
                if (!regex.IsMatch(txt.Text))
                {
                    IsValid = false;
                    txt.BackColor = Color.LightPink;
                }
                else
                { txt.BackColor = SystemColors.Window; }
            }
            TextBox[] boxes = { txt_Reason, txt_Description };
            if (!chk_IsRent.Checked)
            {
                foreach (TextBox txt in txts)
                {
                    if (txt.Text == "")
                    {
                        IsValid = false;
                        txt.BackColor = Color.LightPink;
                    }
                    else
                    { txt.BackColor = SystemColors.Window; }
                }
            }
            else
            {
                foreach (TextBox txt in txts)
                { txt.BackColor = SystemColors.Window; }
            }
            return IsValid;
        }
        private void GetFormInfo()
        {
            AmountReceived = Convert.ToDouble(txt_AmountReceived.Text);
            AmountExpected = Convert.ToDouble(txt_AmountExpected.Text);
            Date = txt_Date.Value.Date;

            if (chk_IsRent.Checked)
            {
                AmountReceived = Convert.ToDouble(txt_AmountReceived.Text);
                if (AmountReceived < AmountExpected)
                {
                    Reason = "Rent Partial Payment";
                    Description = String.Format("{0:C} Paid, {1:C} Remaining", AmountReceived,AmountExpected-AmountReceived);
                }
                if (AmountReceived == AmountExpected)
                {
                    Reason = "Rent Payment";
                    Description = String.Format("{0:C} Paid", AmountReceived);
                }
                if (AmountReceived > AmountExpected)
                {
                    Reason = "Rent Over Payment";
                    Description = String.Format("{0:C} Paid, {1:C} Carried Over", AmountReceived, AmountReceived - AmountExpected);
                }
                
            }
            else
            {
                Reason = txt_Reason.Text;
                Description = txt_Description.Text;
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GetFormInfo();
                AddPayment();
                DialogResult = DialogResult.OK;
            }
        }
        private void AddPayment()
        {
            Payment.AcceptPayment(Reason, Description, Date, property, AmountExpected, AmountReceived,chk_IsRent.Checked);
        }

        private void chk_IsRent_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                group_PaymentInfo.Enabled = false;
                txt_Reason.Text = "Rent Payment";
                txt_Description.Text = String.Format("Amount Paid - {0:C}", Convert.ToString(AmountReceived));
                txt_AmountExpected.Text = property.CurrentLease.CalculateExpectedRent(txt_Date.Value.Date).ToString();
                txt_AmountExpected.Enabled = false;
            }
            else
            {
                group_PaymentInfo.Enabled = true;
                txt_AmountExpected.Enabled = true;
            }
        }

        private void txt_Date_ValueChanged(object sender, EventArgs e)
        {
            if (chk_IsRent.Checked)
            {
                txt_AmountExpected.Text = property.CurrentLease.CalculateExpectedRent(txt_Date.Value.Date).ToString();
            }
        }
    }
}
