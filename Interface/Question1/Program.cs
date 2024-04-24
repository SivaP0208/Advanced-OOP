using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog("Blacky","prairies","2 meals perday");
        Dog dog2 = new Dog("Jimmy","grasslands","2 meals perday");

        Duck duck1=new Duck("ABC","DEF","GHI");
        Duck duck2=new Duck("123","456","789");

        dog1.DisplayInfo();
        Console.WriteLine();

        dog2.DisplayInfo();
        Console.WriteLine();

        duck1.DisplayInfo();
        Console.WriteLine();

        duck2.DisplayInfo();
        Console.WriteLine();
    }
}