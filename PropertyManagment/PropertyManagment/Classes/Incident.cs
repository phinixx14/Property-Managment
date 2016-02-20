using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PropertyManagment
{
    [DataContract]
    public class Incident : Occurence,IFinancial
    {
        public static IEnumerable<Incident> Incidents
        {
            get
            {
                List<Incident> incidents = new List<Incident>();
                foreach (Incident i in Occurences.Where(i => i is Incident))
                {
                    incidents.Add(i);
                }
                return incidents;
            }
        }

        [DataMember]
        public bool TenantIsLiable { get; set; }
        [DataMember]
        public bool PetRelated { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public Lease RelevantLease { get; set; }

        private Incident() { }
        public Incident(string name, string desc, DateTime date, Property property, Occurence.Statuses status, List<Tenant> tenants, bool tenantIsLiable,bool petRelated,double moneyChargedToTenant)
            : base(name, desc, date, property, status, tenants)
        {
            InstanceID = "Inc_" + new string(InstanceID.Skip(4).ToArray());
            TenantIsLiable = tenantIsLiable;
            PetRelated = petRelated;
            Amount = moneyChargedToTenant;
            RelevantLease = property.IsRented ? property.CurrentLease : null;
        }

        public static void CreateIncident(string name, string desc, DateTime date, Property property, Occurence.Statuses status, List<Tenant> tenants, bool tenantIsLiable,bool petRelated, double moneyChargedToTenant)
        {
            Occurence.Occurences.Add(new Incident(name, desc, date, property, status, tenants, tenantIsLiable, petRelated, moneyChargedToTenant));
        }
    }
}
