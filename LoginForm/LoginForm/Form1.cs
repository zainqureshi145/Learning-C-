using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : MetroForm

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            string UserName = metroTextBox1.Text;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            string Password = metroTextBox2.Text;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            User UO = new User();
            string Un = metroTextBox1.Text;
            string Pwd = metroTextBox2.Text;
            UO.CheckLogin(Un, Pwd);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
