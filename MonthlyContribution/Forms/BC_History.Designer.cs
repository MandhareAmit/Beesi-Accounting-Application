namespace MonthlyContribution.Forms
{
    partial class BC_History
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
            System.Windows.Forms.Button btnMonth;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBeesi = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyContryPerPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvReport = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstmRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelmonthbtn = new System.Windows.Forms.Panel();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnNov = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnSep = new System.Windows.Forms.Button();
            this.btnAug = new System.Windows.Forms.Button();
            this.btnJul = new System.Windows.Forms.Button();
            this.btnJun = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnApril = new System.Windows.Forms.Button();
            this.btnMar = new System.Windows.Forms.Button();
            this.btnFeb = new System.Windows.Forms.Button();
            this.btnJan = new System.Windows.Forms.Button();
            this.panelcombobox = new System.Windows.Forms.Panel();
            this.txtBcDec = new MetroFramework.Controls.MetroComboBox();
            this.txtBcNov = new MetroFramework.Controls.MetroComboBox();
            this.txtBcOct = new MetroFramework.Controls.MetroComboBox();
            this.txtBcSep = new MetroFramework.Controls.MetroComboBox();
            this.txtBcAug = new MetroFramework.Controls.MetroComboBox();
            this.txtBcJul = new MetroFramework.Controls.MetroComboBox();
            this.txtBcJun = new MetroFramework.Controls.MetroComboBox();
            this.txtBcMay = new MetroFramework.Controls.MetroComboBox();
            this.txtBcApril = new MetroFramework.Controls.MetroComboBox();
            this.txtBcMar = new MetroFramework.Controls.MetroComboBox();
            this.txtBcFeb = new MetroFramework.Controls.MetroComboBox();
            this.txtBcJan = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            btnMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstmRBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelmonthbtn.SuspendLayout();
            this.panelcombobox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMonth
            // 
            btnMonth.Dock = System.Windows.Forms.DockStyle.Top;
            btnMonth.Location = new System.Drawing.Point(3, 3);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new System.Drawing.Size(142, 27);
            btnMonth.TabIndex = 3;
            btnMonth.Text = "Select Month";
            btnMonth.UseVisualStyleBackColor = true;
            btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dgvBeesi
            // 
            this.dgvBeesi.AllowUserToResizeRows = false;
            this.dgvBeesi.AutoGenerateColumns = false;
            this.dgvBeesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.dgvBeesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBeesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.monthlyContryPerPersonDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn,
            this.totalMemberDataGridViewTextBoxColumn});
            this.dgvBeesi.DataSource = this.bcBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBeesi.EnableHeadersVisualStyles = false;
            this.dgvBeesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBeesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBeesi.Location = new System.Drawing.Point(0, 0);
            this.dgvBeesi.Name = "dgvBeesi";
            this.dgvBeesi.ReadOnly = true;
            this.dgvBeesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBeesi.RowHeadersVisible = false;
            this.dgvBeesi.RowHeadersWidth = 44;
            this.dgvBeesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeesi.RowTemplate.Height = 28;
            this.dgvBeesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeesi.Size = new System.Drawing.Size(800, 174);
            this.dgvBeesi.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Beesi";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "totalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyContryPerPersonDataGridViewTextBoxColumn
            // 
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.DataPropertyName = "monthlyContryPerPerson";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.HeaderText = "Monthly Contry PerPerson";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.Name = "monthlyContryPerPersonDataGridViewTextBoxColumn";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "endDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            this.statusCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Visible = false;
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
            this.totalMemberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMemberDataGridViewTextBoxColumn.DataPropertyName = "totalMember";
            this.totalMemberDataGridViewTextBoxColumn.HeaderText = "Total Member";
            this.totalMemberDataGridViewTextBoxColumn.Name = "totalMemberDataGridViewTextBoxColumn";
            this.totalMemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bcBindingSource
            // 
            this.bcBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Bc);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReport.ColumnHeadersHeight = 30;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.bcNameDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.monthlyAmountDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.paidAmountDataGridViewTextBoxColumn,
            this.collectedAmountDataGridViewTextBoxColumn,
            this.memberIdDataGridViewTextBoxColumn,
            this.bcidDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn1});
            this.dgvReport.DataSource = this.firstmRBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReport.Location = new System.Drawing.Point(117, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReport.RowTemplate.Height = 28;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(680, 407);
            this.dgvReport.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bcNameDataGridViewTextBoxColumn
            // 
            this.bcNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bcNameDataGridViewTextBoxColumn.DataPropertyName = "bcName";
            this.bcNameDataGridViewTextBoxColumn.HeaderText = "Beesi";
            this.bcNameDataGridViewTextBoxColumn.Name = "bcNameDataGridViewTextBoxColumn";
            this.bcNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyAmountDataGridViewTextBoxColumn
            // 
            this.monthlyAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monthlyAmountDataGridViewTextBoxColumn.DataPropertyName = "monthlyAmount";
            this.monthlyAmountDataGridViewTextBoxColumn.HeaderText = "Monthly Amount";
            this.monthlyAmountDataGridViewTextBoxColumn.Name = "monthlyAmountDataGridViewTextBoxColumn";
            this.monthlyAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidAmountDataGridViewTextBoxColumn
            // 
            this.paidAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paidAmountDataGridViewTextBoxColumn.DataPropertyName = "paidAmount";
            this.paidAmountDataGridViewTextBoxColumn.HeaderText = "Paid Amount";
            this.paidAmountDataGridViewTextBoxColumn.Name = "paidAmountDataGridViewTextBoxColumn";
            this.paidAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectedAmountDataGridViewTextBoxColumn
            // 
            this.collectedAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collectedAmountDataGridViewTextBoxColumn.DataPropertyName = "collectedAmount";
            this.collectedAmountDataGridViewTextBoxColumn.HeaderText = "Collected Amount";
            this.collectedAmountDataGridViewTextBoxColumn.Name = "collectedAmountDataGridViewTextBoxColumn";
            this.collectedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            this.memberIdDataGridViewTextBoxColumn.DataPropertyName = "memberId";
            this.memberIdDataGridViewTextBoxColumn.HeaderText = "memberId";
            this.memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            this.memberIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bcidDataGridViewTextBoxColumn
            // 
            this.bcidDataGridViewTextBoxColumn.DataPropertyName = "bcid";
            this.bcidDataGridViewTextBoxColumn.HeaderText = "bcid";
            this.bcidDataGridViewTextBoxColumn.Name = "bcidDataGridViewTextBoxColumn";
            this.bcidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bcidDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedAtDataGridViewTextBoxColumn1
            // 
            this.updatedAtDataGridViewTextBoxColumn1.DataPropertyName = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.HeaderText = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.Name = "updatedAtDataGridViewTextBoxColumn1";
            this.updatedAtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn1.Visible = false;
            // 
            // firstmRBindingSource
            // 
            this.firstmRBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.First_mR);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75F));
            this.tableLayoutPanel1.Controls.Add(this.dgvReport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 433);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(btnMonth);
            this.flowLayoutPanel1.Controls.Add(this.panelmonthbtn);
            this.flowLayoutPanel1.Controls.Add(this.panelcombobox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 427);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panelmonthbtn
            // 
            this.panelmonthbtn.AutoScroll = true;
            this.panelmonthbtn.Controls.Add(this.btnDec);
            this.panelmonthbtn.Controls.Add(this.btnNov);
            this.panelmonthbtn.Controls.Add(this.btnOct);
            this.panelmonthbtn.Controls.Add(this.btnSep);
            this.panelmonthbtn.Controls.Add(this.btnAug);
            this.panelmonthbtn.Controls.Add(this.btnJul);
            this.panelmonthbtn.Controls.Add(this.btnJun);
            this.panelmonthbtn.Controls.Add(this.btnMay);
            this.panelmonthbtn.Controls.Add(this.btnApril);
            this.panelmonthbtn.Controls.Add(this.btnMar);
            this.panelmonthbtn.Controls.Add(this.btnFeb);
            this.panelmonthbtn.Controls.Add(this.btnJan);
            this.panelmonthbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmonthbtn.Location = new System.Drawing.Point(3, 36);
            this.panelmonthbtn.Name = "panelmonthbtn";
            this.panelmonthbtn.Size = new System.Drawing.Size(142, 353);
            this.panelmonthbtn.TabIndex = 4;
            // 
            // btnDec
            // 
            this.btnDec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDec.FlatAppearance.BorderSize = 0;
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.ForeColor = System.Drawing.Color.White;
            this.btnDec.Location = new System.Drawing.Point(0, 319);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(142, 29);
            this.btnDec.TabIndex = 15;
            this.btnDec.Text = "December";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnNov
            // 
            this.btnNov.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNov.FlatAppearance.BorderSize = 0;
            this.btnNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNov.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNov.ForeColor = System.Drawing.Color.White;
            this.btnNov.Location = new System.Drawing.Point(0, 290);
            this.btnNov.Name = "btnNov";
            this.btnNov.Size = new System.Drawing.Size(142, 29);
            this.btnNov.TabIndex = 14;
            this.btnNov.Text = "November";
            this.btnNov.UseVisualStyleBackColor = true;
            this.btnNov.Click += new System.EventHandler(this.btnNov_Click);
            // 
            // btnOct
            // 
            this.btnOct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOct.FlatAppearance.BorderSize = 0;
            this.btnOct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOct.ForeColor = System.Drawing.Color.White;
            this.btnOct.Location = new System.Drawing.Point(0, 261);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(142, 29);
            this.btnOct.TabIndex = 13;
            this.btnOct.Text = "October";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnSep
            // 
            this.btnSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSep.FlatAppearance.BorderSize = 0;
            this.btnSep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSep.ForeColor = System.Drawing.Color.White;
            this.btnSep.Location = new System.Drawing.Point(0, 232);
            this.btnSep.Name = "btnSep";
            this.btnSep.Size = new System.Drawing.Size(142, 29);
            this.btnSep.TabIndex = 12;
            this.btnSep.Text = "September";
            this.btnSep.UseVisualStyleBackColor = true;
            this.btnSep.Click += new System.EventHandler(this.btnSep_Click);
            // 
            // btnAug
            // 
            this.btnAug.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAug.FlatAppearance.BorderSize = 0;
            this.btnAug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAug.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAug.ForeColor = System.Drawing.Color.White;
            this.btnAug.Location = new System.Drawing.Point(0, 203);
            this.btnAug.Name = "btnAug";
            this.btnAug.Size = new System.Drawing.Size(142, 29);
            this.btnAug.TabIndex = 11;
            this.btnAug.Text = "August";
            this.btnAug.UseVisualStyleBackColor = true;
            this.btnAug.Click += new System.EventHandler(this.btnAug_Click);
            // 
            // btnJul
            // 
            this.btnJul.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJul.FlatAppearance.BorderSize = 0;
            this.btnJul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJul.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJul.ForeColor = System.Drawing.Color.White;
            this.btnJul.Location = new System.Drawing.Point(0, 174);
            this.btnJul.Name = "btnJul";
            this.btnJul.Size = new System.Drawing.Size(142, 29);
            this.btnJul.TabIndex = 10;
            this.btnJul.Text = "July";
            this.btnJul.UseVisualStyleBackColor = true;
            this.btnJul.Click += new System.EventHandler(this.btnJul_Click);
            // 
            // btnJun
            // 
            this.btnJun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJun.FlatAppearance.BorderSize = 0;
            this.btnJun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJun.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJun.ForeColor = System.Drawing.Color.White;
            this.btnJun.Location = new System.Drawing.Point(0, 145);
            this.btnJun.Name = "btnJun";
            this.btnJun.Size = new System.Drawing.Size(142, 29);
            this.btnJun.TabIndex = 9;
            this.btnJun.Text = "June";
            this.btnJun.UseVisualStyleBackColor = true;
            this.btnJun.Click += new System.EventHandler(this.btnJun_Click);
            // 
            // btnMay
            // 
            this.btnMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMay.FlatAppearance.BorderSize = 0;
            this.btnMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMay.ForeColor = System.Drawing.Color.White;
            this.btnMay.Location = new System.Drawing.Point(0, 116);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(142, 29);
            this.btnMay.TabIndex = 8;
            this.btnMay.Text = "May";
            this.btnMay.UseVisualStyleBackColor = true;
            this.btnMay.Click += new System.EventHandler(this.btnMay_Click);
            // 
            // btnApril
            // 
            this.btnApril.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApril.FlatAppearance.BorderSize = 0;
            this.btnApril.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApril.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApril.ForeColor = System.Drawing.Color.White;
            this.btnApril.Location = new System.Drawing.Point(0, 87);
            this.btnApril.Name = "btnApril";
            this.btnApril.Size = new System.Drawing.Size(142, 29);
            this.btnApril.TabIndex = 7;
            this.btnApril.Text = "April";
            this.btnApril.UseVisualStyleBackColor = true;
            this.btnApril.Click += new System.EventHandler(this.btnApril_Click);
            // 
            // btnMar
            // 
            this.btnMar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMar.FlatAppearance.BorderSize = 0;
            this.btnMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMar.ForeColor = System.Drawing.Color.White;
            this.btnMar.Location = new System.Drawing.Point(0, 58);
            this.btnMar.Name = "btnMar";
            this.btnMar.Size = new System.Drawing.Size(142, 29);
            this.btnMar.TabIndex = 6;
            this.btnMar.Text = "March";
            this.btnMar.UseVisualStyleBackColor = true;
            this.btnMar.Click += new System.EventHandler(this.btnMar_Click);
            // 
            // btnFeb
            // 
            this.btnFeb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeb.FlatAppearance.BorderSize = 0;
            this.btnFeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeb.ForeColor = System.Drawing.Color.White;
            this.btnFeb.Location = new System.Drawing.Point(0, 29);
            this.btnFeb.Name = "btnFeb";
            this.btnFeb.Size = new System.Drawing.Size(142, 29);
            this.btnFeb.TabIndex = 5;
            this.btnFeb.Text = "February";
            this.btnFeb.UseVisualStyleBackColor = true;
            this.btnFeb.Click += new System.EventHandler(this.btnFeb_Click);
            // 
            // btnJan
            // 
            this.btnJan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJan.FlatAppearance.BorderSize = 0;
            this.btnJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJan.ForeColor = System.Drawing.Color.White;
            this.btnJan.Location = new System.Drawing.Point(0, 0);
            this.btnJan.Name = "btnJan";
            this.btnJan.Size = new System.Drawing.Size(142, 29);
            this.btnJan.TabIndex = 4;
            this.btnJan.Text = "January";
            this.btnJan.UseVisualStyleBackColor = true;
            this.btnJan.Click += new System.EventHandler(this.btnJan_Click_1);
            // 
            // panelcombobox
            // 
            this.panelcombobox.AutoScroll = true;
            this.panelcombobox.Controls.Add(this.txtBcDec);
            this.panelcombobox.Controls.Add(this.txtBcNov);
            this.panelcombobox.Controls.Add(this.txtBcOct);
            this.panelcombobox.Controls.Add(this.txtBcSep);
            this.panelcombobox.Controls.Add(this.txtBcAug);
            this.panelcombobox.Controls.Add(this.txtBcJul);
            this.panelcombobox.Controls.Add(this.txtBcJun);
            this.panelcombobox.Controls.Add(this.txtBcMay);
            this.panelcombobox.Controls.Add(this.txtBcApril);
            this.panelcombobox.Controls.Add(this.txtBcMar);
            this.panelcombobox.Controls.Add(this.txtBcFeb);
            this.panelcombobox.Controls.Add(this.txtBcJan);
            this.panelcombobox.Location = new System.Drawing.Point(3, 395);
            this.panelcombobox.Name = "panelcombobox";
            this.panelcombobox.Size = new System.Drawing.Size(142, 54);
            this.panelcombobox.TabIndex = 5;
            // 
            // txtBcDec
            // 
            this.txtBcDec.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcDec.DataSource = this.bcBindingSource;
            this.txtBcDec.DisplayMember = "fullName";
            this.txtBcDec.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcDec.FormattingEnabled = true;
            this.txtBcDec.ItemHeight = 23;
            this.txtBcDec.Location = new System.Drawing.Point(0, 319);
            this.txtBcDec.Name = "txtBcDec";
            this.txtBcDec.PromptText = "Select Beesi";
            this.txtBcDec.Size = new System.Drawing.Size(125, 29);
            this.txtBcDec.TabIndex = 13;
            this.txtBcDec.UseSelectable = true;
            this.txtBcDec.ValueMember = "fullName";
            this.txtBcDec.SelectedIndexChanged += new System.EventHandler(this.txtBcDec_SelectedIndexChanged);
            // 
            // txtBcNov
            // 
            this.txtBcNov.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcNov.DataSource = this.bcBindingSource;
            this.txtBcNov.DisplayMember = "fullName";
            this.txtBcNov.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcNov.FormattingEnabled = true;
            this.txtBcNov.ItemHeight = 23;
            this.txtBcNov.Location = new System.Drawing.Point(0, 290);
            this.txtBcNov.Name = "txtBcNov";
            this.txtBcNov.PromptText = "Select Beesi";
            this.txtBcNov.Size = new System.Drawing.Size(125, 29);
            this.txtBcNov.TabIndex = 12;
            this.txtBcNov.UseSelectable = true;
            this.txtBcNov.ValueMember = "fullName";
            this.txtBcNov.SelectedIndexChanged += new System.EventHandler(this.txtBcNov_SelectedIndexChanged);
            // 
            // txtBcOct
            // 
            this.txtBcOct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcOct.DataSource = this.bcBindingSource;
            this.txtBcOct.DisplayMember = "fullName";
            this.txtBcOct.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcOct.FormattingEnabled = true;
            this.txtBcOct.ItemHeight = 23;
            this.txtBcOct.Location = new System.Drawing.Point(0, 261);
            this.txtBcOct.Name = "txtBcOct";
            this.txtBcOct.PromptText = "Select Beesi";
            this.txtBcOct.Size = new System.Drawing.Size(125, 29);
            this.txtBcOct.TabIndex = 11;
            this.txtBcOct.UseSelectable = true;
            this.txtBcOct.ValueMember = "fullName";
            this.txtBcOct.SelectedIndexChanged += new System.EventHandler(this.txtBcOct_SelectedIndexChanged);
            // 
            // txtBcSep
            // 
            this.txtBcSep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcSep.DataSource = this.bcBindingSource;
            this.txtBcSep.DisplayMember = "fullName";
            this.txtBcSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcSep.FormattingEnabled = true;
            this.txtBcSep.ItemHeight = 23;
            this.txtBcSep.Location = new System.Drawing.Point(0, 232);
            this.txtBcSep.Name = "txtBcSep";
            this.txtBcSep.PromptText = "Select Beesi";
            this.txtBcSep.Size = new System.Drawing.Size(125, 29);
            this.txtBcSep.TabIndex = 10;
            this.txtBcSep.UseSelectable = true;
            this.txtBcSep.ValueMember = "fullName";
            this.txtBcSep.SelectedIndexChanged += new System.EventHandler(this.txtBcSep_SelectedIndexChanged);
            // 
            // txtBcAug
            // 
            this.txtBcAug.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcAug.DataSource = this.bcBindingSource;
            this.txtBcAug.DisplayMember = "fullName";
            this.txtBcAug.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcAug.FormattingEnabled = true;
            this.txtBcAug.ItemHeight = 23;
            this.txtBcAug.Location = new System.Drawing.Point(0, 203);
            this.txtBcAug.Name = "txtBcAug";
            this.txtBcAug.PromptText = "Select Beesi";
            this.txtBcAug.Size = new System.Drawing.Size(125, 29);
            this.txtBcAug.TabIndex = 9;
            this.txtBcAug.UseSelectable = true;
            this.txtBcAug.ValueMember = "fullName";
            this.txtBcAug.SelectedIndexChanged += new System.EventHandler(this.txtBcAug_SelectedIndexChanged);
            // 
            // txtBcJul
            // 
            this.txtBcJul.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcJul.DataSource = this.bcBindingSource;
            this.txtBcJul.DisplayMember = "fullName";
            this.txtBcJul.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcJul.FormattingEnabled = true;
            this.txtBcJul.ItemHeight = 23;
            this.txtBcJul.Location = new System.Drawing.Point(0, 174);
            this.txtBcJul.Name = "txtBcJul";
            this.txtBcJul.PromptText = "Select Beesi";
            this.txtBcJul.Size = new System.Drawing.Size(125, 29);
            this.txtBcJul.TabIndex = 8;
            this.txtBcJul.UseSelectable = true;
            this.txtBcJul.ValueMember = "fullName";
            this.txtBcJul.SelectedIndexChanged += new System.EventHandler(this.txtBcJul_SelectedIndexChanged);
            // 
            // txtBcJun
            // 
            this.txtBcJun.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcJun.DataSource = this.bcBindingSource;
            this.txtBcJun.DisplayMember = "fullName";
            this.txtBcJun.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcJun.FormattingEnabled = true;
            this.txtBcJun.ItemHeight = 23;
            this.txtBcJun.Location = new System.Drawing.Point(0, 145);
            this.txtBcJun.Name = "txtBcJun";
            this.txtBcJun.PromptText = "Select Beesi";
            this.txtBcJun.Size = new System.Drawing.Size(125, 29);
            this.txtBcJun.TabIndex = 7;
            this.txtBcJun.UseSelectable = true;
            this.txtBcJun.ValueMember = "fullName";
            this.txtBcJun.SelectedIndexChanged += new System.EventHandler(this.txtBcJun_SelectedIndexChanged);
            // 
            // txtBcMay
            // 
            this.txtBcMay.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcMay.DataSource = this.bcBindingSource;
            this.txtBcMay.DisplayMember = "fullName";
            this.txtBcMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcMay.FormattingEnabled = true;
            this.txtBcMay.ItemHeight = 23;
            this.txtBcMay.Location = new System.Drawing.Point(0, 116);
            this.txtBcMay.Name = "txtBcMay";
            this.txtBcMay.PromptText = "Select Beesi";
            this.txtBcMay.Size = new System.Drawing.Size(125, 29);
            this.txtBcMay.TabIndex = 6;
            this.txtBcMay.UseSelectable = true;
            this.txtBcMay.ValueMember = "fullName";
            this.txtBcMay.SelectedIndexChanged += new System.EventHandler(this.txtBcMay_SelectedIndexChanged);
            // 
            // txtBcApril
            // 
            this.txtBcApril.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcApril.DataSource = this.bcBindingSource;
            this.txtBcApril.DisplayMember = "fullName";
            this.txtBcApril.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcApril.FormattingEnabled = true;
            this.txtBcApril.ItemHeight = 23;
            this.txtBcApril.Location = new System.Drawing.Point(0, 87);
            this.txtBcApril.Name = "txtBcApril";
            this.txtBcApril.PromptText = "Select Beesi";
            this.txtBcApril.Size = new System.Drawing.Size(125, 29);
            this.txtBcApril.TabIndex = 5;
            this.txtBcApril.UseSelectable = true;
            this.txtBcApril.ValueMember = "fullName";
            this.txtBcApril.SelectedIndexChanged += new System.EventHandler(this.txtBcApril_SelectedIndexChanged);
            // 
            // txtBcMar
            // 
            this.txtBcMar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcMar.DataSource = this.bcBindingSource;
            this.txtBcMar.DisplayMember = "fullName";
            this.txtBcMar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcMar.FormattingEnabled = true;
            this.txtBcMar.ItemHeight = 23;
            this.txtBcMar.Location = new System.Drawing.Point(0, 58);
            this.txtBcMar.Name = "txtBcMar";
            this.txtBcMar.PromptText = "Select Beesi";
            this.txtBcMar.Size = new System.Drawing.Size(125, 29);
            this.txtBcMar.TabIndex = 4;
            this.txtBcMar.UseSelectable = true;
            this.txtBcMar.ValueMember = "fullName";
            this.txtBcMar.SelectedIndexChanged += new System.EventHandler(this.txtBcMar_SelectedIndexChanged);
            // 
            // txtBcFeb
            // 
            this.txtBcFeb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcFeb.DataSource = this.bcBindingSource;
            this.txtBcFeb.DisplayMember = "fullName";
            this.txtBcFeb.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcFeb.FormattingEnabled = true;
            this.txtBcFeb.ItemHeight = 23;
            this.txtBcFeb.Location = new System.Drawing.Point(0, 29);
            this.txtBcFeb.Name = "txtBcFeb";
            this.txtBcFeb.PromptText = "Select Beesi";
            this.txtBcFeb.Size = new System.Drawing.Size(125, 29);
            this.txtBcFeb.TabIndex = 3;
            this.txtBcFeb.UseSelectable = true;
            this.txtBcFeb.ValueMember = "fullName";
            this.txtBcFeb.SelectedIndexChanged += new System.EventHandler(this.txtBcFeb_SelectedIndexChanged);
            // 
            // txtBcJan
            // 
            this.txtBcJan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bcBindingSource, "fullName", true));
            this.txtBcJan.DataSource = this.bcBindingSource;
            this.txtBcJan.DisplayMember = "fullName";
            this.txtBcJan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBcJan.FormattingEnabled = true;
            this.txtBcJan.ItemHeight = 23;
            this.txtBcJan.Location = new System.Drawing.Point(0, 0);
            this.txtBcJan.Name = "txtBcJan";
            this.txtBcJan.PromptText = "Select Beesi";
            this.txtBcJan.Size = new System.Drawing.Size(125, 29);
            this.txtBcJan.TabIndex = 2;
            this.txtBcJan.UseSelectable = true;
            this.txtBcJan.ValueMember = "fullName";
            this.txtBcJan.SelectedIndexChanged += new System.EventHandler(this.txtselectBeesi_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(405, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Report";
            // 
            // BC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvBeesi);
            this.Name = "BC_History";
            this.Text = "Beesi_History";
            this.Load += new System.EventHandler(this.BC_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstmRBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelmonthbtn.ResumeLayout(false);
            this.panelcombobox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvBeesi;
        private System.Windows.Forms.BindingSource bcBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyContryPerPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMemberDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid dgvReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource firstmRBindingSource;
        private System.Windows.Forms.Panel panelmonthbtn;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnNov;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnSep;
        private System.Windows.Forms.Button btnAug;
        private System.Windows.Forms.Button btnJul;
        private System.Windows.Forms.Button btnJun;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnApril;
        private System.Windows.Forms.Button btnMar;
        private System.Windows.Forms.Button btnFeb;
        private System.Windows.Forms.Button btnJan;
        private MetroFramework.Controls.MetroComboBox txtBcJan;
        private System.Windows.Forms.Panel panelcombobox;
        private MetroFramework.Controls.MetroComboBox txtBcFeb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroComboBox txtBcDec;
        private MetroFramework.Controls.MetroComboBox txtBcNov;
        private MetroFramework.Controls.MetroComboBox txtBcOct;
        private MetroFramework.Controls.MetroComboBox txtBcSep;
        private MetroFramework.Controls.MetroComboBox txtBcAug;
        private MetroFramework.Controls.MetroComboBox txtBcJul;
        private MetroFramework.Controls.MetroComboBox txtBcJun;
        private MetroFramework.Controls.MetroComboBox txtBcMay;
        private MetroFramework.Controls.MetroComboBox txtBcApril;
        private MetroFramework.Controls.MetroComboBox txtBcMar;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}