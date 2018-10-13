using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSysetm2.Classes
{
    class BankController
    {     
        public void  CreateAccount()
        {
            Account objAccount1 = new Account();
           
            objAccount1.Balance = 5000;
            objAccount1.Name = "Customer 1";
            objAccount1.CNIC = "1";
            objAccount1.AccountNumber = Utility.GenerateAccountNumber();
            Utility.AccountList.Add(objAccount1);

            Account objAccount2 = new Account();

            objAccount2.Balance = 7000;
            objAccount2.Name = "Customer 2";
            objAccount2.CNIC = "2";
            objAccount2.AccountNumber = Utility.GenerateAccountNumber();
            Utility.AccountList.Add(objAccount2);

            Account objAccount3 = new Account();

            objAccount3.Balance = 10000;
            objAccount3.Name = "Customer 3";
            objAccount3.CNIC = "3";
            objAccount3.AccountNumber = Utility.GenerateAccountNumber();
            Utility.AccountList.Add(objAccount3);


            Account objAccount4 = new Account();

            objAccount4.Balance = 12000;
            objAccount4.Name = "Customer 4";
            objAccount4.CNIC = "4";
            objAccount4.AccountNumber = Utility.GenerateAccountNumber();
            Utility.AccountList.Add(objAccount4);

            Account objAccount5 = new Account();

            objAccount5.Balance = 15000;
            objAccount5.Name = "Customer 5";
            objAccount5.CNIC = "5";
            objAccount5.AccountNumber = Utility.GenerateAccountNumber();
            Utility.AccountList.Add(objAccount5);
        }

        public void ShowCustomerInfo(Account account)
        {
            Console.WriteLine("\n ");
            Console.WriteLine("Account Title = " + account.Name);
            Console.WriteLine("Account Number = " + account.AccountNumber);
            Console.WriteLine("CNIC = " + account.CNIC);
            Console.WriteLine("Balance = " + account.GetBalance());            
        }

        public void UpdateAccountInfo(string cnictoSearch, string name)
        {  
            foreach (Account acnt in Utility.AccountList)
            {
                if (acnt.CNIC == cnictoSearch)
                {
                    acnt.Name = name;
                    break;
                }
            }
            
        }

        public Account SearchAccount(string cnic)
        {
            Account searchedAccount = new Account();

            foreach (Account acnt in Utility.AccountList)
            {
                if (acnt.CNIC == cnic)
                {
                    searchedAccount = acnt;
                    break;
                }
            }

            return searchedAccount;

        }
    }
}
