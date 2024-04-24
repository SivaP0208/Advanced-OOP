using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Rectangle:Dimension
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double length,double height):base(length,height)
        {
            Length=length;
            Height=height;
        }

        public override void Calculate()
        {
            Area=Length*Height;
        }
    }
}