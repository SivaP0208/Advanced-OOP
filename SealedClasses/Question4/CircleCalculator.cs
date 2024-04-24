using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class CircleCalculator:Calculator
    {
        public sealed override void Area(double r)
        {
            double area=3.14*(r*r);
        }

        public override void Volume(double radius)
        {
            
        }
    }
}