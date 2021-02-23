namespace MonthlyContribution.Forms
{
    partial class Create_New_BC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBcName = new System.Windows.Forms.TextBox();
            this.labelBcName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotalMember = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditBeesi = new System.Windows.Forms.Button();
            this.dgvBeesi = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMemberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBcName
            // 
            this.txtBcName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcName.Location = new System.Drawing.Point(139, 23);
            this.txtBcName.Name = "txtBcName";
            this.txtBcName.Size = new System.Drawing.Size(252, 27);
            this.txtBcName.TabIndex = 1;
            // 
            // labelBcName
            // 
            this.labelBcName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBcName.AutoSize = true;
            this.labelBcName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBcName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelBcName.Location = new System.Drawing.Point(25, 27);
            this.labelBcName.Name = "labelBcName";
            this.labelBcName.Size = new System.Drawing.Size(108, 20);
            this.labelBcName.TabIndex = 2;
            this.labelBcName.Text = "Name Of Beesi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.45842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel1.Controls.Add(this.dtpEndDate, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBcName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBcName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartdate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalMember, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDuration, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.36449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.76636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.03738F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.76636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(587, 267);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(330, 27);
            this.dtpEndDate.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(445, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "Duration(in Month)";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(587, 99);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(330, 27);
            this.txtCountry.TabIndex = 13;
            this.txtCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountry_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(400, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Contry Per Person";
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartdate.Location = new System.Drawing.Point(587, 183);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(330, 27);
            this.dtpStartdate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(505, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(511, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Date";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(139, 99);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(252, 27);
            this.txtTotalAmount.TabIndex = 12;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            // 
            // txtTotalMember
            // 
            this.txtTotalMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMember.Location = new System.Drawing.Point(139, 183);
            this.txtTotalMember.Name = "txtTotalMember";
            this.txtTotalMember.Size = new System.Drawing.Size(252, 27);
            this.txtTotalMember.TabIndex = 10;
            this.txtTotalMember.TextChanged += new System.EventHandler(this.txtTotalMember_TextChanged);
            this.txtTotalMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalMember_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(31, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Member";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Amount";
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(587, 23);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(330, 27);
            this.txtDuration.TabIndex = 18;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtCreate);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(139, 244);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(252, 74);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // txtCreate
            // 
            this.txtCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtCreate.Location = new System.Drawing.Point(3, 3);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(116, 35);
            this.txtCreate.TabIndex = 2;
            this.txtCreate.Text = "Create";
            this.txtCreate.UseVisualStyleBackColor = true;
            this.txtCreate.Click += new System.EventHandler(this.txtCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(125, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditBeesi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 74);
            this.panel1.TabIndex = 20;
            // 
            // EditBeesi
            // 
            this.EditBeesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBeesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBeesi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBeesi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EditBeesi.Location = new System.Drawing.Point(13, 3);
            this.EditBeesi.Name = "EditBeesi";
            this.EditBeesi.Size = new System.Drawing.Size(114, 35);
            this.EditBeesi.TabIndex = 3;
            this.EditBeesi.Text = "Edit Beesi";
            this.EditBeesi.UseVisualStyleBackColor = true;
            this.EditBeesi.Click += new System.EventHandler(this.EditBeesi_Click);
            // 
            // dgvBeesi
            // 
            this.dgvBeesi.AllowUserToResizeRows = false;
            this.dgvBeesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBeesi.AutoGenerateColumns = false;
            this.dgvBeesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBeesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBeesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeesi.ColumnHeadersHeight = 25;
            this.dgvBeesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.totalAmountDataGridViewTextBoxColumn1,
            this.durationDataGridViewTextBoxColumn1,
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1,
            this.statusCodeDataGridViewTextBoxColumn1,
            this.createdAtDataGridViewTextBoxColumn1,
            this.updatedAtDataGridViewTextBoxColumn1,
            this.totalMemberDataGridViewTextBoxColumn1});
            this.dgvBeesi.DataSource = this.bcBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeesi.EnableHeadersVisualStyles = false;
            this.dgvBeesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBeesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBeesi.Location = new System.Drawing.Point(15, 342);
            this.dgvBeesi.Name = "dgvBeesi";
            this.dgvBeesi.ReadOnly = true;
            this.dgvBeesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBeesi.RowHeadersVisible = false;
            this.dgvBeesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeesi.RowTemplate.Height = 30;
            this.dgvBeesi.RowTemplate.ReadOnly = true;
            this.dgvBeesi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeesi.Size = new System.Drawing.Size(404, 132);
            this.dgvBeesi.TabIndex = 6;
            this.dgvBeesi.Click += new System.EventHandler(this.dgvBeesi_Click_1);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            this.fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn1
            // 
            this.totalAmountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmountDataGridViewTextBoxColumn1.DataPropertyName = "totalAmount";
            this.totalAmountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.totalAmountDataGridViewTextBoxColumn1.Name = "totalAmountDataGridViewTextBoxColumn1";
            this.totalAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn1
            // 
            this.durationDataGridViewTextBoxColumn1.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn1.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn1.Name = "durationDataGridViewTextBoxColumn1";
            this.durationDataGridViewTextBoxColumn1.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn1.Visible = false;
            // 
            // monthlyContryPerPersonDataGridViewTextBoxColumn1
            // 
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1.DataPropertyName = "monthlyContryPerPerson";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1.HeaderText = "monthlyContryPerPerson";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1.Name = "monthlyContryPerPersonDataGridViewTextBoxColumn1";
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.monthlyContryPerPersonDataGridViewTextBoxColumn1.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            this.startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            this.endDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "endDate";
            this.endDateDataGridViewTextBoxColumn1.HeaderText = "End Date";
            this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            this.endDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusCodeDataGridViewTextBoxColumn1
            // 
            this.statusCodeDataGridViewTextBoxColumn1.DataPropertyName = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn1.HeaderText = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn1.Name = "statusCodeDataGridViewTextBoxColumn1";
            this.statusCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn1
            // 
            this.createdAtDataGridViewTextBoxColumn1.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn1.HeaderText = "createdAt";
            this.createdAtDataGridViewTextBoxColumn1.Name = "createdAtDataGridViewTextBoxColumn1";
            this.createdAtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn1.Visible = false;
            // 
            // updatedAtDataGridViewTextBoxColumn1
            // 
            this.updatedAtDataGridViewTextBoxColumn1.DataPropertyName = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.HeaderText = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.Name = "updatedAtDataGridViewTextBoxColumn1";
            this.updatedAtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn1.Visible = false;
            // 
            // totalMemberDataGridViewTextBoxColumn1
            // 
            this.totalMemberDataGridViewTextBoxColumn1.DataPropertyName = "totalMember";
            this.totalMemberDataGridViewTextBoxColumn1.HeaderText = "totalMember";
            this.totalMemberDataGridViewTextBoxColumn1.Name = "totalMemberDataGridViewTextBoxColumn1";
            this.totalMemberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalMemberDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bcBindingSource
            // 
            this.bcBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Bc);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Member);
            // 
            // Create_New_BC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(998, 476);
            this.Controls.Add(this.dgvBeesi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Create_New_BC";
            this.Text = "Create New Beesi";
            this.Load += new System.EventHandler(this.Bc_New_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBcName;
        private System.Windows.Forms.Label labelBcName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartdate;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtTotalMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtCreate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Button EditBeesi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource bcBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroGrid dgvBeesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyContryPerPersonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMemberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
    }
}