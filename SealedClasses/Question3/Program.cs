using System;
using Question1;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("Siva","6382520746","siva@Gmail.com","Male","Paramasivam","Valarmathi",1,"Chennai",DateTime.Now);

        employee.Update("siva","paramasivam","6382520746","siva@gmail.com","male");
    }
}