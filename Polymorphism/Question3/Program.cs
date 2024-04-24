using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eee=new EEEDepartment();
        eee.SetBookInfo("ABC","Embedded System","DEF",new DateTime(2021,10,09));

        CSEDepartment cse=new CSEDepartment();
        cse.SetBookInfo("GHI","HTML","JKL",new DateTime(2023,08,03));

        eee.DisplayInfo();
        Console.WriteLine();
        cse.DisplayInfo();
    }
}