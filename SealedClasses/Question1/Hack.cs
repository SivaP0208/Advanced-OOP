using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Hack:EmployeeInfo //'Hack': cannot derive from sealed type 'EmployeeInfo'
    {
        private static int s_storeUserID=2000;
        public string StoreUserID { get; }
        public string StorePassword { get; set; }

        public Hack(string name,string fatherName,string mobile,string mail,string gender,string userPassword,string storePassword) //:base(name,fatherName,mobile,mail,gender,userPassword)  // 'object' does not contain a constructor that takes 6 arguments
        {
            StoreUserID="SID"+(++s_storeUserID);
            StorePassword=storePassword;
        }

        public void ShowKeyInfo()
        {
            // Console.WriteLine($"Key Info : {KeyInfo}"); // The name 'KeyInfo' does not exist in the current context
        }

        public void GetUserInfo()
        {
            // Console.WriteLine($"User ID : {UserID}"); // The name 'UserID' does not exist in the current context
            // Console.WriteLine($"Name : {Name}"); // The name 'Name' does not exist in the current context
            // Console.WriteLine($"Father Name : {FatherName}"); // The name 'FatherName' does not exist in the current context
            // Console.WriteLine($"Mobile : {Mobile}"); // The name 'Mobile' does not exist in the current context
            // Console.WriteLine($"Mail : {Mail}"); // The name 'Mail' does not exist in the current context
            // Console.WriteLine($"Gender : {Gender}"); // The name 'Gender' does not exist in the current context
        }
    }
}