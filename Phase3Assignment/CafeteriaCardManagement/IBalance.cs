using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// This interface contains only Declaration it's Derived class will give Implementations
    /// </summary>
    public interface IBalance
    {
         /// <summary>
        /// This Property is used to hold WalletBalance 
        /// </summary>
        double WalletBalance { get; }

        /// <summary>
        /// This Method is used to recharge the WalletBalance
        /// </summary>
        /// <param name="amount">This parameter is used to perform the Wallet Recharge Fuction</param>
        bool WalletRecharge(double rechargeAmount);

        
        /// <summary>
        /// This Method is used to Deduct the amount from WalletBalance
        /// </summary>
        /// <param name="amount">This parameter is used to perform Deduct Balance Fuction</param>
        bool DeductAmount(double deductAmount);
    }
}