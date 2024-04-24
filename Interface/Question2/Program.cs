using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Siva","Paramsivam","6382520746");
        EmployeeInfo employee=new EmployeeInfo("Naruto","Minato");

        student.Display();
        Console.WriteLine();
        employee.Display();
    }
}