using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PropertyManagment
{
    public partial class MoveInForm : Form
    {
        public List<Tenant> tenants = new List<Tenant>();
        private List<Tenant> tenantList = new List<Tenant>();
        public Property property { get; set; }
        public DateTime StartDate { get; set; }
        public int TermLength { get; set; }
        public double Rent { get; set; }
        public double Deposit { get; set; }
        public double PetDeposit { get; set; }
        public byte[] ImageData { get; set; }
    
        public MoveInForm(Property Prop)
        {
            InitializeComponent();
            property = Prop;
            lbl_Address.Text = property.StreetAddress.StreetAddress;
            lbl_City.Text = property.StreetAddress.City;
            lbl_State.Text = property.StreetAddress.State;
            tenantList = Tenant.NonActiveTenants;
            UpdateListView();
            UpdateDataGridView();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                StartDate = txt_StartDate.Value;
                TermLength = (int)txt_TermLength.Value;
                Rent = Convert.ToDouble(txt_Rent.Text);
                Deposit = Convert.ToDouble(txt_Deposit.Text);
                PetDeposit = Convert.ToDouble(txt_PetDeposit.Text);
                property.MoveInNewTenants(tenants, StartDate, TermLength, Rent, Deposit, PetDeposit, ImageData);
                DialogResult = DialogResult.OK;
            }
        }

        private bool FieldsAreValid()
        {
            bool IsValid = true;
            string numbersOnly = @"^\d+.??\d{0,2}$";
            List<TextBox> textboxes = new List<TextBox> { txt_Rent, txt_Deposit, txt_PetDeposit };
            foreach (TextBox tb in textboxes)
            {
                if (!Regex.IsMatch(tb.Text,numbersOnly))
                {
                    tb.BackColor = Color.LightPink;
                    IsValid = false;
                }
                else
                { tb.BackColor = SystemColors.Window; }
            }
            if (dataGridView1.Rows.Count == 0)
            {
                IsValid = false;
                MessageBox.Show("Must have at least one Tenant on Lease");
            }
            return IsValid;
        }

        private void UpdateListView()
        {
            tenantList = Tenant.NonActiveTenants.Where(i => i.FirstName.Contains(txt_FirstName.Text) && i.LastName.Contains(txt_LastName.Text)&&!tenants.Contains(i)).ToList();
            dataGridView2.DataSource = tenantList.Select(i => new { i.FirstName ,i.LastName}).ToList();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = tenants.Select(i => new { i.FirstName, i.LastName }).ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            UpdateListView();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tenants.Add(tenantList[e.RowIndex]);
            UpdateListView();
            UpdateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool loop;
            do
            {
                loop = false;
                NewTenantForm dialog = new NewTenantForm();
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {
                    tenants.Add(dialog.NewTenant);
                }
                if (dialog.DialogResult == DialogResult.Retry)
                {
                    tenants.Add(dialog.NewTenant);
                    loop = true;
                }
                if (dialog.DialogResult == DialogResult.Cancel)
                {

                }
                UpdateDataGridView();
            } while (loop);
        }

        private void UpdateEndDate()
        {
            DateTime endDate = txt_StartDate.Value.AddMonths((int)txt_TermLength.Value);
            DateTime dt = new DateTime(endDate.Year, endDate.Month, 1);
            txt_EndDate.Text = dt.ToShortDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using(MemoryStream fStream = new MemoryStream())
            {
                openFileDialog1.OpenFile().CopyTo(fStream);
                ImageData = fStream.GetBuffer();
            }
        }
    }
}
