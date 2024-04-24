using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class VolumeCalculator:AreaCalculator
    {
        public double Height { get; set; }

        public VolumeCalculator(double radius,double height):base(radius)
        {
            Height=height;
        }

        public override double Calculate()
        {
            double volume=3.14*Radius*Radius*Height;
            return volume;
        }

        public override void Display()
        {
            Console.WriteLine($"Volume : {Math.Round(Calculate(),2)}");
        }
    }
}