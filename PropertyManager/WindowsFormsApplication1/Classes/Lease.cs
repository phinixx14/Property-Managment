using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [DataContract(IsReference = true)]
    public class Lease
    {
        public static List<Lease> Leases = new List<Lease>();
        public static IEnumerable<Lease> ActiveLeases
        {
            get { return Leases.Where(i => i.IsActive); }
        } //calculated
        public IEnumerable<Incident> Incidents
        {
            get
            {
                return Incident.Incidents.Where(i => i.RelevantLease == this);
            }
        }       //calculated
        
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public Property PropertyLeased { get; set; }
        [DataMember]
        public List<Tenant> Tenants { get; set; }
        [DataMember]
        public double Rent { get; set; }
        [DataMember]
        public double Deposit { get; set; }
        [DataMember]
        public double PetDeposit { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public int TermLengthMonths { get; set; }
        [DataMember]
        public byte[] ImageData { get; set; }
        [DataMember]
        public bool Evicted { get; set; }
        [DataMember]
        public DateTime MoveOutDate { get; set; }
        [DataMember]
        public double RolloverRent { get; set; }
        [DataMember]
        public int MonthsPaid { get; set; }
        [DataMember]
        public double PaymentsForCurrentMonth { get; set; }
        public double DepositRemaining
        {
            get
            {
                double deductions = 0;
                foreach (Incident incident in Incident.Incidents.Where(i => i.RelevantLease == this && i.TenantIsLiable == true && i.PetRelated == false))
                {
                    deductions += incident.MoneyChargedToTenant;
                }
                return Deposit - deductions;
            }
        }    //calculated
        public double PetDepositRemaining
        {
            get
            {
                double deductions = 0;
                foreach (Incident incident in Incident.Incidents.Where(i => i.RelevantLease == this && i.TenantIsLiable == true && i.PetRelated == true))
                {
                    deductions += incident.MoneyChargedToTenant;
                }
                return PetDeposit - deductions;
            }
        } //calculated
        
        public DateTime EndDate
        {
            get { return StartDate.AddMonths(TermLengthMonths); }
        }           //calculated
        public Bitmap Image
        {
            get
            {
                using (MemoryStream stream = new MemoryStream(ImageData))
                { return new Bitmap(stream); }
            }
        }               //calculated

        private Lease() { }
        public Lease(Property property, List<Tenant> tenants, double rent, double deposit, double petDeposit, DateTime startDate, int termLengthInMonths, byte[] imageData)
        {
            PropertyLeased = property;
            Tenants = tenants;
            Rent = rent;
            Deposit = deposit;
            PetDeposit = petDeposit;
            StartDate = startDate;
            TermLengthMonths = termLengthInMonths;
            MonthsPaid = 0;
            ImageData = imageData;
        }
        public void AddLease(Property property, List<Tenant> tenants, double rent, double deposit, double petDeposit, DateTime startDate, int termLengthInMonths, byte[] imageData)
        {
            Leases.Add(new Lease(property, tenants, rent, deposit, PetDeposit, startDate, termLengthInMonths, ImageData));
        }
        public void AddLease(Lease lease)
        {
            Leases.Add(lease);
        }
        public void AcceptRent(double amountReceived,DateTime paymentDate)
        {
            double TotalAmount = amountReceived + PaymentsForCurrentMonth;
            if ( TotalAmount >= CalculateExpectedRent(paymentDate))
            {
                //this month is paid
                PaymentsForCurrentMonth = TotalAmount - CalculateExpectedRent(paymentDate);
                MonthsPaid += MonthsNotPaid(paymentDate)+1;
            }
            else
            {
                if (MonthsNotPaid(paymentDate) >= 1)
                {
                    int monthsPaid = (int)Math.Floor(TotalAmount / (Rent + 50));
                    MonthsPaid += monthsPaid;
                    if (monthsPaid != 0)
                    { PaymentsForCurrentMonth = TotalAmount % (monthsPaid*(Rent+50)); }
                    else
                    { PaymentsForCurrentMonth = TotalAmount; }
                }
                else
                { PaymentsForCurrentMonth = TotalAmount; }
            }
        }
        public double CalculateExpectedRent(DateTime paymentDate)
        {
            if (!ThisMonthIsPaid(paymentDate))
            {
                RolloverRent = 0;
                for (int i = 0; i < MonthsNotPaid(paymentDate); i++)
                {
                    RolloverRent += (Rent + 50); //* MonthsNotPaid(paymentDate);
                }
                return Rent - PaymentsForCurrentMonth + RolloverRent + CalculateLateFee(paymentDate);
            }
            else
            { return 0; }
        }
        public double CalculateLateFee(DateTime paymentDate)
        {
            //if (PaymentIsLate(paymentDate))
            //{
            //if (StartDate.AddMonths(MonthsPaid).Month == paymentDate.Month)
            //{
            if (paymentDate.Day <= 5)
            { return 0; }
            else if (paymentDate.Day <= 12)
            { return 25; }
            else
            { return 50; }
            //}
            //else
            //{ return 50; }
            //}
            //else
            //{ return 0; }
        }
        public bool PaymentIsLate(DateTime paymentDate)
        {
            if (ThisMonthIsPaid(paymentDate))
            { return false; }
            else
            {
                if (paymentDate.Day > 5 || (paymentDate.Month - StartDate.Month) + 12 * (paymentDate.Year - StartDate.Year) > 1)
                { return true; }
                else
                { return false; }
            }
        }
        public int MonthsNotPaid(DateTime paymentDate)
        {
            return ((paymentDate.Month - StartDate.Month) + 12 * (paymentDate.Year - StartDate.Year) - MonthsPaid);
        }
        public bool ThisMonthIsPaid(DateTime paymentDate)
        {
            if (MonthsPaid == (paymentDate.Month - StartDate.Month) + 12 * (paymentDate.Year - StartDate.Year)+1)
            { return true; }
            else
            {
                if (StartDate.AddMonths(MonthsPaid) < paymentDate.Date && StartDate.AddMonths(MonthsPaid).Month <= paymentDate.Month)
                { return false; }
                else
                { return true; }
            }
        }
        public static bool operator ==(Lease left, Lease right)
        {
            try
            {
                if (left.Deposit == right.Deposit &&
                    left.Evicted == right.Evicted &&
                    left.ImageData == right.ImageData &&
                    left.IsActive == right.IsActive &&
                    left.MonthsPaid == right.MonthsPaid &&
                    left.MoveOutDate == right.MoveOutDate &&
                    left.PetDeposit == right.PetDeposit &&
                    left.PropertyLeased.StreetAddress.StreetAddress == right.PropertyLeased.StreetAddress.StreetAddress &&
                    left.Rent == right.Rent &&
                    left.StartDate == right.StartDate &&
                    left.TermLengthMonths == right.TermLengthMonths &&
                    left.Tenants.Count == right.Tenants.Count)
                {
                    for (int i = 0; i < left.Tenants.Count; i++)
                    {
                        if (left.Tenants[i] != right.Tenants[i])
                        { return false; }
                    }
                }
                else
                { return false; }
                return true;
            }
            catch (NullReferenceException) { return false; }
        }
        public static bool operator !=(Lease left, Lease right)
        {
            return !(left == right);
        }
    }
}
