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
    public partial class Reminder : Form
    {
        MonthlyContributionEntities MC = new MonthlyContributionEntities();
        Bc modelb = new Bc();
        Member modelm = new Member();
        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
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

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtEmailSend.Text == "" || txtPassE.Text == "" || txtMemberEmail.Text == "")
            {
                MessageBox.Show("Enter Email or Password");
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Enter Monthly Amount");
            }
            else if (ComboBoxPaymentType.Text == "")
            {
                MessageBox.Show("Select Payment Type");
            }
            else
            {
                string to, from, pass, mail;
                to = (txtMemberEmail.Text).ToString();
                from = (txtEmailSend.Text).ToString();
                mail = ("Dear  " + txtMemberName.Text + " your payment for beesi  " + txtBcName.Text + Environment.NewLine + " are not complete for this month plese complete your palyment before the end date Otherwise you will have to pay a fine. "
                        + Environment.NewLine + "Amount :- " + txtAmount.Text + Environment.NewLine + "Transaction On :- " + ComboBoxPaymentType.Text +
                         Environment.NewLine + txtEBName.Text + Environment.NewLine + "Mobile Number :-" + txtMobile.Text).ToString();
                pass = (txtPassE.Text).ToString();
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "Reminder for payment";
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
            dgvYourName.DataSource = MC.Members.ToList();
            dgvMembername.DataSource = MC.Members.ToList();
            dgvBeesiName.DataSource = MC.Bcs.ToList();
        }

        private void dgvMembername_Click(object sender, EventArgs e)
        {
            try
            {
              if (dgvMembername.CurrentRow.Index != -1)
              {
                modelm.id = Convert.ToInt32(dgvMembername.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
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

        private void dgvYourName_Click(object sender, EventArgs e)
        {
            try
            {
              if (dgvYourName.CurrentRow.Index != -1)
              {
                modelm.id = Convert.ToInt32(dgvYourName.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
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

        private void dgvBeesiName_Click(object sender, EventArgs e)
        {
            try
            {
              if (dgvBeesiName.CurrentRow.Index != -1)
              {
                modelb.id = Convert.ToInt32(dgvBeesiName.CurrentRow.Cells["idDataGridViewTextBoxColumn2"].Value);
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

        private void btnPenalty_Click(object sender, EventArgs e)
        {

            if (txtEmailSend.Text == "" || txtPassE.Text == "" || txtMemberEmail.Text == "")
            {
                MessageBox.Show("Enter Email or Password");
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Enter Monthly Amount");
            }
            else if (ComboBoxPaymentType.Text == "")
            {
                MessageBox.Show("Select Payment Type");
            }
            else
            {
                string to, from, pass, mail;
                to = (txtMemberEmail.Text).ToString();
                from = (txtEmailSend.Text).ToString();
                mail = ("Dear  " + txtMemberName.Text + " You have not paid your Beesi amount of this month before end date " + Environment.NewLine +
                         "So you will have to pay a fine " + Environment.NewLine + "Amount :-" +txtAmount.Text + Environment.NewLine + "Transaction On :- " +ComboBoxPaymentType.Text + 
                         Environment.NewLine + "Mobile Number :-" + txtMobile.Text + Environment.NewLine + "To" + Environment.NewLine + txtEBName.Text);
                pass = (txtPassE.Text).ToString();
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = ("Penalty for Beesi " + txtBcName.Text);
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
