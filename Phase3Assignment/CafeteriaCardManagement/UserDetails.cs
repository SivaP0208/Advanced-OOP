using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="UserDetails"/> 
    /// </summary> 
    public class UserDetails : PersonalDetails, IBalance
    {
        /// <summary>
        /// This field is used to hold Balance of Instance <see cref="UserDetails"/> 
        /// </summary>
        private double _balance;

        /// <summary>
        /// This static field is used to auto increment the User ID of Instance <see cref="UserDetails"/> 
        /// </summary>
        private static int s_userID = 1000;

        /// <summary>
        /// This Property is used to hold User ID of Instance <see cref="UserDetails"/> 
        /// </summary>
        public string UserID { get; }

        /// <summary>
        /// This Property is used to hold Work Station Number of Instance <see cref="UserDetails"/> 
        /// </summary>
        public string WorkStationNumber { get; set; }

        /// <summary>
        /// This Property is used as a Read Only Property of Balance
        /// </summary>
        public double WalletBalance { get { return _balance; } }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="UserDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="name">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/> </param>
        /// <param name="fatherName">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="mobileNumber">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="mailID">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="gender">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="workStationNumber">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="walletBalance">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        public UserDetails(string name, string fatherName, long mobileNumber, string mailID, Gender gender, string workStationNumber, double walletBalance) : base(name, fatherName, gender, mobileNumber, mailID)
        {
            UserID = "SF" + (++s_userID);
            WorkStationNumber = workStationNumber;
            _balance = walletBalance;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="UserDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="user">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/> by splitting it.</param>
        public UserDetails(string user)
        {
            string[] properties = user.Split(',');
            UserID = properties[0];

            s_userID = int.Parse(properties[0].Remove(0, 2));

            Name = properties[1];
            FatherName = properties[2];
            MobileNumber = long.Parse(properties[3]);
            MailID = properties[4];
            Gender = Enum.Parse<Gender>(properties[5], true);
            WorkStationNumber = properties[6];
            _balance = double.Parse(properties[7]);
        }

        /// <summary>
        /// This method is used to Recharge the Wallet Balance of Instance <see cref="UserDetails"/> 
        /// </summary>
        /// <param name="amount">This parameter is used perform WalletRecharge</param>
        public bool WalletRecharge(double rechargeAmount)
        {
            if (rechargeAmount > 0)
            {
                _balance += rechargeAmount;
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method is used to Deduct the Amount from Wallet Balance of Instance <see cref="UserDetails"/> 
        /// </summary>
        /// <param name="amount"></param>
        public bool DeductAmount(double deductAmount)
        {
            if (_balance >= deductAmount)
            {
                _balance -= deductAmount;
                return true;
            }
            return false;
        }
    }
}