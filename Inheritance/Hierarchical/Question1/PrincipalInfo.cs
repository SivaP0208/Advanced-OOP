using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalID=2000;
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public PrincipalInfo(string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,string qualification,int yearOfExperience,DateTime dateOfJoining):base(personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            PrincipalID="TID"+(++s_principalID);
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n\tPrincipal Details\n");
            Console.WriteLine($"Personal ID        : {PersonalID}");
            Console.WriteLine($"Principal ID       : {PrincipalID}");
            Console.WriteLine($"Name               : {Name}");
            Console.WriteLine($"Father Name        : {FatherName}");
            Console.WriteLine($"Date of Birth      : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Phone Number       : {PhoneNumber}");
            Console.WriteLine($"Gender             : {Gender}");
            Console.WriteLine($"Mail ID            : {MailID}");
            Console.WriteLine($"Qualification      : {Qualification}");
            Console.WriteLine($"Year of Experience : {YearOfExperience}");
            Console.WriteLine($"Date of Joining    : {DateOfJoining.ToString("dd/MM/yyyy")}");
        }
    }
}