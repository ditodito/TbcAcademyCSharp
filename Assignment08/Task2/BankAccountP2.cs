using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    partial class BankAccount
    {
        public void TransferFunds(BankAccount target, Currency amount)
        {
            if (Balance.Amount < amount.Amount) {
                Console.WriteLine("Invalid dithdraw amount {0}, current balance for account {1} is {2}", amount.Amount, AccountNumber, Balance.Amount);
                return;
            }

            Withdraw(amount);
            target.Deposit(amount);
            Console.WriteLine("{0} trabsfer {1} to {2}", AccountHolder, amount.Amount, target.AccountHolder);

            /*if (Withdraw(amount))
            {
                target.Deposit(amount);
                Console.WriteLine("{0} trabsfer {1} to {2}", AccountHolder, amount.Amount, target.AccountHolder);
            }*/
        }
    }

}
