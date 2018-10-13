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
        string UserName;
        string FatherName;
        string CNIC;
        string Address;
        string Designation;
        string CellNo;
        string Email;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FatherName = textBox2.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CNIC = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Designation = comboBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Address = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Email = textBox4.Text;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CellNo = maskedTextBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender = string.Empty;///////Gender

            if (radioButton1.Checked)
            {
                MessageBox.Show("Male");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Female");
            }

            if (UserName == null)////////////////UserName
            {
                MessageBox.Show("User Name Should Not Be Null");
                return;
            }

            if(FatherName == null)/////////////////Father Name
            {
                MessageBox.Show("Father's Name Required");
                return;
            }

            if (CNIC == null)
            {
                MessageBox.Show("CNIC Required");
                return;
            }
            if (Designation == null)
            {
                MessageBox.Show("Designation is Required");
                return;
            }
            if (Address == null)
            {
                MessageBox.Show("Address is Required");
                return;
            }
            if (CellNo == null)
            {
                MessageBox.Show("Phone Number is Required");
                return;
            }
            if (Email == null)
            {
                MessageBox.Show("Email is Required");
                return;
            }
        }
    }
}
