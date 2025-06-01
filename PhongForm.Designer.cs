namespace HotelManagement.GUII
{
	partial class PhongForm
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
			this.label9 = new System.Windows.Forms.Label();
			this.inputTienNghi = new System.Windows.Forms.TextBox();
			this.inputDienTich = new System.Windows.Forms.TextBox();
			this.cbSoGiuong = new System.Windows.Forms.ComboBox();
			this.cbSucChua = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.bangPhong = new System.Windows.Forms.DataGridView();
			this.inputGiaMacDinh = new System.Windows.Forms.TextBox();
			this.inputTenLP = new System.Windows.Forms.TextBox();
			this.inputMaLP = new System.Windows.Forms.TextBox();
			this.inputMaP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.comboTT = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GiaMacDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bangPhong)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label9.Location = new System.Drawing.Point(29, 106);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(154, 25);
			this.label9.TabIndex = 49;
			this.label9.Text = "Mã loại phòng ";
			// 
			// inputTienNghi
			// 
			this.inputTienNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputTienNghi.Location = new System.Drawing.Point(660, 190);
			this.inputTienNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputTienNghi.Multiline = true;
			this.inputTienNghi.Name = "inputTienNghi";
			this.inputTienNghi.Size = new System.Drawing.Size(249, 34);
			this.inputTienNghi.TabIndex = 48;
			// 
			// inputDienTich
			// 
			this.inputDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputDienTich.Location = new System.Drawing.Point(660, 144);
			this.inputDienTich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputDienTich.Multiline = true;
			this.inputDienTich.Name = "inputDienTich";
			this.inputDienTich.Size = new System.Drawing.Size(249, 31);
			this.inputDienTich.TabIndex = 47;
			// 
			// cbSoGiuong
			// 
			this.cbSoGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSoGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSoGiuong.FormattingEnabled = true;
			this.cbSoGiuong.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
			this.cbSoGiuong.Location = new System.Drawing.Point(660, 106);
			this.cbSoGiuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSoGiuong.Name = "cbSoGiuong";
			this.cbSoGiuong.Size = new System.Drawing.Size(249, 28);
			this.cbSoGiuong.TabIndex = 46;
			this.cbSoGiuong.SelectedIndexChanged += new System.EventHandler(this.cbSoGiuong_SelectedIndexChanged);
			this.cbSoGiuong.TextChanged += new System.EventHandler(this.cbSoGiuong_TextChanged);
			// 
			// cbSucChua
			// 
			this.cbSucChua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSucChua.FormattingEnabled = true;
			this.cbSucChua.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
			this.cbSucChua.Location = new System.Drawing.Point(660, 69);
			this.cbSucChua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSucChua.Name = "cbSucChua";
			this.cbSucChua.Size = new System.Drawing.Size(249, 28);
			this.cbSucChua.TabIndex = 45;
			this.cbSucChua.SelectedIndexChanged += new System.EventHandler(this.cbSucChua_SelectedIndexChanged);
			this.cbSucChua.TextChanged += new System.EventHandler(this.cbSucChua_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label6.Location = new System.Drawing.Point(506, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 25);
			this.label6.TabIndex = 41;
			this.label6.Text = "Tiện nghi ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label5.Location = new System.Drawing.Point(506, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 25);
			this.label5.TabIndex = 44;
			this.label5.Text = "Diện tích ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label7.Location = new System.Drawing.Point(506, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 25);
			this.label7.TabIndex = 43;
			this.label7.Text = "Số giường ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label8.Location = new System.Drawing.Point(506, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 25);
			this.label8.TabIndex = 42;
			this.label8.Text = "Sức chứa ";
			// 
			// bangPhong
			// 
			this.bangPhong.AllowUserToOrderColumns = true;
			this.bangPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.bangPhong.BackgroundColor = System.Drawing.Color.Ivory;
			this.bangPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bangPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaP,
            this.MaLP,
            this.TenLP,
            this.SucChua,
            this.SoGiuong,
            this.DienTich,
            this.TienNghi,
            this.TrangThai,
            this.GiaMacDinh});
			this.bangPhong.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.bangPhong.Location = new System.Drawing.Point(34, 350);
			this.bangPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bangPhong.Name = "bangPhong";
			this.bangPhong.RowHeadersWidth = 62;
			this.bangPhong.RowTemplate.Height = 28;
			this.bangPhong.Size = new System.Drawing.Size(875, 204);
			this.bangPhong.TabIndex = 36;
			this.bangPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangPhong_CellClick);
			// 
			// inputGiaMacDinh
			// 
			this.inputGiaMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputGiaMacDinh.Location = new System.Drawing.Point(223, 197);
			this.inputGiaMacDinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputGiaMacDinh.Multiline = true;
			this.inputGiaMacDinh.Name = "inputGiaMacDinh";
			this.inputGiaMacDinh.Size = new System.Drawing.Size(235, 25);
			this.inputGiaMacDinh.TabIndex = 35;
			// 
			// inputTenLP
			// 
			this.inputTenLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputTenLP.Location = new System.Drawing.Point(223, 151);
			this.inputTenLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputTenLP.Multiline = true;
			this.inputTenLP.Name = "inputTenLP";
			this.inputTenLP.Size = new System.Drawing.Size(235, 25);
			this.inputTenLP.TabIndex = 34;
			// 
			// inputMaLP
			// 
			this.inputMaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputMaLP.Location = new System.Drawing.Point(223, 110);
			this.inputMaLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputMaLP.Multiline = true;
			this.inputMaLP.Name = "inputMaLP";
			this.inputMaLP.Size = new System.Drawing.Size(235, 25);
			this.inputMaLP.TabIndex = 33;
			// 
			// inputMaP
			// 
			this.inputMaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputMaP.Location = new System.Drawing.Point(223, 66);
			this.inputMaP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputMaP.Multiline = true;
			this.inputMaP.Name = "inputMaP";
			this.inputMaP.Size = new System.Drawing.Size(235, 25);
			this.inputMaP.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label4.Location = new System.Drawing.Point(29, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 25);
			this.label4.TabIndex = 31;
			this.label4.Text = "Giá mặc định ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label3.Location = new System.Drawing.Point(29, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 25);
			this.label3.TabIndex = 30;
			this.label3.Text = "Trạng thái ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label2.Location = new System.Drawing.Point(29, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 25);
			this.label2.TabIndex = 29;
			this.label2.Text = "Tên loại phòng ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label1.Location = new System.Drawing.Point(29, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 25);
			this.label1.TabIndex = 28;
			this.label1.Text = "Mã phòng ";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(832, 295);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 65;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(688, 295);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(124, 40);
			this.update.TabIndex = 64;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(588, 295);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(80, 40);
			this.delete.TabIndex = 63;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(492, 295);
			this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(80, 40);
			this.insert.TabIndex = 62;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// comboTT
			// 
			this.comboTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTT.FormattingEnabled = true;
			this.comboTT.Items.AddRange(new object[] {
            "Trống",
            "Đang dọn dẹp"});
			this.comboTT.Location = new System.Drawing.Point(223, 245);
			this.comboTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboTT.Name = "comboTT";
			this.comboTT.Size = new System.Drawing.Size(235, 28);
			this.comboTT.TabIndex = 66;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Location = new System.Drawing.Point(352, 14);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(260, 29);
			this.label14.TabIndex = 67;
			this.label14.Text = "DANH SÁCH PHÒNG";
			// 
			// MaP
			// 
			this.MaP.DataPropertyName = "MaP";
			this.MaP.HeaderText = "Mã Phòng";
			this.MaP.MinimumWidth = 6;
			this.MaP.Name = "MaP";
			this.MaP.Width = 97;
			// 
			// MaLP
			// 
			this.MaLP.DataPropertyName = "MaLP";
			this.MaLP.HeaderText = "Mã loại phòng";
			this.MaLP.MinimumWidth = 8;
			this.MaLP.Name = "MaLP";
			this.MaLP.Width = 121;
			// 
			// TenLP
			// 
			this.TenLP.DataPropertyName = "TenLP";
			this.TenLP.HeaderText = "Tên loại phòng";
			this.TenLP.MinimumWidth = 8;
			this.TenLP.Name = "TenLP";
			this.TenLP.ReadOnly = true;
			this.TenLP.Width = 116;
			// 
			// SucChua
			// 
			this.SucChua.DataPropertyName = "SucChua";
			this.SucChua.HeaderText = "Sức chứa";
			this.SucChua.MinimumWidth = 8;
			this.SucChua.Name = "SucChua";
			this.SucChua.ReadOnly = true;
			this.SucChua.Width = 84;
			// 
			// SoGiuong
			// 
			this.SoGiuong.DataPropertyName = "SoGiuong";
			this.SoGiuong.HeaderText = "Số giường";
			this.SoGiuong.MinimumWidth = 8;
			this.SoGiuong.Name = "SoGiuong";
			this.SoGiuong.ReadOnly = true;
			this.SoGiuong.Width = 90;
			// 
			// DienTich
			// 
			this.DienTich.DataPropertyName = "DienTich";
			this.DienTich.HeaderText = "Diện tích";
			this.DienTich.MinimumWidth = 8;
			this.DienTich.Name = "DienTich";
			this.DienTich.ReadOnly = true;
			this.DienTich.Width = 81;
			// 
			// TienNghi
			// 
			this.TienNghi.DataPropertyName = "TienNghi";
			this.TienNghi.HeaderText = "Tiện nghi";
			this.TienNghi.MinimumWidth = 8;
			this.TienNghi.Name = "TienNghi";
			this.TienNghi.ReadOnly = true;
			this.TienNghi.Width = 84;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 8;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.ReadOnly = true;
			this.TrangThai.Width = 89;
			// 
			// GiaMacDinh
			// 
			this.GiaMacDinh.DataPropertyName = "GiaMacDinh";
			this.GiaMacDinh.HeaderText = "Giá mặc định";
			this.GiaMacDinh.MinimumWidth = 8;
			this.GiaMacDinh.Name = "GiaMacDinh";
			this.GiaMacDinh.ReadOnly = true;
			this.GiaMacDinh.Width = 105;
			// 
			// PhongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(953, 590);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.comboTT);
			this.Controls.Add(this.back);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.inputTienNghi);
			this.Controls.Add(this.inputDienTich);
			this.Controls.Add(this.cbSoGiuong);
			this.Controls.Add(this.cbSucChua);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.bangPhong);
			this.Controls.Add(this.inputGiaMacDinh);
			this.Controls.Add(this.inputTenLP);
			this.Controls.Add(this.inputMaLP);
			this.Controls.Add(this.inputMaP);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximumSize = new System.Drawing.Size(974, 645);
			this.Name = "PhongForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách Phòng Khách sạn";
			this.Load += new System.EventHandler(this.PhongForm_Load);
			this.Click += new System.EventHandler(this.PhongForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bangPhong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox inputTienNghi;
		private System.Windows.Forms.TextBox inputDienTich;
		private System.Windows.Forms.ComboBox cbSoGiuong;
		private System.Windows.Forms.ComboBox cbSucChua;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView bangPhong;
		private System.Windows.Forms.TextBox inputGiaMacDinh;
		private System.Windows.Forms.TextBox inputTenLP;
		private System.Windows.Forms.TextBox inputMaLP;
		private System.Windows.Forms.TextBox inputMaP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.ComboBox comboTT;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaP;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenLP;
		private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoGiuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
		private System.Windows.Forms.DataGridViewTextBoxColumn TienNghi;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn GiaMacDinh;
	}
}