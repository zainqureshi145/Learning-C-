using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Classes
{
    class Student
    {
        public int _id;
        public string _name;
        public string _status;

        public int id { get { return _id; } set { _id = value; } }
        public string name { get { return _name; } set { _name = value; } }
        public string status { get { return _status; } set { _status = value; } }

    }

}
