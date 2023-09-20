using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signupForm = new SRP.Signup();
            this.Hide();
            signupForm.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(emailBox.Text == "admin@auca.ac.rw" &&
                passwordBox.Text == "Password")
            {
                HomePage hm = new HomePage();
                this.Hide();
                hm.Show();
            }else
            {
                MessageBox.Show("Invalid email and or Password");
            }
        }
    }
}
