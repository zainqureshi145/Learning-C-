using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class PermanentEmployee:Employee
    {

        public double tax1 = 5;
        public double salary1 = 15000;
        public double medical1= 10;
        public double houseRent1 = 30;

         public double tax2 = 15;
        public double salary2 = 50000;
        public double medical2=15;
        public double houseRent2 = 30;




        public override double getPay()
        {
            double grosspay = 0;
            double medical = 0;
            double tax = 0;
            double houserent = 0;
            if (grade <= 15)
            {
                medical = salary1 * medical1 / 100;
                tax = salary1 * tax1 / 100;
                houserent = salary1 * houseRent1 / 100;
                grosspay = salary1 + medical + houserent - tax;
            }
            if (grade>=16)
            {
                medical = salary2 * medical2 / 100;
                tax = salary2 * tax2 / 100;
                houserent = salary2 * houseRent2 / 100;
                grosspay = salary2 + medical + houserent - tax;
            }


            



            return grosspay;
        }




    }
}
