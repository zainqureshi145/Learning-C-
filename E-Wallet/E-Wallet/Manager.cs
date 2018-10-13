using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet
{
    class Manager:Users
    {
        Users UO = new Users();

        public void Register()
        {
            Console.WriteLine("Enter Your Name ");
            UO.UserName = Console.ReadLine();

            Console.WriteLine("Enter Your CNIC ");
            UO.CNIC = Console.ReadLine();

            Console.WriteLine("Enter Your Pin Code ");
            UO.PinCode = Console.ReadLine();

            Console.WriteLine("Enter Your Cash ");
            UO.Cash = Console.ReadLine();

            Console.WriteLine("Enter Your Account Number ");
            UO.Account_No = Console.ReadLine();

            //Add To List
            DataStructure.User.Add(UO);

        }
        public void Login(string UserName, string PinCode)
        {
            if (UO.UserName == UserName)
            {
                if (UO.PinCode == PinCode)
                {
                    Console.WriteLine("Access Granted to " +UO.UserName);
                }
            }
            else
            {
                Console.WriteLine("Access Denied...");
            }

            //search From List...

        }
        public void Withdraw(string UserName)
        {
            Console.WriteLine("Enter Your Name ");
            UO.UserName = Console.ReadLine();

            Console.WriteLine("Enter Your Pin Code ");
            UO.PinCode = Console.ReadLine();

            //search From List...
        }
        public void Reload(string UserName)
        {
            Console.WriteLine("Enter Your Name ");
            UO.UserName = Console.ReadLine();

            Console.WriteLine("Enter Your Pin Code ");
            UO.PinCode = Console.ReadLine();

            //search From List...
        }
        public void Display(Users UO)
        {
            Console.WriteLine("User Name is " + UO.UserName);
            Console.WriteLine("User CNIC is " + UO.CNIC);
            Console.WriteLine("User Pin Code is " + UO.PinCode);
            Console.WriteLine("User Cash is " + UO.Cash);
            Console.WriteLine("User Account Number is " + UO.Account_No);
        }
        public Users Search(string PinCode)
        {
            Users user1 = new Users();
            foreach (Users U in DataStructure.User)
            {
                if (U.PinCode == PinCode)
                {
                    user1 = UO;
                }

            }
            return user1;
        }
    }
}
