using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [DataContract]
    public class Occurence
    {
        public static List<Occurence> Occurences = new List<Occurence>();
        public enum Statuses { Resolved, Active, Cancelled };
        [DataMember]
        private static int NextID { get; set; }
        [DataMember]
        public string InstanceName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime IncidentDate { get; set; }
        [DataMember]
        public Property Location { get; set; }
        [DataMember]
        public Statuses Status { get; set; }
        [DataMember]
        public List<Tenant> TenantsInvolved { get; set; }
        [DataMember]
        public int InstanceID { get; private set; }

        protected Occurence() { }
        public Occurence(string name, string desc, DateTime date, Property address, Statuses status, IEnumerable<Tenant> tenantsInvolved)
        {
            InstanceName = name;
            Description = desc;
            IncidentDate = date;
            Location = address;
            Status = status;
            InstanceID = NextID++;
            if (tenantsInvolved == null)
            { TenantsInvolved = new List<Tenant>(); }
            else
            { TenantsInvolved = tenantsInvolved.ToList(); }
        }
        public static Occurence GetOccurenceByID(int ID)
        {
            return Occurence.Occurences.Find(o => o.InstanceID == ID);
        }
        public static void AddNewOccurence(string name, string desc, DateTime date, Property address, Statuses status, List<Tenant> tenants)
        { Occurences.Add(new Occurence(name, desc, date, address, status, tenants)); }
        public void VoidOccurence()
        { Occurences.Remove(this); }
    }
}
