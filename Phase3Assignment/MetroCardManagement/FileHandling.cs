using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class FileHandling
    {
        // Creating Folder and Files 
        public static void Create()
        {
            // Creating MetroCardManagement Folder
            if (!Directory.Exists("MetroCardManagement"))
            {
                Directory.CreateDirectory("MetroCardManagement");
            }
            
            // Creating UserDetails.csv File in MetroCardManagement Folder
            if (!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                File.Create("MetroCardManagement/UserDetails.csv").Close();
            }

            // Creating TravelHistoryDetails.csv File in MetroCardManagement Folder
            if (!File.Exists("MetroCardManagement/TravelHistoryDetails.csv"))
            {
                File.Create("MetroCardManagement/TravelHistoryDetails.csv").Close();
            }

            // Creating TicketFairDetails.csv File in MetroCardManagement Folder
            if (!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                File.Create("MetroCardManagement/TicketFairDetails.csv").Close();
            }
        }

        // Method for Writing the Details in CSV File
        public static void WriteToCSV()
        {
            // Writing UserDetails into UserDetails.csv File
            string[] userDetails = new string[Operations.userList.Count];
            for (int i = 0; i < Operations.userList.Count; i++)
            {
                userDetails[i] = $"{Operations.userList[i].CardNumber},{Operations.userList[i].UserName},{Operations.userList[i].PhoneNumber},{Operations.userList[i].Balance}";
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv", userDetails);

            // Writing TravelHistoryDetails into TravelHistoryDetails.csv File
            string[] travelHistoryDetails = new string[Operations.travelHistoryList.Count];
            for (int i = 0; i < Operations.travelHistoryList.Count; i++)
            {
                travelHistoryDetails[i] = $"{Operations.travelHistoryList[i].TravelID},{Operations.travelHistoryList[i].CardNumber},{Operations.travelHistoryList[i].FromLocation},{Operations.travelHistoryList[i].ToLocation},{Operations.travelHistoryList[i].Date.ToString("dd/MM/yyyy")},{Operations.travelHistoryList[i].TravelCost}";
            }
            File.WriteAllLines("MetroCardManagement/TravelHistoryDetails.csv", travelHistoryDetails);

            // Writing TicketFairDetails into TicketFairDetails.csv File
            string[] ticketFairDetails = new string[Operations.ticketFairList.Count];
            for (int i = 0; i < Operations.ticketFairList.Count; i++)
            {
                ticketFairDetails[i] = $"{Operations.ticketFairList[i].TicketID},{Operations.ticketFairList[i].FromLocation},{Operations.ticketFairList[i].ToLocation},{Operations.ticketFairList[i].TicketPrice}";
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv", ticketFairDetails);
        }

        // Method for Reading Details from CSV File
        public static void ReadFromCSV()
        {
            // Reading UserDetails from UserDetails.csv File and Storing it in UserList
            string[] userDetails = File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach (string line in userDetails)
            {
                if (line != null)
                {
                    UserDetails user = new UserDetails(line);
                    Operations.userList.Add(user);
                }
            }

            // Reading TravelHistoryDetails from TravelHistoryDetails.csv File and Storing it in TravelHistoryList
            string[] travelHistoryDetails = File.ReadAllLines("MetroCardManagement/TravelHistoryDetails.csv");
            foreach (string line in travelHistoryDetails)
            {
                if (line != null)
                {
                    TravelDetails travel = new TravelDetails(line);
                    Operations.travelHistoryList.Add(travel);
                }
            }

            // Reading TicketFairDetails from TicketFairDetails.csv File and Storing it in TicketFairList
            string[] ticketFairDetails = File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach (string line in ticketFairDetails)
            {
                if (line != null)
                {
                    TicketFairDetails ticket = new TicketFairDetails(line);
                    Operations.ticketFairList.Add(ticket);
                }
            }
        }
    }
}