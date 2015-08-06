using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [DataContract(IsReference = true)]
    public class Property
    {
        public static List<Property> PropertyList = new List<Property>();

        [DataMember]
        public Address StreetAddress { get; set; }
        [DataMember]
        public double PurchasePrice { get; set; }
        [DataMember]
        public DateTime AquisitionDate { get; set; }
        [DataMember]
        public double Rent { get; set; }
        [DataMember]
        public Lease CurrentLease { get; set; }
        [DataMember]
        public bool IsReadyToRent { get; set; }
        [DataMember]
        public byte[] ImageData { get; set; }
        [DataMember]
        public byte[] FloorPlanData { get; set; }

        public Bitmap Image
        {
            get
            {
                if (ImageData != null)
                {
                    using (MemoryStream stream = new MemoryStream(ImageData))
                    { return new Bitmap(stream); }
                }
                else
                { return null; }
            }
        }                            //calculated
        public Bitmap FloorPlan
        {
            get
            {
                if (FloorPlanData != null)
                {
                    using (MemoryStream stream = new MemoryStream(FloorPlanData))
                    { return new Bitmap(stream); }
                }
                else
                { return null; }
            }
        }                        //calculated
        public IEnumerable<Tenant> CurrentTenants
        {
            get
            {
                if (!ReferenceEquals(null, CurrentLease))
                { return CurrentLease.Tenants; }
                else
                { return new List<Tenant>(); }

            }
        }      //calculated
        public IEnumerable<Tenant> PreviousTenants
        {
            get { return PastLeases.SelectMany(i => i.Tenants); }
        }     //calculated
        public string Status
        {
            get
            {
                if (IsRented)
                { return "Rented"; }
                else
                {
                    if (IsReadyToRent)
                    { return "Ready to rent"; }
                    else
                    { return "Not Ready to rent"; }
                }
            }
        }                           //calculated
        public IEnumerable<Occurence> IncidentHistory
        {
            get { return Occurence.Occurences.Where(i => i.Location == this).ToList(); }
        }  //calculated
        public bool IsRented
        {
            get
            {
                if (CurrentTenants.Count() == 0)
                { return false; }
                else
                { return true; }
            }
        }                           //calculated
        public IEnumerable<MaintenanceItem> ActiveMaintenanceItems
        {
            get { return MaintenanceItem.MaintenanceItems.Where(i => i.Location == this && i.Status == Occurence.Statuses.Active).ToList(); }
        }//calculated
        public IEnumerable<Lease> PastLeases
        {
            get { return Lease.Leases.Where(i => i.PropertyLeased == this && i.IsActive == false); }
        }           //calculated

        public Property() { }
        private Property(string city, string streetAddress, double rent, bool moveInReady, string state, double purchasePrice, DateTime aquisitionDate)
        {
            StreetAddress = new Address() { State = state, City = city, StreetAddress = streetAddress };
            PurchasePrice = purchasePrice;
            IsReadyToRent = moveInReady;
            AquisitionDate = Convert.ToDateTime(aquisitionDate);
            Rent = rent;
        }
        public static void AddProperty(string city, string streetAddress, double purchasePrice, DateTime aquisitionDate, double rent = 0, bool moveInReady = false, string state = "Illinois")
        {
            Property property = new Property(city, streetAddress, rent, moveInReady, state, purchasePrice, aquisitionDate);
            PropertyList.Add(property);
            Occurence.AddNewOccurence("Aquired new property", streetAddress, aquisitionDate, property, Occurence.Statuses.Resolved, null);
        }
        public static void AddProperty(Property property)
        {
            PropertyList.Add(property);
            Occurence.AddNewOccurence("Aquired new property", property.StreetAddress.StreetAddress, property.AquisitionDate, property, Occurence.Statuses.Resolved, null);
        }
        public void MoveOutOldTenants(string eventName,string reason,DateTime moveOutDate,bool evicted)
        {
            CurrentLease.MoveOutDate = moveOutDate;
            CurrentLease.Evicted = evicted;
            
            Occurence.AddNewOccurence(eventName, reason, moveOutDate, this, Occurence.Statuses.Resolved, CurrentTenants.ToList());

            foreach (Tenant t in CurrentTenants)
            { t.CurrentLease = null; }
            
            CurrentLease = null;
        }
        public void MoveInNewTenants(List<Tenant> tenants, DateTime startDate, int termLengthInMonths, double rent, double deposit, double petDeposit,byte[] imageData)
        {
            CurrentLease = new Lease(this, tenants, rent, deposit, petDeposit, startDate, termLengthInMonths,imageData);
            Lease.Leases.Add(CurrentLease);
            string[] tenantslist = new string[tenants.Count()];
            int i = 0;
            foreach (Tenant t in tenants)
            {
                t.CurrentLease = CurrentLease;
                tenantslist[i++] = t.FirstName + " " + t.LastName;
            }

            Occurence.AddNewOccurence("New tenant move in", String.Join(", ", tenantslist), startDate, this, Occurence.Statuses.Resolved, tenants);
            Rent = rent;
        }
        public static Property GetPropertyByStreetAddress(string address)
        {
            return PropertyList.Find(i => i.StreetAddress.StreetAddress == address);
        }
        public void RenewLease(int years, int months,byte[] imageData)
        {
            CurrentLease = new Lease(CurrentLease.PropertyLeased, CurrentLease.Tenants, CurrentLease.Rent, CurrentLease.Deposit, CurrentLease.PetDeposit, CurrentLease.EndDate, (years * 12) + months,ImageData);
            Lease.Leases.Add(CurrentLease);
            //add occurence
        }
    }
}
