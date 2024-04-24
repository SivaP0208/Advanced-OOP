using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personalInfo=new PersonalInfo("Siva","Paramasivam",6382520746L,"shiva@gmail.com",new DateTime(2001,08,02),Gender.Male);
        PersonalInfo personalInfo1=new PersonalInfo("Paramasivam","Sankaran",6382520746L,"Paramasivam@gmail.com",new DateTime(2004,09,15),Gender.Male);
        PersonalInfo personalInfo2=new PersonalInfo("Valarmathi","Sanmugavel",8124266623L,"valarmathi@gmail.com",new DateTime(1999,03,29),Gender.Female);
        PersonalInfo personalInfo3=new PersonalInfo("Pavithra","Paramasivam",8765432223L,"pavithra@gmail.com",new DateTime(2004,04,16),Gender.Female);
        PersonalInfo personalInfo4=new PersonalInfo("Ino","Inoichi",9876567990L,"Ino@gmail.com",new DateTime(2007,10,16),Gender.Female);

        // Creating Teacher with the help of Personal
        Teacher teacher1=new Teacher(personalInfo3.PersonalID,personalInfo3.Name,personalInfo3.FatherName,personalInfo3.PhoneNumber,personalInfo3.MailID,personalInfo3.DOB,personalInfo3.Gender,"CSE","HTML","M.phil",7,new DateTime(2021,04,10));
        Teacher teacher2=new Teacher(personalInfo2.PersonalID,personalInfo2.Name,personalInfo2.FatherName,personalInfo2.PhoneNumber,personalInfo2.MailID,personalInfo2.DOB,personalInfo2.Gender,"ECE","VLSI","M.E",5,new DateTime(2019,12,16));

        // Creating Student with the help of Personal
        StudentInfo student1=new StudentInfo(personalInfo.PersonalID,personalInfo.Name,personalInfo.FatherName,personalInfo.PhoneNumber,personalInfo.MailID,personalInfo.DOB,personalInfo.Gender,"B.E","ECE",07);
        StudentInfo student2=new StudentInfo(personalInfo4.PersonalID,personalInfo4.Name,personalInfo4.FatherName,personalInfo4.PhoneNumber,personalInfo4.MailID,personalInfo4.DOB,personalInfo4.Gender,"B.Tech","IT",01);

        // Creating Principal with the help of Personal
        PrincipalInfo principal1=new PrincipalInfo(personalInfo1.PersonalID,personalInfo1.Name,personalInfo1.FatherName,personalInfo.PhoneNumber,personalInfo1.MailID,personalInfo1.DOB,personalInfo1.Gender,"ph.D",10,new DateTime(2011,04,14));
        PrincipalInfo principal2=new PrincipalInfo(personalInfo2.PersonalID,personalInfo2.Name,personalInfo2.FatherName,personalInfo2.PhoneNumber,personalInfo2.MailID,personalInfo2.DOB,personalInfo2.Gender,"M.phil",7,new DateTime(2021,04,10));

        // printing Teacher Details
        teacher1.ShowDetails();
        teacher2.ShowDetails();

        // printing Student Details
        student1.ShowDetails();
        student2.ShowDetails();

        // printing Principal Details
        principal1.ShowDetails();
        principal2.ShowDetails();

    }
}