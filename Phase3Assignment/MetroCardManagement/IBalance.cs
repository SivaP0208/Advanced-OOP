using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// It Supports Bal
    /// </summary>
    public interface IBalance
    {
        public double Balance { get; set; }
        void WalletRecharge(double amount);
        void DeductBalance(double amount);
    }
}