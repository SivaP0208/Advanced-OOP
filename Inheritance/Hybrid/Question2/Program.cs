using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        SavingAccount person1=new SavingAccount("Siva","male",new DateTime(2001,08,02),6382520746,"KDH09876",684285395357L,"GSJEJ9876K",AccountType.Savings,"HDFC","Kilpauk","HDFC763BK");
        SavingAccount person2=new SavingAccount("Naruto","male",new DateTime(2010,12,13),0987654321,"KHR07385",473592495024L,"KDEJR7434L",AccountType.Savings,"SBI","Thousand Light","IOB763BK");
    
        person1.BalanceCheck();
        Console.WriteLine();
        person2.BalanceCheck();
        Console.WriteLine();

        person1.Deposit(600);
        Console.WriteLine();
        person2.Deposit(400);
        Console.WriteLine();

        person1.Withdraw(200);
        Console.WriteLine();
        person2.Withdraw(100);
        Console.WriteLine();

        person1.BalanceCheck();
        Console.WriteLine();
        person2.BalanceCheck();
        Console.WriteLine();

    }
}