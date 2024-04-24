using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class FileHandling
    {
        public static void Create()
        {
            // Creating Folder for Qwick Foodz
            if(!Directory.Exists("QwickFoodz"))
            {
                Directory.CreateDirectory("QwickFoodz");
            }
            
            // Creating File for Customer Detatils in QwickFoodz Folder
            if(!File.Exists("QwickFoodz/CustomerDetails.csv"))
            {
                File.Create("QwickFoodz/CustomerDetails.csv").Close();
            }

            // Creating File for Food Detatils in QwickFoodz Folder
            if(!File.Exists("QwickFoodz/FoodDetails.csv"))
            {
                File.Create("QwickFoodz/FoodDetails.csv").Close();
            }

            // Creating File for Order Detatils in QwickFoodz Folder
            if(!File.Exists("QwickFoodz/OrderDetails.csv"))
            {
                File.Create("QwickFoodz/OrderDetails.csv").Close();
            }

            // Creating File for Item Detatils in QwickFoodz Folder
            if(!File.Exists("QwickFoodz/ItemDetails.csv"))
            {
                File.Create("QwickFoodz/ItemDetails.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            // Wrting the Customer Details into CustomerDetails.csv File
            string[] customerDetails=new string[Operations.customerDetailsList.Count];
            for(int i=0;i<Operations.customerDetailsList.Count;i++)
            {
                customerDetails[i]=$"{Operations.customerDetailsList[i].CustomerID},{Operations.customerDetailsList[i].Name},{Operations.customerDetailsList[i].FatherName},{Operations.customerDetailsList[i].Gender},{Operations.customerDetailsList[i].Mobile},{Operations.customerDetailsList[i].DOB.ToString("dd/MM/yyyy")},{Operations.customerDetailsList[i].MailID},{Operations.customerDetailsList[i].Location}";
            }
            File.WriteAllLines("QwickFoodz/CustomerDetails.csv",customerDetails);

            // Wrting the Food Details into FoodDetails.csv File
            string[] foodDetails=new string[Operations.foodDetailsList.Count];
            for(int i=0;i<Operations.foodDetailsList.Count;i++)
            {
                foodDetails[i]=$"{Operations.foodDetailsList[i].FoodID},{Operations.foodDetailsList[i].FoodName},{Operations.foodDetailsList[i].PricePerQuantity},{Operations.foodDetailsList[i].QuantityAvailable}";
            }
            File.WriteAllLines("QwickFoodz/FoodDetails.csv",foodDetails);

            // Wrting the Order Details into OrderDetails.csv File
            string[] orderDetails=new string[Operations.orderDetailsList.Count];
            for(int i=0;i<Operations.orderDetailsList.Count;i++)
            {
                orderDetails[i]=$"{Operations.orderDetailsList[i].OrderID},{Operations.orderDetailsList[i].CustomerID},{Operations.orderDetailsList[i].TotalPrice},{Operations.orderDetailsList[i].DateOfOrder.ToString("dd/MM/yyyy")},{Operations.orderDetailsList[i].OrderStatus}";
            }
            File.WriteAllLines("QwickFoodz/OrderDetails.csv",orderDetails);

            // Wrting the Item Details into ItemDetails.csv File
            string[] itemDetails=new string[Operations.itemDetailsList.Count];
            for(int i=0;i<Operations.itemDetailsList.Count;i++)
            {
                itemDetails[i]=$"{Operations.itemDetailsList[i].ItemID},{Operations.itemDetailsList[i].OrderID},{Operations.itemDetailsList[i].FoodID},{Operations.itemDetailsList[i].PurchaseCount},{Operations.itemDetailsList[i].PriceOfOrder}";
            }
            File.WriteAllLines("QwickFoodz/ItemDetails.csv",itemDetails);
        }

        public static void ReadFromCSV()
        {
            // Reading Customer Details from CustomerDetails.csv File and storing it to customerDetailList
            string[] customerDetails=File.ReadAllLines("QwickFoodz/CustomerDetails.csv");
            foreach(string line in customerDetails)
            {
                if(line!=null)
                {
                    CustomerDetails customer=new CustomerDetails(line);
                    Operations.customerDetailsList.Add(customer);
                }
            }

            // Reading Food Details from FoodDetails.csv File and storing it to foodDetailList
            string[] foodDetails=File.ReadAllLines("QwickFoodz/FoodDetails.csv");
            foreach(string line in foodDetails)
            {
                if(line!=null)
                {
                    FoodDetails food=new FoodDetails(line);
                    Operations.foodDetailsList.Add(food);
                }
            }

            // Reading Order Details from OrderDetails.csv File and storing it to orderDetailList
            string[] orderDetails=File.ReadAllLines("QwickFoodz/OrderDetails.csv");
            foreach(string line in orderDetails)
            {
                if(line!=null)
                {
                    OrderDetails order=new OrderDetails(line);
                    Operations.orderDetailsList.Add(order);
                }
            }

            // Reading Item Details from ItemDetails.csv File and storing it to itemDetailList
            string[] itemDetails=File.ReadAllLines("QwickFoodz/ItemDetails.csv");
            foreach(string line in itemDetails)
            {
                if(line!=null)
                {
                    ItemDetails item=new ItemDetails(line);
                    Operations.itemDetailsList.Add(item);
                }
            }
        }
    }
}