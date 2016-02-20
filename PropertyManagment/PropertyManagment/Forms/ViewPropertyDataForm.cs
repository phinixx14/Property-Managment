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
    public partial class ViewPropertyDataForm : Form
    {
        public ViewPropertyDataForm(Property item)
        {
            InitializeComponent();
            Text = "Property Info";
            List<Property> source = new List<Property>() { item };
            dataGridView1.DataSource = source;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            foreach (string s in new string[] { "Purchase Price", "Aquisition Date", "Rent", "IsReadyToRent", "Status", "IsRented" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView1.AutoResizeColumns();

            dataGridView2.DataSource = new List<Address>() { item.StreetAddress };//ok

            dataGridView3.DataSource = new List<Lease>() { item.CurrentLease };//manual
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.Columns.Clear();
            foreach (string s in new string[] { "Deposit","Pet Deposit","Start Date", "End Date", "Term Length Months","Deposit Remaining","Pet Deposit Remaining","Move Out Date" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView3.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView3.AutoResizeColumns();

            dataGridView4.DataSource = new List<Features>() { item.PropertyFeatures };//ok
            
            dataGridView5.DataSource = item.CurrentTenants;//manual
            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.Columns.Clear();
            foreach (string s in new string[] { "First Name","Last Name","Age","Date Of Birth","Phone","Email","Status" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView5.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView5.AutoResizeColumns();

            dataGridView6.DataSource = item.PreviousTenants;//manual
            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.Columns.Clear();
            foreach (string s in new string[] { "First Name","Last Name","Age","Date Of Birth","Phone","Email","Status" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView6.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView6.AutoResizeColumns();
            
            dataGridView7.DataSource = item.IncidentHistory;//manual
            dataGridView7.AutoGenerateColumns = false;
            dataGridView7.Columns.Clear();
            foreach (string s in new string[] { "Instance Name", "Description", "Incident Date", "Status" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView7.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView7.AutoResizeColumns();

            dataGridView8.DataSource = item.ActiveMaintenanceItems;//manual
            dataGridView8.AutoGenerateColumns = false;
            dataGridView8.Columns.Clear();
            foreach (string s in new string[] { "Instance Name", "Description", "Incident Date", "Status", "IsServiceCall", "Requested By", "EstimatedTimeTaken", "EstimatedCost", "EarliestDueDate", "LatestDueDate" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView8.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView8.AutoResizeColumns();

            dataGridView9.DataSource = item.PastLeases;//manual
            dataGridView9.AutoGenerateColumns = false;
            dataGridView9.Columns.Clear();
            foreach (string s in new string[] { "Deposit","Pet Deposit","Start Date", "End Date", "Term Length Months","Deposit Remaining","Pet Deposit Remaining","Move Out Date","Evicted" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView9.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            dataGridView9.AutoResizeColumns();
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
