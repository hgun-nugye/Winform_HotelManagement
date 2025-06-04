namespace HotelManagement
{
	partial class AddHDM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHDM));
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.back = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboTT = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboTenMon = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ngaySD = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.ngayDat = new System.Windows.Forms.DateTimePicker();
			this.soLuong = new System.Windows.Forms.NumericUpDown();
			this.maPhong = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.soLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.DarkGreen;
			this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label14.Location = new System.Drawing.Point(159, 41);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(176, 38);
			this.label14.TabIndex = 80;
			this.label14.Text = "ĐẶT MÓN";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(505, 122);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(437, 272);
			this.pictureBox1.TabIndex = 79;
			this.pictureBox1.TabStop = false;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.back.Location = new System.Drawing.Point(855, 423);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(87, 49);
			this.back.TabIndex = 78;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.insert.Location = new System.Drawing.Point(748, 423);
			this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(87, 49);
			this.insert.TabIndex = 77;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.InsertHDMon);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 370);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 25);
			this.label5.TabIndex = 76;
			this.label5.Text = "Trạng thái";
			// 
			// comboTT
			// 
			this.comboTT.DropDownHeight = 150;
			this.comboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTT.FormattingEnabled = true;
			this.comboTT.IntegralHeight = false;
			this.comboTT.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
			this.comboTT.Location = new System.Drawing.Point(210, 367);
			this.comboTT.Margin = new System.Windows.Forms.Padding(4);
			this.comboTT.Name = "comboTT";
			this.comboTT.Size = new System.Drawing.Size(237, 28);
			this.comboTT.TabIndex = 75;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(37, 243);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 25);
			this.label3.TabIndex = 74;
			this.label3.Text = "Tên Món";
			// 
			// comboTenMon
			// 
			this.comboTenMon.DropDownHeight = 250;
			this.comboTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTenMon.FormattingEnabled = true;
			this.comboTenMon.IntegralHeight = false;
			this.comboTenMon.Location = new System.Drawing.Point(209, 240);
			this.comboTenMon.Margin = new System.Windows.Forms.Padding(4);
			this.comboTenMon.Name = "comboTenMon";
			this.comboTenMon.Size = new System.Drawing.Size(237, 28);
			this.comboTenMon.TabIndex = 73;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(37, 308);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 25);
			this.label4.TabIndex = 72;
			this.label4.Text = "Số lượng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 180);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 25);
			this.label1.TabIndex = 70;
			this.label1.Text = "Ngày sử dụng";
			// 
			// ngaySD
			// 
			this.ngaySD.CustomFormat = "dd/MM/yyyy";
			this.ngaySD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ngaySD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ngaySD.Location = new System.Drawing.Point(210, 180);
			this.ngaySD.Margin = new System.Windows.Forms.Padding(4);
			this.ngaySD.Name = "ngaySD";
			this.ngaySD.Size = new System.Drawing.Size(237, 30);
			this.ngaySD.TabIndex = 69;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 119);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 25);
			this.label2.TabIndex = 68;
			this.label2.Text = "Ngày đặt ";
			// 
			// ngayDat
			// 
			this.ngayDat.CustomFormat = "dd/MM/yyyy";
			this.ngayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ngayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ngayDat.Location = new System.Drawing.Point(210, 119);
			this.ngayDat.Margin = new System.Windows.Forms.Padding(4);
			this.ngayDat.Name = "ngayDat";
			this.ngayDat.Size = new System.Drawing.Size(237, 30);
			this.ngayDat.TabIndex = 67;
			// 
			// soLuong
			// 
			this.soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soLuong.Location = new System.Drawing.Point(209, 308);
			this.soLuong.Margin = new System.Windows.Forms.Padding(4);
			this.soLuong.MaximumSize = new System.Drawing.Size(234, 0);
			this.soLuong.MinimumSize = new System.Drawing.Size(234, 0);
			this.soLuong.Name = "soLuong";
			this.soLuong.Size = new System.Drawing.Size(234, 27);
			this.soLuong.TabIndex = 81;
			// 
			// maPhong
			// 
			this.maPhong.BackColor = System.Drawing.Color.LightSkyBlue;
			this.maPhong.Cursor = System.Windows.Forms.Cursors.No;
			this.maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maPhong.Location = new System.Drawing.Point(822, 31);
			this.maPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.maPhong.Name = "maPhong";
			this.maPhong.Size = new System.Drawing.Size(120, 48);
			this.maPhong.TabIndex = 84;
			this.maPhong.Text = "Mã phòng";
			this.maPhong.UseVisualStyleBackColor = false;
			this.maPhong.Click += new System.EventHandler(this.back_Click);
			// 
			// AddHDM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(982, 507);
			this.Controls.Add(this.maPhong);
			this.Controls.Add(this.soLuong);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboTT);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboTenMon);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ngaySD);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ngayDat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddHDM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm Hóa đơn Món";
			this.Load += new System.EventHandler(this.AddHDM_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.soLuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboTT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboTenMon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker ngaySD;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker ngayDat;
		private System.Windows.Forms.NumericUpDown soLuong;
		private System.Windows.Forms.Button maPhong;
	}
}