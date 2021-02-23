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
    public partial class BC_History : Form
    {
        MonthlyContributionEntities mc = new MonthlyContributionEntities();
        public BC_History()
        {
            InitializeComponent();
        }

        private void BC_History_Load(object sender, EventArgs e)
        {
            LoadTheme();
            panelmonthbtn.Visible = false;
            dgvBeesi.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            cmbx();
            cmbemt();
            cmbdata();
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

        public void cmbemt()
        {
            ((ComboBox)txtBcJan).SelectedIndex = -1;
            ((ComboBox)txtBcFeb).SelectedIndex = -1;
            ((ComboBox)txtBcMar).SelectedIndex = -1;
            ((ComboBox)txtBcApril).SelectedIndex = -1;
            ((ComboBox)txtBcMay).SelectedIndex = -1;
            ((ComboBox)txtBcJun).SelectedIndex = -1;
            ((ComboBox)txtBcJul).SelectedIndex = -1;
            ((ComboBox)txtBcAug).SelectedIndex = -1;
            ((ComboBox)txtBcSep).SelectedIndex = -1;
            ((ComboBox)txtBcOct).SelectedIndex = -1;
            ((ComboBox)txtBcNov).SelectedIndex = -1;
            ((ComboBox)txtBcDec).SelectedIndex = -1;


        }
        public void cmbdata()
        {
            txtBcJan.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcFeb.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcMar.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcApril.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcMay.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcJun.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcJul.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcAug.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcSep.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcOct.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcNov.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
            txtBcDec.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
        }
        public void cmbx()
        {
            panelcombobox.Visible = false;
            txtBcJan.Visible = false;
            txtBcFeb.Visible = false;
            txtBcMar.Visible = false;
            txtBcApril.Visible = false;
            txtBcMay.Visible = false;
            txtBcJun.Visible = false;
            txtBcJul.Visible = false;
            txtBcAug.Visible = false;
            txtBcSep.Visible = false;
            txtBcOct.Visible = false;
            txtBcNov.Visible = false;
            txtBcDec.Visible = false;
        }
        
        private void btnMonth_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = true;
            cmbx();
            cmbemt();
            dgvReport.DataSource = mc.Bcs.Where(x => x.endDate < DateTime.Now).ToList();
        }
      
        private void btnJun_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcJun.Visible = true;
            panelcombobox.Visible = true;


        }

        private void btnJul_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcJul.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnAug_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcAug.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnSep_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcSep.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcOct.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcNov.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcDec.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnJan_Click_1(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcJan.Visible = true;            
            panelcombobox.Visible = true;
        }

        private void btnFeb_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcFeb.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnMar_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcMar.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnApril_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;
            txtBcApril.Visible = true;
            panelcombobox.Visible = true;
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            panelmonthbtn.Visible = false;            
            txtBcMay.Visible = true;
            panelcombobox.Visible = true;
        }

        private void txtselectBeesi_SelectedIndexChanged(object sender, EventArgs e)
        {
           dgvReport.DataSource = mc.First_mR.Where(x => x.bcName.Contains(txtBcJan.Text)).ToList();           
        }

        private void txtBcFeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Second_R.Where(x => x.bcName.Contains(txtBcFeb.Text)).ToList();
        }

        private void txtBcMar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Third_mR.Where(x => x.bcName.Contains(txtBcMar.Text)).ToList();
        }

        private void txtBcApril_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.fourt_mr.Where(x => x.bcName.Contains(txtBcApril.Text)).ToList();
        }

        private void txtBcMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Fifth_mR.Where(x => x.bcName.Contains(txtBcMay.Text)).ToList();
        }

        private void txtBcJun_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Sixth_mR.Where(x => x.bcName.Contains(txtBcJun.Text)).ToList();
        }

        private void txtBcJul_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Seven_mR.Where(x => x.bcName.Contains(txtBcJul.Text)).ToList();
        }

        private void txtBcAug_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Eight_mR.Where(x => x.bcName.Contains(txtBcAug.Text)).ToList();
        }

        private void txtBcSep_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Nine_mR.Where(x => x.bcName.Contains(txtBcSep.Text)).ToList();
        }

        private void txtBcOct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Teen_mR.Where(x => x.bcName.Contains(txtBcOct.Text)).ToList();
        }

        private void txtBcNov_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Eleven_mR.Where(x => x.bcName.Contains(txtBcNov.Text)).ToList();
        }

        private void txtBcDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = mc.Twelve_mR.Where(x => x.bcName.Contains(txtBcDec.Text)).ToList();
        }
    }
}
