using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Classes;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee objEmp = new Employee();

            objEmp.Name = "Imran Khan";
            objEmp.CitizenNo = "93939039093";
            objEmp.PerMonthSalary = 60000;

            Console.WriteLine("Salary=" + objEmp.CalculateTax());
            Console.WriteLine("Tax=" + objEmp.Tax);

            Console.ReadLine();


            float monthlySalary = 0;
            float payableSalary = 0;
            float taxOnSalary = 0;

            Console.WriteLine("Please enter your monthly Salary");
            string salary = Console.ReadLine();

            if (string.IsNullOrEmpty(salary))
            {
                Console.WriteLine("Please enter valid salary amount");
                return;
            }
                      

            if (!float.TryParse(salary, out monthlySalary))
            {
                Console.WriteLine("Invalid salary amount");
                return;
            }

            Console.WriteLine("\n");

            if (!CalculatTax(monthlySalary, out taxOnSalary, out payableSalary))
            {
                Console.WriteLine("Employee is not eligible for salary");
            }
            else
            {
                Console.WriteLine("Employee is eligible for salary.");
            }

            Console.WriteLine("Currnet Month Salary = {0}", payableSalary);
            Console.WriteLine("Currnet Month Tax = {0}", taxOnSalary);

            Console.WriteLine("\n");

            Console.ReadLine();
        }


        private static bool CalculatTax(float monthlySaalry, out float taxAmount, out float grossSalary)
        {
            bool isEligible = false;
            float tempTax = 0;
            taxAmount = 0;
            grossSalary = 0;
            float annualSalary = monthlySaalry * 12;

            if (annualSalary > 300000)
            {
                isEligible = true;

                if (annualSalary > 300000 && annualSalary <= 500000)
                {
                    tempTax = annualSalary * 0.15f;
                }

                if (annualSalary > 500000 && annualSalary <= 1000000)
                {
                    tempTax = annualSalary * 0.20f;
                }

                if (annualSalary > 1000000 )
                {
                    tempTax = annualSalary * 0.25f;
                }

                taxAmount = tempTax / 12;
                grossSalary = monthlySaalry - taxAmount;
            }
            return isEligible;
        }
    }
}
