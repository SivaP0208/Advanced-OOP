using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public static class FileHanding
    {
        public static void Create()
        {
            if (!Directory.Exists("CafeteriaCardManagement"))
            {
                Directory.CreateDirectory("CafeteriaCardManagement");
            }

            if (!File.Exists("CafeteriaCardManagement/UserDetails.csv"))
            {
                File.Create("CafeteriaCardManagement/UserDetails.csv").Close();
            }

            if (!File.Exists("CafeteriaCardManagement/FoodDetails.csv"))
            {
                File.Create("CafeteriaCardManagement/FoodDetails.csv").Close();
            }

            if (!File.Exists("CafeteriaCardManagement/OrderDetails.csv"))
            {
                File.Create("CafeteriaCardManagement/OrderDetails.csv").Close();
            }

            if (!File.Exists("CafeteriaCardManagement/CartItemDetails.csv"))
            {
                File.Create("CafeteriaCardManagement/CartItemDetails.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            string[] userDetails = new string[Operations.userList.Count];
            for (int i = 0; i < Operations.userList.Count; i++)
            {
                userDetails[i] = $"{Operations.userList[i].UserID},{Operations.userList[i].Name},{Operations.userList[i].FatherName},{Operations.userList[i].MobileNumber},{Operations.userList[i].MailID},{Operations.userList[i].Gender},{Operations.userList[i].WorkStationNumber},{Operations.userList[i].WalletBalance}";
            }
            File.WriteAllLines("CafeteriaCardManagement/UserDetails.csv", userDetails);

            string[] foodDetails = new string[Operations.foodList.Count];
            for (int i = 0; i < Operations.foodList.Count; i++)
            {
                foodDetails[i] = $"{Operations.foodList[i].FoodID},{Operations.foodList[i].FoodName},{Operations.foodList[i].FoodPrice},{Operations.foodList[i].AvailableQuantity}";
            }
            File.WriteAllLines("CafeteriaCardManagement/FoodDetails.csv", foodDetails);

            string[] orderDetails = new string[Operations.orderList.Count];
            for (int i = 0; i < Operations.orderList.Count; i++)
            {
                orderDetails[i] = $"{Operations.orderList[i].OrderID},{Operations.orderList[i].UserID},{Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")},{Operations.orderList[i].TotalPrice},{Operations.orderList[i].OrderStatus}";
            }
            File.WriteAllLines("CafeteriaCardManagement/OrderDetails.csv", orderDetails);

            string[] cartItemDetails = new string[Operations.cartItemList.Count];
            for (int i = 0; i < Operations.cartItemList.Count; i++)
            {
                cartItemDetails[i] = $"{Operations.cartItemList[i].ItemID},{Operations.cartItemList[i].OrderID},{Operations.cartItemList[i].FoodID},{Operations.cartItemList[i].OrderPrice},{Operations.cartItemList[i].OrderQuantity}";
            }
            File.WriteAllLines("CafeteriaCardManagement/CartItemDetails.csv", cartItemDetails);
        }

        public static void ReadFromCSV()
        {
            string[] userDetails = File.ReadAllLines("CafeteriaCardManagement/UserDetails.csv");
            foreach (string user in userDetails)
            {
                UserDetails user1 = new UserDetails(user);
                Operations.userList.Add(user1);
            }

            string[] foodDetails = File.ReadAllLines("CafeteriaCardManagement/FoodDetails.csv");
            foreach (string food in foodDetails)
            {
                FoodDetails food1 = new FoodDetails(food);
                Operations.foodList.Add(food1);
            }

            string[] orderDetails = File.ReadAllLines("CafeteriaCardManagement/OrderDetails.csv");
            foreach (string order in orderDetails)
            {
                OrderDetails order1 = new OrderDetails(order);
                Operations.orderList.Add(order1);
            }

            string[] cartItemDetails = File.ReadAllLines("CafeteriaCardManagement/CartItemDetails.csv");
            foreach (string cart in cartItemDetails)
            {
                CartItem cartItem = new CartItem(cart);
                Operations.cartItemList.Add(cartItem);
            }
        }
    }
}