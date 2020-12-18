using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_lab_8
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AppareDashboard(object sender, EventArgs e)
        {
            string name = "";
            string password = "";
            string errorMessage = "";
            bool hasError = false;
            if(textBoxUserName.Text==null)
            {
                errorMessage += "Username required\n";
                hasError = true;
            }
            else
            {
                name = textBoxUserName.Text;
            }
            if (textBoxPassword.Text == null)
            {
                errorMessage += "Password required\n";
                hasError = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }
            if(!hasError)
            {
                if(name.Equals("19-40432-1")&&password.Equals("mosabbir"))
                {
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
            
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
