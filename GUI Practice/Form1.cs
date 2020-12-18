using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string mobile = textBoxMobile.Text;
            string orgName = textBoxOrgNmae.Text;
            string orgAddress = textBoxOrgAddress.Text;
            string output = String.Format("Name: {0}\nMobile: {1}\nOrg Name: {2}\nOrg Address:{3}", name, mobile, orgName, orgAddress);
            richTextOutput.Text = output;
        }
    }
}
