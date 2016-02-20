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
    public partial class PropertySelector : Form
    {
        public Property selection = null;

        public PropertySelector()
        {
            InitializeComponent();
            List<Property> source = Property.PropertyList.ToList();
            dataGridView1.DataSource = source;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            foreach (string s in new string[] { "Property ID", "Address", "City", "State" }) 
            {
                string name = new string(s.Where(a => !char.IsWhiteSpace(a)).ToArray());
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = name, HeaderText = s, Name = name, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            }
            
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoResizeColumns();
        }

        private void btn_Okay_Click(object sender, EventArgs e)
        {
            selection = Property.GetPropertyByID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult = DialogResult.OK;
        }

        private void PropertySelector_Load(object sender, EventArgs e)
        {
            int x = 0;
            foreach (Property p in (List<Property>)dataGridView1.DataSource)
            {
                dataGridView1.Rows[x].Cells[1].Value = p.StreetAddress.StreetAddress;
                dataGridView1.Rows[x].Cells[2].Value = p.StreetAddress.City;
                dataGridView1.Rows[x++].Cells[3].Value = p.StreetAddress.State;
            }
        }
        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hti = ((DataGridView)sender).HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                selection = Property.GetPropertyByID(((DataGridView)sender).SelectedRows[0].Cells[0].Value.ToString());
                DialogResult = DialogResult.OK;
            }
        }
    }
}
