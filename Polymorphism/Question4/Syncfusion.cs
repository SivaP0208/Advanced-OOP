using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }
        public string WorkLocation { get; set; }

        public Syncfusion(string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays,string workLocation):base(name,fatherName,gender,qualification,role,noOfWorkingDays)
        {
            EmployeeID="EID"+(++s_employeeID);
            WorkLocation=workLocation;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
        }
        public override void Display()
        {
            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Qualification : {Qualification}");
            Console.WriteLine($"Role : {Role}");
            Console.WriteLine($"Salary Amount : {SalaryAmount}");
            Console.WriteLine($"Work Location : {WorkLocation}");
        }
    }
}