namespace MonthlyContribution.Forms
{
    partial class Payment_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboBoxPaymentType = new MetroFramework.Controls.MetroComboBox();
            this.dgvSelectName = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailSend = new MetroFramework.Controls.MetroTextBox();
            this.txtMemberEmail = new MetroFramework.Controls.MetroTextBox();
            this.panelbody = new MetroFramework.Controls.MetroPanel();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtBcName = new System.Windows.Forms.TextBox();
            this.txtEBName = new System.Windows.Forms.TextBox();
            this.txtPassE = new MetroFramework.Controls.MetroTextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvBcName = new System.Windows.Forms.DataGridView();
            this.dgvmember = new System.Windows.Forms.DataGridView();
            this.btnSelectSender = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyContryPerPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectName)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBcName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmember)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxPaymentType
            // 
            this.ComboBoxPaymentType.FormattingEnabled = true;
            this.ComboBoxPaymentType.ItemHeight = 23;
            this.ComboBoxPaymentType.Items.AddRange(new object[] {
            "Google Pay",
            "Phone Pay",
            "Paytm",
            "Amazon Pay"});
            this.ComboBoxPaymentType.Location = new System.Drawing.Point(62, 304);
            this.ComboBoxPaymentType.Name = "ComboBoxPaymentType";
            this.ComboBoxPaymentType.PromptText = "Select Type";
            this.ComboBoxPaymentType.Size = new System.Drawing.Size(273, 29);
            this.ComboBoxPaymentType.TabIndex = 5;
            this.ComboBoxPaymentType.UseSelectable = true;
            // 
            // dgvSelectName
            // 
            this.dgvSelectName.AllowUserToAddRows = false;
            this.dgvSelectName.AllowUserToDeleteRows = false;
            this.dgvSelectName.AllowUserToOrderColumns = true;
            this.dgvSelectName.AllowUserToResizeColumns = false;
            this.dgvSelectName.AllowUserToResizeRows = false;
            this.dgvSelectName.AutoGenerateColumns = false;
            this.dgvSelectName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectName.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn2,
            this.mobileDataGridViewTextBoxColumn1,
            this.emailIdDataGridViewTextBoxColumn1,
            this.dOBDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.statusCodeDataGridViewTextBoxColumn2,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn2});
            this.dgvSelectName.DataSource = this.memberBindingSource;
            this.dgvSelectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectName.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSelectName.Location = new System.Drawing.Point(0, 0);
            this.dgvSelectName.Name = "dgvSelectName";
            this.dgvSelectName.ReadOnly = true;
            this.dgvSelectName.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSelectName.RowHeadersVisible = false;
            this.dgvSelectName.Size = new System.Drawing.Size(512, 175);
            this.dgvSelectName.TabIndex = 5;
            this.dgvSelectName.Click += new System.EventHandler(this.dgvSelectName_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DimGray;
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtAmount);
            this.metroPanel1.Controls.Add(this.ComboBoxPaymentType);
            this.metroPanel1.Controls.Add(this.txtEmailSend);
            this.metroPanel1.Controls.Add(this.txtMemberEmail);
            this.metroPanel1.Controls.Add(this.panelbody);
            this.metroPanel1.Controls.Add(this.txtPassE);
            this.metroPanel1.Controls.Add(this.btnSendEmail);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(511, 522);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(63, 250);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "Amount";
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(273, 29);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "Amount";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmailSend
            // 
            // 
            // 
            // 
            this.txtEmailSend.CustomButton.Image = null;
            this.txtEmailSend.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txtEmailSend.CustomButton.Name = "";
            this.txtEmailSend.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEmailSend.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailSend.CustomButton.TabIndex = 1;
            this.txtEmailSend.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailSend.CustomButton.UseSelectable = true;
            this.txtEmailSend.CustomButton.Visible = false;
            this.txtEmailSend.Enabled = false;
            this.txtEmailSend.Lines = new string[0];
            this.txtEmailSend.Location = new System.Drawing.Point(63, 77);
            this.txtEmailSend.MaxLength = 32767;
            this.txtEmailSend.Name = "txtEmailSend";
            this.txtEmailSend.PasswordChar = '\0';
            this.txtEmailSend.PromptText = "Email";
            this.txtEmailSend.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailSend.SelectedText = "";
            this.txtEmailSend.SelectionLength = 0;
            this.txtEmailSend.SelectionStart = 0;
            this.txtEmailSend.ShortcutsEnabled = true;
            this.txtEmailSend.Size = new System.Drawing.Size(273, 29);
            this.txtEmailSend.TabIndex = 10;
            this.txtEmailSend.UseSelectable = true;
            this.txtEmailSend.WaterMark = "Email";
            this.txtEmailSend.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailSend.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMemberEmail
            // 
            // 
            // 
            // 
            this.txtMemberEmail.CustomButton.Image = null;
            this.txtMemberEmail.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txtMemberEmail.CustomButton.Name = "";
            this.txtMemberEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMemberEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemberEmail.CustomButton.TabIndex = 1;
            this.txtMemberEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemberEmail.CustomButton.UseSelectable = true;
            this.txtMemberEmail.CustomButton.Visible = false;
            this.txtMemberEmail.Enabled = false;
            this.txtMemberEmail.Lines = new string[0];
            this.txtMemberEmail.Location = new System.Drawing.Point(63, 195);
            this.txtMemberEmail.MaxLength = 32767;
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.PasswordChar = '\0';
            this.txtMemberEmail.PromptText = "Email Id";
            this.txtMemberEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberEmail.SelectedText = "";
            this.txtMemberEmail.SelectionLength = 0;
            this.txtMemberEmail.SelectionStart = 0;
            this.txtMemberEmail.ShortcutsEnabled = true;
            this.txtMemberEmail.Size = new System.Drawing.Size(273, 29);
            this.txtMemberEmail.TabIndex = 9;
            this.txtMemberEmail.UseSelectable = true;
            this.txtMemberEmail.WaterMark = "Email Id";
            this.txtMemberEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelbody
            // 
            this.panelbody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbody.Controls.Add(this.txtMobile);
            this.panelbody.Controls.Add(this.txtMemberName);
            this.panelbody.Controls.Add(this.txtBcName);
            this.panelbody.Controls.Add(this.txtEBName);
            this.panelbody.HorizontalScrollbarBarColor = true;
            this.panelbody.HorizontalScrollbarHighlightOnWheel = false;
            this.panelbody.HorizontalScrollbarSize = 10;
            this.panelbody.Location = new System.Drawing.Point(6, 426);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(505, 51);
            this.panelbody.TabIndex = 8;
            this.panelbody.VerticalScrollbarBarColor = true;
            this.panelbody.VerticalScrollbarHighlightOnWheel = false;
            this.panelbody.VerticalScrollbarSize = 10;
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(204, 56);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(165, 30);
            this.txtMobile.TabIndex = 7;
            this.txtMobile.Text = "Mobile";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(197, 11);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(165, 30);
            this.txtMemberName.TabIndex = 5;
            this.txtMemberName.Text = "member name";
            // 
            // txtBcName
            // 
            this.txtBcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcName.Location = new System.Drawing.Point(0, 92);
            this.txtBcName.Name = "txtBcName";
            this.txtBcName.Size = new System.Drawing.Size(165, 30);
            this.txtBcName.TabIndex = 4;
            this.txtBcName.Text = "bc name";
            // 
            // txtEBName
            // 
            this.txtEBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEBName.Location = new System.Drawing.Point(0, 11);
            this.txtEBName.Name = "txtEBName";
            this.txtEBName.Size = new System.Drawing.Size(165, 30);
            this.txtEBName.TabIndex = 2;
            this.txtEBName.Text = "pName";
            // 
            // txtPassE
            // 
            // 
            // 
            // 
            this.txtPassE.CustomButton.Image = null;
            this.txtPassE.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txtPassE.CustomButton.Name = "";
            this.txtPassE.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassE.CustomButton.TabIndex = 1;
            this.txtPassE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassE.CustomButton.UseSelectable = true;
            this.txtPassE.CustomButton.Visible = false;
            this.txtPassE.Lines = new string[0];
            this.txtPassE.Location = new System.Drawing.Point(63, 135);
            this.txtPassE.MaxLength = 32767;
            this.txtPassE.Name = "txtPassE";
            this.txtPassE.PasswordChar = '*';
            this.txtPassE.PromptText = "Password";
            this.txtPassE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassE.SelectedText = "";
            this.txtPassE.SelectionLength = 0;
            this.txtPassE.SelectionStart = 0;
            this.txtPassE.ShortcutsEnabled = true;
            this.txtPassE.Size = new System.Drawing.Size(273, 29);
            this.txtPassE.TabIndex = 7;
            this.txtPassE.UseSelectable = true;
            this.txtPassE.WaterMark = "Password";
            this.txtPassE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(133, 355);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(111, 29);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(102, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(208, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Send Payment Request";
            // 
            // dgvBcName
            // 
            this.dgvBcName.AllowUserToAddRows = false;
            this.dgvBcName.AllowUserToDeleteRows = false;
            this.dgvBcName.AllowUserToOrderColumns = true;
            this.dgvBcName.AllowUserToResizeColumns = false;
            this.dgvBcName.AllowUserToResizeRows = false;
            this.dgvBcName.AutoGenerateColumns = false;
            this.dgvBcName.BackgroundColor = System.Drawing.Color.White;
            this.dgvBcName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBcName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBcName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.monthlyContryPerPersonDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn1,
            this.updatedAtDataGridViewTextBoxColumn,
            this.totalMemberDataGridViewTextBoxColumn});
            this.dgvBcName.DataSource = this.bcBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBcName.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBcName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBcName.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBcName.Location = new System.Drawing.Point(0, 0);
            this.dgvBcName.Name = "dgvBcName";
            this.dgvBcName.ReadOnly = true;
            this.dgvBcName.RowHeadersVisible = false;
            this.dgvBcName.Size = new System.Drawing.Size(512, 138);
            this.dgvBcName.TabIndex = 0;
            this.dgvBcName.Click += new System.EventHandler(this.dgvBcName_Click);
            // 
            // dgvmember
            // 
            this.dgvmember.AllowUserToAddRows = false;
            this.dgvmember.AllowUserToDeleteRows = false;
            this.dgvmember.AllowUserToOrderColumns = true;
            this.dgvmember.AllowUserToResizeColumns = false;
            this.dgvmember.AllowUserToResizeRows = false;
            this.dgvmember.AutoGenerateColumns = false;
            this.dgvmember.BackgroundColor = System.Drawing.Color.White;
            this.dgvmember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.fullNameDataGridViewTextBoxColumn1,
            this.mobileDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn1,
            this.createdAtDataGridViewTextBoxColumn2,
            this.updatedAtDataGridViewTextBoxColumn1});
            this.dgvmember.DataSource = this.memberBindingSource;
            this.dgvmember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmember.Location = new System.Drawing.Point(0, 0);
            this.dgvmember.Name = "dgvmember";
            this.dgvmember.ReadOnly = true;
            this.dgvmember.RowHeadersVisible = false;
            this.dgvmember.RowTemplate.ReadOnly = true;
            this.dgvmember.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmember.Size = new System.Drawing.Size(512, 179);
            this.dgvmember.TabIndex = 1;
            this.dgvmember.Click += new System.EventHandler(this.dgvmember_Click);
            // 
            // btnSelectSender
            // 
            this.btnSelectSender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectSender.Location = new System.Drawing.Point(0, 0);
            this.btnSelectSender.Name = "btnSelectSender";
            this.btnSelectSender.Size = new System.Drawing.Size(512, 30);
            this.btnSelectSender.TabIndex = 7;
            this.btnSelectSender.Text = "Select Details";
            this.btnSelectSender.UseSelectable = true;
            this.btnSelectSender.Click += new System.EventHandler(this.btnSelectSender_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 528);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSelectSender);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(520, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 522);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvBcName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 138);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvmember);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 179);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSelectName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 175);
            this.panel2.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(34, 401);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(450, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "NOTE :- First Select Details (Your Name, Member Name and Beesi)";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "                                                        Beesi Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "totalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "totalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Visible = false;
            // 
            // monthlyContryPerPersonDataGridViewTextBoxColumn
            // 
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.DataPropertyName = "monthlyContryPerPerson";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.HeaderText = "monthlyContryPerPerson";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.Name = "monthlyContryPerPersonDataGridViewTextBoxColumn";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "endDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "endDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            this.statusCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn1
            // 
            this.createdAtDataGridViewTextBoxColumn1.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn1.HeaderText = "createdAt";
            this.createdAtDataGridViewTextBoxColumn1.Name = "createdAtDataGridViewTextBoxColumn1";
            this.createdAtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn1.Visible = false;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalMemberDataGridViewTextBoxColumn
            // 
            this.totalMemberDataGridViewTextBoxColumn.DataPropertyName = "totalMember";
            this.totalMemberDataGridViewTextBoxColumn.HeaderText = "totalMember";
            this.totalMemberDataGridViewTextBoxColumn.Name = "totalMemberDataGridViewTextBoxColumn";
            this.totalMemberDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalMemberDataGridViewTextBoxColumn.Visible = false;
            // 
            // bcBindingSource1
            // 
            this.bcBindingSource1.DataSource = typeof(MonthlyContribution.EntitiesModel.Bc);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "                                                       Member Name";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            this.fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            this.emailIdDataGridViewTextBoxColumn.DataPropertyName = "emailId";
            this.emailIdDataGridViewTextBoxColumn.HeaderText = "emailId";
            this.emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            this.emailIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOBDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusCodeDataGridViewTextBoxColumn1
            // 
            this.statusCodeDataGridViewTextBoxColumn1.DataPropertyName = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn1.HeaderText = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn1.Name = "statusCodeDataGridViewTextBoxColumn1";
            this.statusCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn2
            // 
            this.createdAtDataGridViewTextBoxColumn2.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn2.HeaderText = "createdAt";
            this.createdAtDataGridViewTextBoxColumn2.Name = "createdAtDataGridViewTextBoxColumn2";
            this.createdAtDataGridViewTextBoxColumn2.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn2.Visible = false;
            // 
            // updatedAtDataGridViewTextBoxColumn1
            // 
            this.updatedAtDataGridViewTextBoxColumn1.DataPropertyName = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.HeaderText = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.Name = "updatedAtDataGridViewTextBoxColumn1";
            this.updatedAtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn1.Visible = false;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Member);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn2
            // 
            this.fullNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn2.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn2.HeaderText = "                                                        Your Name";
            this.fullNameDataGridViewTextBoxColumn2.Name = "fullNameDataGridViewTextBoxColumn2";
            this.fullNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn1
            // 
            this.mobileDataGridViewTextBoxColumn1.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn1.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn1.Name = "mobileDataGridViewTextBoxColumn1";
            this.mobileDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn1.Visible = false;
            // 
            // emailIdDataGridViewTextBoxColumn1
            // 
            this.emailIdDataGridViewTextBoxColumn1.DataPropertyName = "emailId";
            this.emailIdDataGridViewTextBoxColumn1.HeaderText = "emailId";
            this.emailIdDataGridViewTextBoxColumn1.Name = "emailIdDataGridViewTextBoxColumn1";
            this.emailIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dOBDataGridViewTextBoxColumn1
            // 
            this.dOBDataGridViewTextBoxColumn1.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn1.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn1.Name = "dOBDataGridViewTextBoxColumn1";
            this.dOBDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dOBDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn1.Visible = false;
            // 
            // statusCodeDataGridViewTextBoxColumn2
            // 
            this.statusCodeDataGridViewTextBoxColumn2.DataPropertyName = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn2.HeaderText = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn2.Name = "statusCodeDataGridViewTextBoxColumn2";
            this.statusCodeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn2.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedAtDataGridViewTextBoxColumn2
            // 
            this.updatedAtDataGridViewTextBoxColumn2.DataPropertyName = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn2.HeaderText = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn2.Name = "updatedAtDataGridViewTextBoxColumn2";
            this.updatedAtDataGridViewTextBoxColumn2.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn2.Visible = false;
            // 
            // pmethodBindingSource
            // 
            this.pmethodBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Pmethod);
            // 
            // bcBindingSource
            // 
            this.bcBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Bc);
            // 
            // Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Payment_Details";
            this.Text = "Payment_Request";
            this.Load += new System.EventHandler(this.Payment_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectName)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBcName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmember)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox ComboBoxPaymentType;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource pmethodBindingSource;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private MetroFramework.Controls.MetroTextBox txtPassE;
        private MetroFramework.Controls.MetroPanel panelbody;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtBcName;
        private System.Windows.Forms.TextBox txtEBName;
        private System.Windows.Forms.DataGridView dgvBcName;
        private System.Windows.Forms.BindingSource bcBindingSource1;
        private System.Windows.Forms.BindingSource bcBindingSource;
        private MetroFramework.Controls.MetroTextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.DataGridView dgvSelectName;
        private MetroFramework.Controls.MetroTextBox txtEmailSend;
        private System.Windows.Forms.DataGridView dgvmember;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyContryPerPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroButton btnSelectSender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}