using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public sealed class PatientInfo
    {
        private static int s_patientID=1000;
        public string PatientID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }

        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            PatientID="PID"+(++s_patientID);
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Patient ID : {PatientID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Bed No : {BedNo}");
            Console.WriteLine($"Native Place : {NativePlace}");
            Console.WriteLine($"Admitted For : {AdmittedFor}");
        }
    }
}