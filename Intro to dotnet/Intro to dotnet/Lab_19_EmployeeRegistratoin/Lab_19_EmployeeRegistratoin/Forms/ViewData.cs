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
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeManager manager = new EmployeeManager();
                DataSet ds = manager.GetEmployee();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvEmployee.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
