using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class SuzukiCiaz:Car
    {
        public SuzukiCiaz(EngineType engineType,int noOfSeats,double price,CarType carType):base(engineType,noOfSeats,price,carType)
        {

        }

        public override EngineType GetEngineType()
        {
            return EngineType;
        }
        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override double GetPrice()
        {
            return Price;
        }
        public override CarType GetCarType()
        {
            return CarType;
        }

        public override void DisplayCarDetails()
        {
            Console.WriteLine($"Engine Type : {EngineType}");
            Console.WriteLine($"Number Of Seats : {NoOfSeats}");
            ShowWheels();
            ShowDoors();
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Car Type : {CarType}");
        }
    }
}