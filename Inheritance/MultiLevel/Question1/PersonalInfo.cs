using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender{Male,Female,Others}
    public class PersonalInfo
    {
        private static int s_personalID=1000;
        public string PersonalID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender)
        {
            PersonalID="PID"+(++s_personalID);
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DOB=dob;
            Gender=gender;
        }

        public PersonalInfo(string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender)
        {
            PersonalID=personalID;
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DOB=dob;
            Gender=gender;
        }
    }
}