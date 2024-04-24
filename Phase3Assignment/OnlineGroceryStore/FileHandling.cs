using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public static class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("OnlineGroceryStore"))
            {
                Directory.CreateDirectory("OnlineGroceryStore");
            }

            if (!File.Exists("OnlineGroceryStore/CustomerDetails.csv"))
            {
                File.Create("OnlineGroceryStore/CustomerDetails.csv").Close();
            }

            if (!File.Exists("OnlineGroceryStore/ProductDetails.csv"))
            {
                File.Create("OnlineGroceryStore/ProductDetails.csv").Close();
            }

            if (!File.Exists("OnlineGroceryStore/OrderDetails.csv"))
            {
                File.Create("OnlineGroceryStore/OrderDetails.csv").Close();
            }

            if (!File.Exists("OnlineGroceryStore/BookingDetails.csv"))
            {
                File.Create("OnlineGroceryStore/BookingDetails.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            string[] customerDetails = new string[Operations.customerList.Count];
            for (int i = 0; i < Operations.customerList.Count; i++)
            {
                customerDetails[i] = $"{Operations.customerList[i].CustomerID},{Operations.customerList[i].Name},{Operations.customerList[i].FatherName},{Operations.customerList[i].Gender},{Operations.customerList[i].Mobile},{Operations.customerList[i].DOB.ToString("dd/MM/yyyy")},{Operations.customerList[i].MailID},{Operations.customerList[i].WalletBalance}";
            }
            File.WriteAllLines("OnlineGroceryStore/CustomerDetails.csv", customerDetails);

            string[] productDetails = new string[Operations.productList.Count];
            for (int i = 0; i < Operations.productList.Count; i++)
            {
                productDetails[i] = $"{Operations.productList[i].ProductID},{Operations.productList[i].ProductName},{Operations.productList[i].QuantityAvailable},{Operations.productList[i].PricePerQuantity}";
            }
            File.WriteAllLines("OnlineGroceryStore/ProductDetails.csv", productDetails);

            string[] orderDetails = new string[Operations.orderList.Count];
            for (int i = 0; i < Operations.orderList.Count; i++)
            {
                orderDetails[i] = $"{Operations.orderList[i].OrderID},{Operations.orderList[i].BookingID},{Operations.orderList[i].ProductID},{Operations.orderList[i].PurchaseCount},{Operations.orderList[i].PriceOfOrder}";
            }
            File.WriteAllLines("OnlineGroceryStore/OrderDetails.csv", orderDetails);

            string[] bookingDetails = new string[Operations.bookingList.Count];
            for (int i = 0; i < Operations.bookingList.Count; i++)
            {
                bookingDetails[i] = $"{Operations.bookingList[i].BookingID},{Operations.bookingList[i].CustomerID},{Operations.bookingList[i].TotalPrice},{Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")},{Operations.bookingList[i].BookingStatus}";
            }
            File.WriteAllLines("OnlineGroceryStore/BookingDetails.csv", bookingDetails);
        }

        public static void ReadFromCSV()
        {
            string[] customerDetails=File.ReadAllLines("OnlineGroceryStore/CustomerDetails.csv");
            foreach(string line in customerDetails)
            {
                if(line!=null)
                {
                    CustomerRegistration customer=new CustomerRegistration(line);
                    Operations.customerList.Add(customer);
                }
            }

            string[] productDetails=File.ReadAllLines("OnlineGroceryStore/ProductDetails.csv");
            foreach(string line in productDetails)
            {
                if(line!=null)
                {
                    ProductDetails product=new ProductDetails(line);
                    Operations.productList.Add(product);
                }
            }

            string[] orderDetails=File.ReadAllLines("OnlineGroceryStore/OrderDetails.csv");
            foreach(string line in orderDetails)
            {
                if(line!=null)
                {
                    OrderDetails order=new OrderDetails(line);
                    Operations.orderList.Add(order);
                }
            }

            string[] bookingDetails=File.ReadAllLines("OnlineGroceryStore/BookingDetails.csv");
            foreach(string line in bookingDetails)
            {
                if(line!=null)
                {
                    BookingDetails booking=new BookingDetails(line);
                    Operations.bookingList.Add(booking);
                }
            }
        }
    }
}