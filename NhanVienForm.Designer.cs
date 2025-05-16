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
            this.dataGridViewNV.Location = new System.Drawing.Point(28, 345);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 62;
            this.dataGridViewNV.RowTemplate.Height = 28;
            this.dataGridViewNV.Size = new System.Drawing.Size(1014, 257);
            this.dataGridViewNV.TabIndex = 0;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 150;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 8;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            this.CCCD.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 150;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 8;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 150;
            // 
            // SDT_NV
            // 
            this.SDT_NV.DataPropertyName = "SDT_NV";
            this.SDT_NV.HeaderText = "Số điện thoại";
            this.SDT_NV.MinimumWidth = 8;
            this.SDT_NV.Name = "SDT_NV";
            this.SDT_NV.ReadOnly = true;
            this.SDT_NV.Width = 150;
            // 
            // Email_NV
            // 
            this.Email_NV.DataPropertyName = "Email_NV";
            this.Email_NV.HeaderText = "Email";
            this.Email_NV.MinimumWidth = 8;
            this.Email_NV.Name = "Email_NV";
            this.Email_NV.ReadOnly = true;
            this.Email_NV.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 150;
            // 
            // SoBHYT
            // 
            this.SoBHYT.DataPropertyName = "SoBHYT";
            this.SoBHYT.HeaderText = "Số BHYT";
            this.SoBHYT.MinimumWidth = 8;
            this.SoBHYT.Name = "SoBHYT";
            this.SoBHYT.ReadOnly = true;
            this.SoBHYT.Width = 150;
            // 
            // SoHopDong
            // 
            this.SoHopDong.DataPropertyName = "SoHopDong";
            this.SoHopDong.HeaderText = "Số hợp đồng";
            this.SoHopDong.MinimumWidth = 8;
            this.SoHopDong.Name = "SoHopDong";
            this.SoHopDong.ReadOnly = true;
            this.SoHopDong.Width = 150;
            // 
            // NamBatDau
            // 
            this.NamBatDau.DataPropertyName = "NamBatDau";
            this.NamBatDau.HeaderText = "Năm bắt đầu";
            this.NamBatDau.MinimumWidth = 8;
            this.NamBatDau.Name = "NamBatDau";
            this.NamBatDau.ReadOnly = true;
            this.NamBatDau.Width = 150;
            // 
            // MaSoThueCaNhan
            // 
            this.MaSoThueCaNhan.DataPropertyName = "MaSoThueCaNhan";
            this.MaSoThueCaNhan.HeaderText = "MaSoThueCaNhan";
            this.MaSoThueCaNhan.MinimumWidth = 8;
            this.MaSoThueCaNhan.Name = "MaSoThueCaNhan";
            this.MaSoThueCaNhan.Width = 150;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.insert.Location = new System.Drawing.Point(26, 289);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 50);
            this.insert.TabIndex = 1;
            this.insert.Text = "Thêm";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.delete.Location = new System.Drawing.Point(134, 289);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 50);
            this.delete.TabIndex = 3;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "CCCD ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ tên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(36, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(37, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(36, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Chức vụ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(501, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số điện thoại ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(501, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(501, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Địa chỉ ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(501, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số BHYT ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(501, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Số hợp đồng ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(501, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Năm bắt đầu ";
            // 
            // textMaNV
            // 
            this.textMaNV.Location = new System.Drawing.Point(163, 8);
            this.textMaNV.Multiline = true;
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(283, 31);
            this.textMaNV.TabIndex = 16;
            // 
            // textCCCD
            // 
            this.textCCCD.Location = new System.Drawing.Point(163, 47);
            this.textCCCD.Multiline = true;
            this.textCCCD.Name = "textCCCD";
            this.textCCCD.Size = new System.Drawing.Size(283, 31);
            this.textCCCD.TabIndex = 17;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(163, 84);
            this.textHoTen.Multiline = true;
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(283, 31);
            this.textHoTen.TabIndex = 18;
            // 
            // textChucVu
            // 
            this.textChucVu.Location = new System.Drawing.Point(163, 228);
            this.textChucVu.Multiline = true;
            this.textChucVu.Name = "textChucVu";
            this.textChucVu.Size = new System.Drawing.Size(283, 31);
            this.textChucVu.TabIndex = 21;
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(643, 8);
            this.textSDT.Multiline = true;
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(397, 31);
            this.textSDT.TabIndex = 22;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(643, 47);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(397, 31);
            this.textEmail.TabIndex = 23;
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(643, 84);
            this.textDiaChi.Multiline = true;
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(397, 31);
            this.textDiaChi.TabIndex = 24;
            // 
            // textSoBHYT
            // 
            this.textSoBHYT.Location = new System.Drawing.Point(643, 121);
            this.textSoBHYT.Multiline = true;
            this.textSoBHYT.Name = "textSoBHYT";
            this.textSoBHYT.Size = new System.Drawing.Size(397, 31);
            this.textSoBHYT.TabIndex = 25;
            // 
            // textSoHopDong
            // 
            this.textSoHopDong.Location = new System.Drawing.Point(643, 158);
            this.textSoHopDong.Multiline = true;
            this.textSoHopDong.Name = "textSoHopDong";
            this.textSoHopDong.Size = new System.Drawing.Size(397, 31);
            this.textSoHopDong.TabIndex = 26;
            // 
            // textNamBatDau
            // 
            this.textNamBatDau.Location = new System.Drawing.Point(643, 191);
            this.textNamBatDau.Multiline = true;
            this.textNamBatDau.Name = "textNamBatDau";
            this.textNamBatDau.Size = new System.Drawing.Size(397, 31);
            this.textNamBatDau.TabIndex = 27;
            // 
            // inputNgaySinh
            // 
            this.inputNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.inputNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputNgaySinh.Location = new System.Drawing.Point(163, 126);
            this.inputNgaySinh.Name = "inputNgaySinh";
            this.inputNgaySinh.Size = new System.Drawing.Size(283, 26);
            this.inputNgaySinh.TabIndex = 28;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.update.Location = new System.Drawing.Point(247, 289);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 50);
            this.update.TabIndex = 29;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // inputFind
            // 
            this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFind.Location = new System.Drawing.Point(619, 289);
            this.inputFind.Multiline = true;
            this.inputFind.Name = "inputFind";
            this.inputFind.Size = new System.Drawing.Size(421, 50);
            this.inputFind.TabIndex = 30;
            this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
            this.inputFind.MouseEnter += new System.EventHandler(this.inputFind_MouseEnter);
            // 
            // textMST
            // 
            this.textMST.Location = new System.Drawing.Point(643, 228);
            this.textMST.Multiline = true;
            this.textMST.Name = "textMST";
            this.textMST.Size = new System.Drawing.Size(397, 31);
            this.textMST.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(501, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mã số thuế";
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNam.Location = new System.Drawing.Point(4, 7);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(70, 24);
            this.radioNam.TabIndex = 33;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNu.Location = new System.Drawing.Point(125, 7);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(56, 24);
            this.radioNu.TabIndex = 34;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // groupGT
            // 
            this.groupGT.Controls.Add(this.radioNu);
            this.groupGT.Controls.Add(this.radioNam);
            this.groupGT.Location = new System.Drawing.Point(166, 167);
            this.groupGT.Name = "groupGT";
            this.groupGT.Size = new System.Drawing.Size(280, 40);
            this.groupGT.TabIndex = 35;
            this.groupGT.TabStop = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightSkyBlue;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.back.Location = new System.Drawing.Point(356, 289);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 50);
            this.back.TabIndex = 61;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bangNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1078, 624);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên khách sạn";
            this.Load += new System.EventHandler(this.bangNV_Load);
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
    }
}

