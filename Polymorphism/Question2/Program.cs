using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Square(4));
        Console.WriteLine(Square(8.3));
        Console.WriteLine(Square(11.18));
        Console.WriteLine(Square(8462));
    }

    public static int Square(int number)
    {
        return number*number;
    }

    public static float Square(float number)
    {
        return number*number;
    }

    public static double Square(double number)
    {
        return number*number;
    }

    public static long Square(long number)
    {
        return number*number;
    }
}