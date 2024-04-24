using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class Operations
    {
        public static List<UserDetails> userDetailsList=new List<UserDetails>();
        public static List<MedicineDetails> medicineDetailsList=new List<MedicineDetails>();
        public static List<OrderDetails> orderDetailsList=new List<OrderDetails>();

        static UserDetails currentLoggedInUser;

        public static void AddDefaultData()
        {
            userDetailsList.Add(new UserDetails("Ravi",33,"Theni","9877774440",400));
            userDetailsList.Add(new UserDetails("Baskaran",33,"Chennai","8847757470",500));

            medicineDetailsList.Add(new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30)));
            medicineDetailsList.Add(new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30)));
            medicineDetailsList.Add(new MedicineDetails("Gelucil",3,40,new DateTime(2023,04,30)));
            medicineDetailsList.Add(new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30)));
            medicineDetailsList.Add(new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30)));

            orderDetailsList.Add(new OrderDetails("UID1001","MD101",3,15,new DateTime(2022,11,13),OrderStatus.Purchased));
            orderDetailsList.Add(new OrderDetails("UID1001","MD102",2,10,new DateTime(2022,11,13),OrderStatus.Cancelled));
            orderDetailsList.Add(new OrderDetails("UID1001","MD104",2,100,new DateTime(2022,11,13),OrderStatus.Purchased));
            orderDetailsList.Add(new OrderDetails("UID1002","MD103",3,120,new DateTime(2022,11,15),OrderStatus.Cancelled));
            orderDetailsList.Add(new OrderDetails("UID1002","MD105",5,250,new DateTime(2022,11,15),OrderStatus.Purchased));
            orderDetailsList.Add(new OrderDetails("UID1002","MD102",3,15,new DateTime(2022,11,15),OrderStatus.Purchased));
        }
    
        public static void MainMenu()
        {
            Console.WriteLine("\n\t~~~~~~~~~~~~ Online Medical Store ~~~~~~~~~~~~");
            bool exit=true;
            do
            {
                Console.WriteLine("\n\t\tMain Menu\n");
                Console.WriteLine("1. User Registration\n2. User Login\n3. Exit\n");
                Console.Write("Select the Option : ");
                int mainOption;
                while(!int.TryParse(Console.ReadLine(),out mainOption))
                {
                    Console.Write("Invalid Option please enter again : ");
                }
                switch(mainOption)
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
                        exit=false;
                        Console.WriteLine("\n\t\tThank You !\n");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\n\t      \"Invalid Input\"");
                        break;
                    }
                }
            } while (exit);
        }
    
        public static void UserRegistration()
        {
            Console.Write("Enter your Name : ");
            string name=Console.ReadLine();
            Console.Write("Enter your Age : ");
            int age;
            while(!int.TryParse(Console.ReadLine(),out age) || !(age>0))
            {
                Console.Write("Invalid Age please enter again : ");
            }
            Console.Write("Enter your City : ");
            string city=Console.ReadLine();
            Console.Write("Enter your Phone Number : ");
            string phoneNumber=Console.ReadLine();
            while(true)
            {
                if(phoneNumber.Length==10 && (phoneNumber.StartsWith('6')||phoneNumber.StartsWith('7')||phoneNumber.StartsWith('8')||phoneNumber.StartsWith('9')))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Phone Number please enter again : ");
                    phoneNumber=Console.ReadLine();
                }
            }
            Console.Write("Enter your Wallet Balance : ");
            double walletBalance;
            while(!double.TryParse(Console.ReadLine(),out walletBalance) || !(walletBalance>0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }

            UserDetails user=new UserDetails(name,age,city,phoneNumber,walletBalance);
            userDetailsList.Add(user);

            Console.WriteLine($"\n\t\"Registration Successfull and Your User ID is {user.UserID}\"");
        }
    
        public static void UserLogin()
        {
            Console.Write("Enter your User ID : ");
            string userID=Console.ReadLine().ToUpper();
            bool isValidUser=true;
            foreach(UserDetails user in userDetailsList)
            {
                if(user.UserID.Equals(userID))
                {
                    isValidUser=false;
                    currentLoggedInUser=user;
                    SubMenu();
                    break;
                }
            }
            if(isValidUser)
            {
                Console.WriteLine("\n\t\"Invalid User ID\"");
            }
        }
    
        public static void SubMenu()
        {
            Console.WriteLine($"\n\t     Welcome {currentLoggedInUser.Name} !");
            bool mainMenu=true;
            do
            {
                Console.WriteLine("\n\t\tSub Menu\n");
                Console.WriteLine("1. Show Medicine List\n2. Purchase Medicine\n3. Modify Purchase\n4. Cancel Purchase\n5. Show Purchase History\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit\n");
                Console.Write("Select the Option : ");
                int subOption;
                while(!int.TryParse(Console.ReadLine(),out subOption))
                {
                    Console.Write("Invalid Option please enter again : ");
                }
                switch(subOption)
                {
                    case 1:
                    {
                        Console.WriteLine("\n\t\tMedicine List\n");
                        ShowMedicineList();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("\n\t\t  Purchase Medicine\n");
                        PurchaseMedicine();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("\n\t\t\t Modify Purchase\n");
                        ModifyPurchase();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("\n\t\t\t Cancel Purchase\n");
                        CancelPurchase();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("\n\t\t Purchase History\n");
                        ShowPurchaseHistory();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("\n\t   Recharge Wallet\n");
                        RechargeWallet();
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("\n\t\t Balance Details\n");
                        ShowWalletBalance();
                        break;
                    }
                    case 8:
                    {
                        mainMenu=false;
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
    
        public static void ShowMedicineList()
        {
            if(medicineDetailsList!=null)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"| {"Medicine ID",-12}| {"Medicine Name",-14}| {"Available Count",-15}| {"Price",-6}| {"DateOfExpiry",-13}|");
                Console.WriteLine("-----------------------------------------------------------------------");
                foreach(MedicineDetails medicine in medicineDetailsList)
                {
                    if(medicine.AvailableCount>0)
                    {
                        Console.WriteLine($"|    {medicine.MedicineID,-9}| {medicine.MedicineName,-14}|       {medicine.AvailableCount,-9}|  {medicine.Price,-5}|  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-12}|");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }

        public static void PurchaseMedicine()
        {
            ShowMedicineList();
            Console.Write("\nEnter the Medicine ID : ");
            string medicineID=Console.ReadLine().ToUpper();
            bool isValidMedicine=true;
            foreach(MedicineDetails medicine in medicineDetailsList)
            {
                if(medicineID.Equals(medicine.MedicineID))
                {
                    isValidMedicine=false;
                    Console.Write("Enter the Count of Medicine : ");
                    int neededCount;
                    while(!int.TryParse(Console.ReadLine(),out neededCount)||!(neededCount>0))
                    {
                        Console.Write("Invalid Number please enter again : ");
                    }
                    if(medicine.AvailableCount>=neededCount)
                    {
                        if(DateTime.Now<medicine.DateOfExpiry)
                        {
                            if(currentLoggedInUser.WalletBalance>=medicine.Price*neededCount)
                            {
                                medicine.AvailableCount-=neededCount;
                                currentLoggedInUser.DeductBalance(medicine.Price*neededCount);
                                OrderDetails order=new OrderDetails(currentLoggedInUser.UserID,medicine.MedicineID,neededCount,medicine.Price*neededCount,DateTime.Now,OrderStatus.Purchased);
                                orderDetailsList.Add(order);
                                Console.WriteLine("\n\t\"Medicine was Purchased Successfully\"");
                            }
                            else
                            {
                                Console.WriteLine("\n\t\"Insufficient Balance To Purchase\"");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\t\"Medicine is Not Available because of Expired\"");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\"Medicine is Not Available\"");
                    }
                }
            }
            if(isValidMedicine)
            {
                Console.WriteLine("\n\t\"Invalid Medicine ID\"");
            }
        }

        public static void ModifyPurchase()
        {
            bool isOrdered=false;
            foreach(OrderDetails order in orderDetailsList)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    isOrdered=true;
                    break;
                }
            }
            if(isOrdered)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"User ID",-8}| {"Medicine ID",-12}| {"Medicine Count",-15}| {"Total Price",-12}| {"Order Date",-11}| {"Order Status",-13}|");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                foreach(OrderDetails order in orderDetailsList)
                {
                    if(order.OrderStatus==OrderStatus.Purchased)
                    {
                        Console.WriteLine($"| {order.OrderID,-9}| {order.UserID,-8}|    {order.MedicineID,-9}|       {order.MedicineCount,-9}|     {order.TotalPrice,-8}| {order.OrderDate.ToString("dd/MM/yyyy"),-11}|   {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
                Console.Write("Enter the Order ID : ");
                string orderID=Console.ReadLine().ToUpper();
                bool isValidOrder=true;
                foreach(OrderDetails order in orderDetailsList)
                {
                    if(orderID.Equals(order.OrderID))
                    {
                        isValidOrder=false;
                        Console.Write("Enter the New Quantity to Modify : ");
                        int neededQuantity;
                        while(!int.TryParse(Console.ReadLine(),out neededQuantity) || !(neededQuantity>0))
                        {
                            Console.Write("Invalid Quantity Number please enter again : ");
                        }
                        bool isQuantityAavailable=true;
                        foreach(MedicineDetails medicine in medicineDetailsList)
                        {
                            if(order.MedicineID.Equals(medicine.MedicineID))
                            {
                                if(medicine.AvailableCount>=neededQuantity)
                                {
                                    isQuantityAavailable=false;
                                    order.TotalPrice=medicine.Price*neededQuantity;
                                    int quantityUpdate=order.MedicineCount-neededQuantity;
                                    if(quantityUpdate>0)
                                    {
                                        medicine.AvailableCount+=Math.Abs(quantityUpdate);
                                    }
                                    else
                                    {
                                        medicine.AvailableCount-=Math.Abs(quantityUpdate);
                                    }
                                    order.MedicineCount=neededQuantity;
                                    Console.WriteLine("\n\t\"Order Modified Successfully\"");
                                    break;
                                }
                            }
                        }
                        if(isQuantityAavailable)
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
            else
            {
                Console.WriteLine("\n\t \"There is No Medicine Ordered To Modify\"");
            }
        }

        public static void CancelPurchase()
        {
            bool isOrdered=false;
            foreach(OrderDetails order in orderDetailsList)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    isOrdered=true;
                    break;
                }
            }
            if(isOrdered)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"User ID",-8}| {"Medicine ID",-12}| {"Medicine Count",-15}| {"Total Price",-12}| {"Order Date",-11}| {"Order Status",-13}|");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                foreach(OrderDetails order in orderDetailsList)
                {
                    if(order.OrderStatus==OrderStatus.Purchased)
                    {
                        Console.WriteLine($"| {order.OrderID,-9}| {order.UserID,-8}|    {order.MedicineID,-9}|       {order.MedicineCount,-9}|     {order.TotalPrice,-8}| {order.OrderDate.ToString("dd/MM/yyyy"),-11}|   {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
                Console.Write("Enter the Order ID : ");
                string orderID=Console.ReadLine().ToUpper();
                bool isValidOrder=true;
                foreach(OrderDetails order in orderDetailsList)
                {
                    if(orderID.Equals(order.OrderID) && order.OrderStatus==OrderStatus.Purchased)
                    {
                        isValidOrder=false;
                        foreach(MedicineDetails medicine in medicineDetailsList)
                        {
                            if(order.MedicineID.Equals(medicine.MedicineID))
                            {
                                medicine.AvailableCount+=order.MedicineCount;
                                currentLoggedInUser.WalletRecharge(order.TotalPrice);
                                order.OrderStatus=OrderStatus.Cancelled;
                                Console.WriteLine($"\n\t\"Order ID \"{order.OrderID}\" was Cancelled Successfully\"");
                                break;
                            }
                        }
                        break;
                    }
                }
                if(isValidOrder)
                {
                    Console.WriteLine("\n\t\"Invalid Order ID\"");
                }
            }
            else
            {
                Console.WriteLine("\n\t \"There is No Medicine Ordered To Cancel\"");
            }
        }

        public static void ShowPurchaseHistory()
        {
            bool isOrdered=false;
            foreach(OrderDetails order in orderDetailsList)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    isOrdered=true;
                    break;
                }
            }
            if(isOrdered)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine($"| {"Order ID",-9}| {"User ID",-8}| {"Medicine ID",-12}| {"Medicine Count",-15}| {"Total Price",-12}| {"Order Date",-11}| {"Order Status",-13}|");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                foreach(OrderDetails order in orderDetailsList)
                {
                    if(order.OrderStatus==OrderStatus.Purchased)
                    {
                        Console.WriteLine($"| {order.OrderID,-9}| {order.UserID,-8}|    {order.MedicineID,-9}|       {order.MedicineCount,-9}|     {order.TotalPrice,-8}| {order.OrderDate.ToString("dd/MM/yyyy"),-11}|   {order.OrderStatus,-11}|");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            }
            else
            {
                 Console.WriteLine("\n\t \"There is No Purchase History To Show\"");
            }
        }

        public static void RechargeWallet()
        {
            Console.Write("Enter the Amount to Recharge : ");
            double amount;
            while(!double.TryParse(Console.ReadLine(),out amount) || !(amount>0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"\n\t \"Wallet is Recharged with {amount}Rs.\"");
        }

        public static void ShowWalletBalance()
        {
            Console.WriteLine($"\n\t\"Available Wallet Balance is : {currentLoggedInUser.WalletBalance}Rs.\"");
        }
    }
}