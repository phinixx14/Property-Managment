using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace PropertyManagment
{
    [DataContract(IsReference = true)]
    public class Tenant
    {
        public static List<Tenant> TenantList = new List<Tenant>();
        public static List<Tenant> NonActiveTenants
        {
            get { return TenantList.Where(t => t.Status == "Inactive").ToList(); }
        }//calculated
        public static List<Tenant> ActiveTenants
        {
            get { return TenantList.Where(t => t.Status == "Active").ToList(); }
        }   //calculated
        public static List<Tenant> Blacklist
        {
            get { return TenantList.Where(t => t.Blacklisted == true).ToList(); }
        }       //calculated
        [DataMember]
        public List<Note> Notes = new List<Note>();
        [DataMember]
        private static int NextID { get; set; }
        [DataMember]
        public Lease CurrentLease { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public byte[] ImageData { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool Blacklisted { get; set; }
        [DataMember]
        public string TenantID { get; private set; }

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
        }                       //calculated
        public string Status
        {
            get
            {
                if (Blacklisted)
                { return "Blacklisted"; }
                else
                {
                    if (IsCurrentTenant)
                    { return "Active"; }
                    else
                    { return "Inactive"; }
                }
            }
        }                      //calculated
        public int Age
        {
            get { return (int)Math.Floor(Convert.ToDouble((DateTime.Today - DateOfBirth).Days / 365)); }
        }                            //calculated
        public Property Residence
        {
            get
            {
                if (ReferenceEquals(null, CurrentLease))
                { return null; }
                else
                { return CurrentLease.PropertyLeased; }
            }
        }                 //calculated
        public IEnumerable<Occurence> Occurences
        {
            get { return Occurence.Occurences.Where(i => i.TenantsInvolved.Contains(this)); }
        }  //calculated
        public bool IsCurrentTenant
        {
            get
            {
                if (Residence != null)
                { return true; }
                else
                { return false; }
            }
        }               //calculated

        //private Tenant() { }

        public Tenant(string fname, string lname, DateTime dob, string phone, string email)
            : this(fname, lname, dob, phone, email, null)
        {

        }
        public Tenant(string fname, string lname, DateTime dob, string phone, string email, byte[] image)
        {
            TenantID = "Ten_" + NextID++;
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dob;
            ImageData = image;
            Phone = phone;
            Email = email;
        }

        public static void AddNewTenant(Tenant tenant)
        {
            TenantList.Add(tenant);
        }
        public static Tenant GetTenantByName(string firstName, string lastName)
        {
            return TenantList.Find(i => i.FirstName == firstName && i.LastName == lastName);
        }
        public static Tenant GetTenantByID(string id)
        {
            return TenantList.Find(i => i.TenantID == id);
        }

        public static void SaveData()
        {
            using (Stream fStream = new FileStream(@"C:\Users\kmyers\Desktop\File Samples\Tenants.xml", FileMode.Create, FileAccess.Write))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Property>), new List<Type>() { typeof(MaintenanceItem), typeof(Incident), typeof(Occurence), typeof(Tenant), typeof(Lease), typeof(Payment) });
                serializer.WriteObject(fStream, TenantList);
            }
        }
        public static void LoadData()
        {
            try
            {
                using (Stream fStream = new FileStream(@"C:\Users\kmyers\Desktop\File Samples\Tenants.xml", FileMode.Open, FileAccess.Read))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(List<Tenant>), new List<Type>() { typeof(MaintenanceItem), typeof(Incident), typeof(Occurence), typeof(Property), typeof(Lease), typeof(Payment) });
                    TenantList = (List<Tenant>)serializer.ReadObject(fStream);
                }
            }
            catch (FileNotFoundException) { throw new Exception(); }
        }
        public static bool operator ==(Tenant left, Tenant right)
        {
            try
            {
                return (left.FirstName == right.FirstName && left.LastName == right.LastName && left.Phone == right.Phone && left.Age == right.Age && left.DateOfBirth == right.DateOfBirth && left.Email == right.Email);
            }
            catch (NullReferenceException) { return false; }
        }
        public static bool operator !=(Tenant left, Tenant right)
        {
            try
            {
                return !(left == right);
            }
            catch (NullReferenceException) { return false; }
        }
    }
}
