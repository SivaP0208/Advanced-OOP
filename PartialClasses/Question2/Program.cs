using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        // Creating Student object
        StudentInfo studentInfo=new StudentInfo("Siva","Male",new DateTime(2001,08,02),6382520746L,89,78,67);

        // Calculating TotalMarks and Percentage of the Student
        studentInfo.CalculateTotalAndPercentage();

        // Printing Student Details
        studentInfo.DisplayDetails();
    }
}