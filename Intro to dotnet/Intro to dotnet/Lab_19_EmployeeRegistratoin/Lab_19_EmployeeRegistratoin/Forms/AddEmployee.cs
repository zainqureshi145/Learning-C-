using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lab_19_EmployeeRegistratoin.Classes;

namespace Lab_19_EmployeeRegistratoin.Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee objEmployee = new Employee();
            
            try
            {
              objEmployee.Name = txtName.Text;
              objEmployee.FatherName = txtFatherName.Text;

              string gender = string.Empty;

              if (rdoMale.Checked)
              {
                  gender = "male";
              }
              else
              {
                  gender = "female";
              }

              objEmployee.Gender = gender;

              //bool result =   mgr.AddEmployee(objEmployee);

              //if (result)
              //{
              //    MessageBox.Show("Employee has been added successfully");
              //}
              //else
              //{
              //    MessageBox.Show("Employee could not be added");
              //}

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
