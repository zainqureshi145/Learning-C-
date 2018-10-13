using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class ContractEmployee : Employee
    {
        public double tax1 = 10;
        public double salary1 = 55000;


        public double tax2 = 15;
        public double salary2 = 85000;





        public override double getPay()
        {
            double grosspay = 0;
         
            double tax = 0;
           
            if (grade <= 15)
            {

                tax = salary1 * tax1 / 100;

                grosspay = salary1 - tax;
            }
            if (grade >= 16)
            {

                tax = salary2 * tax2 / 100;

                grosspay = salary2 - tax;
            }






            return grosspay;
        }

    }
}
