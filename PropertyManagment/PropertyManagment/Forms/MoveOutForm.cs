using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagment
{
    public partial class MoveOutForm : Form
    {
        public Property property { get; set; }
        public bool SameAsEndOfLease { get; set; }
        public DateTime MoveOutDate { get; set; }
        public bool Evicted { get; set; }
        public string Reason { get; set; }
        public bool ProrateFinalMonth { get; set; }
        public double ProrateAmount { get; set; }
        public string EventName { get; set; }

        public MoveOutForm(Property p)
        {
            InitializeComponent();
            property = p;
        }
        private bool FieldsAreValid()
        {
            bool IsValid = true;
            if (txt_MoveOutReason.Text == "")
            {
                txt_MoveOutReason.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { txt_MoveOutReason.BackColor = SystemColors.Window; }
            if (!rad_Evicted.Checked && !rad_EndOfLease.Checked && !rad_Other.Checked)
            {
                groupBox2.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { groupBox2.BackColor = SystemColors.Control; }
            return IsValid;
        }
        private void GatherFieldInfo()
        {
            MoveOutDate = txt_MoveOutDate.Value.Date;
            Reason = txt_MoveOutReason.Text;
        }
        private void chk_SameAsEndOfLease_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_MoveOutDate.Value = property.CurrentLease.EndDate.Date;
                txt_MoveOutDate.Enabled = false;
            }
            else
            {
                txt_MoveOutDate.Value = DateTime.Today.Date;
                txt_MoveOutDate.Enabled = true;
            }
        }

        private void rad_Evicted_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                EventName = "Eviction";
                Evicted = true;
                txt_MoveOutReason.Enabled = true;
                txt_MoveOutReason.Text = "";
            }
        }

        private void rad_EndOfLease_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                EventName = "Move Out Tenants";
                Evicted = false;
                txt_MoveOutReason.Enabled = false;
                txt_MoveOutReason.Text = "End of Lease";
            }
        }

        private void red_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                EventName = "Move Out Tenants";
                Evicted = false;
                txt_MoveOutReason.Enabled = true;
                txt_MoveOutReason.Text = "";
            }
        }

        private void chk_ProrateFinalMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            { lbl_ProrateAmount.Text = Convert.ToString((property.CurrentLease.Rent / DateTime.DaysInMonth(MoveOutDate.Year, MoveOutDate.Month) * MoveOutDate.Day)); }
            else
            { lbl_ProrateAmount.Text = "0"; }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GatherFieldInfo();
                property.MoveOutOldTenants(EventName, Reason, MoveOutDate, Evicted);
                DialogResult = DialogResult.OK;
            }
        }


    }
}
