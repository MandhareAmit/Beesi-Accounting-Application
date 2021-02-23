using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MonthlyContribution
{
    public partial class HomePage : Form
    {

        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public HomePage()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            custmizDesing();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HomePage_Load(object sender, EventArgs e)
        {
            panelBcOption.Visible = false;
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
        private void SetMyButtonIcon()
        {
            // Assign an image to the button.
            //btnM.Image = Image.FromFile("C:\\Graphics\\My.ico");
            // Align the image and text on the button.
            btnMembers.ImageAlign = ContentAlignment.MiddleRight;
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
        }
        //Themes and child form
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                    PanelTitleBar.BackColor = color;
                    PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in MenuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleBar.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            labelTitleBar.Text = "HOME";
            PanelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            PanelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }

        //Sub Menu 
        private void custmizDesing() 
        {
            panelBcOption.Visible = false;
            panelReportOption.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelBcOption.Visible == true) 
            {
                panelBcOption.Visible = false;
            }

            if (panelReportOption.Visible == true)
            {
                panelReportOption.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        

        // Button Click
        private void btnMembers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MemberForm(), sender);
//            pictureBox1.BackColor = Color.FromArgb(111, 75, 165);
            
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            labelTitleBar.Text = "HOME";
            if (activeForm != null)
                activeForm.Close();
           // Reset();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            //showSubMenu(panelReportOption);
            OpenChildForm(new Forms.Monthly_Report(), sender);
            hideSubMenu();
        }

       

        private void btnYearly_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new Forms.Yearly_Report(), sender);
        }

        private void btnPaymentDetails_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Payment_Details(), sender);
        }

        private void btnReminder_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reminder(), sender);
        }

        private void btnCurrentBc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BC_Current(), sender);
            hideSubMenu();
            labelTitleBar.Text = "Current Beesi";
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            showSubMenu(panelBcOption);
            
        }


        private void btnBcHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BC_History(), sender);
            hideSubMenu();
        }

      

        private void btnBcNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Create_New_BC(), sender);
            hideSubMenu();
        }

      

        // Mouse Oparations
     
        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.Show();

            ActivateButton(sender);

        }

        private void btnMonthly_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Monthly_Report(), sender);
            hideSubMenu();
        }

        private void btnGuid_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.About_us(), sender);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
