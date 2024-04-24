using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Ladieswear ladies=new Ladieswear("Kurti",1300);
        ladies.CalculateDiscount();
        ladies.GetDressInfo();
        ladies.DisplayBill();

        Console.WriteLine();

        Menswear mens=new Menswear("Jeans",1000);
        mens.CalculateDiscount();
        mens.GetDressInfo();
        mens.DisplayBill();
    }
}