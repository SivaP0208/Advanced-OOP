using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class Operations
    {
        // Creating static List for CustomerDetails to Add Customer Details
        public static CustomList<CustomerDetails> customerDetailsList = new CustomList<CustomerDetails>();

        // Creating static List for Food Details to Add Food Details
        public static CustomList<FoodDetails> foodDetailsList = new CustomList<FoodDetails>();

        // Creating static List for Order Details to Add Order Details
        public static CustomList<OrderDetails> orderDetailsList = new CustomList<OrderDetails>();

        // Creating static List for ItemDetails to Add Item Details
        public static CustomList<ItemDetails> itemDetailsList = new CustomList<ItemDetails>();

        // Declaring static CustomerDetails to store Current Logged In User Details
        static CustomerDetails currentLoggedInUser;

        // Method for Adding Default Data
        public static void AddDefaultData()
        {
            // Adding Default Data of Customer Details into CustomerDetails List 
            customerDetailsList.Add(new CustomerDetails("Ravi", "Ettaparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai", 10000));
            customerDetailsList.Add(new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai", 15000));

            // Adding Default Data of Food Details into FoodDetails List 
            foodDetailsList.Add(new FoodDetails("Chicken Briyani 1Kg", 100, 12));
            foodDetailsList.Add(new FoodDetails("Mutton Briyani 1Kg", 150, 10));
            foodDetailsList.Add(new FoodDetails("Veg Full Meals", 80, 30));
            foodDetailsList.Add(new FoodDetails("Noodles", 100, 40));
            foodDetailsList.Add(new FoodDetails("Dosa", 40, 40));
            foodDetailsList.Add(new FoodDetails("Idly (2 pieces)", 20, 50));
            foodDetailsList.Add(new FoodDetails("Pongal", 40, 20));
            foodDetailsList.Add(new FoodDetails("Vegetable Briyani", 80, 15));
            foodDetailsList.Add(new FoodDetails("Lemon Rice", 50, 30));
            foodDetailsList.Add(new FoodDetails("Veg Pulav", 120, 30));
            foodDetailsList.Add(new FoodDetails("Chicken 65 (200 Grams)", 75, 30));

            // Adding Default Data of Order Details into OrderDetails List 
            orderDetailsList.Add(new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered));
            orderDetailsList.Add(new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered));
            orderDetailsList.Add(new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled));

            // Adding Default Data of Item Details into ItemDetails List 
            itemDetailsList.Add(new ItemDetails("OID3001", "FID2001", 2, 200));
            itemDetailsList.Add(new ItemDetails("OID3001", "FID2002", 2, 300));
            itemDetailsList.Add(new ItemDetails("OID3001", "FID2003", 1, 80));
            itemDetailsList.Add(new ItemDetails("OID3002", "FID2001", 1, 100));
            itemDetailsList.Add(new ItemDetails("OID3002", "FID2002", 4, 600));
            itemDetailsList.Add(new ItemDetails("OID3002", "FID2010", 1, 120));
            itemDetailsList.Add(new ItemDetails("OID3002", "FID2009", 1, 50));
            itemDetailsList.Add(new ItemDetails("OID3003", "FID2002", 2, 300));
            itemDetailsList.Add(new ItemDetails("OID3003", "FID2008", 4, 320));
            itemDetailsList.Add(new ItemDetails("OID3003", "FID2001", 2, 200));
        }

        // Method for Main Menu
        public static void MainMenu()
        {
            Console.WriteLine("\n\t~~~~~~~~~~~~ Qwick Foodz ~~~~~~~~~~~~");
            bool exit = true;

            // Creating Basic Structure of Main Menu
            do
            {
                Console.WriteLine("\n\t\tMain Menu\n");
                Console.WriteLine("1. Customer Registration\n2. Customer Login\n3. Exit\n");

                // Prompting the Option from User
                Console.Write("Select the Option : ");
                int mainOption;
                while (!int.TryParse(Console.ReadLine(), out mainOption))
                {
                    Console.Write("Invalid Option please enter again : ");
                }
                switch (mainOption)
                {
                    case 1:
                        {
                            // If he Selects 1 Customer Registration Process will Be Started
                            Console.WriteLine("\n\t\tCustomer Registration\n");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            // If he Selects 2 Customer Login Process will be Started
                            Console.WriteLine("\n\t\tCustomer Login\n");
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            // If he selects 3 Apllication will be exit
                            exit = false;
                            Console.WriteLine("\n\t\tThank You !");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n\t\"Invalid Input\"");
                            break;
                        }
                }
            } while (exit);
        }
        
        // Method for Customer Registration
        public static void CustomerRegistration()
        {
            // Prompting the Details from User
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Father Name : ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Gender (Male/Female/Transgender) : ");
            Gender gender;
            while (!Enum.TryParse<Gender>(Console.ReadLine(), out gender) || !(gender == Gender.Male || gender == Gender.Female || gender == Gender.Transgender))
            {
                Console.Write("Invalid Gender please enter again : ");
            }
            Console.Write("Enter your Mobile Number : ");
            string mobile = Console.ReadLine();
            while (true)
            {
                if (mobile.Length == 10 && (mobile.StartsWith('6') || mobile.StartsWith('7') || mobile.StartsWith('8') || mobile.StartsWith('9')))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Mobile Number please enter again : ");
                    mobile = Console.ReadLine();
                }
            }
            Console.Write("Enter your Date of Birth (DD/MM/YYYY) : ");
            DateTime dob;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
            {
                Console.Write("Invalid Date please enter again : ");
            }
            Console.Write("Enter your Mail ID : ");
            string mailID = Console.ReadLine();
            while (true)
            {
                if (mailID.Contains("@gmail.com"))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Mail ID please enter again : ");
                    mailID = Console.ReadLine();
                }
            }
            Console.Write("Enter your Location : ");
            string location = Console.ReadLine();
            Console.Write("Enter your Balance : ");
            double balance;
            while (!double.TryParse(Console.ReadLine(), out balance) || !(balance > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }

            // Creating Customer Detail Instance using above details
            CustomerDetails customer = new CustomerDetails(name, fatherName, gender, mobile, dob, mailID, location, balance);

            // Adding Customer Detai Instance into Customer Detail List
            customerDetailsList.Add(customer);

            // Displaying the Message with Customer ID
            Console.WriteLine($"\n\t\"Customer Registration Successfull Your Customer ID : {customer.CustomerID}\"");
        }

        // Method for Customer Login
        public static void CustomerLogin()
        {
            // Prompting Customer ID from User to validate
            Console.Write("Enter your Customer ID : ");
            string customerID = Console.ReadLine().ToUpper();

            // Checking whether the Customer ID is Valid or not
            bool isValidCustomer = true;
            foreach (CustomerDetails customer in customerDetailsList)
            {
                if (customerID.Equals(customer.CustomerID))
                {
                    // If the user entered Customer ID is Valid Sub Menu will be displayed
                    isValidCustomer = false;
                    currentLoggedInUser = customer;
                    SubMenu();
                    break;
                }
            }
            if (isValidCustomer)
            {
                // If the Customer ID is invalid below message will be displayed
                Console.WriteLine("\n\t\"Invalid User ID\"");
            }
        }

        // Method for Sub Menu
        public static void SubMenu()
        {
            Console.WriteLine($"\n\t      Welcome {currentLoggedInUser.Name} !");
            bool mainMenu = true;

            // Creating Basic Structure of Sub Menu
            do
            {
                Console.WriteLine("\n\t\tSub Menu\n");
                Console.WriteLine("1. Show Profile\n2. Order Food\n3. Cancel Order\n4. Modify Order\n5. Order History\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit\n");

                // Prompting the Option from User
                Console.Write("Select the Option : ");
                int subOption;
                while (!int.TryParse(Console.ReadLine(), out subOption))
                {
                    Console.Write("Invalid Option please enter again : ");
                }
                switch (subOption)
                {
                    case 1:
                        {
                            // If user Selects 1 Customer Profile will be displayed
                            Console.WriteLine("\n\t\tCustomer Profile\n");
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            // If user Selects 2 Process of Order Food will be started
                            Console.WriteLine("\n\t\tOrder Food\n");
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            // If user selects 3 Process of Cancel Order will be started
                            Console.WriteLine("\n\t\t Cancel Order\n");
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            // If user selects 4 Process of Modify Order will be started
                            Console.WriteLine("\n\t\tModify Order\n");
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            // If user Selects 5 Order History will be Displayed
                            Console.WriteLine("\n\t\tOrder History\n");
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            // If user selects 6 Process of Recharging the Wallet will be started
                            Console.WriteLine("\n\tRecharge Wallet\n");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            // If user selects 7 Available Balance will be Displayed
                            Console.WriteLine("\n\t\t Wallet Balance\n");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            // If user selects 8 Sub Menu will be redirected to Main Menu
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n\t\"Invalid Input\"");
                            break;
                        }
                }
            } while (mainMenu);
        }

        // Method for Show Profile
        public static void ShowProfile()
        {
            // Displaying Customer Profile Details
            Console.WriteLine($"Customer ID : {currentLoggedInUser.CustomerID}");
            Console.WriteLine($"Customer Name : {currentLoggedInUser.Name}");
            Console.WriteLine($"Gender : {currentLoggedInUser.Gender}");
            Console.WriteLine($"Mobile : {currentLoggedInUser.Mobile}");
            Console.WriteLine($"Date Of Birth : {currentLoggedInUser.DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mail ID : {currentLoggedInUser.MailID}");
            Console.WriteLine($"Wallet Balance : {currentLoggedInUser.WalletBalance}");
        }

        // Method for Order Food
        public static void OrderFood()
        {
            // Creating Order Detail Instance 
            OrderDetails order = new OrderDetails(currentLoggedInUser.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            // Creating local Item Details List
            CustomList<ItemDetails> localItemList = new CustomList<ItemDetails>();
            string userWish = "";
            double totalPrice = 0;
            do
            {
                if (foodDetailsList != null)
                {
                    // Displaying Available Food Details 
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine($"| {"Food ID",-8}|      {"Food Name",-18}| {"PricePerQuantity",-17}| {"QuantityAvailable",-18}|");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    foreach (FoodDetails food in foodDetailsList)
                    {
                        if (food.QuantityAvailable > 0)
                        {
                            Console.WriteLine($"| {food.FoodID,-8}| {food.FoodName,-23}|       {food.PricePerQuantity,-11}|        {food.QuantityAvailable,-11}|");
                        }
                    }
                    Console.WriteLine("---------------------------------------------------------------------------\n");
                    
                    // Prompting Food ID to Order
                    Console.Write("Enter the Food ID : ");
                    string foodID = Console.ReadLine().ToUpper();

                    // Checking whether user entered Food ID is Valid or not
                    bool isValidFood = true;
                    foreach (FoodDetails food in foodDetailsList)
                    {
                        if (foodID.Equals(food.FoodID))
                        {
                            // If Food Id is Valid Prompting the needed Quantity from User
                            isValidFood = false;
                            Console.Write("Enter the Quantity : ");
                            int neededQuantity;
                            while (!int.TryParse(Console.ReadLine(), out neededQuantity) || !(neededQuantity > 0))
                            {
                                Console.Write("Invalid Quantity Number please enter again : ");
                            }

                            // Checking whether food is Available or not
                            if (food.QuantityAvailable >= neededQuantity)
                            {
                                ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, neededQuantity, food.PricePerQuantity * neededQuantity);
                                food.QuantityAvailable -= neededQuantity;
                                localItemList.Add(item);
                                totalPrice += item.PriceOfOrder;

                                // prompting whether user want order more
                                Console.Write("\nDo you want to order more (yes/no) : ");
                                userWish = Console.ReadLine().ToLower();
                                while (userWish == "yes" && userWish == "no")
                                {
                                    Console.Write("Invalid Input please enter again : ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\t\"Food Qunatity Unavailable\"");
                            }
                            break;
                        }
                    }
                    if (isValidFood)
                    {
                        Console.WriteLine("\n\t    \"Invalid Food ID\"");
                    }
                }
            } while (userWish == "yes");
            if (userWish == "no")
            {
                // prompting whether user want to confirm Purchase
                Console.Write("\nDo you want to confirm purchase (yes/no) : ");
                string confrimPurchase = Console.ReadLine().ToLower();
                while (confrimPurchase == "yes" && confrimPurchase == "no")
                {
                    Console.Write("Invalid Input please enter again : ");
                }
                if (confrimPurchase == "yes")
                {
                    // if user selects yes checking whether user having enough Balance to order
                    if (currentLoggedInUser.WalletBalance >= totalPrice)
                    {
                        // If he has Enough Balance Order will be Placed
                        currentLoggedInUser.DeductBalance(totalPrice);
                        order.TotalPrice = totalPrice;
                        order.OrderStatus = OrderStatus.Ordered;
                        itemDetailsList.AddRange(localItemList);
                        orderDetailsList.Add(order);

                        // Displaying the Message
                        Console.WriteLine("\n\t\"Order Placed Successfully\"");
                    }
                    else
                    {
                        // If user has insufficient balance asking user to recharge the wallet
                        Console.WriteLine("\n\t\"Wallet has Insufficient Balance\"");
                        Console.Write("\t\tDo you want to Recharge your Wallet (yes/no) : ");
                        string rechargeWish = Console.ReadLine().ToLower();
                        while (rechargeWish == "yes" && rechargeWish == "no")
                        {
                            Console.Write("Invalid Input please enter again : ");
                        }
                        if (rechargeWish == "yes")
                        {
                            Console.Write("Enter the Amount to Recharge the Wallet : ");
                            RechargeWallet();
                            currentLoggedInUser.DeductBalance(totalPrice);
                            order.TotalPrice = totalPrice;
                            order.OrderStatus = OrderStatus.Ordered;
                            itemDetailsList.AddRange(localItemList);
                            orderDetailsList.Add(order);
                            
                             // Displaying the Message
                            Console.WriteLine("\n\t\"Order Placed Successfully\"");
                        }
                        else
                        {
                            // Returning food quantity
                            foreach (ItemDetails item in localItemList)
                            {
                                foreach (FoodDetails food in foodDetailsList)
                                {
                                    if (item.FoodID.Equals(food.FoodID))
                                    {
                                        food.QuantityAvailable += item.PurchaseCount;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Returning food quantity
                    foreach (ItemDetails item in localItemList)
                    {
                        foreach (FoodDetails food in foodDetailsList)
                        {
                            if (item.FoodID.Equals(food.FoodID))
                            {
                                food.QuantityAvailable += item.PurchaseCount;
                            }
                        }
                    }
                }
            }
        }

        // Method to Show Order History
        public static void OrderHistory()
        {
            // Displaying the Order History of Current Logged In User
            bool isOrdered = false;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentLoggedInUser.CustomerID.Equals(order.CustomerID))
                {
                    isOrdered = true;
                    break;
                }
            }
            if (isOrdered)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"Customer ID",-12}| {"Total Price",-12}| {"Date of Order",-14}| {"OrderStatus",-12}|");
                Console.WriteLine("----------------------------------------------------------------------");
                foreach (OrderDetails order in orderDetailsList)
                {
                    if (currentLoggedInUser.CustomerID.Equals(order.CustomerID))
                    {
                        Console.WriteLine($"|  {order.OrderID,-8}|   {order.CustomerID,-10}|     {order.TotalPrice,-8}|  {order.DateOfOrder.ToString("dd/MM/yyyy"),-13}|  {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("----------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\t\"There is no Order History to Show\"");
            }
        }

        // Method for Recharge Wallet
        public static void RechargeWallet()
        {
            // prompting the amount to recharge the wallet
            Console.Write("Enter the Amount to Recharge Wallet : ");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount) || !(amount > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }
            currentLoggedInUser.WalletRecharge(amount);

            // Displaying the Message
            Console.WriteLine("\n\t\"Wallet Recharged\"");
        }

        // Method to Show Wallet Balance
        public static void ShowWalletBalance()
        {
            // Displaying Available Balance of Current Logged in User
            Console.WriteLine($"\t\"Your Available Wallet Balance : {currentLoggedInUser.WalletBalance}\"");
        }

        // Method to Cancel Order
        public static void CancelOrder()
        {
            bool isOrdered = false;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentLoggedInUser.CustomerID.Equals(order.CustomerID))
                {
                    isOrdered = true;
                    break;
                }
            }
            if (isOrdered)
            {
                // Displaying Order History of Current Logged in User
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"Customer ID",-12}| {"Total Price",-12}| {"Date of Order",-14}| {"OrderStatus",-12}|");
                Console.WriteLine("----------------------------------------------------------------------");
                foreach (OrderDetails order in orderDetailsList)
                {
                    if (currentLoggedInUser.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                    {
                        Console.WriteLine($"|  {order.OrderID,-8}|   {order.CustomerID,-10}|     {order.TotalPrice,-8}|  {order.DateOfOrder.ToString("dd/MM/yyyy"),-13}|  {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("----------------------------------------------------------------------\n");
                
                // prompting the Order ID to Cancel
                Console.Write("Enter the Order ID to Cancel : ");
                string orderID = Console.ReadLine().ToUpper();
                bool isVaildOrder = true;
                foreach (OrderDetails order1 in orderDetailsList)
                {
                    if (orderID.Equals(order1.OrderID) && order1.OrderStatus == OrderStatus.Ordered)
                    {
                        isVaildOrder = false;
                        order1.OrderStatus = OrderStatus.Cancelled;
                        currentLoggedInUser.WalletRecharge(order1.TotalPrice);
                        foreach (ItemDetails item in itemDetailsList)
                        {
                            if (item.OrderID.Equals(order1.OrderID))
                            {
                                foreach (FoodDetails food in foodDetailsList)
                                {
                                    if (item.FoodID.Equals(food.FoodID))
                                    {
                                        food.QuantityAvailable += item.PurchaseCount;
                                        break;
                                    }
                                }
                            }
                        }
                        // Displaying the Message
                        Console.WriteLine("\n\t\"Order Cancelled Successfully\"");
                        break;
                    }
                }
                if (isVaildOrder)
                {
                    Console.WriteLine("\n\t\"Invalid Order ID \"");
                }
            }
            else
            {
                Console.WriteLine("\t\"There is no Order History to Cancel\"");
            }

        }

        // Method to Modify Order
        public static void ModifyOrder()
        {
            bool isOrdered = false;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentLoggedInUser.CustomerID.Equals(order.CustomerID))
                {
                    isOrdered = true;
                    break;
                }
            }
            // Displaying Order History of Current Logged In user
            if (isOrdered)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"Customer ID",-12}| {"Total Price",-12}| {"Date of Order",-14}| {"OrderStatus",-12}|");
                Console.WriteLine("----------------------------------------------------------------------");
                foreach (OrderDetails order in orderDetailsList)
                {
                    if (currentLoggedInUser.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                    {
                        Console.WriteLine($"|  {order.OrderID,-8}|   {order.CustomerID,-10}|     {order.TotalPrice,-8}|  {order.DateOfOrder.ToString("dd/MM/yyyy"),-13}|  {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("----------------------------------------------------------------------\n");
                
                // Prompting the Order ID to Modify
                Console.Write("Enter the Order ID to Modify : ");
                string orderID = Console.ReadLine().ToUpper();
                bool isValidOrder = true;
                foreach (OrderDetails order in orderDetailsList)
                {
                    if (orderID.Equals(order.OrderID) && order.OrderStatus == OrderStatus.Ordered)
                    {
                        // Displaying the Item details using Order ID
                        isValidOrder = false;
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine($"| {"Item ID",-9}| {"Order ID",-9}| {"Food ID",-8}| {"Purchase Count",-15}| {"Price Of Order",-15}|");
                        Console.WriteLine("-------------------------------------------------------------------");
                        foreach (ItemDetails item in itemDetailsList)
                        {
                            if (order.OrderID.Equals(item.OrderID))
                            {
                                Console.WriteLine($"| {item.ItemID,-9}| {item.OrderID,-9}| {item.FoodID,-8}|       {item.PurchaseCount,-9}|      {item.PriceOfOrder,-10}|");
                            }
                        }
                        Console.WriteLine("-------------------------------------------------------------------\n");
                        
                        // Prompting Item ID To modify
                        Console.Write("Enter the Item ID to Modify : ");
                        string itemID = Console.ReadLine().ToUpper();
                        bool isValidItem = true;
                        foreach (ItemDetails item in itemDetailsList)
                        {
                            if (itemID.Equals(item.ItemID))
                            {
                                isValidItem = false;
                                
                                // Prompting the New Quantity to modify
                                Console.Write("Enter the New purchase Quantity : ");
                                int modifiedQuantity;
                                while (!int.TryParse(Console.ReadLine(), out modifiedQuantity) || !(modifiedQuantity > 0))
                                {
                                    Console.Write("Invalid Quantity Number please enter again : ");
                                }
                                int quantityUpdate = item.PurchaseCount - modifiedQuantity;
                                foreach (FoodDetails food in foodDetailsList)
                                {
                                    if (item.FoodID.Equals(food.FoodID))
                                    {
                                        item.PriceOfOrder = food.PricePerQuantity * modifiedQuantity;
                                        if (quantityUpdate > 0)
                                        {
                                            food.QuantityAvailable += Math.Abs(quantityUpdate);
                                            currentLoggedInUser.WalletRecharge(food.PricePerQuantity * Math.Abs(quantityUpdate));
                                        }
                                        else
                                        {
                                            food.QuantityAvailable -= Math.Abs(quantityUpdate);
                                            currentLoggedInUser.DeductBalance(food.PricePerQuantity * Math.Abs(quantityUpdate));
                                        }
                                        Console.WriteLine("\n\t\"Order Modified Successfully\"");
                                        break;

                                    }
                                }
                                break;
                            }
                        }
                        if (isValidItem)
                        {
                            Console.WriteLine("\n\t\"Invalid Item ID \"");
                        }
                        break;
                    }
                }
                if (isValidOrder)
                {
                    Console.WriteLine("\n\t\"Invalid Order ID\"");
                }
            }
            else
            {
                Console.WriteLine("\t\"There is no Order History to Modify\"");
            }
        }
    }
}