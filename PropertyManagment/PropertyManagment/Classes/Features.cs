using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PropertyManagment
{
    [DataContract(IsReference = true)]
    public class Features
    {
        [DataMember]
        public int Bedrooms { get; set; }
        [DataMember]
        public double Bathrooms { get; set; }
        [DataMember]
        public int Floors { get; set; }
        [DataMember]
        public bool Basement { get; set; }
    }
}
