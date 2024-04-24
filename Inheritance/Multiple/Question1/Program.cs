using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        RegisterPerson person1=new RegisterPerson("Siva","Male",new DateTime(2001,08,02),6382520746L,MaritalDetails.Single,"Paramsivam","Valarmathi","Chennai",1,DateTime.Now);
        RegisterPerson person2=new RegisterPerson("Naruto","Male",new DateTime(2008,09,22),9876543209L,MaritalDetails.Married,"Minato","Kushina","HiddenLeaf",1,DateTime.Now);
    
        // Showing Details
        person1.ShowInfo();
        person2.ShowInfo();
    }
}