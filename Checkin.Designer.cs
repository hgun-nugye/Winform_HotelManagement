namespace HotelManagement
{
    partial class Checkin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkin));
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboTT = new System.Windows.Forms.ComboBox();
			this.listPhong = new System.Windows.Forms.ComboBox();
			this.inputNgayTra = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.insert = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textCCCD = new System.Windows.Forms.TextBox();
			this.textHoTen = new System.Windows.Forms.TextBox();
			this.textSDT = new System.Windows.Forms.TextBox();
			this.textDiaChi = new System.Windows.Forms.TextBox();
			this.inputNgayNhan = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.textQuocTich = new System.Windows.Forms.TextBox();
			this.back = new System.Windows.Forms.Button();
			this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupGT = new System.Windows.Forms.GroupBox();
			this.radioNu = new System.Windows.Forms.RadioButton();
			this.radioNam = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
			this.groupGT.SuspendLayout();
			this.SuspendLayout();
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Crimson;
			this.label14.Location = new System.Drawing.Point(139, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(164, 36);
			this.label14.TabIndex = 108;
			this.label14.Text = "CHECK IN";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(36, 494);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 24);
			this.label7.TabIndex = 106;
			this.label7.Text = "Trạng thái";
			// 
			// comboTT
			// 
			this.comboTT.DropDownHeight = 200;
			this.comboTT.FormattingEnabled = true;
			this.comboTT.IntegralHeight = false;
			this.comboTT.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
			this.comboTT.Location = new System.Drawing.Point(194, 493);
			this.comboTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboTT.Name = "comboTT";
			this.comboTT.Size = new System.Drawing.Size(247, 24);
			this.comboTT.TabIndex = 107;
			// 
			// listPhong
			// 
			this.listPhong.DropDownHeight = 300;
			this.listPhong.FormattingEnabled = true;
			this.listPhong.IntegralHeight = false;
			this.listPhong.Location = new System.Drawing.Point(191, 451);
			this.listPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listPhong.Name = "listPhong";
			this.listPhong.Size = new System.Drawing.Size(247, 24);
			this.listPhong.TabIndex = 105;
			this.listPhong.DropDown += new System.EventHandler(this.listPhong_DropDown);
			// 
			// inputNgayTra
			// 
			this.inputNgayTra.CustomFormat = "dd-MM-yyyy";
			this.inputNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgayTra.Location = new System.Drawing.Point(191, 122);
			this.inputNgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputNgayTra.Name = "inputNgayTra";
			this.inputNgayTra.Size = new System.Drawing.Size(252, 22);
			this.inputNgayTra.TabIndex = 103;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 24);
			this.label1.TabIndex = 104;
			this.label1.Text = "Ngày trả";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(492, 76);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(421, 369);
			this.pictureBox1.TabIndex = 101;
			this.pictureBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(37, 329);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(140, 24);
			this.label10.TabIndex = 98;
			this.label10.Text = "Số điện thoại ";
			// 
			// textEmail
			// 
			this.textEmail.Location = new System.Drawing.Point(191, 366);
			this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textEmail.Multiline = true;
			this.textEmail.Name = "textEmail";
			this.textEmail.Size = new System.Drawing.Size(252, 26);
			this.textEmail.TabIndex = 99;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(36, 450);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 24);
			this.label6.TabIndex = 95;
			this.label6.Text = "Phòng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 289);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 24);
			this.label4.TabIndex = 94;
			this.label4.Text = "Quốc tịch";
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(725, 475);
			this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(80, 40);
			this.insert.TabIndex = 63;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.dataCheckin);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 66;
			this.label2.Text = "CCCD ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(37, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 24);
			this.label3.TabIndex = 67;
			this.label3.Text = "Họ tên ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(36, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 24);
			this.label5.TabIndex = 69;
			this.label5.Text = "Giới tính ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(36, 370);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 24);
			this.label8.TabIndex = 72;
			this.label8.Text = "Email ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(37, 410);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 24);
			this.label9.TabIndex = 73;
			this.label9.Text = "Địa chỉ ";
			// 
			// textCCCD
			// 
			this.textCCCD.Location = new System.Drawing.Point(191, 160);
			this.textCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textCCCD.Multiline = true;
			this.textCCCD.Name = "textCCCD";
			this.textCCCD.Size = new System.Drawing.Size(252, 26);
			this.textCCCD.TabIndex = 78;
			// 
			// textHoTen
			// 
			this.textHoTen.Location = new System.Drawing.Point(191, 200);
			this.textHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textHoTen.Multiline = true;
			this.textHoTen.Name = "textHoTen";
			this.textHoTen.Size = new System.Drawing.Size(252, 26);
			this.textHoTen.TabIndex = 79;
			// 
			// textSDT
			// 
			this.textSDT.Location = new System.Drawing.Point(191, 325);
			this.textSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textSDT.Multiline = true;
			this.textSDT.Name = "textSDT";
			this.textSDT.Size = new System.Drawing.Size(252, 26);
			this.textSDT.TabIndex = 82;
			// 
			// textDiaChi
			// 
			this.textDiaChi.Location = new System.Drawing.Point(191, 406);
			this.textDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textDiaChi.Multiline = true;
			this.textDiaChi.Name = "textDiaChi";
			this.textDiaChi.Size = new System.Drawing.Size(252, 26);
			this.textDiaChi.TabIndex = 83;
			// 
			// inputNgayNhan
			// 
			this.inputNgayNhan.CustomFormat = "dd-MM-yyyy";
			this.inputNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgayNhan.Location = new System.Drawing.Point(191, 76);
			this.inputNgayNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputNgayNhan.Name = "inputNgayNhan";
			this.inputNgayNhan.Size = new System.Drawing.Size(252, 22);
			this.inputNgayNhan.TabIndex = 87;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(37, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(111, 24);
			this.label13.TabIndex = 90;
			this.label13.Text = "Ngày nhận";
			// 
			// textQuocTich
			// 
			this.textQuocTich.Location = new System.Drawing.Point(191, 285);
			this.textQuocTich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textQuocTich.Multiline = true;
			this.textQuocTich.Name = "textQuocTich";
			this.textQuocTich.Size = new System.Drawing.Size(252, 26);
			this.textQuocTich.TabIndex = 91;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(836, 475);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 93;
			this.back.Text = "BACK";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// hoaDonBindingSource
			// 
			this.hoaDonBindingSource.DataMember = "HoaDon";
			// 
			// groupGT
			// 
			this.groupGT.Controls.Add(this.radioNu);
			this.groupGT.Controls.Add(this.radioNam);
			this.groupGT.Location = new System.Drawing.Point(194, 237);
			this.groupGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupGT.Name = "groupGT";
			this.groupGT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupGT.Size = new System.Drawing.Size(249, 32);
			this.groupGT.TabIndex = 109;
			this.groupGT.TabStop = false;
			// 
			// radioNu
			// 
			this.radioNu.AutoSize = true;
			this.radioNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.radioNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.radioNu.Location = new System.Drawing.Point(111, 6);
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
			this.radioNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.radioNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.radioNam.Location = new System.Drawing.Point(4, 6);
			this.radioNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radioNam.Name = "radioNam";
			this.radioNam.Size = new System.Drawing.Size(61, 21);
			this.radioNam.TabIndex = 33;
			this.radioNam.TabStop = true;
			this.radioNam.Text = "Nam";
			this.radioNam.UseVisualStyleBackColor = true;
			// 
			// Checkin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 558);
			this.Controls.Add(this.groupGT);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.comboTT);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.listPhong);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputNgayTra);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textEmail);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.back);
			this.Controls.Add(this.textQuocTich);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.inputNgayNhan);
			this.Controls.Add(this.textDiaChi);
			this.Controls.Add(this.textSDT);
			this.Controls.Add(this.textHoTen);
			this.Controls.Add(this.textCCCD);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.insert);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Checkin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Checkin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
			this.groupGT.ResumeLayout(false);
			this.groupGT.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboTT;
		private System.Windows.Forms.ComboBox listPhong;
		private System.Windows.Forms.DateTimePicker inputNgayTra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textCCCD;
		private System.Windows.Forms.TextBox textHoTen;
		private System.Windows.Forms.TextBox textSDT;
		private System.Windows.Forms.TextBox textDiaChi;
		private System.Windows.Forms.DateTimePicker inputNgayNhan;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textQuocTich;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.BindingSource hoaDonBindingSource;
		private System.Windows.Forms.GroupBox groupGT;
		private System.Windows.Forms.RadioButton radioNu;
		private System.Windows.Forms.RadioButton radioNam;
	}
}