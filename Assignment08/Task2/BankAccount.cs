using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        readonly string AccountNumber;
        readonly string AccountHolder;
        Currency Balance;

        public BankAccount(string AccountNumber, string AccountHolder) : this(AccountNumber, AccountHolder, new Currency("GEL", 0M))
        {
        }

        public BankAccount(string AccountNumber, string AccountHolder, Currency Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }

        public void Deposit(Currency amount)
        {
            if (amount.Amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount {0}", amount.Amount);
                return;
            }

            Balance.Amount += amount.Amount;
            Console.WriteLine("Deposit of {0} for {1} account, current balance {2}", amount.Amount, AccountNumber, Balance.Amount);
        }

        public void Withdraw(Currency amount)
        {
            if (amount.Amount > Balance.Amount)
            {
                Console.WriteLine("Invalid dithdraw amount {0}, current balance for account {1} is {2}", amount.Amount, AccountNumber, Balance.Amount);
                return;
            }

            Balance.Amount -= amount.Amount;
            Console.WriteLine("Withdraw of {0} for {1} account, current balance {2}", amount.Amount, AccountNumber, Balance.Amount);
        }

        public decimal BalanceCheck()
        {
            return Balance.Amount;
        }

    }

}
