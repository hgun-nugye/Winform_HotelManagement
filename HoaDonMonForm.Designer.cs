namespace HotelManagement
{
	partial class bangHoaDonMon
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
			this.textThanhTien = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.inputFind = new System.Windows.Forms.TextBox();
			this.textMaKH = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
			this.textMaHDM = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewHDM = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.MaHDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SL_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDM)).BeginInit();
			this.SuspendLayout();
			// 
			// textThanhTien
			// 
			this.textThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textThanhTien.Location = new System.Drawing.Point(668, 114);
			this.textThanhTien.Margin = new System.Windows.Forms.Padding(4);
			this.textThanhTien.Multiline = true;
			this.textThanhTien.Name = "textThanhTien";
			this.textThanhTien.Size = new System.Drawing.Size(252, 40);
			this.textThanhTien.TabIndex = 40;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(488, 130);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 25);
			this.label5.TabIndex = 39;
			this.label5.Text = "Thành tiền ";
			// 
			// inputFind
			// 
			this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.inputFind.Location = new System.Drawing.Point(500, 214);
			this.inputFind.Margin = new System.Windows.Forms.Padding(4);
			this.inputFind.Multiline = true;
			this.inputFind.Name = "inputFind";
			this.inputFind.Size = new System.Drawing.Size(420, 41);
			this.inputFind.TabIndex = 38;
			this.inputFind.Click += new System.EventHandler(this.inputFind_MouseEnter);
			// 
			// textMaKH
			// 
			this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaKH.Location = new System.Drawing.Point(668, 67);
			this.textMaKH.Margin = new System.Windows.Forms.Padding(4);
			this.textMaKH.Multiline = true;
			this.textMaKH.Name = "textMaKH";
			this.textMaKH.Size = new System.Drawing.Size(252, 35);
			this.textMaKH.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(488, 78);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 25);
			this.label4.TabIndex = 34;
			this.label4.Text = "Mã khách hàng ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 25);
			this.label2.TabIndex = 31;
			this.label2.Text = "Ngày đặt ";
			// 
			// dateNgayDat
			// 
			this.dateNgayDat.CustomFormat = "dd/MM/yyyy";
			this.dateNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateNgayDat.Location = new System.Drawing.Point(235, 126);
			this.dateNgayDat.Margin = new System.Windows.Forms.Padding(4);
			this.dateNgayDat.Name = "dateNgayDat";
			this.dateNgayDat.Size = new System.Drawing.Size(213, 30);
			this.dateNgayDat.TabIndex = 30;
			// 
			// textMaHDM
			// 
			this.textMaHDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaHDM.Location = new System.Drawing.Point(235, 63);
			this.textMaHDM.Margin = new System.Windows.Forms.Padding(4);
			this.textMaHDM.Multiline = true;
			this.textMaHDM.Name = "textMaHDM";
			this.textMaHDM.Size = new System.Drawing.Size(213, 39);
			this.textMaHDM.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 78);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 25);
			this.label1.TabIndex = 28;
			this.label1.Text = "Mã hóa đơn món ";
			// 
			// dataGridViewHDM
			// 
			this.dataGridViewHDM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridViewHDM.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewHDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDM,
            this.MaNV,
            this.MaKH,
            this.NgayDat,
            this.NgaySD,
            this.MaP,
            this.TenMon,
            this.SL_Mon,
            this.TrangThai,
            this.ThanhTien});
			this.dataGridViewHDM.Location = new System.Drawing.Point(41, 274);
			this.dataGridViewHDM.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewHDM.Name = "dataGridViewHDM";
			this.dataGridViewHDM.RowHeadersWidth = 62;
			this.dataGridViewHDM.Size = new System.Drawing.Size(878, 245);
			this.dataGridViewHDM.TabIndex = 27;
			this.dataGridViewHDM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDM_CellClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(146, 214);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 40);
			this.button1.TabIndex = 68;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.back_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(44, 214);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 40);
			this.button3.TabIndex = 66;
			this.button3.Text = "Xóa";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.delete_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Teal;
			this.label14.Location = new System.Drawing.Point(367, 14);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(198, 29);
			this.label14.TabIndex = 71;
			this.label14.Text = "HÓA ĐƠN MÓN";
			// 
			// MaHDM
			// 
			this.MaHDM.DataPropertyName = "MaHDM";
			this.MaHDM.HeaderText = "Mã Hóa đơn món";
			this.MaHDM.MinimumWidth = 8;
			this.MaHDM.Name = "MaHDM";
			this.MaHDM.Width = 104;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã Nhân viên";
			this.MaNV.MinimumWidth = 8;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 109;
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách hàng";
			this.MaKH.MinimumWidth = 8;
			this.MaKH.Name = "MaKH";
			this.MaKH.Width = 118;
			// 
			// NgayDat
			// 
			this.NgayDat.DataPropertyName = "NgayDat";
			this.NgayDat.HeaderText = "Ngày Đặt";
			this.NgayDat.MinimumWidth = 8;
			this.NgayDat.Name = "NgayDat";
			this.NgayDat.Width = 85;
			// 
			// NgaySD
			// 
			this.NgaySD.DataPropertyName = "NgaySD";
			this.NgaySD.HeaderText = "Ngày Sử dụng";
			this.NgaySD.MinimumWidth = 8;
			this.NgaySD.Name = "NgaySD";
			this.NgaySD.Width = 111;
			// 
			// MaP
			// 
			this.MaP.DataPropertyName = "MaP";
			this.MaP.HeaderText = "Mã Phòng";
			this.MaP.MinimumWidth = 8;
			this.MaP.Name = "MaP";
			this.MaP.Width = 90;
			// 
			// TenMon
			// 
			this.TenMon.DataPropertyName = "TenMon";
			this.TenMon.HeaderText = "Tên Món";
			this.TenMon.MinimumWidth = 8;
			this.TenMon.Name = "TenMon";
			this.TenMon.Width = 83;
			// 
			// SL_Mon
			// 
			this.SL_Mon.DataPropertyName = "SL_Mon";
			this.SL_Mon.HeaderText = "Số lượng";
			this.SL_Mon.MinimumWidth = 8;
			this.SL_Mon.Name = "SL_Mon";
			this.SL_Mon.Width = 83;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 8;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 89;
			// 
			// ThanhTien
			// 
			this.ThanhTien.DataPropertyName = "Thành Tiền";
			this.ThanhTien.HeaderText = "Thành tiền";
			this.ThanhTien.MinimumWidth = 8;
			this.ThanhTien.Name = "ThanhTien";
			this.ThanhTien.Width = 91;
			// 
			// bangHoaDonMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 550);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textThanhTien);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.textMaKH);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateNgayDat);
			this.Controls.Add(this.textMaHDM);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewHDM);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "bangHoaDonMon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hóa đơn Món";
			this.Load += new System.EventHandler(this.frmHoaDonMon_Load);
			this.Click += new System.EventHandler(this.frmHoaDonMon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDM)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textThanhTien;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox inputFind;
		private System.Windows.Forms.TextBox textMaKH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateNgayDat;
		private System.Windows.Forms.TextBox textMaHDM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewHDM;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHDM;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
		private System.Windows.Forms.DataGridViewTextBoxColumn SL_Mon;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
	}
}