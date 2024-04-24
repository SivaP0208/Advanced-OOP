using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        // Creating PersonalInfo object
        PersonalInfo personalInfo=new PersonalInfo("Siva","Paramasivam",6382520746L,"shiva@gmail.com",new DateTime(2001,08,02),Gender.Male);
        
        // Creating StudentInfo object with the help of PersonalInfo object
        StudentInfo studentInfo=new StudentInfo(12,"A sec",2019,personalInfo.PersonalID,personalInfo.Name,personalInfo.FatherName,personalInfo.PhoneNumber,personalInfo.MailID,personalInfo.DOB,personalInfo.Gender);
    
        // Printing Student Details
        studentInfo.ShowStudentInfo();
    }
}