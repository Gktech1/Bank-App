using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTaskApp.Model
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public long AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }

        public Account(int id, decimal initialBalance, string acctType, long accountNumber,
         string accountName)
        {
            Id = id;
            Balance = initialBalance;
            AccountType = acctType;
            AccountNumber = accountNumber;
            AccountName = accountName;
        }
    }

}
