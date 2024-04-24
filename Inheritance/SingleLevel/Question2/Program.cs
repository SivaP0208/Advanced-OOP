using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        // Creating PersonalInfo object
        PersonalInfo personalInfo=new PersonalInfo("Siva","Paramasivam",6382520746L,"Shiva@gmail.com",new DateTime(2001,08,02),Gender.Male);

        // Creating Account with the help of PersonalInfo
        AccountInfo accountInfo=new AccountInfo("Kilpauk","UNB1023",5000,personalInfo.PersonalID,personalInfo.Name,personalInfo.FatherName,personalInfo.PhoneNumber,personalInfo.MailID,personalInfo.DOB,personalInfo.Gender);

        // Account Details
        accountInfo.ShowAccountInfo();

        // Deposit
        accountInfo.Deposit(0);

        // Withdraw
        accountInfo.Withdraw(0);

        // Balance Check
        accountInfo.ShowBalance();
    }
}