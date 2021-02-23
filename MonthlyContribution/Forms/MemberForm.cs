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
    public partial class MemberForm : Form
    {
        Member model = new Member();
        MonthlyContributionEntities MC;



        public MemberForm()
        {
            InitializeComponent();
            MC = new MonthlyContributionEntities();
            LoadTheme();

        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            dvg();
        }
        // Themes 
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
        // Data Grid View
        public void dvg()
        {
            MC = new MonthlyContributionEntities();
            memberBindingSource.DataSource = MC.Members.ToList();
            clear();
        }

        private void dvgMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgMembers_Click(object sender, EventArgs e)
        {
            try
            {
             if (dvgMembers.CurrentRow.Index != -1)
                {
                    model.id = Convert.ToInt32(dvgMembers.CurrentRow.Cells["id"].Value);
                    using (MonthlyContributionEntities mc = new MonthlyContributionEntities())
                    {
                        model = mc.Members.Where(x => x.id == model.id).FirstOrDefault();
                        txtFullName.Text = model.fullName;
                        txtMobile.Text = model.mobile;
                        txtEmailId.Text = model.emailId;
                        txtCity.Text = model.city;
                        // model.updatedAt = DateTime.Now;
                    }
                    btnAdd.Text = "Update";
                    btnDelete.Enabled = true;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("There Are No Member Available");
            }
        }





        //Clear Text Box FOnction
        void clear()
        {
            txtFullName.Text = txtMobile.Text = txtEmailId.Text = dateTimePickerDOB.Text = txtCity.Text = "";
            btnAdd.Text = "Add";
            btnDelete.Enabled = false;
            model.id = 0;
        }
        // Reload form funtion
        private void ReloadForm()
        {
            MemberForm mf = new MemberForm();
            mf.Refresh();

        }
        
        // Button Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            txtCity.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == ""  ||  txtEmailId.Text == "" || txtMobile.Text == "")
            {
                MessageBox.Show("Fill The Required Fields ");
            }
            else if (!this.txtEmailId.Text.Contains('@') || !this.txtEmailId.Text.Contains('.'))
            {
                MessageBox.Show("Enter Wright Email Address");
            }
            else
            {
                ReloadForm();
                model.fullName = txtFullName.Text.Trim();
                model.mobile = txtMobile.Text.Trim();
                model.emailId = txtEmailId.Text.Trim();
                model.DOB = dateTimePickerDOB.Value;
                model.city = txtCity.Text.Trim();
                //model.createdAt = DateTime.Now;
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    if (model.id == 0) //for Insert
                    {
                        MC.Members.Add(model);
                    }
                    else
                    {
                        MC.Entry(model).State = EntityState.Modified;//for Update
                    }
                    try
                    {
                        MC.SaveChanges();
                    }
                    catch(DbEntityValidationException c)
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
                }
                clear();
                MessageBox.Show("Submitted Successfully.");
                dvg();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonthlyContributionEntities MC = new MonthlyContributionEntities())
                {
                    var entry = MC.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        MC.Members.Attach(model);
                        MC.Members.Remove(model);
                        MC.SaveChanges();
                        clear();
                        MessageBox.Show("Deleted Successfully");
                        dvg();
                    }
                }
            }
        }

        // Date Time PIcker
        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerDOB.CustomFormat = "dd-MM-yyyy";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            if(txtMobile.Text.Length > 10)
            {
                MessageBox.Show("Mobile Number is Wrong ");
                txtMobile.Text = "";
            }

        }
    }
}