using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class DailyWages:Employee
    {
        public double tax = 0;
        public double salary = 15000;
        public double medical1= 15;







        public override double getPay()
        {
            double grosspay = 0;
            double medical = 0;
            double tax = 0;



            medical = salary * medical1 / 100;
            tax = salary * tax / 100;

            grosspay = salary + medical - tax;







            return grosspay;
        }

    }
}
