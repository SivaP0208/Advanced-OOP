using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class PersonalInfo
    {
        private static int s_registrationNumber=1000;
        public string RegistrationNumber { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        public PersonalInfo(string name,string fatherName,long phone,DateTime dob,string gender)
        {
            RegistrationNumber="RID"+(++s_registrationNumber);
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
        }

        public PersonalInfo(string registrationNumber,string name,string fatherName,long phone,DateTime dob,string gender)
        {
            RegistrationNumber=registrationNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
        }
    }
}