namespace HotelManagement
{
    partial class bangNV
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bangNV));
			this.dataGridViewNV = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoBHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NamBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaSoThueCaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.insert = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textMaNV = new System.Windows.Forms.TextBox();
			this.textCCCD = new System.Windows.Forms.TextBox();
			this.textHoTen = new System.Windows.Forms.TextBox();
			this.textChucVu = new System.Windows.Forms.TextBox();
			this.textSDT = new System.Windows.Forms.TextBox();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.textDiaChi = new System.Windows.Forms.TextBox();
			this.textSoBHYT = new System.Windows.Forms.TextBox();
			this.textSoHopDong = new System.Windows.Forms.TextBox();
			this.textNamBatDau = new System.Windows.Forms.TextBox();
			this.inputNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.update = new System.Windows.Forms.Button();
			this.inputFind = new System.Windows.Forms.TextBox();
			this.textMST = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.radioNam = new System.Windows.Forms.RadioButton();
			this.radioNu = new System.Windows.Forms.RadioButton();
			this.groupGT = new System.Windows.Forms.GroupBox();
			this.back = new System.Windows.Forms.Button();
			this.lichLam = new System.Windows.Forms.Button();
			this.luong = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
			this.groupGT.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewNV
			// 
			this.dataGridViewNV.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.CCCD,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.ChucVu,
            this.SDT_NV,
            this.Email_NV,
            this.DiaChi,
            this.SoBHYT,
            this.SoHopDong,
            this.NamBatDau,
            this.MaSoThueCaNhan});
			resources.ApplyResources(this.dataGridViewNV, "dataGridViewNV");
			this.dataGridViewNV.Name = "dataGridViewNV";
			this.dataGridViewNV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewNV.RowTemplate.Height = 28;
			this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			resources.ApplyResources(this.MaNV, "MaNV");
			this.MaNV.Name = "MaNV";
			this.MaNV.ReadOnly = true;
			// 
			// CCCD
			// 
			this.CCCD.DataPropertyName = "CCCD";
			resources.ApplyResources(this.CCCD, "CCCD");
			this.CCCD.Name = "CCCD";
			this.CCCD.ReadOnly = true;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "HoTen";
			resources.ApplyResources(this.HoTen, "HoTen");
			this.HoTen.Name = "HoTen";
			this.HoTen.ReadOnly = true;
			// 
			// NgaySinh
			// 
			this.NgaySinh.DataPropertyName = "NgaySinh";
			resources.ApplyResources(this.NgaySinh, "NgaySinh");
			this.NgaySinh.Name = "NgaySinh";
			this.NgaySinh.ReadOnly = true;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			resources.ApplyResources(this.GioiTinh, "GioiTinh");
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.ReadOnly = true;
			// 
			// ChucVu
			// 
			this.ChucVu.DataPropertyName = "ChucVu";
			resources.ApplyResources(this.ChucVu, "ChucVu");
			this.ChucVu.Name = "ChucVu";
			this.ChucVu.ReadOnly = true;
			// 
			// SDT_NV
			// 
			this.SDT_NV.DataPropertyName = "SDT_NV";
			resources.ApplyResources(this.SDT_NV, "SDT_NV");
			this.SDT_NV.Name = "SDT_NV";
			this.SDT_NV.ReadOnly = true;
			// 
			// Email_NV
			// 
			this.Email_NV.DataPropertyName = "Email_NV";
			resources.ApplyResources(this.Email_NV, "Email_NV");
			this.Email_NV.Name = "Email_NV";
			this.Email_NV.ReadOnly = true;
			// 
			// DiaChi
			// 
			this.DiaChi.DataPropertyName = "DiaChi";
			resources.ApplyResources(this.DiaChi, "DiaChi");
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.ReadOnly = true;
			// 
			// SoBHYT
			// 
			this.SoBHYT.DataPropertyName = "SoBHYT";
			resources.ApplyResources(this.SoBHYT, "SoBHYT");
			this.SoBHYT.Name = "SoBHYT";
			this.SoBHYT.ReadOnly = true;
			// 
			// SoHopDong
			// 
			this.SoHopDong.DataPropertyName = "SoHopDong";
			resources.ApplyResources(this.SoHopDong, "SoHopDong");
			this.SoHopDong.Name = "SoHopDong";
			this.SoHopDong.ReadOnly = true;
			// 
			// NamBatDau
			// 
			this.NamBatDau.DataPropertyName = "NamBatDau";
			resources.ApplyResources(this.NamBatDau, "NamBatDau");
			this.NamBatDau.Name = "NamBatDau";
			this.NamBatDau.ReadOnly = true;
			// 
			// MaSoThueCaNhan
			// 
			this.MaSoThueCaNhan.DataPropertyName = "MaSoThueCaNhan";
			resources.ApplyResources(this.MaSoThueCaNhan, "MaSoThueCaNhan");
			this.MaSoThueCaNhan.Name = "MaSoThueCaNhan";
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			resources.ApplyResources(this.insert, "insert");
			this.insert.Name = "insert";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			resources.ApplyResources(this.delete, "delete");
			this.delete.Name = "delete";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// textMaNV
			// 
			resources.ApplyResources(this.textMaNV, "textMaNV");
			this.textMaNV.Name = "textMaNV";
			// 
			// textCCCD
			// 
			resources.ApplyResources(this.textCCCD, "textCCCD");
			this.textCCCD.Name = "textCCCD";
			// 
			// textHoTen
			// 
			resources.ApplyResources(this.textHoTen, "textHoTen");
			this.textHoTen.Name = "textHoTen";
			// 
			// textChucVu
			// 
			resources.ApplyResources(this.textChucVu, "textChucVu");
			this.textChucVu.Name = "textChucVu";
			// 
			// textSDT
			// 
			resources.ApplyResources(this.textSDT, "textSDT");
			this.textSDT.Name = "textSDT";
			// 
			// textEmail
			// 
			resources.ApplyResources(this.textEmail, "textEmail");
			this.textEmail.Name = "textEmail";
			// 
			// textDiaChi
			// 
			resources.ApplyResources(this.textDiaChi, "textDiaChi");
			this.textDiaChi.Name = "textDiaChi";
			// 
			// textSoBHYT
			// 
			resources.ApplyResources(this.textSoBHYT, "textSoBHYT");
			this.textSoBHYT.Name = "textSoBHYT";
			// 
			// textSoHopDong
			// 
			resources.ApplyResources(this.textSoHopDong, "textSoHopDong");
			this.textSoHopDong.Name = "textSoHopDong";
			// 
			// textNamBatDau
			// 
			resources.ApplyResources(this.textNamBatDau, "textNamBatDau");
			this.textNamBatDau.Name = "textNamBatDau";
			// 
			// inputNgaySinh
			// 
			resources.ApplyResources(this.inputNgaySinh, "inputNgaySinh");
			this.inputNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgaySinh.Name = "inputNgaySinh";
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.update, "update");
			this.update.Name = "update";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// inputFind
			// 
			resources.ApplyResources(this.inputFind, "inputFind");
			this.inputFind.Name = "inputFind";
			this.inputFind.Click += new System.EventHandler(this.inputFind_MouseEnter);
			this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
			// 
			// textMST
			// 
			resources.ApplyResources(this.textMST, "textMST");
			this.textMST.Name = "textMST";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			// 
			// radioNam
			// 
			resources.ApplyResources(this.radioNam, "radioNam");
			this.radioNam.Name = "radioNam";
			this.radioNam.TabStop = true;
			this.radioNam.UseVisualStyleBackColor = true;
			// 
			// radioNu
			// 
			resources.ApplyResources(this.radioNu, "radioNu");
			this.radioNu.Name = "radioNu";
			this.radioNu.TabStop = true;
			this.radioNu.UseVisualStyleBackColor = true;
			// 
			// groupGT
			// 
			this.groupGT.Controls.Add(this.radioNu);
			this.groupGT.Controls.Add(this.radioNam);
			resources.ApplyResources(this.groupGT, "groupGT");
			this.groupGT.Name = "groupGT";
			this.groupGT.TabStop = false;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			resources.ApplyResources(this.back, "back");
			this.back.Name = "back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// lichLam
			// 
			this.lichLam.BackColor = System.Drawing.Color.LightSkyBlue;
			resources.ApplyResources(this.lichLam, "lichLam");
			this.lichLam.Name = "lichLam";
			this.lichLam.UseVisualStyleBackColor = false;
			this.lichLam.Click += new System.EventHandler(this.lichLam_Click);
			// 
			// luong
			// 
			this.luong.BackColor = System.Drawing.Color.LightSkyBlue;
			resources.ApplyResources(this.luong, "luong");
			this.luong.Name = "luong";
			this.luong.UseVisualStyleBackColor = false;
			this.luong.Click += new System.EventHandler(this.luong_Click);
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Name = "label14";
			// 
			// bangNV
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.Controls.Add(this.label14);
			this.Controls.Add(this.luong);
			this.Controls.Add(this.lichLam);
			this.Controls.Add(this.back);
			this.Controls.Add(this.groupGT);
			this.Controls.Add(this.textMST);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.update);
			this.Controls.Add(this.inputNgaySinh);
			this.Controls.Add(this.textNamBatDau);
			this.Controls.Add(this.textSoHopDong);
			this.Controls.Add(this.textSoBHYT);
			this.Controls.Add(this.textDiaChi);
			this.Controls.Add(this.textEmail);
			this.Controls.Add(this.textSDT);
			this.Controls.Add(this.textChucVu);
			this.Controls.Add(this.textHoTen);
			this.Controls.Add(this.textCCCD);
			this.Controls.Add(this.textMaNV);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.dataGridViewNV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "bangNV";
			this.Load += new System.EventHandler(this.bangNV_Load);
			this.Click += new System.EventHandler(this.bangNV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
			this.groupGT.ResumeLayout(false);
			this.groupGT.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMaNV;
        private System.Windows.Forms.TextBox textCCCD;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textChucVu;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.TextBox textSoBHYT;
        private System.Windows.Forms.TextBox textSoHopDong;
        private System.Windows.Forms.TextBox textNamBatDau;
        private System.Windows.Forms.DateTimePicker inputNgaySinh;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox inputFind;
        private System.Windows.Forms.TextBox textMST;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.GroupBox groupGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoThueCaNhan;
        private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button lichLam;
		private System.Windows.Forms.Button luong;
		private System.Windows.Forms.Label label14;
	}
}

