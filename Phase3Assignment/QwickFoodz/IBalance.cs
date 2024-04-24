using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// This interface contains only Declaration it's Derived class will give Implementations
    /// </summary>
    public interface IBalance
    {
        /// <summary>
        /// This Property is used to hold WalletBalance 
        /// </summary>
        public double WalletBalance { get; }

        /// <summary>
        /// This Method is used to recharge the WalletBalance
        /// </summary>
        /// <param name="amount">This parameter is used to perform the Wallet Recharge Fuction</param>
        void WalletRecharge(double amount);

        /// <summary>
        /// This Method is used to Deduct the amount from WalletBalance
        /// </summary>
        /// <param name="amount">This parameter is used to perform Deduct Balance Fuction</param>
        void DeductBalance(double amount);
    }
}