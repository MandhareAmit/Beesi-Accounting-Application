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
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Validation;

namespace MonthlyContribution.Forms
{
    public partial class BC_Current : Form
    {
        Bc model = new Bc();
        MonthlyContributionEntities MC;   
        private Form activeForm;

        public BC_Current()
        {
            InitializeComponent();
            MC = new MonthlyContributionEntities();

        }
        private void BC_Current_Load(object sender, EventArgs e)
        {
            dgvSelectBc.Visible = false;
            dgvSelectBc.Visible = false;           
            panelSelectMonth.Visible = false;
            var d = MC.Members.ToList();
            comboBox1.DataSource = d;
            ((ComboBox)comboBox1).SelectedIndex = -1;

            // invisible button Save 
            btnJanSave.Visible = false;
            btnFebSave.Visible = false;
            btnMarchSave.Visible = false;
            btnAprilSave.Visible = false;
            btnMaySave.Visible = false;
            btnJunSave.Visible = false;
            btnJulySave.Visible = false;
            btnAugustSave.Visible = false;
            btnSeptemberSave.Visible = false;
            btnOctSave.Visible = false;
            btnNovSave.Visible = false;
            btnDecSave.Visible = false;




        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //this.panelMembers.Controls.Add(childForm);
            //this.panelMembers.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // labelTitleBar.Text = childForm.Text;
        }
        //Button Click
        private void btnSelectBc_Click(object sender, EventArgs e)
        {
            dgvSelectBc.Visible = true;
            dgvSelectBc.Visible = true;                        
            dgvSelectBc.DataSource = MC.Bcs.Where(x => x.endDate > DateTime.Now).ToList();

            //dataGridView();
        }

