using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public static class Operations
    {
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static CustomList<CartItem> cartItemList = new CustomList<CartItem>();
        public static void AddDefaultData()
        {
            userList.Add(new UserDetails("Ravichandran", "Ettaparajan", 8857777575L, "ravi@gmail.com", Gender.Male, "WS101", 400));
            userList.Add(new UserDetails("Baskaran", "Sethurajan", 9577747744L, "baskaran@gmail.com", Gender.Male, "WS105", 500));

            foodList.Add(new FoodDetails("Coffee", 20, 100));
            foodList.Add(new FoodDetails("Tea", 15, 100));
            foodList.Add(new FoodDetails("Biscuit", 10, 100));
            foodList.Add(new FoodDetails("Juice", 50, 100));
            foodList.Add(new FoodDetails("Puff", 40, 100));
            foodList.Add(new FoodDetails("Milk", 10, 100));
            foodList.Add(new FoodDetails("Popcorn", 20, 20));

            orderList.Add(new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderStatus.Ordered));
            orderList.Add(new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderStatus.Ordered));

            cartItemList.Add(new CartItem("OID1001", "FID101", 20, 1));
            cartItemList.Add(new CartItem("OID1001", "FID103", 10, 1));
            cartItemList.Add(new CartItem("OID1001", "FID105", 40, 1));
            cartItemList.Add(new CartItem("OID1002", "FID103", 10, 1));
            cartItemList.Add(new CartItem("OID1002", "FID104", 50, 1));
            cartItemList.Add(new CartItem("OID1002", "FID105", 40, 1));
        }

        public static void MainMenu()
        {
            Console.WriteLine("\n\t~~~~~~~~~~~ Cafeteria Card Management ~~~~~~~~~~~");
            bool exit = true;
            do
            {
                Console.WriteLine("\n\t\t\tMain Menu\n");
                Console.WriteLine("1. User Registration\n2. User Login\n3. Exit\n");
                int mainOption;
                while (!int.TryParse(Console.ReadLine(), out mainOption))
                {
                    Console.WriteLine("\n\t\t     Invalid Input");
                    Console.WriteLine("\n\t\t\tMain Menu\n");
                    Console.WriteLine("1. User Registration\n2. User Login\n3. Exit\n");
                }
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\t\tUser Registration\n");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\t\tUser Login\n");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            exit = false;
                            Console.WriteLine("\n\t\t Thank You !\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n\t\tInvalid Input");
                            break;
                        }
                }
            } while (exit);
        }

        public static void UserRegistration()
        {
            PersonalDetails personalDetails = new PersonalDetails();

            Console.Write("Enter your Name : ");
            personalDetails.Name = Console.ReadLine();

            Console.Write("Enter your Father Name : ");
            personalDetails.FatherName = Console.ReadLine();

            Console.Write("Enter your Mobile Number : ");
            long mobileNumber;
            while (!long.TryParse(Console.ReadLine(), out mobileNumber) || !(mobileNumber >= 6000000000 && mobileNumber <= 9999999999))
            {
                Console.Write("Invalid Mobile Number please enter again : ");
            }
            personalDetails.MobileNumber = mobileNumber;

            Console.Write("Enter your Mail ID : ");
            string mailID = Console.ReadLine().ToLower();
            while (true)
            {
                if (mailID.Contains("@gmail.com"))
                {
                    personalDetails.MailID = mailID;
                    break;
                }
                else
                {
                    Console.Write("Invalid Mail ID please enter again : ");
                    mailID = Console.ReadLine();
                }
            }

            Console.Write("Enter your Gender (Male/Female/Transgender) : ");
            Gender gender;
            while (!Enum.TryParse<Gender>(Console.ReadLine(), true, out gender) || !(gender == Gender.Male || gender == Gender.Female || gender == Gender.Transgender))
            {
                Console.Write("Invalid Gender please enter again : ");
            }
            personalDetails.Gender = gender;

            Console.Write("Enter your WorkStation Number in (WS???): ");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || !(result >= 100 && result <= 999))
            {
                Console.Write("Invalid WorkStation Number please enter again : ");
            }
            string workStationNumber = "WS" + result;

            Console.Write("Enter your Wallet Balance : ");
            double walletBalance;
            while (!double.TryParse(Console.ReadLine(), out walletBalance) || !(walletBalance > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }

            UserDetails user = new UserDetails(personalDetails.Name, personalDetails.FatherName, personalDetails.MobileNumber, personalDetails.MailID, personalDetails.Gender, workStationNumber, walletBalance);
            userList.Add(user);

            Console.WriteLine($"\n\tUser Registered Successfully and User ID is : {user.UserID}");
        }

        public static void UserLogin()
        {
            Console.Write("Enter your User ID : ");
            string loginID = Console.ReadLine().ToUpper();
            UserDetails user = UserBinarySearch(loginID);
            if (user != null)
            {
                SubMenu(user);
            }
            else
            {
                Console.WriteLine("\n\tInvalid User ID or Registration not completed");
            }
        }

        public static void SubMenu(UserDetails user)
        {
            Console.WriteLine($"\n\tWelcome {user.Name} !");
            bool mainMenu = true;
            do
            {
                Console.WriteLine("\n\t\tSub Menu\n");
                Console.WriteLine("a. Show My Profile\nb. Food Order\nc. Modify Order\nd. Cancel Order\ne. Order History\nf. Wallet Recharge\ng. Show WalletBalance\nh. Back to Main Menu\n");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        {
                            Console.WriteLine("\n\tMy Profile\n");
                            ShowMyProfie(user);
                            break;
                        }
                    case "b":
                        {
                            Console.WriteLine("\n\t\tFood Order");
                            FoodOrder(user);
                            break;
                        }
                    case "c":
                        {
                            Console.WriteLine("\n\t\tModify Order\n");
                            ModifyOrder(user);
                            break;
                        }
                    case "d":
                        {
                            Console.WriteLine("\n\t\tCancel Order\n");
                            CancelOrder(user);
                            break;
                        }
                    case "e":
                        {
                            Console.WriteLine("\n\t\tOrder History\n");
                            OrderHistory(user);
                            break;
                        }
                    case "f":
                        {
                            Console.WriteLine("\n\t\tWallet Recharge\n");
                            WalletRecharge(user);
                            break;
                        }
                    case "g":
                        {
                            Console.WriteLine("\n\t\t\tWalletBalance");
                            ShowWalletBalance(user);
                            break;
                        }
                    case "h":
                        {
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n\tInvalid Input");
                            break;
                        }
                }
            } while (mainMenu);
        }

        public static void ShowMyProfie(UserDetails user)
        {
            Console.WriteLine($"User ID            : {user.UserID}");
            Console.WriteLine($"User Name          : {user.Name}");
            Console.WriteLine($"Father Name        : {user.FatherName}");
            Console.WriteLine($"User ID            : {user.Name}");
            Console.WriteLine($"Mobile Number      : {user.MobileNumber}");
            Console.WriteLine($"Mail ID            : {user.MailID}");
            Console.WriteLine($"Gender             : {user.Gender}");
            Console.WriteLine($"Workstation Number : {user.WorkStationNumber}");
            Console.WriteLine($"Wallet Balance     : {user.WalletBalance}");
        }

        public static void FoodOrder(UserDetails user)
        {
            if (foodList != null)
            {
                bool flag = true;
                CustomList<CartItem> tempCart = new CustomList<CartItem>();
                OrderDetails order = new OrderDetails(user.UserID, DateTime.Now, 0, OrderStatus.Initiated);
                do
                {
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine($"| {"Food ID",-8}| {"Food Name",-10}| {"Price",-6}| {"Available Quantity",-19}|");
                    Console.WriteLine("----------------------------------------------------");
                    foreach (FoodDetails food in foodList)
                    {
                        Console.WriteLine($"|  {food.FoodID,-7}|  {food.FoodName,-9}|   {food.FoodPrice,-4}|       {food.AvailableQuantity,-13}|");
                    }
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("Enter the Food ID to Order : ");
                    string foodID = Console.ReadLine().ToUpper();
                    FoodDetails foodDetails = FoodBinarySearch(foodID);
                    if (foodDetails != null)
                    {
                        Console.Write("Enter the Qunatity needed : ");
                        int quantityNeeded;
                        while (!int.TryParse(Console.ReadLine(), out quantityNeeded) || !(quantityNeeded > 0))
                        {
                            Console.Write("Invalid Number please enter again : ");
                        }
                        if (foodDetails.AvailableQuantity >= quantityNeeded)
                        {
                            foodDetails.AvailableQuantity -= quantityNeeded;
                            CartItem cartItem = new CartItem(order.OrderID, foodDetails.FoodID, foodDetails.FoodPrice * quantityNeeded, quantityNeeded);
                            tempCart.Add(cartItem);
                            Console.Write("Do you want to pick another Food (yes/no): ");
                            string userWish = Console.ReadLine().ToLower();
                            while (!userWish.Equals("yes") && !userWish.Equals("no"))
                            {
                                Console.Write("Invalid Input please enter again : ");
                                userWish = Console.ReadLine().ToLower();
                            }
                            if (userWish.Equals("yes"))
                            {
                                flag = true;
                            }
                            else if (userWish.Equals("no"))
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\tRequired quantity is Not Available");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t     Invalid Food ID");
                    }
                } while (flag);

                Console.Write("\nConfirm Order to Purchase (yes/no) : ");
                string confirmOrder = Console.ReadLine().ToLower();
                while (!confirmOrder.Equals("yes") && !confirmOrder.Equals("no"))
                {
                    Console.Write("Invalid Input please enter again : ");
                    confirmOrder = Console.ReadLine().ToLower();
                }
                if (confirmOrder.Equals("yes"))
                {
                    double totalPrice = 0;
                    foreach (CartItem cart in tempCart)
                    {
                        totalPrice += cart.OrderPrice;
                    }
                    if (user.WalletBalance >= totalPrice)
                    {
                        user.DeductAmount(totalPrice);
                        cartItemList.AddRange(tempCart);
                        order.TotalPrice = totalPrice;
                        order.OrderStatus = OrderStatus.Ordered;
                        orderList.Add(order);
                        Console.WriteLine($"\n  \"Order Placed Successfully and Order ID is {order.OrderID}\"");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\"Insufficient Balance to purchase\"");
                        Console.Write("\tAre you Willing to Recharge your Wallet (yes/no) : ");
                        string rechargeWish = Console.ReadLine().ToLower();
                        while (!rechargeWish.Equals("yes") && !rechargeWish.Equals("no"))
                        {
                            Console.Write("Invalid Input please enter again : ");
                            rechargeWish = Console.ReadLine().ToLower();
                        }
                        if (rechargeWish.Equals("yes"))
                        {
                            Console.Write("Enter the Amount to recharge : ");
                            double rechargeAmount = 0;
                            while (!double.TryParse(Console.ReadLine(), out rechargeAmount) || !(rechargeAmount > 0))
                            {
                                Console.Write("Invalid Amount please enter a valid Amount : ");
                            }
                            user.WalletRecharge(rechargeAmount);
                        }
                        else
                        {
                            Console.WriteLine("\n\t\"Exiting Without Order due to Insufficient Balance\"");
                        }

                    }
                }
                else
                {
                    foreach (CartItem cart in tempCart)
                    {
                        foreach (FoodDetails food in foodList)
                        {
                            if (cart.FoodID.Equals(food.FoodID))
                            {
                                food.AvailableQuantity += cart.OrderQuantity;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\tThere is no Food to Order");
            }
        }

        public static void ModifyOrder(UserDetails user)
        {
            if (OrderHistory(user))
            {
                Console.Write("\nEnter the Order ID to Modify : ");
                string orderID = Console.ReadLine().ToUpper();
                OrderDetails order = OrderBinarySearch(orderID);
                if (order != null)
                {
                    Console.WriteLine("\n---------------------------------------------------------------");
                    Console.WriteLine($"| {"Item ID",-8}| {"Order ID",-9}| {"Food ID",-8}| {"Order Price",-12}| {"Order Quantity",-15}|");
                    Console.WriteLine("---------------------------------------------------------------");
                    foreach (CartItem cart in cartItemList)
                    {
                        if (order.OrderID.Equals(cart.OrderID))
                        {
                            Console.WriteLine($"| {cart.ItemID,-8}| {cart.OrderID,-9}| {cart.FoodID,-8}|      {cart.OrderPrice,-7}|       {cart.OrderQuantity,-9}|");
                        }
                    }
                    Console.WriteLine("---------------------------------------------------------------\n");

                    Console.Write("Enter the Item ID to Modify : ");
                    string itemID = Console.ReadLine().ToUpper();
                    CartItem cartItem = CartItemBinarySearch(itemID);
                    if (cartItem != null)
                    {
                        FoodDetails food = FoodBinarySearch(cartItem.FoodID);
                        Console.Write("Enter the new Quantity to Modify : ");
                        int modifiedQuantity;
                        while (!int.TryParse(Console.ReadLine(), out modifiedQuantity) || !(modifiedQuantity + cartItem.OrderQuantity >= 0))
                        {
                            Console.Write("Invalid Quantity Number please enter again : ");
                        }
                        if (food.AvailableQuantity >= modifiedQuantity)
                        {
                            user.WalletRecharge(order.TotalPrice);
                            if (user.WalletBalance >= order.TotalPrice + (food.FoodPrice * modifiedQuantity))
                            {
                                cartItem.OrderQuantity = modifiedQuantity;
                                cartItem.OrderPrice = food.FoodPrice * cartItem.OrderQuantity;
                                order.TotalPrice = 0;
                                foreach (CartItem cart in cartItemList)
                                {
                                    if (order.OrderID.Equals(cart.OrderID))
                                    {
                                        order.TotalPrice += cart.OrderPrice;
                                    }
                                }
                                order.OrderStatus=OrderStatus.Ordered;
                                user.DeductAmount(order.TotalPrice);
                                Console.WriteLine($"\n\t\"Order Modified Successfully\"");
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\"Insufficient Balance to purchase\"");
                                Console.Write("\tAre you Willing to Recharge your Wallet (yes/no) : ");
                                string rechargeWish = Console.ReadLine().ToLower();
                                while (!rechargeWish.Equals("yes") && !rechargeWish.Equals("no"))
                                {
                                    Console.Write("Invalid Input please enter again : ");
                                    rechargeWish = Console.ReadLine().ToLower();
                                }
                                if (rechargeWish.Equals("yes"))
                                {
                                    Console.Write("Enter the Amount to recharge : ");
                                    double rechargeAmount = 0;
                                    while (!double.TryParse(Console.ReadLine(), out rechargeAmount) || !(rechargeAmount > 0))
                                    {
                                        Console.Write("Invalid Amount please enter a valid Amount : ");
                                    }
                                    user.WalletRecharge(rechargeAmount);
                                }
                                else
                                {
                                    Console.WriteLine("\n\t\"Exiting Without Modifying Order due to Insufficient Balance\"");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\tRequired Quantity is not Available");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\n\tInvalid Item ID");
                    }

                }
                else
                {
                    Console.WriteLine("\n\tInvaid Order ID");
                }
            }
        }

        public static void CancelOrder(UserDetails user)
        {
            if (OrderHistory(user))
            {
                Console.Write("\nEnter the Order ID to Cancel : ");
                string orderID = Console.ReadLine().ToUpper();
                OrderDetails order = OrderBinarySearch(orderID);
                if (order != null)
                {
                    user.WalletRecharge(order.TotalPrice);
                    foreach (CartItem cart in cartItemList)
                    {
                        if (order.OrderID.Equals(cart.OrderID))
                        {
                            foreach (FoodDetails food in foodList)
                            {
                                if (cart.FoodID.Equals(food.FoodID))
                                {
                                    food.AvailableQuantity += cart.OrderQuantity;
                                }
                            }
                        }
                    }
                    order.OrderStatus = OrderStatus.Cancelled;
                    Console.WriteLine("\n\t\"Order Cancelled Successfully\"");
                }
                else
                {
                    Console.WriteLine("\n\t Invalid Order ID");
                }
            }
        }

        public static bool OrderHistory(UserDetails user)
        {
            bool isOrdered = false;
            foreach (OrderDetails order in orderList)
            {
                if (user.UserID.Equals(order.UserID))
                {
                    isOrdered = true;
                    break;
                }
            }
            if (isOrdered)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"Order Date",-11}| {"Total Price",-12}| {"Order Status",-13}|");
                Console.WriteLine("------------------------------------------------------");
                foreach (OrderDetails order in orderList)
                {
                    if (user.UserID.Equals(order.UserID) && order.OrderStatus == OrderStatus.Ordered)
                    {
                        Console.WriteLine($"| {order.OrderID,-9}| {order.OrderDate.ToString("dd/MM/yyyy"),-11}|    {order.TotalPrice,-9}|   {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("------------------------------------------------------");
                return isOrdered;
            }
            else
            {
                Console.WriteLine("\tNo Orders has been made by You to Show");
                return isOrdered;
            }
        }

        public static void WalletRecharge(UserDetails user)
        {
            Console.Write("\tAre you Willing to Recharge your Wallet (yes/no) : ");
            string rechargeWish = Console.ReadLine().ToLower();
            while (!rechargeWish.Equals("yes") && !rechargeWish.Equals("no"))
            {
                Console.Write("Invalid Input please enter again : ");
                rechargeWish = Console.ReadLine().ToLower();
            }
            if (rechargeWish.Equals("yes"))
            {
                Console.Write("Enter the Amount to recharge : ");
                double rechargeAmount = 0;
                while (!double.TryParse(Console.ReadLine(), out rechargeAmount) || !(rechargeAmount > 0))
                {
                    Console.Write("Invalid Amount please enter a valid Amount : ");
                }
                user.WalletRecharge(rechargeAmount);
                Console.WriteLine("\n\t\"Wallet Recharged Successfully\"");
            }
        }

        public static void ShowWalletBalance(UserDetails user)
        {
            Console.WriteLine($"\n\t\"Your Available Wallet Balance is : {user.WalletBalance}\"");
        }

        public static UserDetails UserBinarySearch(string userID)
        {
            // Sorting the List based on User Id
            for (int i = 0; i < userList.Count - 1; i++)
            {
                for (int j = i + 1; j < userList.Count; j++)
                {
                    if (userList[i].UserID.CompareTo(userList[j].UserID) == -1)
                    {
                        UserDetails temp = userList[j];
                        userList[j] = userList[i];
                        userList[i] = temp;
                    }
                }
            }
            UserDetails user = null;
            int lowerIndex = 0;
            int higherIndex = userList.Count - 1;
            int middleIndex = (lowerIndex + higherIndex) / 2;
            while (higherIndex >= lowerIndex)
            {
                if (userID.Equals((userList[middleIndex]).UserID))
                {
                    user = userList[middleIndex];
                    break;
                }
                else if (userID.CompareTo(userList[middleIndex].UserID) == 1)
                {
                    higherIndex = middleIndex - 1;
                }
                else if (userID.CompareTo(userList[middleIndex].UserID) == -1)
                {
                    lowerIndex = middleIndex + 1;
                }
                middleIndex = (lowerIndex + higherIndex) / 2;
            }
            return user;
        }

        public static FoodDetails FoodBinarySearch(string foodID)
        {
            // Sorting the List based on Food Id
            for (int i = 0; i < foodList.Count - 1; i++)
            {
                for (int j = i + 1; j < foodList.Count; j++)
                {
                    if (foodList[i].FoodID.CompareTo(foodList[j].FoodID) == 1)
                    {
                        FoodDetails temp = foodList[j];
                        foodList[j] = foodList[i];
                        foodList[i] = temp;
                    }
                }
            }
            FoodDetails food = null;
            int lowerIndex = 0;
            int higherIndex = foodList.Count - 1;
            int middleIndex = (lowerIndex + higherIndex) / 2;
            while (higherIndex >= lowerIndex)
            {
                if (foodID.Equals((foodList[middleIndex]).FoodID))
                {
                    food = foodList[middleIndex];
                    break;
                }
                else if (foodID.CompareTo(foodList[middleIndex].FoodID) == -1)
                {
                    higherIndex = middleIndex - 1;
                }
                else if (foodID.CompareTo(foodList[middleIndex].FoodID) == 1)
                {
                    lowerIndex = middleIndex + 1;
                }
                middleIndex = (lowerIndex + higherIndex) / 2;
            }
            return food;
        }

        public static OrderDetails OrderBinarySearch(string orderID)
        {
            // Sorting the List based on Order Id
            for (int i = 0; i < orderList.Count - 1; i++)
            {
                for (int j = i + 1; j < orderList.Count; j++)
                {
                    if (orderList[i].OrderID.CompareTo(orderList[j].OrderID) == 1)
                    {
                        OrderDetails temp = orderList[j];
                        orderList[j] = orderList[i];
                        orderList[i] = temp;
                    }
                }
            }
            OrderDetails order = null;
            int lowerIndex = 0;
            int higherIndex = orderList.Count - 1;
            int middleIndex = (lowerIndex + higherIndex) / 2;
            while (higherIndex >= lowerIndex)
            {
                if (orderID.Equals((orderList[middleIndex]).OrderID))
                {
                    order = orderList[middleIndex];
                    break;
                }
                else if (orderID.CompareTo(orderList[middleIndex].OrderID) == -1)
                {
                    higherIndex = middleIndex - 1;
                }
                else if (orderID.CompareTo(orderList[middleIndex].OrderID) == 1)
                {
                    lowerIndex = middleIndex + 1;
                }
                middleIndex = (lowerIndex + higherIndex) / 2;
            }
            return order;
        }

        public static CartItem CartItemBinarySearch(string cartItemID)
        {
            // Sorting the List based on Item Id
            for (int i = 0; i < cartItemList.Count - 1; i++)
            {
                for (int j = i + 1; j < cartItemList.Count; j++)
                {
                    if (cartItemList[i].OrderID.CompareTo(cartItemList[j].OrderID) == 1)
                    {
                        CartItem temp = cartItemList[j];
                        cartItemList[j] = cartItemList[i];
                        cartItemList[i] = temp;
                    }
                }
            }
            CartItem cartItem = null;
            int lowerIndex = 0;
            int higherIndex = cartItemList.Count - 1;
            int middleIndex = (lowerIndex + higherIndex) / 2;
            while (higherIndex >= lowerIndex)
            {
                if (cartItemID.Equals((cartItemList[middleIndex]).ItemID))
                {
                    cartItem = cartItemList[middleIndex];
                    break;
                }
                else if (cartItemID.CompareTo(cartItemList[middleIndex].ItemID) == -1)
                {
                    higherIndex = middleIndex - 1;
                }
                else if (cartItemID.CompareTo(cartItemList[middleIndex].ItemID) == 1)
                {
                    lowerIndex = middleIndex + 1;
                }
                middleIndex = (lowerIndex + higherIndex) / 2;
            }
            return cartItem;
        }
    }
}