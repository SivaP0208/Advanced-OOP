using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class DoctorInfo  // : PatientInfo - 'DoctorInfo': cannot derive from sealed type 'PatientInfo'
    {
        private static int s_doctorID=2000;
        public string DoctorID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public DoctorInfo(string name,string fatherName)
        {
            DoctorID="DID"+(++s_doctorID);
            Name=name;
            FatherName=fatherName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Doctor ID : {DoctorID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName : {FatherName}");
        }
    }
}