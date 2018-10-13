using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSysetm2.Classes
{
    class Utility
    {
        public static List<Account> AccountList = new List<Account>();

        public static int GenerateAccountNumber()
        {
            int AccountNo = 0;
            Random random = new Random();
            AccountNo = random.Next(10000,99999);
            return AccountNo;
        }
    }
}
