using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        // Creating Rectangle Object
        Rectangle rectangle=new Rectangle(5,3);
        
        // Creating Sphere Object
        Sphere sphere=new Sphere(5);

        // Calculating Area of two shapes
        rectangle.Calculate();
        sphere.Calculate();

        // Displaying the Area of two Shapes
        rectangle.DisplayArea();
        sphere.DisplayArea();
    }
}