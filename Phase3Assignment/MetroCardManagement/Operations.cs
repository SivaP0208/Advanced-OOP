using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class Operations
    {
        // Creating static CustomList to store UserDetails
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();

        // Creating static CustomList to store TravelHistoryDetails
        public static CustomList<TravelDetails> travelHistoryList = new CustomList<TravelDetails>();

        // Creating static CustomList to store TicketFairDetails
        public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();

        // Method for Add Default Data
        public static void AddDefaultData()
        {
            // Adding Default UserDetails in userList
            userList.Add(new UserDetails("Ravi", 9848812345, 1000));
            userList.Add(new UserDetails("Baskaran", 9948854321, 1000));

            // Adding Default TravelDetails in travelHistoryList
            travelHistoryList.Add(new TravelDetails("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55));
            travelHistoryList.Add(new TravelDetails("CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32));
            travelHistoryList.Add(new TravelDetails("CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 25));
            travelHistoryList.Add(new TravelDetails("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25));

            // Adding Default TicketFairDetails in ticketFairList
            ticketFairList.Add(new TicketFairDetails("Airport", "Egmore", 55));
            ticketFairList.Add(new TicketFairDetails("Airport", "Koyambedu", 25));
            ticketFairList.Add(new TicketFairDetails("Alandur", "Koyambedu", 25));
            ticketFairList.Add(new TicketFairDetails("Koyambedu", "Egmore", 32));
            ticketFairList.Add(new TicketFairDetails("Vadapalani", "Egmore", 45));
            ticketFairList.Add(new TicketFairDetails("Arumbakkam", "Egmore", 25));
            ticketFairList.Add(new TicketFairDetails("Vadapalani", "Koyambedu", 25));
            ticketFairList.Add(new TicketFairDetails("Arumbakkam", "Koyambedu", 16));
        }

        // Method fro Main Menu
        public static void MainMenu()
        {
            Console.WriteLine("\n     ~~~~~~~~~ Metro Card Management ~~~~~~~~~");
            bool exit = true;

            // Creating Basic Structure of Main Menu
            do
            {
                Console.WriteLine("\n\tMain Menu\n");
                Console.WriteLine("1. New User Registration\n2. Login User\n3. Exit\n");
                int mainOption;
                Console.Write("Select the Option : ");
                while (!int.TryParse(Console.ReadLine(), out mainOption))
                {
                    Console.Write("Invalid Option please enter again : ");
                }
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\tNew User Registration\n");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\tLogin User\n");
                            LoginUser();
                            break;
                        }
                    case 3:
                        {
                            exit = false;
                            Console.WriteLine("\n\t\tThank You!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\t\"Invalid Input\"");
                            break;
                        }
                }
            } while (exit);
        }

        // Method for User Registration
        public static void UserRegistration()
        {
            // Prompting Details from User
            Console.Write("Enter your Name : ");
            string userName = Console.ReadLine();
            Console.Write("Enter your Phone Number : ");
            long phoneNumber;
            while (!long.TryParse(Console.ReadLine(), out phoneNumber) || !(phoneNumber >= 6000000000 && phoneNumber <= 9999999999))
            {
                Console.Write("Invalid Phone Number please enter again : ");
            }
            Console.Write("Enter your Wallet Balance : ");
            double walletBalance;
            while (!double.TryParse(Console.ReadLine(), out walletBalance) || !(walletBalance > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }

            // Creating UserDetail instance
            UserDetails user = new UserDetails(userName, phoneNumber, walletBalance);

            // Adding the UserDetail Instance to userList
            userList.Add(user);

            Console.WriteLine($"\n     \"Registration Successfull and Your Card Number is {user.CardNumber}\"");
        }

        // Method for Login
        public static void LoginUser()
        {
            // Prompting Card Number from User
            Console.Write("Enter your Card Number : ");
            string cardNumber = Console.ReadLine().ToUpper();
            bool isValidCard = true;

            // Checking whether the user entered Card Number is Valid or Not
            foreach (UserDetails user in userList)
            {
                // If Card Number is Valid user will get into Sub Menu
                if (cardNumber.Equals(user.CardNumber))
                {
                    isValidCard = false;
                    SubMenu(user);
                    break;
                }
            }
            if (isValidCard)
            {
                Console.WriteLine("\n     Invalid Card Number or Registration not Completed");
            }
        }

        // Method for Sub Menu
        public static void SubMenu(UserDetails user)
        {
            Console.WriteLine($"\n\t        Welcome {user.UserName}");
            bool mainMenu = true;

            // Creating Basic Structure of Sub Menu
            do
            {
                Console.WriteLine("\n\t\tSub Menu\n");
                Console.WriteLine("1. Balance Check\n2. Recharge\n3. View Travel History\n4. Travel\n5. Back to Main Menu\n");
                int subOption;
                while (!int.TryParse(Console.ReadLine(), out subOption))
                {
                    Console.Write("Invalid Option please enter again : ");
                }
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\t\tBalance Check\n");
                            BalanceCheck(user);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\t\tRecharge\n");
                            Recharge(user);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n\t\t Travel History\n");
                            ViewTravelHistory(user);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n\t\tTravel\n");
                            Travel(user);
                            break;
                        }
                    case 5:
                        {
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n\"Invalid Input\"");
                            break;
                        }
                }
            } while (mainMenu);
        }

        // Method for Balance Check
        public static void BalanceCheck(UserDetails user)
        {
            // Displaying the Available Balance of User Wallet
            Console.WriteLine($"\t\"Available Wallet Balance : {user.Balance}\"");
        }

        // Method for Wallet Recharge
        public static void Recharge(UserDetails user)
        {
            // Prompting the Amount from the user to Recharge the Wallet
            Console.Write("Enter the amount to Recharge Wallet : ");
            double amount;

            // Checking whether the amount is greater than 0
            while (!double.TryParse(Console.ReadLine(), out amount) || !(amount > 0))
            {
                Console.Write("Invalid Amount please enter again : ");
            }

            // Recharging the Wallet using WalletRecharge Method 
            user.WalletRecharge(amount);

            // Displaying the Message to user
            Console.WriteLine($"\n\t\"Wallet Recharged with Amount {amount}Rs.\"");
        }

        // Method for Travel History
        public static void ViewTravelHistory(UserDetails user)
        {
            // Checking whether the user has made Any travel 
            bool isTraveled = false;
            foreach (TravelDetails travel in travelHistoryList)
            {
                if (user.CardNumber.Equals(travel.CardNumber))
                {
                    isTraveled = true;
                    break;
                }
            }

            if (isTraveled)
            {
                // If user Travelled , then Displaying the Travel History by Traversing the travelHistoryDetail List
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine($"| {"Travel ID",-10}| {"Card Number",-12}| {"From Location",-14}|   {"To Location",-13}|    {"Date",-8}| {"Travel Cost",-12}|");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                foreach (TravelDetails travel in travelHistoryList)
                {
                    if (user.CardNumber.Equals(travel.CardNumber))
                    {
                        Console.WriteLine($"|  {travel.TravelID,-9}|  {travel.CardNumber,-11}|     {travel.FromLocation,-10}| {travel.ToLocation,-15}| {travel.Date.ToString("dd/MM/yyyy"),-11}|     {travel.TravelCost,-8}|");
                    }
                }
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine();
            }
            else
            {
                // If User not Travelled
                Console.WriteLine("\t\"There is No Travel History to Show\"");
            }
        }

        // Method for Travel
        public static void Travel(UserDetails user)
        {
            // Displaying Ticket Fair Details To User 
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"| {"Ticket ID",-10}| {"From Location",-14}| {"To Location",-12}| {"Fair",-5}|");
            Console.WriteLine("--------------------------------------------------");
            foreach (TicketFairDetails fair in ticketFairList)
            {
                Console.WriteLine($"|  {fair.TicketID,-9}|   {fair.FromLocation,-12}|  {fair.ToLocation,-11}|  {fair.TicketPrice,-4}|");
            }
            Console.WriteLine("--------------------------------------------------\n");

            // Prompting Ticket ID to take Travel
            Console.Write("Enter the Ticket ID to Travel : ");
            string ticketID = Console.ReadLine().ToUpper();

            // Checking Whether the user Entered Ticket ID is Valid or Not
            bool isValidTicket = true;
            foreach (TicketFairDetails fair in ticketFairList)
            {
                if (ticketID.Equals(fair.TicketID))
                {
                    // If Ticket ID is Valid , then Checking Whether the User is having Enough Balance in his/her Wallet
                    isValidTicket = false;
                    if (user.Balance >= fair.TicketPrice)
                    {
                        // If user having Enough Balance, then deduct Travel Cost Amount from User Wallet
                        user.DeductBalance(fair.TicketPrice);

                        // Creating TravelHistoryDetail Instance
                        TravelDetails travel = new TravelDetails(user.CardNumber, fair.FromLocation, fair.ToLocation, DateTime.Now, fair.TicketPrice);

                        // Adding the TravelHistoryDetail into travelHistoryList
                        travelHistoryList.Add(travel);

                        // Displaying the Message to user
                        Console.WriteLine("\n\t\"Happy Journey !\"");
                    }
                    else
                    {
                        // If User not Having Enough Balance to Travel
                        Console.WriteLine("\n\t\"Insufficient Balance please recharge your Wallet\"");
                    }
                }
            }
            if (isValidTicket)
            {
                // If user Entered Ticket ID is Invalid
                Console.WriteLine("\n\t\"Invalid Ticket ID\"");
            }
        }
    }
}