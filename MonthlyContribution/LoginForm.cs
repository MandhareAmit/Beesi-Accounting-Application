using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MonthlyContribution.EntitiesModel;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Validation;

namespace MonthlyContribution
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }      

        private void txtUserNameEnter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("UserName"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserNameLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                txtUserName.Text = "UserName";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Password"))
            {
                txtPass.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.Text = "Password";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NewAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.ShowDialog();           
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MonthlyContributionEntities m = new MonthlyContributionEntities())
            {
                var user = m.Users.FirstOrDefault(o => o.UserName == txtUserName.Text);
                if(user != null)
                {
                    if(user.Password == txtPass.Text)
                    {
                        HomePage f1 = new HomePage();
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("No User found");
                }
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}