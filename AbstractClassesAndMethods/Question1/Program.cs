using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinders cylinder=new Cylinders(12,15,9);
        cylinder.CalculateArea();
        cylinder.CalculateVolume();

        Cubes cube=new Cubes(8.2,11.3,12.5);
        cube.CalculateArea();
        cube.CalculateVolume();

        Console.WriteLine($"Cylinder's Area : {Math.Round(cylinder.Area,2)} and Volume : {Math.Round(cylinder.Volume,2)}\n");
        Console.WriteLine($"Cube's Area : {Math.Round(cube.Area,2)} and Volume : {Math.Round(cube.Volume,2)}\n");
    }
}