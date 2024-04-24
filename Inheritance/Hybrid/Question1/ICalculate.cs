using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public interface ICalculate
    {
        public double ProjectMark { get; set; }

        void CalculateTotal();
        void CalculatePercentage();
    }
}