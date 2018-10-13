using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSysetm2.Classes
{
    class ATMManager
    {
        public bool PerformTransaction(string cnic , double amount)
        {
            bool result = false;

            // search account 

            foreach (Account acnt in Utility.AccountList)
            {
                if (acnt.CNIC == cnic)
                {
                    if (acnt.Balance > amount)
                    {
                        acnt.Balance = acnt.Balance - amount;
                        result = true;
                    }
                    break;
                }
            }
            
            return result;
        }

        public bool ValidateAccount(string cnic)
        {
            bool result = false;
            Account tempAccount = new Account();

            foreach (Account acnt in Utility.AccountList)
            {
                if (acnt.CNIC == cnic)
                {
                    tempAccount = acnt;
                    result = true;
                    break;
                }
            }
            
            return result;
        }
    }
}
