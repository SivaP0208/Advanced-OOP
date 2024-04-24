using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question5
{
    public class SalaryInfo:EmployeeInfo
    {
       private int _numberOfDaysWorked;
       public int NumberOfDaysWorked { get; }

       public SalaryInfo(string employeeID,string name,string fatherName,string mobileNumber,string gender,int noOfDaysWorked):base(employeeID,name,fatherName,mobileNumber,gender)
       {
            NumberOfDaysWorked=noOfDaysWorked;
       }

        public override void Display()
        {
            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Mobile Number : {MobileNumber}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Salary : {NumberOfDaysWorked*500.0}");
        }
    }
}