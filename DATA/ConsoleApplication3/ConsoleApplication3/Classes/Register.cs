using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Classes
{
    class Register
    {
        List<Classes.Student> Applied = new List<Classes.Student>();

        List<Classes.Student> Pass = new List<Classes.Student>();

        List<Classes.Student> Rejected = new List<Classes.Student>();

        public void addStudent(Classes.Student obj)
        {
            if(obj.status=="Applied"){
                Applied.Add(obj);
            }
            else if (obj.status == "Pass")
            {
                Pass.Add(obj);
            }
            else
            {
                Rejected.Add(obj);
            }
        }
        public Classes.Student searchStudentbyID(Classes.Student obj)
        {
            Classes.Student obj3=null;

            if (obj.status == "Applied")
            {
                foreach (Classes.Student obj2 in Applied)
                {
                    if(obj2.id ==obj.id)
                    {
                        obj3 = obj2;
                    }
                }
            }
            if (obj.status == "Pass")
            {
                foreach (Classes.Student obj2 in Pass)
                {
                    if (obj2.id == obj.id)
                    {
                        obj3 = obj2;
                    }
                }
            }
            if (obj.status == "Rejected")
            {
                foreach (Classes.Student obj2 in Rejected)
                {
                    if (obj2.id == obj.id)
                    {
                        obj3 = obj2;
                    }
                }
            }

            return obj3;


        }

        public void searchList(string listName)
        {
            if (listName == "Applied")
            {
                foreach (Classes.Student obj2 in Applied)
                {
                    Console.WriteLine("Student name = "+obj2.name);
                    Console.WriteLine("Student id = " + obj2.id);
                    Console.WriteLine("Student status = " + obj2.status);
                }
            }
            else if (listName == "Pass")
            {
                foreach (Classes.Student obj2 in Pass)
                {
                    Console.WriteLine("Student name = " + obj2.name);
                    Console.WriteLine("Student id = " + obj2.id);
                    Console.WriteLine("Student status = " + obj2.status);
                }
            }
            else
            {
                foreach (Classes.Student obj2 in Rejected)
                {
                    Console.WriteLine("Student name = " + obj2.name);
                    Console.WriteLine("Student id = " + obj2.id);
                    Console.WriteLine("Student status = " + obj2.status);
                }
            }
        }


    }

}
