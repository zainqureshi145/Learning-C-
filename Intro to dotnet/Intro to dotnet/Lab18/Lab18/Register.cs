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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;           
            
            if (rdoMale.Checked)
            {
                gender = "Male";
            }

            if (rdoFemale.Checked)
            {
                gender = "Female";
            }


            MessageBox.Show(gender);
        }
    }
}
