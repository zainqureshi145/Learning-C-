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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // validataion

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter user name");
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter user password");
                    return;
                }

                Users user = new Users();

                bool returnValue = user.VerifyUser(username, password);

                if (returnValue)
                {
                    Main objMain = new Main();
                    objMain.Show();
                    this.Hide();
                   // MessageBox.Show("verified");
                }
                else
                {
                    MessageBox.Show("not verified");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
