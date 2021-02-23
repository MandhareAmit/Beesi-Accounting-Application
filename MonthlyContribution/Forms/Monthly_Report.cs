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

namespace MonthlyContribution.Forms
{
    public partial class Monthly_Report : Form
    {
        MonthlyContributionEntities mc = new MonthlyContributionEntities();
        First_mR m1 = new First_mR();
        Second_R m2 = new Second_R();
        Third_mR m3 = new Third_mR();
        fourt_mr m4 = new fourt_mr();
        Fifth_mR m5 = new Fifth_mR();
        Sixth_mR m6 = new Sixth_mR();
        Seven_mR m7 = new Seven_mR();
        Eight_mR m8 = new Eight_mR();
        Nine_mR m9 = new Nine_mR();
        Teen_mR m10 = new Teen_mR();
        Eleven_mR m11 = new Eleven_mR();
        Twelve_mR m12 = new Twelve_mR();


        public Monthly_Report()
        {
            InitializeComponent();
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {
            showdata();
            panelMonth.Visible = false;
            DelBtn();
            dgvisiblef();
            txtbcSelect.DataSource = mc.Bcs.Where(x => x.endDate > DateTime.Now).ToList();
            ((ComboBox)txtbcSelect).SelectedIndex = -1;
            textBox1.Visible = false;
        }

        public void showdata()
        {
            dgvFirstR.DataSource = mc.First_mR.ToList();
            dgvSecond.DataSource = mc.Second_R.ToList();
            dgvThird.DataSource = mc.Third_mR.ToList();
            dgvFourth.DataSource = mc.fourt_mr.ToList();
            dgvFifth.DataSource = mc.Fifth_mR.ToList();
            dgvSixth.DataSource = mc.Sixth_mR.ToList();
            dgvSeven.DataSource = mc.Seven_mR.ToList();
            dgvEigth.DataSource = mc.Eight_mR.ToList();
            dgvNine.DataSource = mc.Nine_mR.ToList();
            dgvten.DataSource = mc.Teen_mR.ToList();
            dgveleven.DataSource = mc.Eleven_mR.ToList();
            dgvtwele.DataSource = mc.Twelve_mR.ToList();

        }
        public void dgvisiblef()
        {
            dgvFirstR.Visible = false;
            dgvSecond.Visible = false;
            dgvThird.Visible = false;
            dgvFourth.Visible = false;
            dgvFifth.Visible = false;
            dgvSixth.Visible = false;
            dgvSeven.Visible = false;
            dgvEigth.Visible = false;
            dgvNine.Visible = false;
            dgvten.Visible = false;
            dgveleven.Visible = false;
            dgvtwele.Visible = false;

        }


        public void DelBtn()  //for delete button
        {
            btnDeleteFirst.Visible = false;
            btnDelSecond.Visible = false;
            btndelThird.Visible = false;
            btnDelFour.Visible = false;
            btnDelFifth.Visible = false;
            BtnDelSix.Visible = false;
            btnDelSeven.Visible = false;
            btnDelEight.Visible = false;
            btnDelNine.Visible = false;
            btnDelTen.Visible = false;
            btnDeleleven.Visible = false;
            btnDelTwele.Visible = false;

            btnDeleteFirst.Enabled = false;
            btnDelSecond.Enabled = false;
            btndelThird.Enabled = false;
            btnDelFour.Enabled = false;
            btnDelFifth.Enabled = false;
            BtnDelSix.Enabled = false;
            btnDelSeven.Enabled = false;
            btnDelEight.Enabled = false;
            btnDelNine.Enabled = false;
            btnDelTen.Enabled = false;
            btnDeleleven.Enabled = false;
            btnDelTwele.Enabled = false;
            
        }

        private void btnJan_Click(object sender, EventArgs e)
        {
            dgvFirstR.Visible = true;   //dgvFirstR visible                        
            panelMonth.Visible = false;
            btnDeleteFirst.Visible = true;
        }

        private void btnFeb_Click(object sender, EventArgs e)
        {
            dgvSecond.Visible = true;
            panelMonth.Visible = false;
            btnDelSecond.Visible = true;
        }

        private void btnMarch_Click(object sender, EventArgs e)
        {
            dgvThird.Visible = true;
            panelMonth.Visible = false;
            btndelThird.Visible = true;
        }

        private void btnApril_Click(object sender, EventArgs e)
        {
            dgvFourth.Visible = true;
            panelMonth.Visible = false;
            btnDelFour.Visible = true;
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            dgvFifth.Visible = true;
            panelMonth.Visible = false;
            btnDelFifth.Visible = true;
        }

        private void btnJun_Click(object sender, EventArgs e)
        {
            dgvSixth.Visible = true;
            panelMonth.Visible = false;
            BtnDelSix.Visible = true;
        }

        private void btnJuly_Click(object sender, EventArgs e)
        {
            dgvSeven.Visible = true;
            panelMonth.Visible = false;
            btnDelSeven.Visible = true;
        }

        private void btnAug_Click(object sender, EventArgs e)
        {
            dgvEigth.Visible = true;
            panelMonth.Visible = false;
            btnDelEight.Visible = true;
        }

        private void btnSep_Click(object sender, EventArgs e)
        {
            dgvNine.Visible = true;
            panelMonth.Visible = false;
            btnDelNine.Visible = true;
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            dgvten.Visible = true;
            panelMonth.Visible = false;
            btnDelTen.Visible = true;
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            dgveleven.Visible = true;
            panelMonth.Visible = false;
            btnDeleleven.Visible = true;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            dgvtwele.Visible = true;
            panelMonth.Visible = false;
            btnDelTwele.Visible = true;
        }

        private void btnSelectMonth_Click(object sender, EventArgs e) //for selecting month
        {
            panelMonth.Visible = true;
            DelBtn();
            dgvisiblef();
            ((ComboBox)txtbcSelect).SelectedIndex = -1;
        }

        

       
        // delet buttons
        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m1);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.First_mR.Attach(m1);
                        MC.First_mR.Remove(m1);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            dgvFirstR.DataSource = mc.First_mR.ToList();
        }

