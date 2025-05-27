namespace HotelManagement
{
	partial class bangKhachHang
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
			this.inputFind = new System.Windows.Forms.TextBox();
			this.textEmail_KH = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textQuocTich = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textDiaChi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textHoTen = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textSDT_KH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textCCCD_KH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textMaKH = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewKH = new System.Windows.Forms.DataGridView();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupGT = new System.Windows.Forms.GroupBox();
			this.radioNu = new System.Windows.Forms.RadioButton();
			this.radioNam = new System.Windows.Forms.RadioButton();
			this.delete = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
			this.groupGT.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputFind
			// 
			this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputFind.Location = new System.Drawing.Point(460, 284);
			this.inputFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputFind.Multiline = true;
			this.inputFind.Name = "inputFind";
			this.inputFind.Size = new System.Drawing.Size(456, 40);
			this.inputFind.TabIndex = 41;
			this.inputFind.Click += new System.EventHandler(this.update_Click);
			this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
			// 
			// textEmail_KH
			// 
			this.textEmail_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEmail_KH.Location = new System.Drawing.Point(621, 202);
			this.textEmail_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textEmail_KH.Multiline = true;
			this.textEmail_KH.Name = "textEmail_KH";
			this.textEmail_KH.Size = new System.Drawing.Size(295, 40);
			this.textEmail_KH.TabIndex = 38;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(497, 218);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 24);
			this.label8.TabIndex = 37;
			this.label8.Text = "Email ";
			// 
			// textQuocTich
			// 
			this.textQuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textQuocTich.Location = new System.Drawing.Point(621, 157);
			this.textQuocTich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textQuocTich.Multiline = true;
			this.textQuocTich.Name = "textQuocTich";
			this.textQuocTich.Size = new System.Drawing.Size(295, 38);
			this.textQuocTich.TabIndex = 36;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(497, 171);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 24);
			this.label7.TabIndex = 35;
			this.label7.Text = "Quốc tịch ";
			// 
			// textDiaChi
			// 
			this.textDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDiaChi.Location = new System.Drawing.Point(621, 113);
			this.textDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textDiaChi.Multiline = true;
			this.textDiaChi.Name = "textDiaChi";
			this.textDiaChi.Size = new System.Drawing.Size(295, 37);
			this.textDiaChi.TabIndex = 34;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(497, 129);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 24);
			this.label6.TabIndex = 33;
			this.label6.Text = "Địa chỉ ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(46, 218);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 24);
			this.label5.TabIndex = 31;
			this.label5.Text = "Giới tính ";
			// 
			// textHoTen
			// 
			this.textHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textHoTen.Location = new System.Drawing.Point(221, 156);
			this.textHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textHoTen.Multiline = true;
			this.textHoTen.Name = "textHoTen";
			this.textHoTen.Size = new System.Drawing.Size(203, 40);
			this.textHoTen.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(46, 171);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 24);
			this.label4.TabIndex = 29;
			this.label4.Text = "Họ tên ";
			// 
			// textSDT_KH
			// 
			this.textSDT_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textSDT_KH.Location = new System.Drawing.Point(668, 66);
			this.textSDT_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textSDT_KH.Multiline = true;
			this.textSDT_KH.Name = "textSDT_KH";
			this.textSDT_KH.Size = new System.Drawing.Size(248, 38);
			this.textSDT_KH.TabIndex = 28;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(497, 82);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 24);
			this.label3.TabIndex = 27;
			this.label3.Text = "Số điện thoại ";
			// 
			// textCCCD_KH
			// 
			this.textCCCD_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textCCCD_KH.Location = new System.Drawing.Point(221, 114);
			this.textCCCD_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textCCCD_KH.Multiline = true;
			this.textCCCD_KH.Name = "textCCCD_KH";
			this.textCCCD_KH.Size = new System.Drawing.Size(203, 37);
			this.textCCCD_KH.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 129);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 25;
			this.label2.Text = "CCCD ";
			// 
			// textMaKH
			// 
			this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaKH.Location = new System.Drawing.Point(221, 66);
			this.textMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textMaKH.Multiline = true;
			this.textMaKH.Name = "textMaKH";
			this.textMaKH.Size = new System.Drawing.Size(203, 41);
			this.textMaKH.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 82);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 24);
			this.label1.TabIndex = 23;
			this.label1.Text = "Mã khách hàng ";
			// 
			// dataGridViewKH
			// 
			this.dataGridViewKH.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.CCCD,
            this.SDT_KH,
            this.HoTen,
            this.GioiTinh,
            this.DiaChi,
            this.QuocTich,
            this.Email_KH});
			this.dataGridViewKH.Location = new System.Drawing.Point(48, 346);
			this.dataGridViewKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewKH.Name = "dataGridViewKH";
			this.dataGridViewKH.RowHeadersWidth = 62;
			this.dataGridViewKH.Size = new System.Drawing.Size(867, 218);
			this.dataGridViewKH.TabIndex = 22;
			this.dataGridViewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellClick);
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách hàng";
			this.MaKH.MinimumWidth = 8;
			this.MaKH.Name = "MaKH";
			this.MaKH.Width = 150;
			// 
			// CCCD
			// 
			this.CCCD.DataPropertyName = "CCCD";
			this.CCCD.HeaderText = "Số CCCD";
			this.CCCD.MinimumWidth = 8;
			this.CCCD.Name = "CCCD";
			this.CCCD.Width = 150;
			// 
			// SDT_KH
			// 
			this.SDT_KH.DataPropertyName = "SDT_KH";
			this.SDT_KH.HeaderText = "Số điện thoại";
			this.SDT_KH.MinimumWidth = 8;
			this.SDT_KH.Name = "SDT_KH";
			this.SDT_KH.Width = 150;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "HoTen";
			this.HoTen.HeaderText = "Họ và tên";
			this.HoTen.MinimumWidth = 8;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 150;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.HeaderText = "Giới tính";
			this.GioiTinh.MinimumWidth = 8;
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.Width = 150;
			// 
			// DiaChi
			// 
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "Địa chỉ";
			this.DiaChi.MinimumWidth = 8;
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.Width = 150;
			// 
			// QuocTich
			// 
			this.QuocTich.DataPropertyName = "QuocTich";
			this.QuocTich.HeaderText = "Quốc tịch";
			this.QuocTich.MinimumWidth = 8;
			this.QuocTich.Name = "QuocTich";
			this.QuocTich.Width = 150;
			// 
			// Email_KH
			// 
			this.Email_KH.DataPropertyName = "Email_KH";
			this.Email_KH.HeaderText = "Email";
			this.Email_KH.MinimumWidth = 8;
			this.Email_KH.Name = "Email_KH";
			this.Email_KH.Width = 150;
			// 
			// groupGT
			// 
			this.groupGT.Controls.Add(this.radioNu);
			this.groupGT.Controls.Add(this.radioNam);
			this.groupGT.Location = new System.Drawing.Point(221, 210);
			this.groupGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupGT.Name = "groupGT";
			this.groupGT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupGT.Size = new System.Drawing.Size(203, 32);
			this.groupGT.TabIndex = 42;
			this.groupGT.TabStop = false;
			// 
			// radioNu
			// 
			this.radioNu.AutoSize = true;
			this.radioNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioNu.Location = new System.Drawing.Point(111, 60);
			this.radioNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radioNu.Name = "radioNu";
			this.radioNu.Size = new System.Drawing.Size(49, 21);
			this.radioNu.TabIndex = 34;
			this.radioNu.TabStop = true;
			this.radioNu.Text = "Nữ";
			this.radioNu.UseVisualStyleBackColor = true;
			// 
			// radioNam
			// 
			this.radioNam.AutoSize = true;
			this.radioNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioNam.Location = new System.Drawing.Point(4, 60);
			this.radioNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radioNam.Name = "radioNam";
			this.radioNam.Size = new System.Drawing.Size(61, 21);
			this.radioNam.TabIndex = 33;
			this.radioNam.TabStop = true;
			this.radioNam.Text = "Nam";
			this.radioNam.UseVisualStyleBackColor = true;
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(48, 284);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(80, 40);
			this.delete.TabIndex = 63;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(148, 284);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(121, 40);
			this.update.TabIndex = 64;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(286, 283);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 65;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Location = new System.Drawing.Point(291, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(333, 29);
			this.label14.TabIndex = 71;
			this.label14.Text = "DANH SÁCH KHÁCH HÀNG";
			// 
			// bangKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 588);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.back);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.groupGT);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.textEmail_KH);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textQuocTich);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textDiaChi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textHoTen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textSDT_KH);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textCCCD_KH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textMaKH);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewKH);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "bangKhachHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý thông tin Khách hàng";
			this.Load += new System.EventHandler(this.bangKhachHang_Load);
			this.Click += new System.EventHandler(this.bangKhachHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
			this.groupGT.ResumeLayout(false);
			this.groupGT.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputFind;
		private System.Windows.Forms.TextBox textEmail_KH;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textQuocTich;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textDiaChi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textHoTen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textSDT_KH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textCCCD_KH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textMaKH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewKH;
		private System.Windows.Forms.GroupBox groupGT;
		private System.Windows.Forms.RadioButton radioNu;
		private System.Windows.Forms.RadioButton radioNam;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT_KH;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email_KH;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label label14;
	}
}