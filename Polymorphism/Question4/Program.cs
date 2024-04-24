using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion employee=new Syncfusion("Siva","Paramasivam","Male","B.E(ECE)","Software Engineer",23,"Mathura Tower");
        employee.CalculateSalary();
        employee.Display();
    }
}