using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum MaritalDetails{Single,Married}
    public class PersonalInfo:IShowData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
        public MaritalDetails MaritalDetails { get; set; }

        public  PersonalInfo(string name,string gender,DateTime dob,long mobileNumber,MaritalDetails maritalDetails)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNumber=mobileNumber;
            MaritalDetails=maritalDetails;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Date of Birth : {DOB}");
            Console.WriteLine($"Mobile Number : {MobileNumber}");
            Console.WriteLine($"Marital Detail : {MaritalDetails}");
        }
    }
}