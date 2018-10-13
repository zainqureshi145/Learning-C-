using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSysetm2.Classes
{
    class Account
    {
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string PinNo { get; set; }
        public int AccountNumber { get; set; }
        public string FatherName { get; set; }
        public string AccountType { get; set; }
        private double _balance =0;
               
        public double Balance
        {
            get {
                return _balance;
            }
            set
            {
                _balance = value;
            }

        }
               
        public virtual double GetBalance()
        {
            return _balance;        
        }
    }
}
