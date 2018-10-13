using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankSysetm2.Classes;

namespace BankSysetm2
{
    class Program
    {
        static void Main(string[] args)
        {

            BankController cntrlr = new BankController();

            Console.WriteLine("--------------------- Create Account -------------");
            cntrlr.CreateAccount();


            Console.WriteLine("--------------------- Display All Accounts-------------");

            foreach (Account acnt in Utility.AccountList)
            {
                cntrlr.ShowCustomerInfo(acnt);
            }


            Console.WriteLine("--------------------- Search an Account -------------");


            Console.WriteLine("Enter CNIC");
            string cnic = Console.ReadLine();
            Account resultAccount = cntrlr.SearchAccount(cnic);
            cntrlr.ShowCustomerInfo(resultAccount);


            Console.WriteLine("--------------------- Edit an Account -------------");


            Console.WriteLine("Enter CNIC to edit");
            string cnicToSearch = Console.ReadLine();

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

                       
            cntrlr.UpdateAccountInfo(cnicToSearch,name);

            
            Console.WriteLine("--------------------- Display All Accounts-------------");

            foreach (Account acnt in Utility.AccountList)
            {
                cntrlr.ShowCustomerInfo(acnt);
            }


            Console.WriteLine("--------------------- ATM Related Functions -------------");

            Console.WriteLine("Enter CNIC for atm transction");
            string cnicAtm = Console.ReadLine();

            ATMManager atmManager = new ATMManager();

            if (atmManager.ValidateAccount(cnicAtm))
            { 
                Console.WriteLine("Enter Amount");
                string sAmount = Console.ReadLine();

                double amount = double.Parse(sAmount);
                if (atmManager.PerformTransaction(cnicAtm, amount))
                {
                    Console.WriteLine("Transaciton was successful");
                }
                else
                {
                    Console.WriteLine("Amount is not available");
                }

            }
            else
            {
                Console.WriteLine("Invalid Account/CNIC Number");
            }


            Console.WriteLine("--------------------- Display All Accounts-------------");

            foreach (Account acnt in Utility.AccountList)
            {
                cntrlr.ShowCustomerInfo(acnt);
            }

            Console.Read();

        }
    }
}
