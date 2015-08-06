using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [DataContract]
    class Payment : Occurence
    {
        public static IEnumerable<Payment> Payments
        {
            get
            {
                List<Payment> items = new List<Payment>();
                foreach (Payment item in Occurence.Occurences.Where(i => i is Payment))
                { items.Add(item); }
                return items;
            }
        }
        [DataMember]
        public double AmountReceived { get; set; }
        [DataMember]
        public double AmountExpected { get; set; }
        [DataMember]
        public Lease RelevantLease { get; set; }

        private Payment() { }
        public Payment(string name, string desc, DateTime date, Property prop, Occurence.Statuses status, double paymentExpected,double paymentReceived,Lease relevantLease)
            : base(name, desc, date, prop, status, relevantLease.Tenants)
        {
            AmountExpected = paymentExpected;
            AmountReceived = paymentReceived;
            RelevantLease = relevantLease;
        }

        public static void AcceptPayment(string reason,string desc,DateTime date, Property prop, double paymentExpected, double paymentReceived,bool PaymentIsRent)
        {
            Occurence.Occurences.Add(new Payment(reason, desc, date, prop, Statuses.Resolved, paymentExpected, paymentReceived, prop.CurrentLease));
            if (PaymentIsRent)
            { prop.CurrentLease.AcceptRent(paymentReceived, date); }
        }
    }
}
