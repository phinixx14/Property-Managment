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
    public partial class ListForm : Form
    {
        public ListForm(object data)
        {
            InitializeComponent();
            if (data is Property)
            {
                Property property = (Property)data;
                Text = property.StreetAddress.StreetAddress;
                if (property.PastLeases.Count()==0)
                { listBox1.DataSource = new List<String> { "No Past Leases" }; }
                else
                { listBox1.DataSource = property.PastLeases.Select(i => i.StartDate.ToShortDateString() + " - " + i.EndDate.ToShortDateString()).ToList(); }
            }
        }
    }
}
