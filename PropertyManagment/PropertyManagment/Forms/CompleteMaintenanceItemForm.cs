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

namespace PropertyManagment
{
    public partial class CompleteMaintenanceItemForm : Form
    {
        MaintenanceItem Item { get; set; }
        TimeSpan TimeTaken { get; set; }
        double Cost { get; set; }
        List<string> CompletedBy = new List<string>();
        DateTime CompletionDate { get; set; }

        public CompleteMaintenanceItemForm(MaintenanceItem item)
        {
            InitializeComponent();
            Item = item;
        }

        private bool FieldsAreValid()
        {
            bool IsValid = true;
            //TODO: add criteria
            string numbersOnly = @"^\d+.??\d{0,2}$";
            if (!Regex.IsMatch(txt_Cost.Text, numbersOnly))
            {
                txt_Cost.BackColor = Color.LightPink;
                IsValid = false;
            }
            else
            { txt_Cost.BackColor = SystemColors.Window; }
            return IsValid;
        }
        private void GatherFieldData()
        {
            CompletionDate = txt_CompletionDate.Value.Date;
            Cost = Convert.ToDouble(txt_Cost.Text);
            for (int i = 0; i < txt_CompletedBy.Lines.Count(); i++)
            {
                CompletedBy.Add(txt_CompletedBy.Lines[i]);
            }
            TimeTaken = TimeSpan.FromHours(Convert.ToDouble((txt_Days.Value * 24) + txt_Hours.Value));
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                GatherFieldData();
                Item.CompleteMaintenance(TimeTaken, Cost, CompletedBy.ToArray(), CompletionDate);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
