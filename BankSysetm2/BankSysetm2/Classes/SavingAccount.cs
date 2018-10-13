using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSysetm2.Classes
{
    class SavingAccount:Account
    {
        private double _profit_rate = 15;
        private double _atm_fee = 4.5;

        public string AccountType
        {
            get
            {
                return "Saving Account";
            }
        }

        public override double GetBalance()
        {
            double accountBalance = 0;
            double atm_fee = 0;
            double profit_rate = 0;

            atm_fee = Balance * _atm_fee / 100;
            accountBalance = Balance - atm_fee;

            profit_rate = accountBalance * 15 / 100;
            accountBalance = accountBalance + profit_rate;

            return accountBalance;
        }
    }
}
