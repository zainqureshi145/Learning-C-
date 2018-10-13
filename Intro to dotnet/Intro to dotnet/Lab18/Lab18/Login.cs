using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab18
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username");
                return;
            }

            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password");
            }

            MessageBox.Show("User Name=" + username + "  Password = " + password);

            lblMessage.Text = "User Name=" + username + "  Password = " + password;
         
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

       

       
    }
}
