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
    public partial class AddIncidentForm : Form
    {
        Property property { get; set; }
        string IncidentName { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        Occurence.Statuses Status { get; set; }
        List<Tenant> tenants = new List<Tenant>();
        bool TenantIsLiable { get; set; }
        bool PetRelated { get; set; }
        double MoneyChargedToTenant { get; set; }

        public AddIncidentForm(Property p)
        {
            InitializeComponent();
            property = p;
        }

        private bool FieldsAreValid()
        {
            bool IsValid = true;
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\d+.??\d{0,2}$");
            if (!regex.IsMatch(txt_MoneyChargedToTenant.Text))
            {
                txt_MoneyChargedToTenant.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { txt_MoneyChargedToTenant.BackColor = SystemColors.Window; }
            List<TextBox> boxes = new List<TextBox>() { txt_IncidentName, txt_Description };
            foreach (TextBox tb in boxes)
            {
                if (tb.Text == "")
                {
                    IsValid = false;
                    tb.BackColor = Color.LightPink;
                }
                else
                { tb.BackColor = SystemColors.Window; }
            }
            return IsValid;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                IncidentName = txt_IncidentName.Text;
                Description = txt_Description.Text;
                Date = txt_Date.Value.Date;
                PetRelated = chk_PetRelated.Checked;
                Status = Occurence.Statuses.Resolved;
                tenants = property.CurrentTenants.ToList();
                TenantIsLiable = chk_TenantLiable.Checked;
                if (TenantIsLiable)
                { MoneyChargedToTenant = Convert.ToDouble(txt_MoneyChargedToTenant.Text); }
                else
                { MoneyChargedToTenant = 0; }
                Incident.CreateIncident(IncidentName, Description, Date, property, Status, tenants, TenantIsLiable, PetRelated, MoneyChargedToTenant);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
