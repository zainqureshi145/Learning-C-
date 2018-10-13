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

            List<Account> accountList = new List<Account>();

            Account objAccount = new Account();

            objAccount.Balance = 15000;
            objAccount.Name = "Akram";
            Console.WriteLine("Name = " + objAccount.Name);
            Console.WriteLine("Balance After 1 Year = " + objAccount.GetBalance());

            accountList.Add(objAccount);

            SavingAccount objSAccount = new SavingAccount();

            objSAccount.Balance = 15000;
            objSAccount.Name = "Akram";
            Console.WriteLine("Name = " + objSAccount.Name);
            Console.WriteLine("Balance After 1 Year = " + objSAccount.GetBalance());
            accountList.Add(objSAccount);


            CurrentAccont objCAccount = new CurrentAccont();

            objCAccount.Balance = 15000;
            objCAccount.Name = "Akram";
            Console.WriteLine("Name = " + objCAccount.Name);
            Console.WriteLine("Balance After 1 Year = " + objCAccount.GetBalance());


            accountList.Add(objCAccount);

            Console.WriteLine("Object Count=" + accountList.Count());

            Console.Read();

        }
    }
}
