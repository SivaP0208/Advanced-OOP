using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        // Creating PersonalInfo object
        PersonalInfo personalInfo=new PersonalInfo("Siva","Paramasivam",6382520746L,"shiva@gmail.com",new DateTime(2001,08,02),Gender.Male);
        PersonalInfo personalInfo1=new PersonalInfo("Paramasivam","Siva",6382520746L,"Paramasivam@gmail.com",new DateTime(2004,09,15),Gender.Male);
        
        // Creating StudentInfo object with the help of PersonalInfo object
        StudentInfo studentInfo=new StudentInfo(12,"A sec",2019,personalInfo.PersonalID,personalInfo.Name,personalInfo.FatherName,personalInfo.PhoneNumber,personalInfo.MailID,personalInfo.DOB,personalInfo.Gender);
        StudentInfo studentInfo1=new StudentInfo(12,"B sec",2019,personalInfo1.PersonalID,personalInfo1.Name,personalInfo1.FatherName,personalInfo1.PhoneNumber,personalInfo1.MailID,personalInfo1.DOB,personalInfo1.Gender);
        
        // Creating HSC Details object with the help of PersonalInfo and StudentInfo
        HSCDetails hSCDetails=new HSCDetails(studentInfo.RegisterNumber,studentInfo.Standard,studentInfo.Branch,studentInfo.AcademicYear,studentInfo.PersonalID,studentInfo.Name,studentInfo.FatherName,studentInfo.PhoneNumber,studentInfo.MailID,studentInfo.DOB,studentInfo.Gender,89,78,81);
        HSCDetails hSCDetails1=new HSCDetails(studentInfo1.RegisterNumber,studentInfo1.Standard,studentInfo1.Branch,studentInfo1.AcademicYear,studentInfo1.PersonalID,studentInfo1.Name,studentInfo1.FatherName,studentInfo1.PhoneNumber,studentInfo1.MailID,studentInfo1.DOB,studentInfo1.Gender,98,77,88);

        studentInfo.GetStudentInfo();
        studentInfo1.GetStudentInfo();

        hSCDetails.GetMarks();
        hSCDetails1.GetMarks();

        hSCDetails.CalculateTotalAndPercentage();
        hSCDetails1.CalculateTotalAndPercentage();

        hSCDetails.ShowMarksheet();
        hSCDetails1.ShowMarksheet();
        
    }
}