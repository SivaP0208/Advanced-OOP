using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        // Creating Salary object
        SalaryInfo salaryInfo=new SalaryInfo(25000,2);
        SalaryInfo salaryInfo1=new SalaryInfo(35000,4);

        // Creating Salary for Permanent Employee
        PermanentEmployee permanentEmployee1=new PermanentEmployee(salaryInfo.BasicSalary,salaryInfo.Month);
        PermanentEmployee permanentEmployee2=new PermanentEmployee(salaryInfo1.BasicSalary,salaryInfo.Month);

        // Creating Salary for Temporary Employee
        TemporaryEmployee temporaryEmployee1=new TemporaryEmployee(salaryInfo.BasicSalary,salaryInfo.Month);
        TemporaryEmployee temporaryEmployee2=new TemporaryEmployee(salaryInfo1.BasicSalary,salaryInfo.Month);
    
        // Total Salary Calculation for Permanent Employee
        permanentEmployee1.SalaryCalculate();
        permanentEmployee2.SalaryCalculate();

        // Total Salary Calculation for Temporary Employee
        temporaryEmployee1.SalaryCalculate();
        temporaryEmployee2.SalaryCalculate();

        // printing Total Salary for Permanent Employee
        permanentEmployee1.ShowSalary();
        permanentEmployee2.ShowSalary();

        // printing Total Salary for Temporary Employee
        temporaryEmployee1.ShowSalary();
        temporaryEmployee2.ShowSalary();
    }
}