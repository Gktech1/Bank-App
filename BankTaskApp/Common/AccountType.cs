using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTaskApp.Common
{
    public class AccountType
    {
        /// <summary>
        /// The enum for account type
        /// </summary>
        public enum accountType
        {
            Savings = 1000,
            Current = 0
        }

        /// <summary>
        /// 
        /// </summary>
        public enum TransactionType
        {
            Deposit,
            Withdraw,
            Transfer
        }
    }
}
