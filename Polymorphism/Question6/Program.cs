using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Bank bank;
        bank=new SBI();
        Console.WriteLine($"SBI Interest Value : {bank.GetInterestInfo()}%\n");
    
        bank=new ICICI();
        Console.WriteLine($"ICICI Interest Value : {bank.GetInterestInfo()}%\n");

        bank=new HDFC();
        Console.WriteLine($"HDFC Interest Value : {bank.GetInterestInfo()}%\n");

        bank=new IDBI();
        Console.WriteLine($"IDBI Interest Value : {bank.GetInterestInfo()}%\n");
    }
}