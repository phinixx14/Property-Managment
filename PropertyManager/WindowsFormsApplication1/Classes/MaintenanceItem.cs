using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [DataContract]
    public class MaintenanceItem : Occurence
    {
        public enum Frequencies { Once, Daily, Weekly, Biweekly, Monthly, Yearly, Custom };
        public enum Priorities { Urgent, High, Meduim, Low, Optional };
        public enum RequestorTypes { Tenant, Official, RedRock};
        public static IEnumerable<MaintenanceItem> MaintenanceItems
        {
            get
            {
                List<MaintenanceItem> items = new List<MaintenanceItem>();
                foreach (MaintenanceItem item in Occurence.Occurences.Where(i => i is MaintenanceItem))
                { items.Add(item); }
                return items;
            }
        }

        [DataMember]
        public Frequencies Frequency { get; set; } //Used for recurring items such as preventive maintenence
        [DataMember]
        public Priorities Priority { get; set; } //Used to determine how high on the list this item will appear
        [DataMember]
        public RequestorTypes RequestedBy { get; set; } //Who put in the request? Tenant? City? Someone at the Company?
        [DataMember]
        public double EstimatedCost { get; set; } //Estimate of how much money the maintenance item will cost to complete
        [DataMember]
        public double ActualCost { get; set; }
        [DataMember]
        public TimeSpan EstimatedTimeTaken { get; set; } //Estimate of how much time the maintenance item will take to complete
        [DataMember]
        public TimeSpan ActualTimeTaken { get; set; }
        [DataMember]
        public DateTime EarliestDueDate { get; set; }
        [DataMember]
        public DateTime LatestDueDate { get; set; }
        [DataMember]
        public List<string> CompletedBy = new List<string>();
        [DataMember]
        public DateTime CompletionDate { get; set; }
        [DataMember]
        public bool IsServiceCall { get; set; }

        private MaintenanceItem() { }
        private MaintenanceItem(string name, string desc, DateTime issueDate, Property property, Statuses status, List<Tenant> tenantsInvolved, RequestorTypes requestedBy, double estimatedCost, DateTime ealiestDue, DateTime latestDue, Priorities priority, TimeSpan estimatedTimeTaken,bool isServiceCall)
            : base(name, desc, issueDate, property, status, tenantsInvolved)
        {
             Priority = priority; 

            RequestedBy = requestedBy;
            EstimatedCost = estimatedCost;
            EstimatedTimeTaken = estimatedTimeTaken;
            EarliestDueDate = ealiestDue;
            LatestDueDate = latestDue;
            IsServiceCall = isServiceCall;
        }
        public static List<MaintenanceItem> getListOfAllActiveItems()
        {
            return MaintenanceItems.Where(i => i.Status == Statuses.Active).ToList();
        }
        public static void SubmitMaintenanceRequest(string name, string desc, DateTime issueDate, Property property, Statuses status, List<Tenant> tenantsInvolved, RequestorTypes requestedBy, double estimatedCost, DateTime ealiestDue, DateTime latestDue, Priorities priority, TimeSpan estimatedTimeTaken)
        {
            Occurence.Occurences.Add(new MaintenanceItem(name, desc, issueDate, property, status, tenantsInvolved, requestedBy, estimatedCost, ealiestDue, latestDue, priority, estimatedTimeTaken,false));
        }
        public static void SubmitServiceCall(string description,DateTime date,Property property,double estimatedCost,DateTime earliestDue,DateTime latestDue,TimeSpan estimatedTimeTaken)
        {
            Occurence.Occurences.Add(new MaintenanceItem("Service Call", description, date, property, Statuses.Active, property.CurrentTenants.ToList(), RequestorTypes.Tenant, estimatedCost, earliestDue, latestDue, Priorities.Urgent, estimatedTimeTaken,true));
        }
        public void CompleteMaintenance(TimeSpan timeTaken, double cost, string[] completedBy, DateTime completionDate)
        {
            ActualTimeTaken = timeTaken;
            ActualCost = cost;

            for (int i = 0; i < completedBy.Length; i++)
            {
                CompletedBy.Add(completedBy[i]);
            }
            CompletionDate = Convert.ToDateTime(completionDate).Date;
            Status = Statuses.Resolved;
        }
        public void CancelMaintenanceRequest()
        {
            Status = Statuses.Cancelled;
        }
        public static MaintenanceItem GetMaintenanceItem(string name,string description,string address,DateTime date)
        { return MaintenanceItems.Where(i => i.InstanceName == name && i.Location.StreetAddress.StreetAddress == address && i.Description == description && i.LatestDueDate == date).First(); }
    }
}
