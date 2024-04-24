using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=2000;
        public string RegisterNumber { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }

        public StudentInfo(int standard,string branch,int academicYear,string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender):base(personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            RegisterNumber="SID"+(++s_registerNumber);
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }
        public StudentInfo(string registerNumber,int standard,string branch,int academicYear,string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender):base(personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("\n\tStudent Information");
            Console.WriteLine($"Register Number : {RegisterNumber}");
            Console.WriteLine($"Standard        : {Standard}");
            Console.WriteLine($"Branch          : {Branch}");
            Console.WriteLine($"Academic Year   : {AcademicYear}");
            Console.WriteLine($"Personal ID     : {PersonalID}");
            Console.WriteLine($"Name            : {Name}");
            Console.WriteLine($"Father Name     : {FatherName}");
            Console.WriteLine($"Phone Number    : {PhoneNumber}");
            Console.WriteLine($"Mail ID         : {MailID}");
            Console.WriteLine($"Date of Birth   : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Gender          : {Gender}\n");
        }
    }
}