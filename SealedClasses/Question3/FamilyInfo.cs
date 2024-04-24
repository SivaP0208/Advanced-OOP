using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Question1;

namespace Question3
{
    public class FamilyInfo:PersonalInfo
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSiblings { get; set; }
        public string NativePlace { get; set; }

        public FamilyInfo(string name,string mobile,string mail,string gender,string fatherName,string motherName,int noOfSiblings,string nativePlace):base(name,fatherName,mobile,mail,gender)
        {
            FatherName=fatherName;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
        }

        public sealed override void Update(string name, string fatherName, string mobile, string mail, string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;

            Console.WriteLine("\n\t\"Informations Updated\"");
        }

        public sealed override void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Mobile : {Mobile}");
            Console.WriteLine($"Mail : {Mail}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"MotherName : {MotherName}");
            Console.WriteLine($"No Of Siblings : {NoOfSiblings}");
            Console.WriteLine($"Native Place : {NativePlace}");
        }
    }
}