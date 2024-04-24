using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        
        public PersonalInfo(string name,string fatherName,string mobile,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }

        public void UpdateInfo(string name,string fatherName,string mobile,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;

            Console.WriteLine("\n\t\"Informations Updated\"");
        }
    }
}