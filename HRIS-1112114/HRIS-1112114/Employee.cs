using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class Employee
    {
        public string name { set; get; }
        public string father_name { set; get; }
        public string cnic { set; get; }
        public string mobile_no { set; get; }
        public string current_address { set; get; }
        public string prmanent_address { set; get; }
        public int  grade { set; get; }
        public double pay {set;get; }
        public string type { set; get; }



        public virtual double getPay() {

            return pay;
        }


    }
}
