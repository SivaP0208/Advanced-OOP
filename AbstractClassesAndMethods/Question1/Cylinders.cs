using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cylinders:Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public Cylinders(double radius,double height,double width):base(radius,height,width)
        {

        }
        
        public override void CalculateArea()
        {
            Area=2*Math.PI*Radius*(Radius+Height);
        }
        public override void CalculateVolume()
        {
            Volume=Math.PI*Radius*Radius*Height;
        }
    }
}