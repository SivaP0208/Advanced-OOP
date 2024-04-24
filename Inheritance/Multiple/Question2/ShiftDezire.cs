using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class ShiftDezire:Car,IBrand
    {
        private static int s_makingID=1000;
        public string MakingID { get; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }

        public string BrandName { get; set; }
        public string ModelName { get; set; }

        public ShiftDezire(string engineNumber,string chasisNumber,string brandName,string modelName,string fuelType,int numberOfSeats,string color,double tankCapacity,double numberOfKmDriven):base(fuelType,numberOfSeats,color,tankCapacity,numberOfKmDriven)
        {
            MakingID="SID"+(++s_makingID);
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            ModelName=modelName;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"\n\tShift Dezire Details");
            Console.WriteLine($"\nMaking ID           : {MakingID}");
            Console.WriteLine($"Engine Number       : {EngineNumber}");
            Console.WriteLine($"Chasis Number       : {ChasisNumber}");
            Console.WriteLine($"Brand Name          : {BrandName}");
            Console.WriteLine($"Model Name          : {ModelName}");
            Console.WriteLine($"Fuel Type           : {FuelType}");
            Console.WriteLine($"Number of seats     : {NumberOfSeats}");
            Console.WriteLine($"Color               : {Color}");
            Console.WriteLine($"Tank Capacity       : {TankCapacity}");
            Console.WriteLine($"Number of KM Driven : {NumberOfKmDriven}");
        }
    }
}