using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        private static int s_registrationNumber=1000;
        public string RegistrationNumber { get; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }

        public RegisterPerson(string name,string gender,DateTime dob,long mobileNumber,MaritalDetails maritalDetails,string fatherName,string motherName,string houseAddress,int noOfSiblings,DateTime dateOfRegistration):base(name,gender,dob,mobileNumber,maritalDetails)
        {
            RegistrationNumber="SF"+(++s_registrationNumber);
            DateOfRegistration=dateOfRegistration;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;
        }   
        
        public void ShowInfo()
        {
            Console.WriteLine($"\nRegistration Number  : {RegistrationNumber}");
            Console.WriteLine($"Name                 : {Name}");
            Console.WriteLine($"Gender               : {Gender}");
            Console.WriteLine($"Date of Birth        : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mobile Number        : {MobileNumber}");
            Console.WriteLine($"Date of Registration : {FatherName}");
            Console.WriteLine($"Marital Detail       : {MaritalDetails}");
            Console.WriteLine($"Father Name          : {FatherName}");
            Console.WriteLine($"Mother Name          : {MotherName}");
            Console.WriteLine($"House Address        : {HouseAddress}");
            Console.WriteLine($"Number of Siblings   : {NoOfSiblings}");
        }
    }
}