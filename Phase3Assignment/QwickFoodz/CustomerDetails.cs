using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="CustomerDetails"/> 
    /// </summary> 
    public class CustomerDetails : PersonalDetails, IBalance
    {
        /// <summary>
        /// This field is used to hold Balance of Instance <see cref="CustomerDetails"/> 
        /// </summary>
        private double _balance;

        /// <summary>
        /// This static field is used to auto increment the Customer ID of Instance <see cref="CustomerDetails"/> 
        /// </summary>
        private static int s_customerID = 1000;

        /// <summary>
        /// This Property is used to hold Customer ID of Instance <see cref="CustomerDetails"/> 
        /// </summary>
        public string CustomerID { get; }

        /// <summary>
        /// This Property is used as a Read Only Property of Balance
        /// </summary>
        public double WalletBalance { get { return _balance; } }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="CustomerDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="name">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="fatherName">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="gender">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="mobile">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="dob">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="mailID">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="location">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        /// <param name="balance">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> </param>
        public CustomerDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location, double balance) : base(name, fatherName, gender, mobile, dob, mailID, location)
        {
            CustomerID = "CID" + (++s_customerID);
            _balance = balance;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="CustomerDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="customer">This Parameter is used to initialize its respective Property of <see cref="CustomerDetails"/> by splitting it.</param>
        public CustomerDetails(string customer)
        {
            string[] properties = customer.Split(',');
            CustomerID = properties[0];
            s_customerID = int.Parse(properties[0].Remove(0, 3));
            Name = properties[1];
            FatherName = properties[2];
            Gender = Enum.Parse<Gender>(properties[3], true);
            Mobile = properties[4];
            DOB = DateTime.ParseExact(properties[5], "dd/MM/yyyy", null);
            MailID = properties[6];
            Location = properties[7];
        }

        /// <summary>
        /// This method is used to Recharge the Wallet Balance of Instance <see cref="CustomerDetails"/> 
        /// </summary>
        /// <param name="amount">This parameter is used perform WalletRecharge</param>
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }

        /// <summary>
        /// This method is used to Deduct the Amount from Wallet Balance of Instance <see cref="CustomerDetails"/> 
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }
    }
}