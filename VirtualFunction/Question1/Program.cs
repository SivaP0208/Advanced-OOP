using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        // Creating Area Calculator Object
        AreaCalculator area = new AreaCalculator(5.3);

        // Displaying the Area
        area.Display();

        // Creating Volume Calculator object
        VolumeCalculator volume = new VolumeCalculator(4.5,5.9);
        
        // Displaying the volume
        volume.Display();
    }
}