        private void dgvSelectBc_Click(object sender, EventArgs e)
        {
            try
            {                
               if (dgvSelectBc.CurrentRow.Index != -1)
               {
                 model.id = Convert.ToInt32(dgvSelectBc.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                 using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                 {
                    model = mc.Bcs.Where(x => x.id == model.id).FirstOrDefault();
                    labelBcName.Text = model.fullName;
                    txtTotalAmount.Text = model.totalAmount;
                    txtStartDate.Text = model.startDate.ToString();
                    txtEndDate.Text = model.endDate.ToString();
                    txtDuration.Text = model.duration;
                    txtMonthlyAmount.Text = model.monthlyContryPerPerson;

                 }
               }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("There Are No Beesi Available");
            }
    dgvSelectBc.Visible = false;
            dgvSelectBc.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var t1 = MC.Members.ToList();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSelectMonth.Visible = true;
            // invisible button Save 
            btnJanSave.Visible = false;
            btnFebSave.Visible = false;
            btnMarchSave.Visible = false;
            btnAprilSave.Visible = false;
            btnMaySave.Visible = false;
            btnJunSave.Visible = false;
            btnJulySave.Visible = false;
            btnAugustSave.Visible = false;
            btnSeptemberSave.Visible = false;
            btnOctSave.Visible = false;
            btnNovSave.Visible = false;
            btnDecSave.Visible = false;


        }
        //Onclick month button to select month view save button for this month
        private void btnJan_Click(object sender, EventArgs e)
        {
            btnJanSave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        private void btnFeb_Click(object sender, EventArgs e)
        {
            btnFebSave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        private void btnMarch_Click(object sender, EventArgs e)
        {
            btnMarchSave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        private void btnApril_Click(object sender, EventArgs e)
        {
            btnAprilSave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            btnMaySave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        private void btnJun_Click(object sender, EventArgs e)
        {
            btnJunSave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        
        private void btnJuly1_Click(object sender, EventArgs e)
        {
            btnJulySave.Visible = true;
            panelSelectMonth.Visible = false;
        }
                
        private void btnAugust1_Click(object sender, EventArgs e)
        {
            btnAugustSave.Visible = true;
            panelSelectMonth.Visible = false;
        }
      

        private void btnSep_Click(object sender, EventArgs e)
        {
            btnSeptemberSave.Visible = true;
            panelSelectMonth.Visible = false;
        }   

        private void btnOct1_Click(object sender, EventArgs e)
        {
            btnOctSave.Visible = true;
            panelSelectMonth.Visible = false;
        }
        private void btnNov1_Click(object sender, EventArgs e)
        {
            btnNovSave.Visible = true;
            panelSelectMonth.Visible = false;
        }
        private void btnDec1_Click(object sender, EventArgs e)
        {
            btnDecSave.Visible = true;
            panelSelectMonth.Visible = false;
        }

        
        // save the Monthly data to table by month 
        private void btnJanSave_Click(object sender, EventArgs e)
        {
            First_mR jan = new First_mR();
            jan.memberName = comboBox1.Text.Trim();
            jan.monthlyAmount = txtMonthlyAmount.Text.Trim();
            jan.interest = txtInterest.Text.Trim();
            jan.paidAmount = txtPaidAmount.Text.Trim();
            jan.collectedAmount = txtCollectAmt.Text.Trim();
            jan.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter Interest");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
           
           else if (comboBox1.Text == "Select")
            {
                MessageBox.Show("Please Select Member");
            }
            else
            {
                MC.First_mR.Add(jan);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                                    " Member:  " + comboBox1.Text + Environment.NewLine +
                                    " To Beei Name:  " + labelBcName.Text);
            }
        }

        private void btnFebSave_Click(object sender, EventArgs e)
        {
            Second_R Feb = new Second_R();
            Feb.memberName = comboBox1.Text.Trim();
            Feb.monthlyAmount = txtMonthlyAmount.Text.Trim();
            Feb.interest = txtInterest.Text.Trim();
            Feb.paidAmount = txtPaidAmount.Text.Trim();
            Feb.CollectedAmount = txtCollectAmt.Text.Trim();
            Feb.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }

            else
            {
                MC.Second_R.Add(Feb);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine+
                    " Member:  " + comboBox1.Text + Environment.NewLine+
                    " To Beei Name:  " + labelBcName.Text);
            }
        }

        private void btnMarchSave_Click(object sender, EventArgs e)
        {
            Third_mR March = new Third_mR();
            March.memberName = comboBox1.Text.Trim();
            March.monthlyAmount = txtMonthlyAmount.Text.Trim();
            March.interest = txtInterest.Text.Trim();
            March.paidAmount = txtPaidAmount.Text.Trim();
            March.CollectedAmount = txtCollectAmt.Text.Trim();
            March.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
          
            else
            {
                MC.Third_mR.Add(March);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beei Name:  " + labelBcName.Text);
            }
        }

        private void btnAprilSave_Click(object sender, EventArgs e)
        {
            fourt_mr April = new fourt_mr();
            April.memberName = comboBox1.Text.Trim();
            April.monthlyAmount = txtMonthlyAmount.Text.Trim();
            April.interest = txtInterest.Text.Trim();
            April.paidAmount = txtPaidAmount.Text.Trim();
            April.collectedAmount = txtCollectAmt.Text.Trim();
            April.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }           
            else
            {
                using (MonthlyContributionEntities ma = new MonthlyContributionEntities())
                {

                    ma.fourt_mr.Add(April);
                    ma.SaveChanges();
                    MessageBox.Show("   Record Save For" + Environment.NewLine +
                        " Member:  " + comboBox1.Text + Environment.NewLine +
                        " To Beei Name:  " + labelBcName.Text);
                }
            }
        }

        private void btnMaySave_Click(object sender, EventArgs e)
        {
            Fifth_mR May = new Fifth_mR();
            May.memberName = comboBox1.Text.Trim();
            May.monthlyAmount = txtMonthlyAmount.Text.Trim();
            May.interest = txtInterest.Text.Trim();
            May.paidAmount = txtPaidAmount.Text.Trim();
            May.CollectedAmount = txtCollectAmt.Text.Trim();
            May.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
      
            else
            {
                MC.Fifth_mR.Add(May);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnJunSave_Click(object sender, EventArgs e)
        {
            Sixth_mR Jun = new Sixth_mR();
            Jun.memberName = comboBox1.Text.Trim();
            Jun.monthlyAmount = txtMonthlyAmount.Text.Trim();
            Jun.interest = txtInterest.Text.Trim();
            Jun.paidAmount = txtPaidAmount.Text.Trim();
            Jun.CollectedAmount = txtCollectAmt.Text.Trim();
            Jun.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
         
            else
            {
                MC.Sixth_mR.Add(Jun);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnJulySave_Click(object sender, EventArgs e)
        {
            Seven_mR jul = new Seven_mR();
            jul.memberName = comboBox1.Text.Trim();
            jul.monthlyAmount = txtMonthlyAmount.Text.Trim();
            jul.interest = txtInterest.Text.Trim();
            jul.paidAmount = txtPaidAmount.Text.Trim();
            jul.CollectedAmount = txtCollectAmt.Text.Trim();
            jul.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
        
            else
            {
                MC.Seven_mR.Add(jul);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnAugustSave_Click(object sender, EventArgs e)
        {
            Eight_mR aug = new Eight_mR();
            aug.memberName = comboBox1.Text.Trim();
            aug.monthlyAmount = txtMonthlyAmount.Text.Trim();
            aug.interest = txtInterest.Text.Trim();
            aug.paidAmount = txtPaidAmount.Text.Trim();
            aug.CollectedAmount = txtCollectAmt.Text.Trim();
            aug.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
            /*else if (MC.Second_R.Any(o => o.memberName == comboBox1.Text))
            {
                MessageBox.Show("Record Alredy Submitted for this Member" + Environment.NewLine +
                    "  Do You want to Update Delete It First");
                return;
            }*/
            else
            {
                MC.Eight_mR.Add(aug);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnSeptemberSave_Click(object sender, EventArgs e)
        {
            Nine_mR sep = new Nine_mR();
            sep.memberName = comboBox1.Text.Trim();
            sep.monthlyAmount = txtMonthlyAmount.Text.Trim();
            sep.interest = txtInterest.Text.Trim();
            sep.paidAmount = txtPaidAmount.Text.Trim();
            sep.CollectedAmount = txtCollectAmt.Text.Trim();
            sep.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
           
            else
            {
                MC.Nine_mR.Add(sep);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnOctSave_Click(object sender, EventArgs e)
        {
            Teen_mR oct = new Teen_mR();
            oct.memberName = comboBox1.Text.Trim();
            oct.monthlyAmount = txtMonthlyAmount.Text.Trim();
            oct.interest = txtInterest.Text.Trim();
            oct.paidAmount = txtPaidAmount.Text.Trim();
            oct.CollectedAmount = txtCollectAmt.Text.Trim();
            oct.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
          
            else
            {
                MC.Teen_mR.Add(oct);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnNovSave_Click(object sender, EventArgs e)
        {
            Eleven_mR nov = new Eleven_mR();
            nov.memberName = comboBox1.Text.Trim();
            nov.monthlyAmount = txtMonthlyAmount.Text.Trim();
            nov.interest = txtInterest.Text.Trim();
            nov.paidAmount = txtPaidAmount.Text.Trim();
            nov.CollectedAmount = txtCollectAmt.Text.Trim();
            nov.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
        
            else
            {
                MC.Eleven_mR.Add(nov);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }

        private void btnDecSave_Click(object sender, EventArgs e)
        {
            Twelve_mR dec = new Twelve_mR();
            dec.memberName = comboBox1.Text.Trim();
            dec.monthlyAmount = txtMonthlyAmount.Text.Trim();
            dec.interest = txtInterest.Text.Trim();
            dec.paidAmount = txtPaidAmount.Text.Trim();
            dec.CollectedAmount = txtCollectAmt.Text.Trim();
            dec.bcName = labelBcName.Text.Trim();
            if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter The Interest % Amount");
            }
            else if (txtPaidAmount.Text == "")
            {
                MessageBox.Show("Enter Paid Amount");
            }
         
            else
            {
                MC.Twelve_mR.Add(dec);
                MC.SaveChanges();
                MessageBox.Show("   Record Save For" + Environment.NewLine +
                    " Member:  " + comboBox1.Text + Environment.NewLine +
                    " To Beesi Name:  " + labelBcName.Text);
            }
        }



    }
}
