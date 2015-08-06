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

namespace WindowsFormsApplication1
{
    public partial class NewMaintenanceForm : Form
    {
        Property property { get; set; }
        string ItemName { get; set; }
        string Description { get; set; }
        MaintenanceItem.Priorities Priority { get; set; }
        MaintenanceItem.RequestorTypes RequestedBy { get; set; }
        public double EstimatedCost { get; set; }
        public TimeSpan EstimatedTimeTaken { get; set; }
        public DateTime EarliestDueDate { get; set; }
        public DateTime LatestDueDate { get; set; }
        public bool IsServiceCall { get; set; }

        public NewMaintenanceForm(Property p,bool isServiceCall)
        {
            InitializeComponent();
            property = p;
            IsServiceCall = isServiceCall;
            cbx_Priority.DataSource = Enum.GetNames(typeof(MaintenanceItem.Priorities));
            cbx_Requestor.DataSource = Enum.GetNames(typeof(MaintenanceItem.RequestorTypes));
            if (IsServiceCall)
            {
                chk_ServiceCall.Checked = true;
                chk_ServiceCall.Visible = false;
                cbx_Requestor.Enabled = false;
            }
            else
            {
                chk_ServiceCall.Checked = false;
                chk_ServiceCall.Visible = false;
                cbx_Requestor.Enabled = true;
            }
            //MaintenanceItem.SubmitMaintenanceRequest()
        }

        private bool FieldsAreValid()
        {
            bool IsValid = true;
            string NumbersOnly = @"^\d+.??\d{0,2}$";
            if (!Regex.IsMatch(txt_EstCost.Text, NumbersOnly))
            {
                txt_EstCost.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { txt_EstCost.BackColor = SystemColors.Window; }

            return IsValid;
        }
        private void GetFieldData()
        {
            EstimatedCost = Convert.ToDouble(txt_EstCost.Text);
            EstimatedTimeTaken = new TimeSpan(Convert.ToInt32(txt_Days.Value), Convert.ToInt32(txt_Hours.Value), 0, 0);
            EarliestDueDate = txt_EarliestDueDate.Value.Date;
            LatestDueDate = txt_LatestDueDate.Value.Date;
            Priority = (MaintenanceItem.Priorities)Enum.Parse(typeof(MaintenanceItem.Priorities), cbx_Priority.SelectedValue.ToString());
            RequestedBy = (MaintenanceItem.RequestorTypes)Enum.Parse(typeof(MaintenanceItem.RequestorTypes), cbx_Requestor.SelectedValue.ToString());
            Description = txt_Description.Text;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GetFieldData();
                if (IsServiceCall)
                { MaintenanceItem.SubmitServiceCall(Description, DateTime.Today.Date, property, EstimatedCost, EarliestDueDate, LatestDueDate, EstimatedTimeTaken); }
                else
                { MaintenanceItem.SubmitMaintenanceRequest(ItemName, Description, DateTime.Today.Date, property, Occurence.Statuses.Active, property.CurrentTenants.ToList(), RequestedBy, EstimatedCost, EarliestDueDate, LatestDueDate, Priority, EstimatedTimeTaken); }
                DialogResult = DialogResult.OK;
            }
        }

        private void chk_ServiceCall_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_Name.Text = "Service Call";
                txt_Name.Enabled = false;
                chk_ServiceCall.Checked = true;
                //cbx_Requestor.SelectedValue = "Tenant";
                cbx_Requestor.Enabled = false;
            }
            else
            {
                txt_Name.Enabled = true;
                txt_Name.Text = "";
                chk_ServiceCall.Checked = false;
                cbx_Requestor.Enabled = true;
            }
        }
    }
}
