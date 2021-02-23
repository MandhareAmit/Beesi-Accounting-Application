namespace MonthlyContribution.Forms
{
    partial class MemberForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgMembers = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelfullname = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelemailid = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelcity = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new MetroFramework.Controls.MetroComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgMembers
            // 
            this.dvgMembers.AllowUserToAddRows = false;
            this.dvgMembers.AllowUserToResizeColumns = false;
            this.dvgMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dvgMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgMembers.AutoGenerateColumns = false;
            this.dvgMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dvgMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgMembers.ColumnHeadersHeight = 40;
            this.dvgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullNameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.dvgMembers.DataSource = this.memberBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgMembers.DefaultCellStyle = dataGridViewCellStyle7;
            this.dvgMembers.EnableHeadersVisualStyles = false;
            this.dvgMembers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dvgMembers.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dvgMembers.Location = new System.Drawing.Point(1, 203);
            this.dvgMembers.Name = "dvgMembers";
            this.dvgMembers.ReadOnly = true;
            this.dvgMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgMembers.RowHeadersVisible = false;
            this.dvgMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgMembers.RowTemplate.DividerHeight = 1;
            this.dvgMembers.RowTemplate.Height = 35;
            this.dvgMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMembers.Size = new System.Drawing.Size(991, 304);
            this.dvgMembers.TabIndex = 14;
            this.dvgMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMembers_CellDoubleClick);
            this.dvgMembers.Click += new System.EventHandler(this.dvgMembers_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.Location = new System.Drawing.Point(832, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.Location = new System.Drawing.Point(832, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Location = new System.Drawing.Point(832, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(110, 10);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(292, 29);
            this.txtFullName.TabIndex = 4;
            // 
            // labelfullname
            // 
            this.labelfullname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelfullname.AutoSize = true;
            this.labelfullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfullname.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelfullname.Location = new System.Drawing.Point(3, 14);
            this.labelfullname.Name = "labelfullname";
            this.labelfullname.Size = new System.Drawing.Size(82, 21);
            this.labelfullname.TabIndex = 5;
            this.labelfullname.Text = "Full Name";
            // 
            // labelMobile
            // 
            this.labelMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMobile.Location = new System.Drawing.Point(3, 73);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(62, 21);
            this.labelMobile.TabIndex = 6;
            this.labelMobile.Text = "Mobile";
            // 
            // labelemailid
            // 
            this.labelemailid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelemailid.AutoSize = true;
            this.labelemailid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemailid.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelemailid.Location = new System.Drawing.Point(3, 135);
            this.labelemailid.Name = "labelemailid";
            this.labelemailid.Size = new System.Drawing.Size(67, 21);
            this.labelemailid.TabIndex = 7;
            this.labelemailid.Text = "Email Id";
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDOB.Location = new System.Drawing.Point(422, 14);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(103, 21);
            this.labelDOB.TabIndex = 8;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelcity
            // 
            this.labelcity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcity.AutoSize = true;
            this.labelcity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcity.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelcity.Location = new System.Drawing.Point(422, 73);
            this.labelcity.Name = "labelcity";
            this.labelcity.Size = new System.Drawing.Size(38, 21);
            this.labelcity.TabIndex = 9;
            this.labelcity.Text = "City";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(110, 69);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(292, 29);
            this.txtMobile.TabIndex = 10;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtEmailId
            // 
            this.txtEmailId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmailId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.Location = new System.Drawing.Point(110, 131);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(292, 29);
            this.txtEmailId.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.12245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.40166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83644F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.81367F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.07868F));
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMobile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMobile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailId, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelcity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelfullname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelemailid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDOB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDOB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCity, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.26829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.75904F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.3253F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 174);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDOB.CustomFormat = " ";
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(545, 12);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(269, 26);
            this.dateTimePickerDOB.TabIndex = 14;
            this.dateTimePickerDOB.Value = new System.DateTime(2020, 10, 9, 6, 10, 20, 0);
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCity.FormattingEnabled = true;
            this.txtCity.ItemHeight = 23;
            this.txtCity.Items.AddRange(new object[] {
            "Adilabad",
            "Agra",
            "Ahmedabad",
            "Ahmednagar",
            "Aizawl",
            "Ajitgarh (Mohali)",
            "Ajmer",
            "Akola",
            "Alappuzha",
            "Aligarh",
            "Alirajpur",
            "Allahabad",
            "Almora",
            "Alwar",
            "Ambala",
            "Ambedkar Nagar",
            "Amravati",
            "Amreli district",
            "Amritsar",
            "Anand",
            "Anantapur",
            "Anantnag",
            "Angul",
            "Anjaw",
            "Anuppur",
            "Araria",
            "Ariyalur",
            "Arwal",
            "Ashok Nagar",
            "Auraiya",
            "Aurangabad",
            "Aurangabad",
            "Azamgarh",
            "Badgam",
            "Bagalkot",
            "Bageshwar",
            "Bagpat",
            "Bahraich",
            "Baksa",
            "Balaghat",
            "Balangir",
            "Balasore",
            "Ballia",
            "Balrampur",
            "Banaskantha",
            "Banda",
            "Bandipora",
            "Bangalore Rural",
            "Bangalore Urban",
            "Banka",
            "Bankura",
            "Banswara",
            "Barabanki",
            "Baramulla",
            "Baran",
            "Bardhaman",
            "Bareilly",
            "Bargarh (Baragarh)",
            "Barmer",
            "Barnala",
            "Barpeta",
            "Barwani",
            "Bastar",
            "Basti",
            "Bathinda",
            "Beed",
            "Begusarai",
            "Belgaum",
            "Bellary",
            "Betul",
            "Bhadrak",
            "Bhagalpur",
            "Bhandara",
            "Bharatpur",
            "Bharuch",
            "Bhavnagar",
            "Bhilwara",
            "Bhind",
            "Bhiwani",
            "Bhojpur",
            "Bhopal",
            "Bidar",
            "Bijapur",
            "Bijapur",
            "Bijnor",
            "Bikaner",
            "Bilaspur",
            "Bilaspur",
            "Birbhum",
            "Bishnupur",
            "Bokaro",
            "Bongaigaon",
            "Boudh (Bauda)",
            "Budaun",
            "Bulandshahr",
            "Buldhana",
            "Bundi",
            "Burhanpur",
            "Buxar",
            "Cachar",
            "Central Delhi",
            "Chamarajnagar",
            "Chamba",
            "Chamoli",
            "Champawat",
            "Champhai",
            "Chandauli",
            "Chandel",
            "Chandigarh",
            "Chandrapur",
            "Changlang",
            "Chatra",
            "Chennai",
            "Chhatarpur",
            "Chhatrapati Shahuji Maharaj Nagar",
            "Chhindwara",
            "Chikkaballapur",
            "Chikkamagaluru",
            "Chirang",
            "Chitradurga",
            "Chitrakoot",
            "Chittoor",
            "Chittorgarh",
            "Churachandpur",
            "Churu",
            "Coimbatore",
            "Cooch Behar",
            "Cuddalore",
            "Cuttack",
            "Dadra and Nagar Haveli",
            "Dahod",
            "Dakshin Dinajpur",
            "Dakshina Kannada",
            "Daman",
            "Damoh",
            "Dantewada",
            "Darbhanga",
            "Darjeeling",
            "Darrang",
            "Datia",
            "Dausa",
            "Davanagere",
            "Debagarh (Deogarh)",
            "Dehradun",
            "Deoghar",
            "Deoria",
            "Dewas",
            "Dhalai",
            "Dhamtari",
            "Dhanbad",
            "Dhar",
            "Dharmapuri",
            "Dharwad",
            "Dhemaji",
            "Dhenkanal",
            "Dholpur",
            "Dhubri",
            "Dhule",
            "Dibang Valley",
            "Dibrugarh",
            "Dima Hasao",
            "Dimapur",
            "Dindigul",
            "Dindori",
            "Diu",
            "Doda",
            "Dumka",
            "Dungapur",
            "Durg",
            "East Champaran",
            "East Delhi",
            "East Garo Hills",
            "East Khasi Hills",
            "East Siang",
            "East Sikkim",
            "East Singhbhum",
            "Eluru",
            "Ernakulam",
            "Erode",
            "Etah",
            "Etawah",
            "Faizabad",
            "Faridabad",
            "Faridkot",
            "Farrukhabad",
            "Fatehabad",
            "Fatehgarh Sahib",
            "Fatehpur",
            "Fazilka",
            "Firozabad",
            "Firozpur",
            "Gadag",
            "Gadchiroli",
            "Gajapati",
            "Ganderbal",
            "Gandhinagar",
            "Ganganagar",
            "Ganjam",
            "Garhwa",
            "Gautam Buddh Nagar",
            "Gaya",
            "Ghaziabad",
            "Ghazipur",
            "Giridih",
            "Goalpara",
            "Godda",
            "Golaghat",
            "Gonda",
            "Gondia",
            "Gopalganj",
            "Gorakhpur",
            "Gulbarga",
            "Gumla",
            "Guna",
            "Guntur",
            "Gurdaspur",
            "Gurgaon",
            "Gwalior",
            "Hailakandi",
            "Hamirpur",
            "Hamirpur",
            "Hanumangarh",
            "Harda",
            "Hardoi",
            "Haridwar",
            "Hassan",
            "Haveri district",
            "Hazaribag",
            "Hingoli",
            "Hissar",
            "Hooghly",
            "Hoshangabad",
            "Hoshiarpur",
            "Howrah",
            "Hyderabad",
            "Hyderabad",
            "Idukki",
            "Imphal East",
            "Imphal West",
            "Indore",
            "Jabalpur",
            "Jagatsinghpur",
            "Jaintia Hills",
            "Jaipur",
            "Jaisalmer",
            "Jajpur",
            "Jalandhar",
            "Jalaun",
            "Jalgaon",
            "Jalna",
            "Jalore",
            "Jalpaiguri",
            "Jammu",
            "Jamnagar",
            "Jamtara",
            "Jamui",
            "Janjgir-Champa",
            "Jashpur",
            "Jaunpur district",
            "Jehanabad",
            "Jhabua",
            "Jhajjar",
            "Jhalawar",
            "Jhansi",
            "Jharsuguda",
            "Jhunjhunu",
            "Jind",
            "Jodhpur",
            "Jorhat",
            "Junagadh",
            "Jyotiba Phule Nagar",
            "Kabirdham (formerly Kawardha)",
            "Kadapa",
            "Kaimur",
            "Kaithal",
            "Kakinada",
            "Kalahandi",
            "Kamrup",
            "Kamrup Metropolitan",
            "Kanchipuram",
            "Kandhamal",
            "Kangra",
            "Kanker",
            "Kannauj",
            "Kannur",
            "Kanpur",
            "Kanshi Ram Nagar",
            "Kanyakumari",
            "Kapurthala",
            "Karaikal",
            "Karauli",
            "Karbi Anglong",
            "Kargil",
            "Karimganj",
            "Karimnagar",
            "Karnal",
            "Karur",
            "Kasaragod",
            "Kathua",
            "Katihar",
            "Katni",
            "Kaushambi",
            "Kendrapara",
            "Kendujhar (Keonjhar)",
            "Khagaria",
            "Khammam",
            "Khandwa (East Nimar)",
            "Khargone (West Nimar)",
            "Kheda",
            "Khordha",
            "Khowai",
            "Khunti",
            "Kinnaur",
            "Kishanganj",
            "Kishtwar",
            "Kodagu",
            "Koderma",
            "Kohima",
            "Kokrajhar",
            "Kolar",
            "Kolasib",
            "Kolhapur",
            "Kolkata",
            "Kollam",
            "Koppal",
            "Koraput",
            "Korba",
            "Koriya",
            "Kota",
            "Kottayam",
            "Kozhikode",
            "Krishna",
            "Kulgam",
            "Kullu",
            "Kupwara",
            "Kurnool",
            "Kurukshetra",
            "Kurung Kumey",
            "Kushinagar",
            "Kutch",
            "Lahaul and Spiti",
            "Lakhimpur",
            "Lakhimpur Kheri",
            "Lakhisarai",
            "Lalitpur",
            "Latehar",
            "Latur",
            "Lawngtlai",
            "Leh",
            "Lohardaga",
            "Lohit",
            "Lower Dibang Valley",
            "Lower Subansiri",
            "Lucknow",
            "Ludhiana",
            "Lunglei",
            "Madhepura",
            "Madhubani",
            "Madurai",
            "Mahamaya Nagar",
            "Maharajganj",
            "Mahasamund",
            "Mahbubnagar",
            "Mahe",
            "Mahendragarh",
            "Mahoba",
            "Mainpuri",
            "Malappuram",
            "Maldah",
            "Malkangiri",
            "Mamit",
            "Mandi",
            "Mandla",
            "Mandsaur",
            "Mandya",
            "Mansa",
            "Marigaon",
            "Mathura",
            "Mau",
            "Mayurbhanj",
            "Medak",
            "Meerut",
            "Mehsana",
            "Mewat",
            "Mirzapur",
            "Moga",
            "Mokokchung",
            "Mon",
            "Moradabad",
            "Morena",
            "Mumbai City",
            "Mumbai suburban",
            "Munger",
            "Murshidabad",
            "Muzaffarnagar",
            "Muzaffarpur",
            "Mysore",
            "Nabarangpur",
            "Nadia",
            "Nagaon",
            "Nagapattinam",
            "Nagaur",
            "Nagpur",
            "Nainital",
            "Nalanda",
            "Nalbari",
            "Nalgonda",
            "Namakkal",
            "Nanded",
            "Nandurbar",
            "Narayanpur",
            "Narmada",
            "Narsinghpur",
            "Nashik",
            "Navsari",
            "Nawada",
            "Nawanshahr",
            "Nayagarh",
            "Neemuch",
            "Nellore",
            "New Delhi",
            "Nilgiris",
            "Nizamabad",
            "North 24 Parganas",
            "North Delhi",
            "North East Delhi",
            "North Goa",
            "North Sikkim",
            "North Tripura",
            "North West Delhi",
            "Nuapada",
            "Ongole",
            "Osmanabad",
            "Pakur",
            "Palakkad",
            "Palamu",
            "Pali",
            "Palwal",
            "Panchkula",
            "Panchmahal",
            "Panchsheel Nagar district (Hapur)",
            "Panipat",
            "Panna",
            "Papum Pare",
            "Parbhani",
            "Paschim Medinipur",
            "Patan",
            "Pathanamthitta",
            "Pathankot",
            "Patiala",
            "Patna",
            "Pauri Garhwal",
            "Perambalur",
            "Phek",
            "Pilibhit",
            "Pithoragarh",
            "Pondicherry",
            "Poonch",
            "Porbandar",
            "Pratapgarh",
            "Pratapgarh",
            "Pudukkottai",
            "Pulwama",
            "Pune",
            "Purba Medinipur",
            "Puri",
            "Purnia",
            "Purulia",
            "Raebareli",
            "Raichur",
            "Raigad",
            "Raigarh",
            "Raipur",
            "Raisen",
            "Rajauri",
            "Rajgarh",
            "Rajkot",
            "Rajnandgaon",
            "Rajsamand",
            "Ramabai Nagar (Kanpur Dehat)",
            "Ramanagara",
            "Ramanathapuram",
            "Ramban",
            "Ramgarh",
            "Rampur",
            "Ranchi",
            "Ratlam",
            "Ratnagiri",
            "Rayagada",
            "Reasi",
            "Rewa",
            "Rewari",
            "Ri Bhoi",
            "Rohtak",
            "Rohtas",
            "Rudraprayag",
            "Rupnagar",
            "Sabarkantha",
            "Sagar",
            "Saharanpur",
            "Saharsa",
            "Sahibganj",
            "Saiha",
            "Salem",
            "Samastipur",
            "Samba",
            "Sambalpur",
            "Sangli",
            "Sangrur",
            "Sant Kabir Nagar",
            "Sant Ravidas Nagar",
            "Saran",
            "Satara",
            "Satna",
            "Sawai Madhopur",
            "Sehore",
            "Senapati",
            "Seoni",
            "Seraikela Kharsawan",
            "Serchhip",
            "Shahdol",
            "Shahjahanpur",
            "Shajapur",
            "Shamli",
            "Sheikhpura",
            "Sheohar",
            "Sheopur",
            "Shimla",
            "Shimoga",
            "Shivpuri",
            "Shopian",
            "Shravasti",
            "Sibsagar",
            "Siddharthnagar",
            "Sidhi",
            "Sikar",
            "Simdega",
            "Sindhudurg",
            "Singrauli",
            "Sirmaur",
            "Sirohi",
            "Sirsa",
            "Sitamarhi",
            "Sitapur",
            "Sivaganga",
            "Siwan",
            "Solan",
            "Solapur",
            "Sonbhadra",
            "Sonipat",
            "Sonitpur",
            "South 24 Parganas",
            "South Delhi",
            "South Garo Hills",
            "South Goa",
            "South Sikkim",
            "South Tripura",
            "South West Delhi",
            "Sri Muktsar Sahib",
            "Srikakulam",
            "Srinagar",
            "Subarnapur (Sonepur)",
            "Sultanpur",
            "Sundergarh",
            "Supaul",
            "Surat",
            "Surendranagar",
            "Surguja",
            "Tamenglong",
            "Tarn Taran",
            "Tawang",
            "Tehri Garhwal",
            "Thane",
            "Thanjavur",
            "The Dangs",
            "Theni",
            "Thiruvananthapuram",
            "Thoothukudi",
            "Thoubal",
            "Thrissur",
            "Tikamgarh",
            "Tinsukia",
            "Tirap",
            "Tiruchirappalli",
            "Tirunelveli",
            "Tirupur",
            "Tiruvallur",
            "Tiruvannamalai",
            "Tiruvarur",
            "Tonk",
            "Tuensang",
            "Tumkur",
            "Udaipur",
            "Udalguri",
            "Udham Singh Nagar",
            "Udhampur",
            "Udupi",
            "Ujjain",
            "Ukhrul",
            "Umaria",
            "Una",
            "Unnao",
            "Upper Siang",
            "Upper Subansiri",
            "Uttar Dinajpur",
            "Uttara Kannada",
            "Uttarkashi",
            "Vadodara",
            "Vaishali",
            "Valsad",
            "Varanasi",
            "Vellore",
            "Vidisha",
            "Viluppuram",
            "Virudhunagar",
            "Visakhapatnam",
            "Vizianagaram",
            "Vyara",
            "Warangal",
            "Wardha",
            "Washim",
            "Wayanad",
            "West Champaran",
            "West Delhi",
            "West Garo Hills",
            "West Kameng",
            "West Khasi Hills",
            "West Siang",
            "West Sikkim",
            "West Singhbhum",
            "West Tripura",
            "Wokha",
            "Yadgir",
            "Yamuna Nagar",
            "Yanam",
            "Yavatmal",
            "Zunheboto"});
            this.txtCity.Location = new System.Drawing.Point(545, 73);
            this.txtCity.Name = "txtCity";
            this.txtCity.PromptText = "Select City";
            this.txtCity.Size = new System.Drawing.Size(269, 29);
            this.txtCity.TabIndex = 15;
            this.txtCity.UseSelectable = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            this.emailIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailIdDataGridViewTextBoxColumn.DataPropertyName = "emailId";
            this.emailIdDataGridViewTextBoxColumn.HeaderText = "Email Id";
            this.emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            this.emailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "statusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "Status Code";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            this.statusCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "Created At";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "updatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "Updated At";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(MonthlyContribution.EntitiesModel.Member);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(994, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dvgMembers);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgMembers;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelfullname;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelemailid;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelcity;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcMembersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroComboBox txtCity;
    }
}