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
using System.Data.SqlClient;


namespace MonthlyContribution.Forms
{   
    public partial class Create_New_BC : Form
       
    {
        
        Bc model = new Bc();
        BcMember model1 = new BcMember();
        //  MonthlyTransaction m1 = new MonthlyTransaction();

        MonthlyContributionEntities mc = new MonthlyContributionEntities();
        
        public Create_New_BC()
        {
            InitializeComponent();
        }

        private void Bc_New_Load(object sender, EventArgs e)
        {
            dgvBeesi.Visible = false;
            btnDelete.Visible = false;
            // var item = mc.Bcs.ToList();
            dgv();
        }
     
        public void dgv()
        {
            mc.Configuration.ProxyCreationEnabled = false;
            mc.Bcs.Load();
            this.dgvBeesi.DataSource = mc.Bcs.Local.ToBindingList();
        }
        public void clear()
        {
            txtBcName.Text = "";
            txtCountry.Text = "";
            txtDuration.Text = "";
            txtTotalAmount.Text = "";
            txtTotalAmount.Text = "";
        }
       // Automatic Calculation Of textBoxes
        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            double t1, t2, t3;
            double.TryParse(txtTotalAmount.Text, out t1);
            double.TryParse(txtTotalMember.Text, out t2);
            t3 = t1 / t2;
            if(t3 > 0)
            {
                txtCountry.Text = t3.ToString("c").Remove(0, 1);
            }
        }

        private void txtTotalMember_TextChanged(object sender, EventArgs e)
        {
            double t1, t2, t3;
            double.TryParse(txtTotalAmount.Text, out t1);
            double.TryParse(txtTotalMember.Text, out t2);
            t3 = t1 / t2;
            if (t3 > 0)
            {
                txtCountry.Text = t3.ToString("c").Remove(0, 1);
            }
            txtDuration.Text = txtTotalMember.Text;
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            txtTotalMember.Text = txtDuration.Text;
        }


        // Button click
        private void txtCreate_Click(object sender, EventArgs e)
        {            
            if (txtBcName.Text == "" || txtTotalAmount.Text == "" || txtTotalMember.Text == "") // validation for empty textbox
            {
                MessageBox.Show("Fill The Required Fields");
            }
            else
            {
                model.fullName = txtBcName.Text.Trim();
                model.totalAmount = txtTotalAmount.Text.Trim();
                model.totalMember = txtTotalMember.Text.Trim();
                model.duration = txtDuration.Text.Trim();
                model.monthlyContryPerPerson = txtCountry.Text.Trim();
                model.startDate = dtpStartdate.Value;
                model.endDate = dtpEndDate.Value;

                int i = 0;
                List<int> ChkedRow = new List<int>();                        
                            
             
                using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                {
                    if (model.id == 0)
                    {
                        mc.Bcs.Add(model);
                        

                    }
                    try // for Entity Exception
                    {
                        mc.SaveChanges();
                    }
                    catch (DbEntityValidationException c)
                    {
                        foreach (var eve in c.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                    }                    
                    MessageBox.Show("Beesi Created Succefully.");
                }



            }
        }

        // Validations
        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtTotalMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

       

        private void EditBeesi_Click(object sender, EventArgs e)
        {
            dgv();
            dgvBeesi.Visible = true;
            btnDelete.Visible = true;
            clear();
            btnDelete.Enabled = false;
            txtCreate.Enabled = true;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Details ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Bcs.Attach(model);
                        MC.Bcs.Remove(model);
                        MC.SaveChanges();
                        clear();
                        MessageBox.Show("Deleted Successfully");
                        dgvBeesi.DataSource = mc.Bcs.ToList();
                    }
                }
            }
            btnDelete.Enabled = false;
            txtCreate.Enabled = true;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mc.Entry(model).State = EntityState.Modified;
            btnDelete.Enabled = false;
           
        }

        private void dgvBeesi_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvBeesi.CurrentRow.Index != -1)
                {
                    model.id = Convert.ToInt32(dgvBeesi.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        model = mc.Bcs.Where(x => x.id == model.id).FirstOrDefault();
                        txtBcName.Text = model.fullName;
                        txtCountry.Text = model.monthlyContryPerPerson;
                        txtDuration.Text = model.duration;
                        txtTotalAmount.Text = model.totalAmount;
                        txtTotalMember.Text = model.totalAmount;
                        btnDelete.Enabled = true;
                        txtCreate.Enabled = false;

                    }
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Beesi Not Available");
            }

        }

    }
    }

