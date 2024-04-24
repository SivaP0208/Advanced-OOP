using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public enum AccountType{Savings}
    public class SavingAccount:IDInfo,ICalculate,IBankInfo
    {
        private static int s_accountNumber=30000;
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        private double _balance;
        public double Balance { get{return _balance;}}

        public SavingAccount(string name,string gender,DateTime dob,long mobile,string voterID,long aadharID,string panNumber,AccountType accountType,string bankName,string branch,string ifsc):base(name,gender,dob,mobile,voterID,aadharID,panNumber)
        {
            AccountNumber="AID"+(++s_accountNumber);
            AccountType=accountType;
            BankName=bankName;
            IFSC=ifsc;
            Branch=branch;
        }
        public void Deposit(double amount)
        {
            if(amount>0)
            {
                _balance+=amount;
                Console.WriteLine($"{amount}Rs. Deposited Successfully");
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void Withdraw(double amount)
        {
            if(_balance>=amount)
            {
                _balance-=amount;
                Console.WriteLine($"{amount}Rs. Withdrawed Successfully");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void BalanceCheck()
        {
            Console.WriteLine($"Available Balance : {Balance}");
        }
    }
}