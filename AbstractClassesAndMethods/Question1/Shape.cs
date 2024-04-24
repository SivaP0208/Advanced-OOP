using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public abstract class Shape
    {
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Shape(double radius,double height,double width)
        {
            Radius=radius;
            Height=height;
            Width=width;
        }
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}