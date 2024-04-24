using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employeeInfo=new EmployeeInfo("Shiva","Paramasivam","6382520746","siva@gmail.com","Male","siva2001");
        Hack hack=new Hack(employeeInfo.Name,employeeInfo.FatherName,employeeInfo.Mobile,employeeInfo.Mail,employeeInfo.Gender,employeeInfo.Password,"store3001");

        hack.ShowKeyInfo();
    }
}