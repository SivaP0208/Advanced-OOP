using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="UserDetails"/> 
    /// </summary>
    public class UserDetails:PersonalDetails,IWallet
    {
        /// <summary>
        /// This static field is used to auto increment the User ID of Instance <see cref="UserDetails"/> 
        /// </summary>
        private static int s_userID=1000;

        /// <summary>
        /// This Property is used to hold User ID of Instance <see cref="UserDetails"/> 
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// This field is used to hold Balance of Instance <see cref="UserDetails"/> 
        /// </summary>
        private double _walletBalance;

        /// <summary>
        /// This Property is used as a Read Only Property of Balance
        /// </summary>
        public double WalletBalance { get{return _walletBalance;} }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="UserDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="name">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="age">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="city">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="phoneNumber">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <param name="walletBalance">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/></param>
        /// <returns></returns>
        public UserDetails(string name,int age,string city,string phoneNumber,double walletBalance):base(name,age,city,phoneNumber)
        {
            UserID="UID"+(++s_userID);
            _walletBalance=walletBalance;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="UserDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="user">This Parameter is used to initialize its respective Property of <see cref="UserDetails"/> by splitting it.</param>
        public UserDetails(string user)
        {
            string [] properties=user.Split(',');
            UserID=properties[0];
            s_userID=int.Parse(properties[0].Remove(0,3));
            Name=properties[1];
            Age=int.Parse(properties[2]);
            City=properties[3];
            PhoneNumber=properties[4];
            _walletBalance=double.Parse(properties[5]);
        }

        /// <summary>
        /// This method is used to Recharge the Wallet Balance of Instance <see cref="UserDetails"/> 
        /// </summary>
        /// <param name="amount">This parameter is used perform WalletRecharge</param>
        public void WalletRecharge(double amount)
        {
            _walletBalance+=amount;
        }

        /// <summary>
        /// This method is used to Deduct the Amount from Wallet Balance of Instance <see cref="UserDetails"/> 
        /// </summary>
        /// <param name="amount">This parameter is used perform DeductBalance</param>
        public void DeductBalance(double amount)
        {
            _walletBalance-=amount;
        }
    }
}