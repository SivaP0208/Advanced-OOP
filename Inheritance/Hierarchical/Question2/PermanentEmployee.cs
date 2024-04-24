using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_employeeID=1000;
        private static string s_employeeType="Permanent";
        public string EmployeeID { get; }
        public string EmployeeType { get; }
        public double TotalSalary { get; set; }

        public PermanentEmployee(double basicSalary,int month):base(basicSalary,month)
        {

        }

        public void SalaryCalculate()
        {
            TotalSalary= BasicSalary + (0.2*BasicSalary)/100 + (0.18*BasicSalary)/100 - (0.1*BasicSalary)/100;
        } 

        public void ShowSalary()
        {
            Console.WriteLine($"\nYour Salary is {TotalSalary*Month}");
        }
    }
}