using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class Menswear:Dress
    {
        private DressType _dressType=DressType.Menswear;
        public override DressType DressType { get{return _dressType;} }
        public override string DressName { get; set; }
        private double _price;
        public override double Price { get{return _price;} }
        public override double TotalPrice { get; set; }

        public Menswear(string dressName,double totalPrice)
        {
            DressName=dressName;
            TotalPrice=totalPrice;
        }
        public override void GetDressInfo()
        {
            Console.WriteLine($"Dress Type : {DressType}");
            Console.WriteLine($"Dress Name : {DressName}");
            Console.WriteLine($"Total Price : {TotalPrice}");
        }

        public double CalculateDiscount()
        {
            _price=TotalPrice-TotalPrice*30/100.0;
            return _price;
        }
        public override void DisplayBill()
        {
            Console.WriteLine($"Price Of the Dress with 30% Discount : {CalculateDiscount()}");
        }
    }
}