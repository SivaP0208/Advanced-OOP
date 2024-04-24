using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal;
        personal=new EmployeeInfo("Siva","Paramasivam","6382520746","Male");
        EmployeeInfo employee=(EmployeeInfo)personal;
        personal.Display();

        Console.WriteLine();

        personal=new SalaryInfo(employee.EmployeeID,employee.Name,employee.FatherName,employee.MobileNumber,employee.Gender,28);
        personal.Display();
    }
}