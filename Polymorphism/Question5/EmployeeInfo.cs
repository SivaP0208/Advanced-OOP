using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question5
{
    public class EmployeeInfo:PersonalInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }

        public EmployeeInfo(string name,string fatherName,string mobileNumber,string gender):base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID="EID"+(++s_employeeID);
        }

        public EmployeeInfo(string employeeID,string name,string fatherName,string mobileNumber,string gender):base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID=employeeID;
        }
        public override void Display()
        {
            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Mobile Number : {MobileNumber}");
            Console.WriteLine($"Gender : {Gender}");
        }
    }
}