using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Siva","Paramasivam",6382520746,new DateTime(2001,08,02),"Male");
        PersonalInfo personal1=new PersonalInfo("Naruto","Minato",9876543210,new DateTime(2005,10,01),"Male");
    
        Marksheet marksheet1=new Marksheet(personal.RegistrationNumber,personal.Name,personal.FatherName,personal.Phone,personal.DOB,personal.Gender,new double[]{87,86,65,72,81,79},new double[]{81,76,53,58,46,97},new double[]{59,63,70,66,39,59},new double[]{50,67,88,55,66,77},84,DateTime.Now);
        Marksheet marksheet2=new Marksheet(personal1.RegistrationNumber,personal1.Name,personal1.FatherName,personal1.Phone,personal1.DOB,personal1.Gender,new double[]{78,68,56,39,47,97},new double[]{49,67,35,85,64,79},new double[]{69,93,84,44,99,78},new double[]{49,88,78,56,87,67},89,DateTime.Now);
    
        marksheet1.CalculateTotal();
        marksheet1.CalculatePercentage();
        marksheet1.ShowUGMarkSheet();

        marksheet2.CalculateTotal();
        marksheet2.CalculatePercentage();
        marksheet2.ShowUGMarkSheet();
    }
}