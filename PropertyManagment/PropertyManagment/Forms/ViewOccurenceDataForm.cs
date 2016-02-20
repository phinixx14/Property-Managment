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
    public partial class ViewOccurenceDataForm : Form
    {
        public ViewOccurenceDataForm(Occurence item)
        {
            InitializeComponent();
            string[] values = null;
            if (item is Payment)
            {
                Text = "Payment Info";
                List<Payment> source = new List<Payment>() { (Payment)item };
                dataGridView1.DataSource = source;
                values = new string[] { "InstanceID", "InstanceName", "Description", "IncidentDate", "Status", "Amount", "AmountExpected" };

            }
            else if (item is Incident)
            {
                Text = "Incident Info";
                List<Incident> source = new List<Incident>() { (Incident)item };
                dataGridView1.DataSource = source;
                values = new string[] { "InstanceID", "InstanceName", "Description", "IncidentDate", "Status", "TenantIsLiable", "PetRelated", "Amount" };

            }
            else if (item is MaintenanceItem)
            {
                Text = "Maintenance Item Info";
                List<MaintenanceItem> source = new List<MaintenanceItem>() { (MaintenanceItem)item };
                dataGridView1.DataSource = source;
                values = new string[] { "InstanceID", "InstanceName", "Description", "IncidentDate", "Status", "IsServiceCall", "RequestedBy", "EstimatedTimeTaken", "EstimatedCost", "ActualTimeTaken", "ActualCost", "EarliestDueDate", "LatestDueDate", "CompletionDate" };
            }
            else if (item is Occurence)
            {
                Text = "Occurence Info";
                List<Occurence> source = new List<Occurence>() { item };
                dataGridView1.DataSource = source;
                values = new string[] { "InstanceID", "InstanceName", "Description", "IncidentDate", "Status" };
            }


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            foreach (string s in values)
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoResizeColumns();
        }
        
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.GetType() == typeof(FormatException))
            {
                MessageBox.Show("Invalid value entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = false;
                e.ThrowException = false;
            }
            else
            {
                MessageBox.Show("An unexpected error has occured:\n" + e.Exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = false;
                e.ThrowException = false;
            }
        }
    }
}
