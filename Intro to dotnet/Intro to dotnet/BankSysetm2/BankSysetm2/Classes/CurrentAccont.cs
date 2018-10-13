using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSysetm2.Classes
{
    class CurrentAccont:Account
    {
        private double _profit_rate = 0;
        private double _atm_fee = 3.5;

        public string AccountType 
        { 
                get { 
                    return "Currnet Account"; 
                } 
        }

        public override double GetBalance()
        {
            double accountBalance = 0;
            double atm_fee = 0;

            atm_fee = Balance * _atm_fee / 100;

            accountBalance  = Balance -atm_fee;
            
            return accountBalance;
        }
    }
}