        private void btnDelSecond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m2);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Second_R.Attach(m2);
                        MC.Second_R.Remove(m2);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelSecond.Enabled = false;
            dgvSecond.DataSource = mc.Second_R.ToList();
        }

        private void btndelThird_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m2);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Third_mR.Attach(m3);
                        MC.Third_mR.Remove(m3);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btndelThird.Enabled = false;
            dgvThird.DataSource = mc.Third_mR.ToList();
        }

        private void btnDelFour_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m4);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.fourt_mr.Attach(m4);
                        MC.fourt_mr.Remove(m4);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelFour.Enabled = false;
            dgvFourth.DataSource = mc.fourt_mr.ToList();
        }

        private void btnDelFifth_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m5);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Fifth_mR.Attach(m5);
                        MC.Fifth_mR.Remove(m5);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelFifth.Enabled = false;
            dgvFifth.DataSource = mc.Fifth_mR.ToList();
        }

        private void BtnDelSix_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m6);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Sixth_mR.Attach(m6);
                        MC.Sixth_mR.Remove(m6);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            BtnDelSix.Enabled = false;
            dgvSixth.DataSource = mc.Sixth_mR.ToList();
        }

        private void btnDelSeven_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m7);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Seven_mR.Attach(m7);
                        MC.Seven_mR.Remove(m7);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelSeven.Enabled = false;
            dgvSeven.DataSource = mc.Seven_mR.ToList();
        }

        private void btnDelEight_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m8);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Eight_mR.Attach(m8);
                        MC.Eight_mR.Remove(m8);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelEight.Enabled = false;
            dgvEigth.DataSource = mc.Eight_mR.ToList();
        }

        private void btnDelNine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m9);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Nine_mR.Attach(m9);
                        MC.Nine_mR.Remove(m9);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelNine.Enabled = false;
            dgvNine.DataSource = mc.Nine_mR.ToList();
        }

        private void btnDelTen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m10);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Teen_mR.Attach(m10);
                        MC.Teen_mR.Remove(m10);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelTen.Enabled = false;
            dgvten.DataSource = mc.Teen_mR.ToList();
        }

        private void btnDeleleven_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m11);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Eleven_mR.Attach(m11);
                        MC.Eleven_mR.Remove(m11);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDeleleven.Enabled = false;
            dgveleven.DataSource = mc.Eleven_mR.ToList();
        }

        private void btnDelTwele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(m12);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Twelve_mR.Attach(m12);
                        MC.Twelve_mR.Remove(m12);
                        MC.SaveChanges();

                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
            btnDelTwele.Enabled = false;
            dgvtwele.DataSource = mc.Twelve_mR.ToList();
        }

        // grid view click
        private void dgvFirstR_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFirstR.CurrentRow.Index != -1)
                {
                    m1.id = Convert.ToInt32(dgvFirstR.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m1 = mc.First_mR.Where(x => x.id == m1.id).FirstOrDefault();
                        textBox1.Text = m1.bcName;
                        btnDeleteFirst.Enabled = true;

                    }

                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvSecond_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSecond.CurrentRow.Index != -1)
                {
                    m2.id = Convert.ToInt32(dgvSecond.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m2 = mc.Second_R.Where(x => x.id == m2.id).FirstOrDefault();
                        textBox1.Text = m2.bcName;
                        btnDelSecond.Enabled = true;

                    }

                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvThird_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThird.CurrentRow.Index != -1)
                {
                    m3.id = Convert.ToInt32(dgvThird.CurrentRow.Cells["thirdId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m3 = mc.Third_mR.Where(x => x.id == m3.id).FirstOrDefault();
                        textBox1.Text = m3.bcName;
                        btndelThird.Enabled = true;

                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvFourth.CurrentRow.Index != -1)
                {
                    m4.id = Convert.ToInt32(dgvFourth.CurrentRow.Cells["founthId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m4 = mc.fourt_mr.Where(x => x.id == m4.id).FirstOrDefault();
                        textBox1.Text = m4.bcName;
                        btnDelFour.Enabled = true;

                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvFifth_Click(object sender, EventArgs e)
        {            
            try
            {
                if (dgvFifth.CurrentRow.Index != -1)
                {
                    m5.id = Convert.ToInt32(dgvFifth.CurrentRow.Cells["fifthId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m5 = mc.Fifth_mR.Where(x => x.id == m5.id).FirstOrDefault();
                        textBox1.Text = m5.bcName;
                        btnDelFifth.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvSixth_Click(object sender, EventArgs e)
        {            
            try
            {
                if (dgvSixth.CurrentRow.Index != -1)
                {
                    m6.id = Convert.ToInt32(dgvSixth.CurrentRow.Cells["sixthId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m6 = mc.Sixth_mR.Where(x => x.id == m6.id).FirstOrDefault();
                        textBox1.Text = m6.bcName;
                        BtnDelSix.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvSeven_Click(object sender, EventArgs e)
        {            
            try{
                if (dgvSeven.CurrentRow.Index != -1)
                {
                    m7.id = Convert.ToInt32(dgvSeven.CurrentRow.Cells["sevenId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m7 = mc.Seven_mR.Where(x => x.id == m7.id).FirstOrDefault();
                        textBox1.Text = m7.bcName;
                        btnDelSeven.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvEigth_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvEigth.CurrentRow.Index != -1)
                {
                    m8.id = Convert.ToInt32(dgvEigth.CurrentRow.Cells["eightId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m8 = mc.Eight_mR.Where(x => x.id == m8.id).FirstOrDefault();
                        textBox1.Text = m8.bcName;
                        btnDelEight.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvNine_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNine.CurrentRow.Index != -1)
                {
                    m9.id = Convert.ToInt32(dgvNine.CurrentRow.Cells["nineId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m9 = mc.Nine_mR.Where(x => x.id == m9.id).FirstOrDefault();
                        textBox1.Text = m9.bcName;
                        btnDelNine.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvten_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvten.CurrentRow.Index != -1)
                {
                    m10.id = Convert.ToInt32(dgvten.CurrentRow.Cells["tenId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m10 = mc.Teen_mR.Where(x => x.id == m10.id).FirstOrDefault();
                        textBox1.Text = m10.bcName;
                        btnDelTen.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgveleven_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgveleven.CurrentRow.Index != -1)
                {
                    m11.id = Convert.ToInt32(dgveleven.CurrentRow.Cells["elevenId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m11 = mc.Eleven_mR.Where(x => x.id == m11.id).FirstOrDefault();
                        textBox1.Text = m11.bcName;
                        btnDeleleven.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void dgvtwele_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvtwele.CurrentRow.Index != -1)
                {
                    m12.id = Convert.ToInt32(dgvtwele.CurrentRow.Cells["tweleId"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        m12 = mc.Twelve_mR.Where(x => x.id == m12.id).FirstOrDefault();
                        textBox1.Text = m12.bcName;
                        btnDelTwele.Enabled = true;


                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There Are no Record Available");
            }
        }

        private void txtbcSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFirstR.DataSource = mc.First_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvSecond.DataSource = mc.Second_R.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvThird.DataSource = mc.Third_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvFourth.DataSource = mc.fourt_mr.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvFifth.DataSource = mc.Fifth_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvSixth.DataSource = mc.Sixth_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvSeven.DataSource = mc.Seven_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvEigth.DataSource = mc.Eight_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvNine.DataSource = mc.Nine_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvten.DataSource = mc.Teen_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgveleven.DataSource = mc.Eleven_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
            dgvtwele.DataSource = mc.Twelve_mR.Where(x => x.bcName.Contains(txtbcSelect.Text)).ToList();
        }
    }
}
