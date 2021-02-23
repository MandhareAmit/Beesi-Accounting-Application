using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MonthlyContribution.EntitiesModel;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Validation;

namespace MonthlyContribution
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Registration : Form
    {
        MonthlyContributionEntities mc = new MonthlyContributionEntities();
        User model = new User();
        public Registration()
        {
            InitializeComponent();
        }

       public void clear()
        {
            txtFisrtN.Text = "";
            txtLastN.Text = "";
            txtUserN.Text = "";
            txteml.Text = "";
            txtPhoneN.Text = "";
            txtPassword.Text = "";
            txtconfpass.Text = "";
        }
        

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        

        private void btnLoginReturn_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFisrtN.Text == "")
            {
                MessageBox.Show("Enter First Name");
            }
            else if (txtUserN.Text == "")
            {
                MessageBox.Show("Enter User Name");
            }
            else if (txtPassword.Text == "" || txtconfpass.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (txtPassword.Text != txtconfpass.Text)
            {
                MessageBox.Show("Password and confirm password not same");
            }
            else
            {
                model.FirstName = txtFisrtN.Text.Trim();
                model.LastName = txtLastN.Text.Trim();
                model.UserName = txtUserN.Text.Trim();
                model.Email = txteml.Text.Trim();
                model.PhoneNo = txtPhoneN.Text.Trim();
                model.Password = txtPassword.Text.Trim();
                model.ConfirmPassword = txtconfpass.Text.Trim();
                using (MonthlyContributionEntities m = new MonthlyContributionEntities())
                {
                    if (m.Users.Any(o => o.UserName == txtUserN.Text))
                    {
                        MessageBox.Show("User Name Alreaady Exists !");
                    }
                    else
                    {
                        m.Users.Add(model);
                        m.SaveChanges();
                        MessageBox.Show("Account Created. ");
                        clear();
                    }

                }
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
    }