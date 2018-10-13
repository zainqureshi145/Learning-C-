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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string empID = txtEmployeeID.Text;

                if (string.IsNullOrEmpty(empID))
                {
                    MessageBox.Show("please enter id");
                    return;
                }

                EmployeeManager manager = new EmployeeManager();
                DataSet ds = manager.SearchEmployee(empID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    txtFatherName.Text = ds.Tables[0].Rows[0]["username"].ToString();
                }
                else
                {
                   MessageBox.Show("Employee does not exists"); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string father_name = txtFatherName.Text;
                string empID = txtEmployeeID.Text;

                EmployeeManager manager = new EmployeeManager();
                int rowsUpdated = manager.UpdateEmployee(name, father_name, empID);

                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Employee has been updated");
                }
                else
                {
                    MessageBox.Show("Employee could not be udapted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
