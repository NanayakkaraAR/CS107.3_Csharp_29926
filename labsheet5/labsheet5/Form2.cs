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
    public partial class HomePage : Form
    {
        public HomePage(string fullname,string username, string email)
        {
            InitializeComponent();
            //display user information
            nameLable.Text = $"Name: {fullname}";
            usernameLable.Text = $"UserName: {username}";
            emailLable.Text = $"Email: {email}";
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void nameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
