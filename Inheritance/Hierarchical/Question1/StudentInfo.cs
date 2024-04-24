using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentID=3000;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }

        public StudentInfo(string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,string degree,string department,int semester):base(personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            StudentID="SID"+(++s_studentID);
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n\tStudent Details\n");
            Console.WriteLine($"Personal ID        : {PersonalID}");
            Console.WriteLine($"Student ID         : {StudentID}");
            Console.WriteLine($"Name               : {Name}");
            Console.WriteLine($"Father Name        : {FatherName}");
            Console.WriteLine($"Date of Birth      : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Phone Number       : {PhoneNumber}");
            Console.WriteLine($"Gender             : {Gender}");
            Console.WriteLine($"Mail ID            : {MailID}");
            Console.WriteLine($"Department         : {Department}");
            Console.WriteLine($"Degree             : {Degree}");
            Console.WriteLine($"Semester           : {Semester}");
        }
    }
}