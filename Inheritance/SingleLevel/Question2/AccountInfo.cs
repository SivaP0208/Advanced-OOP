using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountNumber=2000;
        public string AccountNumber { get; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        public AccountInfo(string branchName,string ifscCode,double balance,string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender):base(personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            AccountNumber="AID"+(++s_accountNumber);
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"\nAccount Number : {AccountNumber}");
            Console.WriteLine($"Branch Name     : {BranchName}");
            Console.WriteLine($"IFSC Code       : {IFSCCode}");
            Console.WriteLine($"Balance         : {Balance}");
            Console.WriteLine($"Personal ID     : {PersonalID}");
            Console.WriteLine($"Name            : {Name}");
            Console.WriteLine($"Father Name     : {FatherName}");
            Console.WriteLine($"Phone Number    : {PhoneNumber}");
            Console.WriteLine($"Mail ID         : {MailID}");
            Console.WriteLine($"Date of Birth   : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Gender          : {Gender}");
        }

        public void Deposit(double depositAmount)
        {
            Console.WriteLine("\n\t\tDepositing");
            bool isValidAmount=true;
            while(isValidAmount)
            {
                if(depositAmount>0)
                {
                    isValidAmount=false;
                    Balance+=depositAmount;
                    Console.WriteLine("\n\tAmount Deposited Successfully");
                }
                else
                {
                    Console.Write("\nInvalid Amount please enter again : ");
                    bool flag=double.TryParse(Console.ReadLine(),out depositAmount);
                }
            }
        }

        public void Withdraw(double withdrawAmount)
        {
            Console.WriteLine("\n\t\tWithdrawing");
            bool isValidAmount=true;
            while(isValidAmount)
            {
                if(withdrawAmount>0)
                {
                    if(Balance>=withdrawAmount)
                    {
                        isValidAmount=false;
                        Balance-=withdrawAmount;
                        Console.WriteLine("\n\tAmount Withdrawed Successfully");
                    }
                    else
                    {
                        Console.WriteLine("\n\tInsufficient Balance");
                    }
                }
                else
                {
                    Console.Write("\nInvalid Amount please enter again : ");
                    bool flag=double.TryParse(Console.ReadLine(),out withdrawAmount);
                }
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"\n\tAvailable Balance is : {Balance}\n");
        }
    }
}