using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Classes
{
    class Employee
    {

        private bool _isEligible=false;
        //private string _fatherName;
        //private float _salary;

       
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public string Name { get; set; }
        public string CitizenNo { get; set; }
        public string FatherName { get; set; }
        public float PerMonthSalary { set;get; }
        public bool IsEligibleForTax 
        {
            get { return _isEligible; }           
        }

        public float Tax { get; set; }

        public float CalculateTax()
        {

            float grossSalary = 0;
            float annualSalary=  PerMonthSalary * 12;

            if (annualSalary > 300000)
            {
                _isEligible = true;
            }
            else
            {
                Tax = 999;
                _isEligible = false;
            }

            return grossSalary;

        }

        //private static bool CalculatTax(out float taxAmount, out float grossSalary)
        //{
        //    bool isEligible = false;
        //    float tempTax = 0;
        //    taxAmount = 0;
        //    grossSalary = 0;
        //    float annualSalary = Salary * 12;

        //    if (annualSalary > 300000)
        //    {
        //        isEligible = true;


        //        if (annualSalary > 300000 && annualSalary <= 500000)
        //        {
        //            tempTax = annualSalary * 0.15f;
        //        }

        //        if (annualSalary > 500000 && annualSalary <= 1000000)
        //        {
        //            tempTax = annualSalary * 0.20f;
        //        }

        //        if (annualSalary > 1000000)
        //        {
        //            tempTax = annualSalary * 0.25f;
        //        }

        //        taxAmount = tempTax / 12;
        //        grossSalary = Salary - taxAmount;
        //    }
        //    return isEligible;
        //}
    }
}
