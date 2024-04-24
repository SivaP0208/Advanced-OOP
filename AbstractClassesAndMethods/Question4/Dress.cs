using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public enum DressType{Ladieswear,Menswear,Childrenswear}
    public abstract class Dress
    {
        public abstract DressType DressType { get;}
        public abstract string DressName { get; set; }
        public abstract double Price { get; }
        public abstract double TotalPrice { get; set; }

        public abstract void GetDressInfo();
        public abstract void DisplayBill();

    }
}