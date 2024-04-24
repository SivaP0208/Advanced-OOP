using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineMedicalStore"))
            {
                Directory.CreateDirectory("OnlineMedicalStore");
            }

            if(!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                File.Create("OnlineMedicalStore/UserDetails.csv").Close();
            }

            if(!File.Exists("OnlineMedicalStore/MedicineDetails.csv"))
            {
                File.Create("OnlineMedicalStore/MedicineDetails.csv").Close();
            }

            if(!File.Exists("OnlineMedicalStore/OrderDetails.csv"))
            {
                File.Create("OnlineMedicalStore/OrderDetails.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            string [] userDetails=new string[Operations.userDetailsList.Count];
            for(int i=0;i<Operations.userDetailsList.Count;i++)
            {
                userDetails[i]=$"{Operations.userDetailsList[i].UserID},{Operations.userDetailsList[i].Name},{Operations.userDetailsList[i].Age},{Operations.userDetailsList[i].City},{Operations.userDetailsList[i].PhoneNumber},{Operations.userDetailsList[i].WalletBalance}";
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",userDetails);

            string [] medicineDetails=new string[Operations.medicineDetailsList.Count];
            for(int i=0;i<Operations.medicineDetailsList.Count;i++)
            {
                medicineDetails[i]=$"{Operations.medicineDetailsList[i].MedicineID},{Operations.medicineDetailsList[i].MedicineName},{Operations.medicineDetailsList[i].AvailableCount},{Operations.medicineDetailsList[i].Price},{Operations.medicineDetailsList[i].DateOfExpiry.ToString("dd/MM/yyyy")}";
            }
            File.WriteAllLines("OnlineMedicalStore/MedicineDetails.csv",medicineDetails);

            string [] orderDetails=new string[Operations.orderDetailsList.Count];
            for(int i=0;i<Operations.orderDetailsList.Count;i++)
            {
                orderDetails[i]=$"{Operations.orderDetailsList[i].OrderID},{Operations.orderDetailsList[i].UserID},{Operations.orderDetailsList[i].MedicineID},{Operations.orderDetailsList[i].MedicineCount},{Operations.orderDetailsList[i].TotalPrice},{Operations.orderDetailsList[i].OrderDate.ToString("dd/MM/yyyy")},{Operations.orderDetailsList[i].OrderStatus}";
            }
            File.WriteAllLines("OnlineMedicalStore/OrderDetails.csv",orderDetails);
        }

        public static void ReadFromCSV()
        {
            string [] userDetails=File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach(string line in userDetails)
            {
                if(line != null)
                {
                    UserDetails user=new UserDetails(line);
                    Operations.userDetailsList.Add(user);
                }
            }

            string [] medicineDetails=File.ReadAllLines("OnlineMedicalStore/MedicineDetails.csv");
            foreach(string line in medicineDetails)
            {
                if(line != null)
                {
                    MedicineDetails medicine=new MedicineDetails(line);
                    Operations.medicineDetailsList.Add(medicine);
                }
            }

            string [] orderDetails=File.ReadAllLines("OnlineMedicalStore/OrderDetails.csv");
            foreach(string line in orderDetails)
            {
                if(line != null)
                {
                    OrderDetails order=new OrderDetails(line);
                    Operations.orderDetailsList.Add(order);
                }
            }
        }
    }
}