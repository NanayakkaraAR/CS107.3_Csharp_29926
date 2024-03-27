using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsheet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataTableClearEventArgs the text of all texboxes when the "Reset" button is clicked
            fnTxtBox.Text = "";
            lnTxtBox.Text = "";
            DBTxtBox.Text = String.Empty;
            emailTxtBox.Text = "";
            usernameTxtBox.Text = "";
            passwordTxtBox.Text = "";
            confirmpasswordTxtBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if password and confirm password match
            if (passwordTxtBox.Text != confirmpasswordTxtBox.Text)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if any field is empty
            if (String.IsNullOrEmpty(fnTxtBox.Text) ||
                String.IsNullOrEmpty(lnTxtBox.Text) ||
                String.IsNullOrEmpty(DBTxtBox.Text) ||
                String.IsNullOrEmpty(emailTxtBox.Text) ||
                String.IsNullOrEmpty(usernameTxtBox.Text) ||
                String.IsNullOrEmpty(passwordTxtBox.Text) ||
                String.IsNullOrEmpty(confirmpasswordTxtBox.Text)

                ) 
            {
                MessageBox.Show("Please Fill the in all field", "Error");
                return;
            }

            // Create an object as a homeform and pas user information
            HomePage userInfo = new HomePage(
               $"{fnTxtBox.Text} {lnTxtBox.Text}",
               usernameTxtBox.Text,// pass username
               emailTxtBox.Text // pass email
               ) ;
       


            //link with HomePage
            userInfo.Show();
            this.Hide();
        }
        // Method to check if a given text is a string
        private bool IsString(string text)
        {
            return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
        }
    }
}
