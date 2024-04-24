using System;
namespace CafeteriaCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        FileHanding.Create();
        // Operations.AddDefaultData();
        FileHanding.ReadFromCSV();
        Operations.MainMenu();
        FileHanding.WriteToCSV();
    }
}