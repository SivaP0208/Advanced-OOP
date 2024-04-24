using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="UserDetails"/> 
    /// </summary>
    public class UserDetails : PersonalDetails, IBalance
    {
        /// <summary>
        /// Static field to auto increment the Card Number of instance of <see cref="UserDetails"/> 
        /// </summary>
        private static int s_cardNumber = 1000;

        /// <summary>
        /// This Property used to hold Card Number of the Instance <see cref="UserDetails"/>  
        /// </summary>
        public string CardNumber { get; }

        // <summary>
        /// This Property used to hold Balance of the Instance <see cref="UserDetails"/>  
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="UserDetails"/> with Parameter Values
        /// </summary>
        /// <param name="userName">This parameter used to initialize the respective property of <see cref="UserDetails"/></param>
        /// <param name="phoneNumber">This parameter used to initialize the respective property of <see cref="UserDetails"/></param>
        /// <param name="balance">This parameter used to initialize the respective property of <see cref="UserDetails"/></param> 
        public UserDetails(string userName, long phoneNumber, double balance) : base(userName, phoneNumber)
        {
            CardNumber = "CMRL" + (++s_cardNumber);
            Balance = balance;
        }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="UserDetails"/> with Parameter Values
        /// </summary>
        /// <param name="user">This parameter used to initialize the respective properties of <see cref="UserDetails"/> by splitting this.</param>
        public UserDetails(string user)
        {
            string[] properties = user.Split(",");
            CardNumber = properties[0];

            s_cardNumber = int.Parse(properties[0].Remove(0, 4));

            UserName = properties[1];
            PhoneNumber = long.Parse(properties[2]);
            Balance = double.Parse(properties[3]);
        }

        /// <summary>
        /// This method is used to recharge the User Wallet.
        /// </summary>
        /// <param name="amount">This parameter used to perform Wallet Recharge of <see cref="UserDetails"/></param> 
        public void WalletRecharge(double amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// This method is used to Deduct Amount from the User Wallet.
        /// </summary>
        /// <param name="amount">This parameter used to perform Deduct Balance of <see cref="UserDetails"/></param> 
        public void DeductBalance(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }
    }
}