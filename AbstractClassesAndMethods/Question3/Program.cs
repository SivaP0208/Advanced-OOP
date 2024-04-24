using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        MaruthiSwift maruthi=new MaruthiSwift(EngineType.Petrol,4,300000,CarType.Hatchback);
        Console.WriteLine(maruthi.GetEngineType());
        Console.WriteLine(maruthi.GetNoOfSeats());
        Console.WriteLine(maruthi.GetCarType());
        Console.WriteLine(maruthi.GetPrice());

        Console.WriteLine();
        maruthi.DisplayCarDetails();
        Console.WriteLine();

        SuzukiCiaz suzuki=new SuzukiCiaz(EngineType.Petrol,6,450000,CarType.SUV);
        Console.WriteLine(suzuki.GetEngineType());
        Console.WriteLine(suzuki.GetNoOfSeats());
        Console.WriteLine(suzuki.GetCarType());
        Console.WriteLine(suzuki.GetPrice());

        Console.WriteLine();
        suzuki.DisplayCarDetails();
    }
}