using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Teacher:PersonalInfo
    {
        private static int s_teacherID=2000;
        public string TeacherID { get; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Teacher(string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            TeacherID="TID"+(++s_teacherID);
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n\tTeacher Details\n");
            Console.WriteLine($"Personal ID        : {PersonalID}");
            Console.WriteLine($"Teacher ID         : {TeacherID}");
            Console.WriteLine($"Name               : {Name}");
            Console.WriteLine($"Father Name        : {FatherName}");
            Console.WriteLine($"Date of Birth      : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Phone Number       : {PhoneNumber}");
            Console.WriteLine($"Gender             : {Gender}");
            Console.WriteLine($"Mail ID            : {MailID}");
            Console.WriteLine($"Department         : {Department}");
            Console.WriteLine($"Subject Teaching   : {SubjectTeaching}");
            Console.WriteLine($"Qualification      : {Qualification}");
            Console.WriteLine($"Year of Experience : {YearOfExperience}");
            Console.WriteLine($"Date of Joining    : {DateOfJoining.ToString("dd/MM/yyyy")}");
        }
    }
}