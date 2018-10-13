using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Form2 : Form
    {
        Donor DO = new Donor();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Click = new Form1();
            Click.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DO.Donor_Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DO.Donor_CNIC = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DO.Donor_BGroup = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DO.Donor_RH = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DO.Donor_Address = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DO.Donor_Tel = textBox6.Text;
        }
    }
}
