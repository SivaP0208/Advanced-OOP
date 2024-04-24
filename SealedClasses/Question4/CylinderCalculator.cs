using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class CylinderCalculator:Calculator
    {
        public override void Area(double radius)
        {
            
        }

        public override void Volume(double radius)
        {
            double volume=3.14*(radius*radius*radius);
        }
    }
}