using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagment
{
    interface IFinancial
    {
        double Amount { get; set; }
        string InstanceName { get; set; }
        string Description { get; set; }
        DateTime IncidentDate { get; set; }
        string InstanceID { get; }
    }
}
