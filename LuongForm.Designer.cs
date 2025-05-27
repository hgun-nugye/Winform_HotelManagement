namespace HotelManagement.GUII
{
	partial class LuongForm
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
			this.bangLuong = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThangLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.inputThangLuong = new System.Windows.Forms.DateTimePicker();
			this.inputPhuCap = new System.Windows.Forms.TextBox();
			this.inputPhat = new System.Windows.Forms.TextBox();
			this.inputThuong = new System.Windows.Forms.TextBox();
			this.inputMucLuong = new System.Windows.Forms.TextBox();
			this.inputMaNV = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputTimKiem = new System.Windows.Forms.DateTimePicker();
			this.back = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bangLuong)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bangLuong
			// 
			this.bangLuong.BackgroundColor = System.Drawing.Color.Ivory;
			this.bangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MucLuong,
            this.Thuong,
            this.Phat,
            this.PhuCap,
            this.ThangLuong});
			this.bangLuong.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.bangLuong.Location = new System.Drawing.Point(12, 59);
			this.bangLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bangLuong.Name = "bangLuong";
			this.bangLuong.RowHeadersWidth = 62;
			this.bangLuong.RowTemplate.Height = 28;
			this.bangLuong.Size = new System.Drawing.Size(413, 366);
			this.bangLuong.TabIndex = 0;
			this.bangLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangLuong_CellClick);
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
			// MucLuong
			// 
			this.MucLuong.DataPropertyName = "MucLuong";
			this.MucLuong.HeaderText = "Mức lương";
			this.MucLuong.MinimumWidth = 8;
			this.MucLuong.Name = "MucLuong";
			this.MucLuong.ReadOnly = true;
			this.MucLuong.Width = 150;
			// 
			// Thuong
			// 
			this.Thuong.DataPropertyName = "Thuong";
			this.Thuong.HeaderText = "Thưởng";
			this.Thuong.MinimumWidth = 8;
			this.Thuong.Name = "Thuong";
			this.Thuong.ReadOnly = true;
			this.Thuong.Width = 150;
			// 
			// Phat
			// 
			this.Phat.DataPropertyName = "Phat";
			this.Phat.HeaderText = "Phạt";
			this.Phat.MinimumWidth = 8;
			this.Phat.Name = "Phat";
			this.Phat.ReadOnly = true;
			this.Phat.Width = 150;
			// 
			// PhuCap
			// 
			this.PhuCap.DataPropertyName = "PhuCap";
			this.PhuCap.HeaderText = "Phụ cấp";
			this.PhuCap.MinimumWidth = 8;
			this.PhuCap.Name = "PhuCap";
			this.PhuCap.ReadOnly = true;
			this.PhuCap.Width = 150;
			// 
			// ThangLuong
			// 
			this.ThangLuong.DataPropertyName = "ThangLuong";
			this.ThangLuong.HeaderText = "Tháng lương";
			this.ThangLuong.MinimumWidth = 8;
			this.ThangLuong.Name = "ThangLuong";
			this.ThangLuong.ReadOnly = true;
			this.ThangLuong.Width = 150;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label8.Location = new System.Drawing.Point(29, 293);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(218, 25);
			this.label8.TabIndex = 15;
			this.label8.Text = "Tìm kiếm tháng lương";
			// 
			// inputThangLuong
			// 
			this.inputThangLuong.CustomFormat = "MM-yyyy";
			this.inputThangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputThangLuong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputThangLuong.Location = new System.Drawing.Point(206, 251);
			this.inputThangLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputThangLuong.Name = "inputThangLuong";
			this.inputThangLuong.Size = new System.Drawing.Size(232, 22);
			this.inputThangLuong.TabIndex = 10;
			// 
			// inputPhuCap
			// 
			this.inputPhuCap.Location = new System.Drawing.Point(206, 205);
			this.inputPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputPhuCap.Multiline = true;
			this.inputPhuCap.Name = "inputPhuCap";
			this.inputPhuCap.Size = new System.Drawing.Size(232, 25);
			this.inputPhuCap.TabIndex = 9;
			// 
			// inputPhat
			// 
			this.inputPhat.Location = new System.Drawing.Point(206, 162);
			this.inputPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputPhat.Multiline = true;
			this.inputPhat.Name = "inputPhat";
			this.inputPhat.Size = new System.Drawing.Size(232, 25);
			this.inputPhat.TabIndex = 8;
			// 
			// inputThuong
			// 
			this.inputThuong.Location = new System.Drawing.Point(206, 120);
			this.inputThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputThuong.Multiline = true;
			this.inputThuong.Name = "inputThuong";
			this.inputThuong.Size = new System.Drawing.Size(232, 25);
			this.inputThuong.TabIndex = 7;
			// 
			// inputMucLuong
			// 
			this.inputMucLuong.Location = new System.Drawing.Point(206, 80);
			this.inputMucLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputMucLuong.Multiline = true;
			this.inputMucLuong.Name = "inputMucLuong";
			this.inputMucLuong.Size = new System.Drawing.Size(232, 25);
			this.inputMucLuong.TabIndex = 6;
			// 
			// inputMaNV
			// 
			this.inputMaNV.Location = new System.Drawing.Point(206, 36);
			this.inputMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputMaNV.Multiline = true;
			this.inputMaNV.Name = "inputMaNV";
			this.inputMaNV.Size = new System.Drawing.Size(232, 25);
			this.inputMaNV.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label6.Location = new System.Drawing.Point(29, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Tháng lương ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label5.Location = new System.Drawing.Point(29, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Phụ cấp ";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.bangLuong);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(493, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(465, 453);
			this.panel2.TabIndex = 18;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Location = new System.Drawing.Point(79, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(257, 29);
			this.label14.TabIndex = 72;
			this.label14.Text = "DANH SÁCH LƯƠNG";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label4.Location = new System.Drawing.Point(29, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Phạt ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label3.Location = new System.Drawing.Point(29, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thưởng ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label2.Location = new System.Drawing.Point(29, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mức lương ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label1.Location = new System.Drawing.Point(29, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.inputTimKiem);
			this.panel1.Controls.Add(this.back);
			this.panel1.Controls.Add(this.update);
			this.panel1.Controls.Add(this.delete);
			this.panel1.Controls.Add(this.insert);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.inputThangLuong);
			this.panel1.Controls.Add(this.inputPhuCap);
			this.panel1.Controls.Add(this.inputPhat);
			this.panel1.Controls.Add(this.inputThuong);
			this.panel1.Controls.Add(this.inputMucLuong);
			this.panel1.Controls.Add(this.inputMaNV);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(444, 453);
			this.panel1.TabIndex = 17;
			// 
			// inputTimKiem
			// 
			this.inputTimKiem.CustomFormat = "MM/yyyy";
			this.inputTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputTimKiem.Location = new System.Drawing.Point(292, 295);
			this.inputTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputTimKiem.Name = "inputTimKiem";
			this.inputTimKiem.ShowUpDown = true;
			this.inputTimKiem.Size = new System.Drawing.Size(147, 22);
			this.inputTimKiem.TabIndex = 71;
			this.inputTimKiem.Value = new System.DateTime(2025, 5, 25, 6, 39, 26, 0);
			this.inputTimKiem.ValueChanged += new System.EventHandler(this.inputTimKiem_ValueChanged);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(364, 378);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 69;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(228, 378);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(121, 40);
			this.update.TabIndex = 68;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(130, 378);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(80, 40);
			this.delete.TabIndex = 67;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(34, 378);
			this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(80, 40);
			this.insert.TabIndex = 66;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// LuongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 453);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LuongForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lương Nhân viên";
			this.Load += new System.EventHandler(this.LuongForm_Load);
			this.Click += new System.EventHandler(this.LuongForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bangLuong)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView bangLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MucLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phat;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThangLuong;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker inputThangLuong;
		private System.Windows.Forms.TextBox inputPhuCap;
		private System.Windows.Forms.TextBox inputPhat;
		private System.Windows.Forms.TextBox inputThuong;
		private System.Windows.Forms.TextBox inputMucLuong;
		private System.Windows.Forms.TextBox inputMaNV;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.DateTimePicker inputTimKiem;
		private System.Windows.Forms.Label label14;
	}
}