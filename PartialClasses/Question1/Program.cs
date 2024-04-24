using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        // Creating Employee Object
        EmployeeInfo employeeInfo=new EmployeeInfo("Siva","Male",new DateTime(2001,08,02),9876543210L);

        // Updaing Mobile Number in Employee object
        employeeInfo.UpdateMobile(6382520746L);

        // printing Employee Details
        employeeInfo.DisplayDetails();
    }
}