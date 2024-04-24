using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Sphere:Dimension
    {
        public double Radius { get; set; }

        public Sphere(double radius):base(radius,radius)
        {
            Radius=radius;
        }

        public override void Calculate()
        {
            Area=4*3.14*Radius*Radius;
        }
    }
}