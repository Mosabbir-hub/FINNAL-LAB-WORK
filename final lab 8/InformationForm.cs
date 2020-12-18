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
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = textBoxFirstName.Text;
            user.LastName = textBoxLastName.Text;
            user.BirthDate = comboBoxDay.Text + " " + comboBoxMonth.Text + " " + comboBoxYear.Text;
            user.Gender = comboBoxGender.Text;
            user.Email =textBoxEmail.Text;
            user.ReTypeEmail =textBoxREmail.Text;
            user.Password = textBoxPassword.Text;
            user.ReTypePassword = textBoxRPassword.Text;
            user.SecurityQuestion = comboBoxSecurityQuestion.Text;
            user.SecurityAnswer = textBoxSecurityAnswer.Text;
            user.Address = textBoxAddress.Text;
            user.City = textBoxCity.Text;
            user.State = comboBoxState.Text;
            user.ZipCode = textBoxZipCode.Text;
            user.Phon = textBoxPhon.Text;
            string text =string.Format( "Personal information :\n" +
                "\nFirst Name : {0}\nLast Name : {1}\nDate of Birth : {2}\nGender : {3}\n" +
                "\nAccount Information :\n" +
                "\nEmail : {4}\nRe-Type Email : {5}\nPassword : {6}\nRe-Type Password : {7}\nSecurity Question : {8}\n" +
                "Security Question Answer : {9}\n" +
                "\nContact information :\n" +
                "\nAddress : {10}\nCity : {11}\nState : {12}\nZip code : {13}\nPhon : {14}",
                user.FirstName, user.LastName, user.BirthDate, user.Gender, user.Email, user.ReTypeEmail, user.Password,
                user.ReTypePassword, user.SecurityQuestion, user.SecurityAnswer, user.Address, user.City, user.State,
                user.ZipCode, user.Phon);
            richTextBoxInformation.Text = text;
        }
    }
}
