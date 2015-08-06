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
    public partial class ViewDataForm : Form
    {
        public ViewDataForm(Property item)
        {
            InitializeComponent();
            Text = "Property Info";
            List<Property> source = new List<Property>() { item };
            if (!ReferenceEquals(null, item.CurrentLease))
            { dataGridView1.DataSource = source.Select(i => new { i.StreetAddress.StreetAddress, i.PurchasePrice, i.AquisitionDate, i.Status, i.Rent, i.CurrentLease.StartDate, i.CurrentLease.EndDate }).ToList(); }
            else
            { dataGridView1.DataSource = source.Select(i => new { i.StreetAddress.StreetAddress, i.PurchasePrice, i.AquisitionDate, i.Status, i.Rent, StartDate = "none", EndDate = "none" }).ToList(); }
        }
        public ViewDataForm(Occurence item)
        {
            InitializeComponent();
            if (item is Payment)
            {
                Text = "Payment Info";
                List<Payment> source = new List<Payment>() { (Payment)item };
                dataGridView1.DataSource = source.Select(i => new { i.InstanceName, i.Description, i.IncidentDate, i.Location.StreetAddress.StreetAddress, i.Status, i.AmountReceived, i.AmountExpected }).ToList();
            }
            else if (item is Incident)
            {
                Text = "Incident Info";
                List<Incident> source = new List<Incident>() { (Incident)item };
                dataGridView1.DataSource = source.Select(i => new { i.InstanceName, i.Description, i.IncidentDate, i.Location.StreetAddress.StreetAddress, i.Status, i.TenantIsLiable, i.PetRelated, i.MoneyChargedToTenant }).ToList();
            }
            else if (item is MaintenanceItem)
            {
                Text = "Maintenance Item Info";
                List<MaintenanceItem> source = new List<MaintenanceItem>() { (MaintenanceItem)item };
                dataGridView1.DataSource = source.Select(i => new { i.InstanceName, i.Description, i.IncidentDate, i.Location.StreetAddress.StreetAddress, i.Status, i.IsServiceCall, i.RequestedBy, i.EstimatedTimeTaken, i.EstimatedCost, i.ActualTimeTaken, i.ActualCost, i.EarliestDueDate, i.LatestDueDate, i.CompletionDate }).ToList();
            }
            else
            {
                Text = "Occurence Info";
                List<Occurence> source = new List<Occurence>() { item };
                dataGridView1.DataSource = source.Select(i => new { i.InstanceName, i.Description, i.IncidentDate, i.Location.StreetAddress.StreetAddress, i.Status }).ToList();
            }
        }
    }
}
