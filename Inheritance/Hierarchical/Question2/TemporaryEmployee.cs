using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_employeeID=1000;
        private static string s_employeeType="Temporary";
        public string EmployeeID { get; }
        public string EmployeeType { get; }
        public double TotalSalary { get; set; }

        public TemporaryEmployee(double basicSalary,int month):base(basicSalary,month)
        {

        }

        public void SalaryCalculate()
        {
            TotalSalary=BasicSalary + (0.15*BasicSalary)/100 + (0.13*BasicSalary)/100 - (0.1*BasicSalary)/100;
        } 

        public void ShowSalary()
        {
            Console.WriteLine($"\nYour Salary is {TotalSalary*Month}");
        }
    }
}