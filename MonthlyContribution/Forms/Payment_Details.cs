using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MonthlyContribution.EntitiesModel;
using System.Data.Entity.Validation;
using System.Net;
using System.Net.Mail;

namespace MonthlyContribution.Forms
{
    public partial class Payment_Details : Form 
    {
        MonthlyContributionEntities mc = new MonthlyContributionEntities();
        Bc modelb = new Bc();
        Member modelm = new Member();
        
        public Payment_Details()
        {
            InitializeComponent();
        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {
            LoadTheme();
            panelbody.Visible = false;                   
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }

        public void clear()
        {
            
          
        }

       
       

        private void btnEdit_Click(object sender, EventArgs e)
        {
           clear();
           
        }

        

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtEmailSend.Text == "" || txtPassE.Text == "" || txtMemberEmail.Text == "")
            {
                MessageBox.Show("Enter Email or Password");
            }
            else if(txtAmount.Text == "")
            {
                MessageBox.Show("Enter Monthly Amount");
            }
            else if(ComboBoxPaymentType.Text == "")
            {
                MessageBox.Show("Select Payment Type");
            }
            else
            {
                string to, from, pass, mail;
                to = (txtMemberEmail.Text).ToString();
                from = (txtEmailSend.Text).ToString();
                mail = ("Dear  " + txtMemberName.Text + " You are  Member Of beesi  " + txtBcName.Text + Environment.NewLine + " Please send Your Monthly Amount as following Instructons:-"
                        + Environment.NewLine + "Amount :- " + txtAmount.Text + Environment.NewLine + "Transaction On :- " + ComboBoxPaymentType.Text +
                         Environment.NewLine + txtEBName.Text + Environment.NewLine + "Mobile Number :-" + txtMobile.Text).ToString();
                pass = (txtPassE.Text).ToString();
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "For Beesi Amount";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Email send", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong" + Environment.NewLine + "1. check Your Email Address" + Environment.NewLine + "2. Check Your Password" + Environment.NewLine + "3. Check Your Email Setting");
                    
                }
            }
        }

        
        private void btnSelectSender_Click(object sender, EventArgs e)
        {
            dgvSelectName.DataSource = mc.Members.ToList();
            dgvBcName.DataSource = mc.Bcs.ToList();
            dgvmember.DataSource = mc.Members.ToList();
        }

        private void dgvSelectName_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSelectName.CurrentRow.Index != -1)
                {
                    modelm.id = Convert.ToInt32(dgvSelectName.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        modelm = mc.Members.Where(x => x.id == modelm.id).FirstOrDefault();
                        txtEmailSend.Text = modelm.emailId;
                        txtEBName.Text = modelm.fullName;
                        txtMobile.Text = modelm.mobile;

                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Details Available");
            }
        }

        

        private void dgvBcName_Click(object sender, EventArgs e)
        {
            try 
            { 
              if (dgvBcName.CurrentRow.Index != -1)
              {
                modelb.id = Convert.ToInt32(dgvBcName.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                {
                    modelb = mc.Bcs.Where(x => x.id == modelb.id).FirstOrDefault();
                    txtBcName.Text = modelb.fullName;

                }
              }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Details Available");
            }
}

        private void dgvmember_Click(object sender, EventArgs e)
        {
            try
            {
              if (dgvmember.CurrentRow.Index != -1)
              {
                modelm.id = Convert.ToInt32(dgvmember.CurrentRow.Cells["idDataGridViewTextBoxColumn2"].Value);
                using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                {
                    modelm = mc.Members.Where(x => x.id == modelm.id).FirstOrDefault();
                    txtMemberEmail.Text = modelm.emailId;
                    txtMemberName.Text = modelm.fullName;

                }
              }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Details Available");
            }
        }

    }
}
