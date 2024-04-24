using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public enum EngineType{Petrol,Diesel,CNG}
    public enum CarType{Hatchback,Sedan,SUV}
    public abstract class Car
    {
        private int _noOfWheels=4;
        private int _noOfDoors=4;
        public EngineType EngineType { get; set; }
        public int NoOfSeats { get; set; }
        public double Price { get; set; }
        public CarType CarType { get; set; }

        public Car(EngineType engineType,int noOfSeats,double price,CarType carType)
        {
            EngineType=engineType;
            NoOfSeats=noOfSeats;
            Price=price;
            CarType=carType;
        }

        public void ShowWheels()
        {
            Console.WriteLine($"Number of Wheels : {_noOfWheels}");
        }

        public void ShowDoors()
        {
            Console.WriteLine($"Number of Doors : {_noOfDoors}");
        }

        public abstract EngineType GetEngineType();

        public abstract int GetNoOfSeats();

        public abstract double GetPrice();

        public abstract CarType GetCarType();

        public abstract void DisplayCarDetails();
    }
}