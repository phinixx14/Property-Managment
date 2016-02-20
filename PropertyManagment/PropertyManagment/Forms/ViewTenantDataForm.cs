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
    public partial class ViewTenantDataForm : Form
    {
        public ViewTenantDataForm(Tenant item)
        {
            InitializeComponent();
            Text = "Tenant Info";
            List<Tenant> source = new List<Tenant>() { item };
            dataGridView1.DataSource = source;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            foreach (string s in new string[] { "First Name", "Last Name", "Age", "Date Of Birth", "Phone", "Email", "Status" })
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
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
