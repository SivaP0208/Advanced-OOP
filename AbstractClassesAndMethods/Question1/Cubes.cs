using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cubes:Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public Cubes(double radius,double height,double width):base(radius,height,width)
        {

        }

        public override void CalculateArea()
        {
            Area=6*Radius*Radius;
        }
        public override void CalculateVolume()
        {
            Volume=Radius*Radius*Radius;
        }
    }
}