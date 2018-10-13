using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class Manager
    {
        public void Insert(){
            Employee emp = new Employee();
            Console.WriteLine("Enter Name of Employee");
            emp.name = Console.ReadLine();
            if (String.IsNullOrEmpty(emp.name)) {
                Console.WriteLine("You have to enter something...try Again");
                Console.WriteLine("Enter Name of Employee");
                emp.name = Console.ReadLine();
            }
           
            Console.WriteLine("Enter Father Name of Employee");
            emp.father_name = Console.ReadLine();
            if (String.IsNullOrEmpty(emp.father_name))
            {
                Console.WriteLine("You have to enter something...try Again");
                Console.WriteLine("Enter Father Name of Employee");
                emp.father_name = Console.ReadLine();
            }
            Console.WriteLine("Enter Cnic of Employee");
            emp.cnic = Console.ReadLine();
            if (emp.cnic.Count() < 13) {
                Console.WriteLine("Invalid entry CNIC must be 13 digits....enter again");
                Console.WriteLine("Enter Cnic of Employee");
                emp.cnic = Console.ReadLine();
            
            }
            Console.WriteLine("Enter Mobile number of Employee");
            emp.mobile_no= Console.ReadLine();
           
            Console.WriteLine("Enter Current Address of Employee");
            emp.current_address = Console.ReadLine();
            if (String.IsNullOrEmpty(emp.current_address))
            {
                Console.WriteLine("You have to enter something...try Again");
                Console.WriteLine("Enter Current Address of Employee");
                emp.current_address = Console.ReadLine();
            }
            Console.WriteLine("Enter Permanent Address of Employee");
            emp.prmanent_address = Console.ReadLine();
            if (String.IsNullOrEmpty(emp.prmanent_address))
            {
                Console.WriteLine("You have to enter something...try Again");
                Console.WriteLine("Enter Permanent Address of Employee");
                emp.prmanent_address = Console.ReadLine();
            }
            Console.WriteLine("Enter Grade of Employee");
            emp.grade =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter type of employee...type P for Permanent,C for contract,D for dailywages");
            emp.type = Console.ReadLine();



            //insert in to list
            Utility.employeeList.Add(emp);
            Console.WriteLine("Inserted in List");
            //insert into Database
            DataDb db = new DataDb();
            db.Insert(emp);


        }
        public void ShowAllList(Employee emp)
        {
            Console.WriteLine("\nName of employee is= " +emp.name);
            Console.WriteLine("Father Name of employee is= " +emp.father_name);
            Console.WriteLine("CNIC  of employee is= " + emp.cnic);
            Console.WriteLine("Mobile No  of employee is= " + emp.mobile_no);
            Console.WriteLine("Current Address of employee is= " + emp.current_address);
            Console.WriteLine("Permanent Address of employee is= " + emp.prmanent_address);
            Console.WriteLine("Grade of employee is= " + emp.grade);
            if (emp.type == "P")
            {
                PermanentEmployee pemp = new PermanentEmployee();
                Console.WriteLine("Salary of eployee is= " + pemp.getPay());
            }
            if (emp.type == "C") {
                ContractEmployee cemp = new ContractEmployee();
                Console.WriteLine("Salary of eployee is= " + cemp.getPay());
            }
            if (emp.type == "D")
            {
                DailyWages demp = new DailyWages();
                Console.WriteLine("Salary of eployee is= " + demp.getPay());
            }

        }
        public void ShowAllD() {

            DataDb db = new DataDb();
            db.ShowAll();
        
        }
        public Employee SearchList(String name) {
            Employee emp = new Employee();
            foreach(Employee empe in Utility.employeeList){
                if(empe.name==name){
                    emp = empe;
                
                }
            
            
            }
            return emp;
        
        }
        public void UpdateEmployeeList(string cnic,string name){
        
        foreach(Employee empe in Utility.employeeList){
                if(empe.cnic==cnic){
                    empe.name=name;
                    
                
                }
            
            
            }
            Console.WriteLine("Updated");        
        
        }
        public void UpdateDB(string cnic,string name) {
            DataDb db = new DataDb();
            db.Update(cnic,name);
        
        }
        public void SearchDB(string name) {
            DataDb db = new DataDb();
            db.Searh(name);
        
        
        }
        public void deleteDB(string cnic) {
            DataDb db = new DataDb();
            db.Delete(cnic);
        
        }
        public void CountList() {

            Console.WriteLine("Count in list = "+Utility.employeeList.Count);
        }
        public void countDb()
        {
            DataDb db = new DataDb();
            db.Count();
            

        }
        public void clear() {

            Console.Clear();
        }
        public void CountPay() {
            Console.WriteLine("Enter type of employee...type P for Permanent,C for contract,D for dailywages");
            
            String type=Console.ReadLine();
          
            if (type == "P")
            {
                PermanentEmployee pemp = new PermanentEmployee();
                Console.WriteLine("Salary of eployee is= " + pemp.getPay());
            }
            if (type == "C")
            {
                ContractEmployee cemp = new ContractEmployee();
                Console.WriteLine("Salary of eployee is= " + cemp.getPay());
            }
            if (type == "D")
            {
                DailyWages demp = new DailyWages();
                Console.WriteLine("Salary of eployee is= " + demp.getPay());
            }
        
        
        }


    }
}
