using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public static class Operations
    {
        public static CustomList<CustomerRegistration> customerList = new CustomList<CustomerRegistration>();
        public static CustomList<ProductDetails> productList = new CustomList<ProductDetails>();
        public static CustomList<BookingDetails> bookingList = new CustomList<BookingDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static void AddDefaultData()
        {
            customerList.Add(new CustomerRegistration("Ravi", "Ettaparajan", Gender.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com", 10000));
            customerList.Add(new CustomerRegistration("Baskaran", "Sethurajan", Gender.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com", 15000));

            productList.Add(new ProductDetails("Sugar", 20, 40));
            productList.Add(new ProductDetails("Rice", 100, 50));
            productList.Add(new ProductDetails("Milk", 10, 40));
            productList.Add(new ProductDetails("Coffee", 10, 10));
            productList.Add(new ProductDetails("Tea", 10, 10));
            productList.Add(new ProductDetails("Masala Powder", 10, 20));
            productList.Add(new ProductDetails("Salt", 10, 10));
            productList.Add(new ProductDetails("Turmeric Powder", 10, 25));
            productList.Add(new ProductDetails("Chiili Powder", 10, 20));
            productList.Add(new ProductDetails("Groundnut Oil", 10, 140));

            bookingList.Add(new BookingDetails("CID1001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked));
            bookingList.Add(new BookingDetails("CID1002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked));
            bookingList.Add(new BookingDetails("CID1001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled));
            bookingList.Add(new BookingDetails("CID1002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated));

            orderList.Add(new OrderDetails("BID3001", "PID2001", 2, 80));
            orderList.Add(new OrderDetails("BID3001", "PID2002", 2, 100));
            orderList.Add(new OrderDetails("BID3001", "PID2003", 1, 40));
            orderList.Add(new OrderDetails("BID3002", "PID2001", 1, 40));
            orderList.Add(new OrderDetails("BID3002", "PID2002", 4, 200));
            orderList.Add(new OrderDetails("BID3002", "PID2010", 1, 140));
            orderList.Add(new OrderDetails("BID3002", "PID2009", 1, 20));
            orderList.Add(new OrderDetails("BID3003", "PID2002", 2, 100));
            orderList.Add(new OrderDetails("BID3003", "PID2008", 4, 100));
            orderList.Add(new OrderDetails("BID3003", "PID2001", 2, 80));
        }

        public static void MainMenu()
        {
            Console.WriteLine("\n\t~~~~~~ Online Grocery Store ~~~~~~");
            bool exit = true;
            do
            {
                Console.WriteLine("\n\t\tMain Menu\n");
                Console.WriteLine("1. Customer Registration\n2. Customer Login\n3. Exit\n");
                int mainOption;
                Console.Write("Select the Option : ");
                while (!int.TryParse(Console.ReadLine(), out mainOption))
                {
                    Console.Write("Invalid Input please enter again : ");
                }
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\tCustomer Registration\n");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\t Customer Login\n");
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            exit = false;
                            Console.WriteLine("\n\t\tThank You !");
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

        public static void CustomerRegistration()
        {
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Father Name : ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Gender (Male/Female/Transgender) : ");
            Gender gender;
            while (!Enum.TryParse<Gender>(Console.ReadLine(), true, out gender) || !(gender == Gender.Male || gender == Gender.Female || gender == Gender.Transgender))
            {
                Console.Write("Invalid Gender please enter again : ");
            }
            Console.Write("Enter your Mobile Number : ");
            long mobile;
            while (!long.TryParse(Console.ReadLine(), out mobile) || !(mobile >= 6000000000 && mobile <= 9999999999))
            {
                Console.Write("Invalid Mobile Number please enter again : ");
            }
            Console.Write("Enter your Date of Birth (DD/MM/YYYY): ");
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
            Console.Write("Enter your Wallet Balance : ");
            double walletBalance;
            while (!double.TryParse(Console.ReadLine(), out walletBalance) || !(walletBalance > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }

            CustomerRegistration customer = new CustomerRegistration(name, fatherName, gender, mobile, dob, mailID, walletBalance);
            customerList.Add(customer);

            Console.WriteLine($"\n\t\"Registration Completed and Your Customer ID is : {customer.CustomerID}\"");
        }

        public static void CustomerLogin()
        {
            Console.Write("Enter your Customer ID : ");
            string customerID = Console.ReadLine().ToUpper();
            bool isValidCustomer = true;
            foreach (CustomerRegistration customer in customerList)
            {
                if (customerID.Equals(customer.CustomerID))
                {
                    isValidCustomer = false;
                    SubMenu(customer);
                    break;
                }
            }
            if (isValidCustomer)
            {
                Console.WriteLine("\n\tInvalid Customer ID");
            }
        }

        public static void SubMenu(CustomerRegistration customer)
        {
            Console.WriteLine($"\n    Welcome {customer.Name}");
            bool mainMenu = true;
            do
            {
                Console.WriteLine("\n\tSub Menu\n");
                Console.WriteLine("1. Show My Details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order Quantity\n6. Cancel Order\n7. Show Balance\n8. Exit\n");
                int subOption;
                Console.Write("Select the Option : ");
                while (!int.TryParse(Console.ReadLine(), out subOption))
                {
                    Console.Write("Invalid Number please enter again : ");
                }
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\t\tCustomer Details\n");
                            CustomerDetails(customer);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\t\t\tProduct Details\n");
                            ProductDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n\t Wallet Recharge\n");
                            WalletRecharge(customer);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n\t\t Take Order\n");
                            TakeOrder(customer);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\n\t\tModify Order\n");
                            ModifyOrder(customer);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\n\t\tCancel Order\n");
                            CancelOrder(customer);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\n\t    Balance Detail\n");
                            ShowBalance(customer);
                            break;
                        }
                    case 8:
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

        public static void CustomerDetails(CustomerRegistration customer)
        {
            Console.WriteLine($"Customer ID    : {customer.CustomerID}");
            Console.WriteLine($"Name           : {customer.Name}");
            Console.WriteLine($"Father Name    : {customer.FatherName}");
            Console.WriteLine($"Gender         : {customer.Gender}");
            Console.WriteLine($"Mobile Number  : {customer.Mobile}");
            Console.WriteLine($"Date of Birth  : {customer.DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mail ID        : {customer.MailID}");
            Console.WriteLine($"Wallet Balance : {customer.WalletBalance}");
        }

        public static void ProductDetails()
        {
            if (productList != null)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine($"| {"Product ID",-11}|   {"Product Name",-16}| {"Quantity Available",-19}| {"Price Per Quantity",-19}|");
                Console.WriteLine("----------------------------------------------------------------------------");
                foreach (ProductDetails product in productList)
                {
                    if (product.QuantityAvailable > 0)
                    {
                        Console.WriteLine($"|  {product.ProductID,-10}|  {product.ProductName,-17}|       {product.QuantityAvailable,-13}|       {product.PricePerQuantity,-13}|");
                    }
                }
                Console.WriteLine("----------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\tThere is No Products to Show");
            }
        }

        public static void WalletRecharge(CustomerRegistration customer)
        {
            Console.Write("Enter the Amount to Recharge Wallet : ");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount) || !(amount > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }
            customer.WalletRecharge(amount);
            Console.WriteLine($"\n   \"Wallet Recharged with {amount} and Updated Balance is : {customer.WalletBalance}\"");
        }

        public static void TakeOrder(CustomerRegistration customer)
        {
            Console.Write("Do you Want to Purchase Product (yes/no) :");
            string purchaseWish = Console.ReadLine().ToLower();
            while (!(purchaseWish == "yes" || purchaseWish == "no"))
            {
                Console.Write("Invalid Input please enter again : ");
                purchaseWish = Console.ReadLine().ToLower();
            }
            bool userWish = true;
            if (purchaseWish == "yes")
            {
                BookingDetails booking = new BookingDetails(customer.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
                CustomList<OrderDetails> tempOrderList = new CustomList<OrderDetails>();
                do
                {
                    ProductDetails();
                    Console.WriteLine();
                    Console.Write("Enter the Product ID to purchase : ");
                    string productID = Console.ReadLine().ToUpper();
                    bool isValidProduct = true;
                    foreach (ProductDetails product in productList)
                    {
                        if (productID.Equals(product.ProductID))
                        {
                            isValidProduct = false;
                            Console.Write("Enter the Qunatity needed : ");
                            int neededQuantity;
                            while (!int.TryParse(Console.ReadLine(), out neededQuantity) || !(neededQuantity > 0))
                            {
                                Console.Write("Invalid Quantity Number please enter again : ");
                            }
                            if (product.QuantityAvailable >= neededQuantity)
                            {
                                OrderDetails order = new OrderDetails(booking.BookingID, product.ProductID, neededQuantity, product.PricePerQuantity * neededQuantity);
                                product.QuantityAvailable -= neededQuantity;
                                tempOrderList.Add(order);
                                booking.TotalPrice += order.PriceOfOrder;
                                Console.WriteLine("\n\t\"Product Successfully Added to Cart\"\n");
                                Console.Write("Do you want to Book Another product (yes/no) : ");
                                string anotherProductWish = Console.ReadLine().ToLower();
                                while (!(anotherProductWish == "yes" || anotherProductWish == "no"))
                                {
                                    Console.Write("Invalid Input please enter again : ");
                                    anotherProductWish = Console.ReadLine().ToLower();
                                }
                                if (anotherProductWish == "no")
                                {
                                    userWish = false;
                                    Console.Write("\nDo you Want to Confirm Order (yes/no) : ");
                                    string confirmOrder = Console.ReadLine().ToLower();
                                    while (!(confirmOrder == "yes" || confirmOrder == "no"))
                                    {
                                        Console.Write("Invalid Input please enter again : ");
                                        confirmOrder = Console.ReadLine().ToLower();
                                    }
                                    if (confirmOrder == "yes")
                                    {
                                        if (customer.WalletBalance >= booking.TotalPrice)
                                        {
                                            customer.DeductBalance(booking.TotalPrice);
                                            booking.BookingStatus = BookingStatus.Booked;
                                            bookingList.Add(booking);
                                            orderList.AddRange(tempOrderList);
                                            Console.WriteLine("\n\t\t\"Booking Successfull\"");
                                        }
                                        else
                                        {
                                            while (!(customer.WalletBalance >= booking.TotalPrice))
                                            {
                                                Console.Write($"\nInsufficient Balance please recharge with {booking.TotalPrice}");
                                                WalletRecharge(customer);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        foreach (OrderDetails tempOrder in tempOrderList)
                                        {
                                            if (product.ProductID.Equals(tempOrder.ProductID))
                                            {
                                                product.QuantityAvailable += tempOrder.PurchaseCount;
                                            }
                                        }
                                        Console.WriteLine("\n\t\t\"Cart Removed Successfully\"");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\t\"Required Quantity is not Available\"");
                            }
                        }
                    }
                    if (isValidProduct)
                    {
                        Console.WriteLine("\n\tInvalid Product ID");
                    }
                } while (userWish);
            }
        }

        public static void ModifyOrder(CustomerRegistration customer)
        {
            bool isBooked = false;
            foreach (BookingDetails booking in bookingList)
            {
                if (customer.CustomerID.Equals(booking.CustomerID) && booking.BookingStatus == BookingStatus.Booked)
                {
                    isBooked = true;
                    break;
                }
            }
            if (isBooked)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"| {"Booking ID",-11}| {"Customer ID",-12}| {"Total Price",-12}| {"Date of Booking",-16}| {"Booking Status",-15}|");
                Console.WriteLine("-----------------------------------------------------------------------------");
                foreach (BookingDetails booking in bookingList)
                {
                    if (customer.CustomerID.Equals(booking.CustomerID) && booking.BookingStatus == BookingStatus.Booked)
                    {
                        Console.WriteLine($"|  {booking.BookingID,-10}|  {booking.CustomerID,-11}|     {booking.TotalPrice,-8}|   {booking.DateOfBooking.ToString("dd/MM/yyyy"),-14}|    {booking.BookingStatus,-12}|");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Enter the Booking ID to Modify : ");
                string bookingID=Console.ReadLine().ToUpper();
                bool isValidBooking=true;
                foreach(BookingDetails booking in bookingList)
                {
                    if(bookingID.Equals(booking.BookingID))
                    {
                        isValidBooking=false;
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine($"| {"Order ID",-9}| {"Booking ID",-11}| {"Product ID",-11}| {"Purchase Count",-15}| {"Price of Order",-15}|");
                        Console.WriteLine("------------------------------------------------------------------------");
                        foreach(OrderDetails order in orderList)
                        {
                            if(booking.BookingID.Equals(order.BookingID))
                            {
                                Console.WriteLine($"| {order.OrderID,-9}|  {order.BookingID,-10}|  {order.ProductID,-10}|       {order.PurchaseCount,-9}|      {order.PriceOfOrder,-10}|");
                            }
                        }
                        Console.WriteLine("------------------------------------------------------------------------");
                        
                        Console.Write("\nEnter the Order ID to Modify : ");
                        string orderID=Console.ReadLine().ToUpper();
                        bool isValidOrder=true;
                        foreach(OrderDetails order in orderList)
                        {
                            if(orderID.Equals(order.OrderID))
                            {
                                isValidOrder=false;
                                Console.Write("Enter the New Quantity : ");
                                int neededQuantity;
                                while(!int.TryParse(Console.ReadLine(),out neededQuantity) || !(neededQuantity>0))
                                {
                                    Console.Write("Invalid Number please enter again : ");
                                }
                                bool isProductAvailable=true;
                                foreach(ProductDetails product in productList)
                                {
                                    if(order.ProductID.Equals(product.ProductID))
                                    {
                                        if(product.QuantityAvailable>=neededQuantity)
                                        {
                                            isProductAvailable=false;
                                            order.PriceOfOrder=product.PricePerQuantity*neededQuantity;
                                            booking.TotalPrice=0;
                                            int quantity=order.PurchaseCount-neededQuantity;
                                            if(quantity<0)
                                            {
                                                product.QuantityAvailable-=Math.Abs(quantity);
                                            }
                                            else
                                            {
                                                product.QuantityAvailable+=Math.Abs(quantity);
                                            }
                                            order.PurchaseCount=neededQuantity;
                                            foreach(OrderDetails order1 in orderList)
                                            {
                                                if(order1.BookingID.Equals(bookingID))
                                                {
                                                    booking.TotalPrice+=order1.PriceOfOrder;
                                                }
                                            }
                                            Console.WriteLine("\n\t\"Order Modified Successfully\"");
                                            break;
                                        }
                                    }
                                }
                                if(isProductAvailable)
                                {
                                   Console.WriteLine("\n\t\"Required Quantity is not Available\"");
                                }
                            }
                        }
                        if(isValidOrder)
                        {
                            Console.WriteLine("\n\t\"Invalid Order ID\"");
                        }
                    }
                }
                if(isValidBooking)
                {
                    Console.WriteLine("\n\t\"Invalid Booking ID\"");
                }
            }
            else
            {
                Console.WriteLine("\n\t\"No Orders are Booked to Modify\"");
            }
        }

        public static void CancelOrder(CustomerRegistration customer)
        {
            bool isBooked = false;
            foreach (BookingDetails booking in bookingList)
            {
                if (customer.CustomerID.Equals(booking.CustomerID) && booking.BookingStatus == BookingStatus.Booked)
                {
                    isBooked = true;
                    break;
                }
            }
            if (isBooked)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"| {"Booking ID",-11}| {"Customer ID",-12}| {"Total Price",-12}| {"Date of Booking",-16}| {"Booking Status",-15}|");
                Console.WriteLine("-----------------------------------------------------------------------------");
                foreach (BookingDetails booking in bookingList)
                {
                    if (customer.CustomerID.Equals(booking.CustomerID) && booking.BookingStatus == BookingStatus.Booked)
                    {
                        Console.WriteLine($"|  {booking.BookingID,-10}|  {booking.CustomerID,-11}|     {booking.TotalPrice,-8}|   {booking.DateOfBooking.ToString("dd/MM/yyyy"),-14}|    {booking.BookingStatus,-12}|");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Enter the Booking ID to Modify : ");
                string bookingID=Console.ReadLine().ToUpper();
                bool isValidBooking=true;
                foreach(BookingDetails booking in bookingList)
                {
                    if(bookingID.Equals(booking.BookingID))
                    {
                        isValidBooking=false;
                        booking.BookingStatus=BookingStatus.Cancelled;
                        customer.WalletRecharge(booking.TotalPrice);
                        foreach(OrderDetails order in orderList)
                        {
                            if(order.BookingID.Equals(bookingID))
                            {
                                foreach(ProductDetails product in productList)
                                {
                                    if(order.ProductID.Equals(product.ProductID))
                                    {
                                        product.QuantityAvailable+=order.PurchaseCount;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("\n\t\"Booking Cancelled Successfully\"");
                        break;
                    }
                }
                if(isValidBooking)
                {
                    Console.WriteLine("\n\t\"Invalid Booking ID\"");
                }
            }
            else
            {
                Console.WriteLine("\n\t\"No Orders are Booked to Cancel\"");
            }
        }

        public static void ShowBalance(CustomerRegistration customer)
        {
            Console.WriteLine($"    \"Available Wallet Balance is : {customer.WalletBalance}\"");
        }
    }
}