﻿namespace HotelManagement
{
	partial class bangHoaDonDV
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label5 = new System.Windows.Forms.Label();
			this.textThanhTien = new System.Windows.Forms.TextBox();
			this.inputFind = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textMaKH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textMaHDDV = new System.Windows.Forms.TextBox();
			this.back = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.dataGridViewHDDV = new System.Windows.Forms.DataGridView();
			this.MaHDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SL_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDDV)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(496, 118);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 25);
			this.label5.TabIndex = 30;
			this.label5.Text = "Thành tiền ";
			// 
			// textThanhTien
			// 
			this.textThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textThanhTien.Location = new System.Drawing.Point(676, 106);
			this.textThanhTien.Margin = new System.Windows.Forms.Padding(4);
			this.textThanhTien.Multiline = true;
			this.textThanhTien.Name = "textThanhTien";
			this.textThanhTien.Size = new System.Drawing.Size(239, 35);
			this.textThanhTien.TabIndex = 29;
			// 
			// inputFind
			// 
			this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputFind.Location = new System.Drawing.Point(500, 196);
			this.inputFind.Margin = new System.Windows.Forms.Padding(4);
			this.inputFind.Multiline = true;
			this.inputFind.Name = "inputFind";
			this.inputFind.Size = new System.Drawing.Size(414, 41);
			this.inputFind.TabIndex = 28;
			this.inputFind.Click += new System.EventHandler(this.inputFind_MouseEnter);
			this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(496, 67);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 25);
			this.label4.TabIndex = 25;
			this.label4.Text = "Mã khách hàng ";
			// 
			// textMaKH
			// 
			this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaKH.Location = new System.Drawing.Point(676, 58);
			this.textMaKH.Margin = new System.Windows.Forms.Padding(4);
			this.textMaKH.Multiline = true;
			this.textMaKH.Name = "textMaKH";
			this.textMaKH.Size = new System.Drawing.Size(239, 34);
			this.textMaKH.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 118);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 25);
			this.label2.TabIndex = 21;
			this.label2.Text = "Ngày đặt ";
			// 
			// dateNgayDat
			// 
			this.dateNgayDat.CustomFormat = "dd/MM/yyyy";
			this.dateNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateNgayDat.Location = new System.Drawing.Point(256, 118);
			this.dateNgayDat.Margin = new System.Windows.Forms.Padding(4);
			this.dateNgayDat.Name = "dateNgayDat";
			this.dateNgayDat.Size = new System.Drawing.Size(200, 30);
			this.dateNgayDat.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 67);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "Mã hóa đơn dịch vụ ";
			// 
			// textMaHDDV
			// 
			this.textMaHDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaHDDV.Location = new System.Drawing.Point(256, 58);
			this.textMaHDDV.Margin = new System.Windows.Forms.Padding(4);
			this.textMaHDDV.Multiline = true;
			this.textMaHDDV.Name = "textMaHDDV";
			this.textMaHDDV.Size = new System.Drawing.Size(200, 34);
			this.textMaHDDV.TabIndex = 16;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(267, 196);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 68;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(136, 196);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(113, 40);
			this.update.TabIndex = 67;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(36, 196);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(80, 40);
			this.delete.TabIndex = 66;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// dataGridViewHDDV
			// 
			this.dataGridViewHDDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridViewHDDV.BackgroundColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewHDDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewHDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHDDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDDV,
            this.MaNV,
            this.MaKH,
            this.NgayDat,
            this.NgaySD,
            this.MaP,
            this.TenDV,
            this.SL_DV,
            this.TrangThai,
            this.ThanhTien});
			this.dataGridViewHDDV.Location = new System.Drawing.Point(36, 259);
			this.dataGridViewHDDV.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewHDDV.Name = "dataGridViewHDDV";
			this.dataGridViewHDDV.RowHeadersWidth = 62;
			this.dataGridViewHDDV.Size = new System.Drawing.Size(878, 256);
			this.dataGridViewHDDV.TabIndex = 69;
			this.dataGridViewHDDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDDV_CellClick);
			this.dataGridViewHDDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDDV_CellClick);
			// 
			// MaHDDV
			// 
			this.MaHDDV.DataPropertyName = "MaHDDV";
			this.MaHDDV.HeaderText = "Mã Hóa đơn Dịch vụ";
			this.MaHDDV.MinimumWidth = 8;
			this.MaHDDV.Name = "MaHDDV";
			this.MaHDDV.Width = 158;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã Nhân viên";
			this.MaNV.MinimumWidth = 8;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 128;
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách hàng";
			this.MaKH.MinimumWidth = 8;
			this.MaKH.Name = "MaKH";
			this.MaKH.Width = 140;
			// 
			// NgayDat
			// 
			this.NgayDat.DataPropertyName = "NgayDat";
			this.NgayDat.HeaderText = "Ngày Đặt";
			this.NgayDat.MinimumWidth = 8;
			this.NgayDat.Name = "NgayDat";
			this.NgayDat.Width = 98;
			// 
			// NgaySD
			// 
			this.NgaySD.DataPropertyName = "NgaySD";
			this.NgaySD.HeaderText = "Ngày Sử dụng";
			this.NgaySD.MinimumWidth = 8;
			this.NgaySD.Name = "NgaySD";
			this.NgaySD.Width = 129;
			// 
			// MaP
			// 
			this.MaP.DataPropertyName = "MaP";
			this.MaP.HeaderText = "Mã Phòng";
			this.MaP.MinimumWidth = 8;
			this.MaP.Name = "MaP";
			this.MaP.Width = 104;
			// 
			// TenDV
			// 
			this.TenDV.DataPropertyName = "TenDV";
			this.TenDV.HeaderText = "Tên Dịch vụ";
			this.TenDV.MinimumWidth = 8;
			this.TenDV.Name = "TenDV";
			this.TenDV.Width = 101;
			// 
			// SL_DV
			// 
			this.SL_DV.DataPropertyName = "SL_DV";
			this.SL_DV.HeaderText = "Số lượng";
			this.SL_DV.MinimumWidth = 8;
			this.SL_DV.Name = "SL_DV";
			this.SL_DV.Width = 96;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 8;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 103;
			// 
			// ThanhTien
			// 
			this.ThanhTien.DataPropertyName = "ThanhTien";
			this.ThanhTien.HeaderText = "Thành tiền";
			this.ThanhTien.MinimumWidth = 8;
			this.ThanhTien.Name = "ThanhTien";
			this.ThanhTien.Width = 106;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Teal;
			this.label14.Location = new System.Drawing.Point(344, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(240, 29);
			this.label14.TabIndex = 70;
			this.label14.Text = "HÓA ĐƠN DỊCH VỤ";
			// 
			// bangHoaDonDV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 547);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dataGridViewHDDV);
			this.Controls.Add(this.back);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textThanhTien);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textMaKH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateNgayDat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textMaHDDV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "bangHoaDonDV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hóa đơn Dịch vụ";
			this.Load += new System.EventHandler(this.bangHoaDonDV_Load);
			this.Click += new System.EventHandler(this.bangHoaDonDV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDDV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textThanhTien;
		private System.Windows.Forms.TextBox inputFind;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textMaKH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateNgayDat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textMaHDDV;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.DataGridView dataGridViewHDDV;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHDDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn SL_DV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
	}
}