namespace HotelManagement
{
    partial class Dashboard
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.logout = new System.Windows.Forms.Button();
			this.customer = new System.Windows.Forms.Label();
			this.checkout = new System.Windows.Forms.Label();
			this.checkin = new System.Windows.Forms.Label();
			this.employee = new System.Windows.Forms.Label();
			this.room = new System.Windows.Forms.Label();
			this.report = new System.Windows.Forms.Button();
			this.dish = new System.Windows.Forms.Label();
			this.service = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuHD = new System.Windows.Forms.MenuStrip();
			this.toolStripComboBoxHD = new System.Windows.Forms.ToolStripComboBox();
			this.P101 = new System.Windows.Forms.Button();
			this.P102 = new System.Windows.Forms.Button();
			this.P104 = new System.Windows.Forms.Button();
			this.P103 = new System.Windows.Forms.Button();
			this.P108 = new System.Windows.Forms.Button();
			this.P107 = new System.Windows.Forms.Button();
			this.P106 = new System.Windows.Forms.Button();
			this.P105 = new System.Windows.Forms.Button();
			this.P202 = new System.Windows.Forms.Button();
			this.P201 = new System.Windows.Forms.Button();
			this.P110 = new System.Windows.Forms.Button();
			this.P109 = new System.Windows.Forms.Button();
			this.P206 = new System.Windows.Forms.Button();
			this.P205 = new System.Windows.Forms.Button();
			this.P204 = new System.Windows.Forms.Button();
			this.P203 = new System.Windows.Forms.Button();
			this.P210 = new System.Windows.Forms.Button();
			this.P209 = new System.Windows.Forms.Button();
			this.P208 = new System.Windows.Forms.Button();
			this.P207 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.menuHD.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.Color.PowderBlue;
			this.panel1.Controls.Add(this.logout);
			this.panel1.Controls.Add(this.customer);
			this.panel1.Controls.Add(this.checkout);
			this.panel1.Controls.Add(this.checkin);
			this.panel1.Controls.Add(this.employee);
			this.panel1.Controls.Add(this.room);
			this.panel1.Controls.Add(this.report);
			this.panel1.Controls.Add(this.dish);
			this.panel1.Controls.Add(this.service);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.menuHD);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 596);
			this.panel1.TabIndex = 0;
			// 
			// logout
			// 
			this.logout.BackColor = System.Drawing.Color.Crimson;
			this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logout.ForeColor = System.Drawing.SystemColors.Window;
			this.logout.Location = new System.Drawing.Point(41, 520);
			this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(182, 46);
			this.logout.TabIndex = 12;
			this.logout.Text = "LOG OUT";
			this.logout.UseVisualStyleBackColor = false;
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// customer
			// 
			this.customer.CausesValidation = false;
			this.customer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customer.ForeColor = System.Drawing.Color.MidnightBlue;
			this.customer.Location = new System.Drawing.Point(23, 240);
			this.customer.Name = "customer";
			this.customer.Size = new System.Drawing.Size(225, 23);
			this.customer.TabIndex = 11;
			this.customer.Text = "▶  KHÁCH HÀNG";
			this.customer.UseMnemonic = false;
			this.customer.Click += new System.EventHandler(this.customer_Click);
			// 
			// checkout
			// 
			this.checkout.CausesValidation = false;
			this.checkout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkout.ForeColor = System.Drawing.Color.Crimson;
			this.checkout.Location = new System.Drawing.Point(23, 334);
			this.checkout.Name = "checkout";
			this.checkout.Size = new System.Drawing.Size(225, 23);
			this.checkout.TabIndex = 10;
			this.checkout.Text = "▶  CHECK OUT";
			this.checkout.UseMnemonic = false;
			this.checkout.Click += new System.EventHandler(this.checkout_Click);
			// 
			// checkin
			// 
			this.checkin.CausesValidation = false;
			this.checkin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkin.ForeColor = System.Drawing.Color.Crimson;
			this.checkin.Location = new System.Drawing.Point(23, 289);
			this.checkin.Name = "checkin";
			this.checkin.Size = new System.Drawing.Size(225, 23);
			this.checkin.TabIndex = 9;
			this.checkin.Text = "▶  CHECK IN";
			this.checkin.UseMnemonic = false;
			this.checkin.Click += new System.EventHandler(this.checkin_Click);
			// 
			// employee
			// 
			this.employee.CausesValidation = false;
			this.employee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employee.ForeColor = System.Drawing.Color.MidnightBlue;
			this.employee.Location = new System.Drawing.Point(23, 192);
			this.employee.Name = "employee";
			this.employee.Size = new System.Drawing.Size(225, 23);
			this.employee.TabIndex = 8;
			this.employee.Text = "▶  NHÂN VIÊN";
			this.employee.UseMnemonic = false;
			this.employee.Click += new System.EventHandler(this.employee_Click);
			// 
			// room
			// 
			this.room.CausesValidation = false;
			this.room.Cursor = System.Windows.Forms.Cursors.Hand;
			this.room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.room.ForeColor = System.Drawing.Color.MediumBlue;
			this.room.Location = new System.Drawing.Point(23, 54);
			this.room.Name = "room";
			this.room.Size = new System.Drawing.Size(215, 37);
			this.room.TabIndex = 6;
			this.room.Text = "▶  PHÒNG";
			this.room.UseMnemonic = false;
			this.room.Click += new System.EventHandler(this.room_Click);
			// 
			// report
			// 
			this.report.BackColor = System.Drawing.Color.LightSkyBlue;
			this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.report.Location = new System.Drawing.Point(41, 457);
			this.report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.report.Name = "report";
			this.report.Size = new System.Drawing.Size(182, 46);
			this.report.TabIndex = 5;
			this.report.Text = "BÁO CÁO";
			this.report.UseVisualStyleBackColor = false;
			this.report.Click += new System.EventHandler(this.report_Click);
			// 
			// dish
			// 
			this.dish.CausesValidation = false;
			this.dish.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dish.ForeColor = System.Drawing.Color.MediumBlue;
			this.dish.Location = new System.Drawing.Point(23, 101);
			this.dish.Name = "dish";
			this.dish.Size = new System.Drawing.Size(215, 23);
			this.dish.TabIndex = 3;
			this.dish.Text = "▶  MÓN ĂN";
			this.dish.UseMnemonic = false;
			this.dish.Click += new System.EventHandler(this.dish_Click);
			// 
			// service
			// 
			this.service.CausesValidation = false;
			this.service.Cursor = System.Windows.Forms.Cursors.Hand;
			this.service.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.service.ForeColor = System.Drawing.Color.MediumBlue;
			this.service.Location = new System.Drawing.Point(23, 146);
			this.service.Name = "service";
			this.service.Size = new System.Drawing.Size(215, 37);
			this.service.TabIndex = 2;
			this.service.Text = "▶  DỊCH VỤ";
			this.service.UseMnemonic = false;
			this.service.Click += new System.EventHandler(this.service_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Goldenrod;
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "HOTEL GROUP 1";
			// 
			// menuHD
			// 
			this.menuHD.BackColor = System.Drawing.Color.PowderBlue;
			this.menuHD.Dock = System.Windows.Forms.DockStyle.None;
			this.menuHD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuHD.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuHD.ImageScalingSize = new System.Drawing.Size(0, 0);
			this.menuHD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxHD});
			this.menuHD.Location = new System.Drawing.Point(27, 390);
			this.menuHD.MaximumSize = new System.Drawing.Size(338, 36);
			this.menuHD.Name = "menuHD";
			this.menuHD.Padding = new System.Windows.Forms.Padding(4, 2, 3, 2);
			this.menuHD.Size = new System.Drawing.Size(217, 34);
			this.menuHD.TabIndex = 0;
			this.menuHD.Text = "▶ HÓA ĐƠN";
			// 
			// toolStripComboBoxHD
			// 
			this.toolStripComboBoxHD.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.toolStripComboBoxHD.AutoCompleteCustomSource.AddRange(new string[] {
            "▶  HÓA ĐƠN"});
			this.toolStripComboBoxHD.BackColor = System.Drawing.Color.AliceBlue;
			this.toolStripComboBoxHD.DropDownHeight = 250;
			this.toolStripComboBoxHD.DropDownWidth = 200;
			this.toolStripComboBoxHD.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripComboBoxHD.ForeColor = System.Drawing.Color.RoyalBlue;
			this.toolStripComboBoxHD.IntegralHeight = false;
			this.toolStripComboBoxHD.Items.AddRange(new object[] {
            "HÓA ĐƠN PHÒNG",
            "HÓA ĐƠN MÓN",
            "HÓA ĐƠN DỊCH VỤ",
            "TỔNG HÓA ĐƠN"});
			this.toolStripComboBoxHD.Margin = new System.Windows.Forms.Padding(0);
			this.toolStripComboBoxHD.Name = "toolStripComboBoxHD";
			this.toolStripComboBoxHD.Size = new System.Drawing.Size(200, 30);
			this.toolStripComboBoxHD.Text = "▶ HÓA ĐƠN";
			this.toolStripComboBoxHD.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxHD_Click);
			// 
			// P101
			// 
			this.P101.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P101.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P101.Location = new System.Drawing.Point(43, 29);
			this.P101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P101.Name = "P101";
			this.P101.Size = new System.Drawing.Size(106, 63);
			this.P101.TabIndex = 6;
			this.P101.Text = "101";
			this.P101.UseVisualStyleBackColor = false;
			this.P101.Click += new System.EventHandler(this.P101_Click);
			// 
			// P102
			// 
			this.P102.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P102.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P102.Location = new System.Drawing.Point(207, 29);
			this.P102.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P102.Name = "P102";
			this.P102.Size = new System.Drawing.Size(106, 63);
			this.P102.TabIndex = 7;
			this.P102.Text = "102";
			this.P102.UseVisualStyleBackColor = false;
			this.P102.Click += new System.EventHandler(this.P101_Click);
			// 
			// P104
			// 
			this.P104.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P104.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P104.Location = new System.Drawing.Point(531, 29);
			this.P104.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P104.Name = "P104";
			this.P104.Size = new System.Drawing.Size(106, 63);
			this.P104.TabIndex = 9;
			this.P104.Text = "104";
			this.P104.UseVisualStyleBackColor = false;
			this.P104.Click += new System.EventHandler(this.P101_Click);
			// 
			// P103
			// 
			this.P103.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P103.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P103.Location = new System.Drawing.Point(366, 29);
			this.P103.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P103.Name = "P103";
			this.P103.Size = new System.Drawing.Size(106, 63);
			this.P103.TabIndex = 8;
			this.P103.Text = "103";
			this.P103.UseVisualStyleBackColor = false;
			this.P103.Click += new System.EventHandler(this.P101_Click);
			// 
			// P108
			// 
			this.P108.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P108.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P108.Location = new System.Drawing.Point(531, 127);
			this.P108.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P108.Name = "P108";
			this.P108.Size = new System.Drawing.Size(106, 63);
			this.P108.TabIndex = 13;
			this.P108.Text = "108";
			this.P108.UseVisualStyleBackColor = false;
			this.P108.Click += new System.EventHandler(this.P101_Click);
			// 
			// P107
			// 
			this.P107.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P107.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P107.Location = new System.Drawing.Point(366, 127);
			this.P107.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P107.Name = "P107";
			this.P107.Size = new System.Drawing.Size(106, 63);
			this.P107.TabIndex = 12;
			this.P107.Text = "107";
			this.P107.UseVisualStyleBackColor = false;
			this.P107.Click += new System.EventHandler(this.P101_Click);
			// 
			// P106
			// 
			this.P106.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P106.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P106.Location = new System.Drawing.Point(207, 127);
			this.P106.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P106.Name = "P106";
			this.P106.Size = new System.Drawing.Size(106, 63);
			this.P106.TabIndex = 11;
			this.P106.Text = "106";
			this.P106.UseVisualStyleBackColor = false;
			this.P106.Click += new System.EventHandler(this.P101_Click);
			// 
			// P105
			// 
			this.P105.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P105.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P105.Location = new System.Drawing.Point(43, 127);
			this.P105.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P105.Name = "P105";
			this.P105.Size = new System.Drawing.Size(106, 63);
			this.P105.TabIndex = 10;
			this.P105.Text = "105";
			this.P105.UseVisualStyleBackColor = false;
			this.P105.Click += new System.EventHandler(this.P101_Click);
			// 
			// P202
			// 
			this.P202.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P202.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P202.Location = new System.Drawing.Point(531, 230);
			this.P202.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P202.Name = "P202";
			this.P202.Size = new System.Drawing.Size(106, 63);
			this.P202.TabIndex = 17;
			this.P202.Text = "202";
			this.P202.UseVisualStyleBackColor = false;
			this.P202.Click += new System.EventHandler(this.P101_Click);
			// 
			// P201
			// 
			this.P201.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P201.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P201.Location = new System.Drawing.Point(366, 230);
			this.P201.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P201.Name = "P201";
			this.P201.Size = new System.Drawing.Size(106, 63);
			this.P201.TabIndex = 16;
			this.P201.Text = "201";
			this.P201.UseVisualStyleBackColor = false;
			this.P201.Click += new System.EventHandler(this.P101_Click);
			// 
			// P110
			// 
			this.P110.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P110.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P110.Location = new System.Drawing.Point(207, 230);
			this.P110.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P110.Name = "P110";
			this.P110.Size = new System.Drawing.Size(106, 63);
			this.P110.TabIndex = 15;
			this.P110.Text = "110";
			this.P110.UseVisualStyleBackColor = false;
			this.P110.Click += new System.EventHandler(this.P101_Click);
			// 
			// P109
			// 
			this.P109.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P109.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P109.Location = new System.Drawing.Point(43, 230);
			this.P109.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P109.Name = "P109";
			this.P109.Size = new System.Drawing.Size(106, 63);
			this.P109.TabIndex = 14;
			this.P109.Text = "109";
			this.P109.UseVisualStyleBackColor = false;
			this.P109.Click += new System.EventHandler(this.P101_Click);
			// 
			// P206
			// 
			this.P206.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P206.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P206.Location = new System.Drawing.Point(531, 332);
			this.P206.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P206.Name = "P206";
			this.P206.Size = new System.Drawing.Size(106, 63);
			this.P206.TabIndex = 21;
			this.P206.Text = "206";
			this.P206.UseVisualStyleBackColor = false;
			this.P206.Click += new System.EventHandler(this.P101_Click);
			// 
			// P205
			// 
			this.P205.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P205.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P205.Location = new System.Drawing.Point(366, 332);
			this.P205.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P205.Name = "P205";
			this.P205.Size = new System.Drawing.Size(106, 63);
			this.P205.TabIndex = 20;
			this.P205.Text = "205";
			this.P205.UseVisualStyleBackColor = false;
			this.P205.Click += new System.EventHandler(this.P101_Click);
			// 
			// P204
			// 
			this.P204.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P204.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P204.Location = new System.Drawing.Point(207, 332);
			this.P204.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P204.Name = "P204";
			this.P204.Size = new System.Drawing.Size(106, 63);
			this.P204.TabIndex = 19;
			this.P204.Text = "204";
			this.P204.UseVisualStyleBackColor = false;
			this.P204.Click += new System.EventHandler(this.P101_Click);
			// 
			// P203
			// 
			this.P203.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P203.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P203.Location = new System.Drawing.Point(43, 332);
			this.P203.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P203.Name = "P203";
			this.P203.Size = new System.Drawing.Size(106, 63);
			this.P203.TabIndex = 18;
			this.P203.Text = "203";
			this.P203.UseVisualStyleBackColor = false;
			this.P203.Click += new System.EventHandler(this.P101_Click);
			// 
			// P210
			// 
			this.P210.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P210.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P210.Location = new System.Drawing.Point(531, 438);
			this.P210.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P210.Name = "P210";
			this.P210.Size = new System.Drawing.Size(106, 63);
			this.P210.TabIndex = 25;
			this.P210.Text = "210";
			this.P210.UseVisualStyleBackColor = false;
			this.P210.Click += new System.EventHandler(this.P101_Click);
			// 
			// P209
			// 
			this.P209.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P209.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P209.Location = new System.Drawing.Point(366, 438);
			this.P209.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P209.Name = "P209";
			this.P209.Size = new System.Drawing.Size(106, 63);
			this.P209.TabIndex = 24;
			this.P209.Text = "209";
			this.P209.UseVisualStyleBackColor = false;
			this.P209.Click += new System.EventHandler(this.P101_Click);
			// 
			// P208
			// 
			this.P208.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P208.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P208.Location = new System.Drawing.Point(207, 438);
			this.P208.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P208.Name = "P208";
			this.P208.Size = new System.Drawing.Size(106, 63);
			this.P208.TabIndex = 23;
			this.P208.Text = "208";
			this.P208.UseVisualStyleBackColor = false;
			this.P208.Click += new System.EventHandler(this.P101_Click);
			// 
			// P207
			// 
			this.P207.BackColor = System.Drawing.Color.LightSkyBlue;
			this.P207.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P207.Location = new System.Drawing.Point(43, 438);
			this.P207.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P207.Name = "P207";
			this.P207.Size = new System.Drawing.Size(106, 63);
			this.P207.TabIndex = 22;
			this.P207.Text = "207";
			this.P207.UseVisualStyleBackColor = false;
			this.P207.Click += new System.EventHandler(this.P101_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.PowderBlue;
			this.panel2.Controls.Add(this.P210);
			this.panel2.Controls.Add(this.P209);
			this.panel2.Controls.Add(this.P208);
			this.panel2.Controls.Add(this.P207);
			this.panel2.Controls.Add(this.P206);
			this.panel2.Controls.Add(this.P205);
			this.panel2.Controls.Add(this.P204);
			this.panel2.Controls.Add(this.P203);
			this.panel2.Controls.Add(this.P202);
			this.panel2.Controls.Add(this.P201);
			this.panel2.Controls.Add(this.P110);
			this.panel2.Controls.Add(this.P109);
			this.panel2.Controls.Add(this.P108);
			this.panel2.Controls.Add(this.P107);
			this.panel2.Controls.Add(this.P106);
			this.panel2.Controls.Add(this.P105);
			this.panel2.Controls.Add(this.P104);
			this.panel2.Controls.Add(this.P103);
			this.panel2.Controls.Add(this.P102);
			this.panel2.Controls.Add(this.P101);
			this.panel2.Location = new System.Drawing.Point(309, 29);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(674, 541);
			this.panel2.TabIndex = 28;
			// 
			// Dashboard
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1013, 596);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Dashboard";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hotel Manangement System";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuHD.ResumeLayout(false);
			this.menuHD.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dish;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button P101;
        private System.Windows.Forms.Button P102;
        private System.Windows.Forms.Button P104;
        private System.Windows.Forms.Button P103;
        private System.Windows.Forms.Button P108;
        private System.Windows.Forms.Button P107;
        private System.Windows.Forms.Button P106;
        private System.Windows.Forms.Button P105;
        private System.Windows.Forms.Button P202;
        private System.Windows.Forms.Button P201;
        private System.Windows.Forms.Button P110;
        private System.Windows.Forms.Button P109;
        private System.Windows.Forms.Button P206;
        private System.Windows.Forms.Button P205;
        private System.Windows.Forms.Button P204;
        private System.Windows.Forms.Button P203;
        private System.Windows.Forms.Button P210;
        private System.Windows.Forms.Button P209;
        private System.Windows.Forms.Button P208;
        private System.Windows.Forms.Button P207;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label checkin;
        private System.Windows.Forms.Label checkout;
		private System.Windows.Forms.Label customer;
		private System.Windows.Forms.MenuStrip menuHD;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxHD;
		private System.Windows.Forms.Button logout;
	}
}