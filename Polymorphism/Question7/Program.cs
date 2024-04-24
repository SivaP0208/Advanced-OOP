using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(26,2,0);
        Attendance month2=new Attendance(25,1,1);
        Attendance month3=new Attendance(27,2,0);

        Attendance totalSalary=month1+month2+month3;

        Console.WriteLine($"Total Salary is {(totalSalary.TotalWorkingDaysInMonth-totalSalary.NumberOfLeavesTaken)*500.0}");
    }
}