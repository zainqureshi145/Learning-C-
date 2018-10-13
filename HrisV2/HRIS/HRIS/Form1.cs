using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string UN = textBox1.Text;
            string Pwd = textBox2.Text; ;
            Users UO = new Users();
            //UO.CheckLogin(UN, Pwd);
            if (UO.CheckLogin(UN, Pwd) == true)
            {
                MessageBox.Show("Logged In");
                Information IO = new Information();
                IO.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
