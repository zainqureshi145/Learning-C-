﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double GetStudentCGPA(int regNo)
        {
            double cgpa = 0;
            try
            {
                if(regNo == 111216)
                {
                    cgpa = (3.9 + 3.8 + 3.2 + 2.2 + 1.5 + 4.0) / 6;

                }

               //return string.Format("You entered: {0}", value);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cgpa;
        }
               
    }
}
