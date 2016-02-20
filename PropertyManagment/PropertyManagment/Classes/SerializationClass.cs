using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace PropertyManagment
{
    static class SerializationClass
    {
        static string directory = System.AppDomain.CurrentDomain.BaseDirectory;
        public enum classNames { Property, Tenant, Lease, Occurence};

        public static void SaveData(object obj, classNames className)
        {
            string str = className.ToString();
            using (Stream fStream = new FileStream(directory + className.ToString() + ".xml", FileMode.Create, FileAccess.Write))
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType(), new List<Type>() { typeof(MaintenanceItem), typeof(Incident), typeof(Occurence), typeof(Tenant), typeof(Lease), typeof(Payment), typeof(Property) });
                serializer.WriteObject(fStream, obj);
            }
        }
        public static void LoadData(object obj, classNames className)
        {
            try {
                using (Stream fStream = new FileStream(directory + className.ToString() + ".xml", FileMode.Open, FileAccess.Read))
                {
                    DataContractSerializer serializer = new DataContractSerializer(obj.GetType(), new List<Type>() { typeof(MaintenanceItem), typeof(Incident), typeof(Occurence), typeof(Tenant), typeof(Lease), typeof(Payment), typeof(Property) });
                    obj = serializer.ReadObject(fStream);
                }
                switch (className)
                {
                    case classNames.Property:
                        {
                            Property.PropertyList = (List<Property>)obj;
                            break;
                        }
                    case classNames.Tenant:
                        {
                            Tenant.TenantList = (List<Tenant>)obj;
                            break;
                        }
                    case classNames.Lease:
                        {
                            Lease.Leases = (List<Lease>)obj;
                            break;
                        }
                    case classNames.Occurence:
                        {
                            Occurence.Occurences = (List<Occurence>)obj;
                            break;
                        }

                }
            }
            catch (FileNotFoundException) { }
        }
    }
}
