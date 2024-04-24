using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public sealed class EmployeeInfo:PersonalInfo
    {
        private static int s_userID=1000;
        public string UserID { get;}
        public string Password { get; set; }
        public int KeyInfo =100;

        public EmployeeInfo(string name,string fatherName,string mobile,string mail,string gender,string password):base(name,fatherName,mobile,mail,gender)
        {
            UserID="UID"+(++s_userID);
            Password=password;
        }

        public void UpdateInfo(string password)
        {
            Password=password;
            Console.WriteLine("\n\t\"Informations Updated\"");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"User ID : {UserID}");
            Console.WriteLine($"Password : {Password}");
        }
    }
}