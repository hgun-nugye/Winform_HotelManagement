namespace HotelManagement
{
    partial class HoaDonForm
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
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridViewHD = new System.Windows.Forms.DataGridView();
			this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.inputFind = new System.Windows.Forms.TextBox();
			this.delete = new System.Windows.Forms.Button();
			this.inputNgayXuat = new System.Windows.Forms.DateTimePicker();
			this.back = new System.Windows.Forms.Button();
			this.listHDP = new System.Windows.Forms.ListBox();
			this.listHDM = new System.Windows.Forms.ListBox();
			this.listHDDV = new System.Windows.Forms.ListBox();
			this.comboTT = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textMaHD = new System.Windows.Forms.TextBox();
			this.textMaNV = new System.Windows.Forms.TextBox();
			this.textMaKH = new System.Windows.Forms.TextBox();
			this.TongHD = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayXuatHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(345, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 18);
			this.label7.TabIndex = 29;
			this.label7.Text = "Mã Khách hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(648, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 18);
			this.label2.TabIndex = 27;
			this.label2.Text = "Mã Nhân viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 26;
			this.label1.Text = "Mã Hóa đơn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(345, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 18);
			this.label3.TabIndex = 44;
			this.label3.Text = "Hóa đơn Món";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(648, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 18);
			this.label4.TabIndex = 43;
			this.label4.Text = "Hóa đơn Dịch vụ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(37, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 18);
			this.label5.TabIndex = 42;
			this.label5.Text = "Hóa đơn Phòng";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(345, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 18);
			this.label8.TabIndex = 49;
			this.label8.Text = "Trạng thái";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(37, 215);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 18);
			this.label9.TabIndex = 48;
			this.label9.Text = "Ngày xuất";
			// 
			// dataGridViewHD
			// 
			this.dataGridViewHD.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.MaLoaiHD,
            this.NgayXuatHD,
            this.TrangThai,
            this.ThanhTien});
			this.dataGridViewHD.Location = new System.Drawing.Point(41, 314);
			this.dataGridViewHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewHD.Name = "dataGridViewHD";
			this.dataGridViewHD.ReadOnly = true;
			this.dataGridViewHD.RowHeadersWidth = 62;
			this.dataGridViewHD.RowTemplate.Height = 28;
			this.dataGridViewHD.Size = new System.Drawing.Size(894, 248);
			this.dataGridViewHD.TabIndex = 54;
			this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
			this.dataGridViewHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
			// 
			// inputFind
			// 
			this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputFind.Location = new System.Drawing.Point(569, 261);
			this.inputFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputFind.Multiline = true;
			this.inputFind.Name = "inputFind";
			this.inputFind.Size = new System.Drawing.Size(366, 41);
			this.inputFind.TabIndex = 58;
			this.inputFind.Click += new System.EventHandler(this.inputFind_MouseEnter);
			this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(44, 261);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(80, 40);
			this.delete.TabIndex = 56;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// inputNgayXuat
			// 
			this.inputNgayXuat.CustomFormat = "dd/MM/yyyy";
			this.inputNgayXuat.Enabled = false;
			this.inputNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgayXuat.Location = new System.Drawing.Point(174, 213);
			this.inputNgayXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputNgayXuat.Name = "inputNgayXuat";
			this.inputNgayXuat.Size = new System.Drawing.Size(142, 22);
			this.inputNgayXuat.TabIndex = 59;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlText;
			this.back.Location = new System.Drawing.Point(148, 261);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 60;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// listHDP
			// 
			this.listHDP.FormattingEnabled = true;
			this.listHDP.ItemHeight = 16;
			this.listHDP.Location = new System.Drawing.Point(174, 119);
			this.listHDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listHDP.Name = "listHDP";
			this.listHDP.ScrollAlwaysVisible = true;
			this.listHDP.Size = new System.Drawing.Size(141, 68);
			this.listHDP.TabIndex = 62;
			// 
			// listHDM
			// 
			this.listHDM.FormattingEnabled = true;
			this.listHDM.ItemHeight = 16;
			this.listHDM.Location = new System.Drawing.Point(482, 119);
			this.listHDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listHDM.Name = "listHDM";
			this.listHDM.ScrollAlwaysVisible = true;
			this.listHDM.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listHDM.Size = new System.Drawing.Size(137, 68);
			this.listHDM.TabIndex = 63;
			// 
			// listHDDV
			// 
			this.listHDDV.FormattingEnabled = true;
			this.listHDDV.ItemHeight = 16;
			this.listHDDV.Location = new System.Drawing.Point(798, 119);
			this.listHDDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listHDDV.Name = "listHDDV";
			this.listHDDV.ScrollAlwaysVisible = true;
			this.listHDDV.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listHDDV.Size = new System.Drawing.Size(137, 68);
			this.listHDDV.TabIndex = 64;
			// 
			// comboTT
			// 
			this.comboTT.Location = new System.Drawing.Point(482, 209);
			this.comboTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboTT.Multiline = true;
			this.comboTT.Name = "comboTT";
			this.comboTT.Size = new System.Drawing.Size(136, 26);
			this.comboTT.TabIndex = 65;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Crimson;
			this.label14.Location = new System.Drawing.Point(397, 22);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(213, 29);
			this.label14.TabIndex = 72;
			this.label14.Text = "TỔNG HÓA ĐƠN";
			// 
			// textMaHD
			// 
			this.textMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaHD.Location = new System.Drawing.Point(174, 69);
			this.textMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textMaHD.Multiline = true;
			this.textMaHD.Name = "textMaHD";
			this.textMaHD.Size = new System.Drawing.Size(142, 33);
			this.textMaHD.TabIndex = 73;
			// 
			// textMaNV
			// 
			this.textMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaNV.Location = new System.Drawing.Point(798, 69);
			this.textMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textMaNV.Multiline = true;
			this.textMaNV.Name = "textMaNV";
			this.textMaNV.Size = new System.Drawing.Size(137, 33);
			this.textMaNV.TabIndex = 74;
			this.textMaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textMaKH
			// 
			this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaKH.Location = new System.Drawing.Point(482, 69);
			this.textMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textMaKH.Multiline = true;
			this.textMaKH.Name = "textMaKH";
			this.textMaKH.Size = new System.Drawing.Size(137, 33);
			this.textMaKH.TabIndex = 75;
			// 
			// TongHD
			// 
			this.TongHD.Location = new System.Drawing.Point(798, 208);
			this.TongHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TongHD.Multiline = true;
			this.TongHD.Name = "TongHD";
			this.TongHD.Size = new System.Drawing.Size(136, 26);
			this.TongHD.TabIndex = 77;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(661, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 18);
			this.label6.TabIndex = 76;
			this.label6.Text = "Tổng Hóa đơn";
			// 
			// MaHD
			// 
			this.MaHD.DataPropertyName = "MaHD";
			this.MaHD.HeaderText = "Mã Hóa đơn";
			this.MaHD.MinimumWidth = 8;
			this.MaHD.Name = "MaHD";
			this.MaHD.ReadOnly = true;
			this.MaHD.Width = 120;
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách hàng";
			this.MaKH.MinimumWidth = 8;
			this.MaKH.Name = "MaKH";
			this.MaKH.ReadOnly = true;
			this.MaKH.Width = 120;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 8;
			this.MaNV.Name = "MaNV";
			this.MaNV.ReadOnly = true;
			this.MaNV.Width = 120;
			// 
			// MaLoaiHD
			// 
			this.MaLoaiHD.DataPropertyName = "MaLoaiHD";
			this.MaLoaiHD.HeaderText = "Mã loại Hóa đơn";
			this.MaLoaiHD.MinimumWidth = 8;
			this.MaLoaiHD.Name = "MaLoaiHD";
			this.MaLoaiHD.ReadOnly = true;
			this.MaLoaiHD.Width = 150;
			// 
			// NgayXuatHD
			// 
			this.NgayXuatHD.DataPropertyName = "NgayXuatHD";
			this.NgayXuatHD.HeaderText = "Ngày xuất";
			this.NgayXuatHD.MinimumWidth = 8;
			this.NgayXuatHD.Name = "NgayXuatHD";
			this.NgayXuatHD.ReadOnly = true;
			this.NgayXuatHD.Width = 150;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái thanh toán";
			this.TrangThai.MinimumWidth = 8;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.ReadOnly = true;
			this.TrangThai.Width = 180;
			// 
			// ThanhTien
			// 
			this.ThanhTien.DataPropertyName = "TongHoaDon";
			this.ThanhTien.HeaderText = "Tổng Hóa đơn";
			this.ThanhTien.MinimumWidth = 6;
			this.ThanhTien.Name = "ThanhTien";
			this.ThanhTien.ReadOnly = true;
			this.ThanhTien.Width = 125;
			// 
			// HoaDonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(993, 594);
			this.Controls.Add(this.TongHD);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textMaKH);
			this.Controls.Add(this.textMaNV);
			this.Controls.Add(this.textMaHD);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.comboTT);
			this.Controls.Add(this.listHDDV);
			this.Controls.Add(this.listHDM);
			this.Controls.Add(this.listHDP);
			this.Controls.Add(this.back);
			this.Controls.Add(this.inputNgayXuat);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.dataGridViewHD);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "HoaDonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hóa đơn";
			this.Load += new System.EventHandler(this.HoaDonForm_Load);
			this.Click += new System.EventHandler(this.HoaDonForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.TextBox inputFind;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DateTimePicker inputNgayXuat;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox listHDP;
        private System.Windows.Forms.ListBox listHDM;
        private System.Windows.Forms.ListBox listHDDV;
		private System.Windows.Forms.TextBox comboTT;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textMaHD;
		private System.Windows.Forms.TextBox textMaNV;
		private System.Windows.Forms.TextBox textMaKH;
		private System.Windows.Forms.TextBox TongHD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
	}
}