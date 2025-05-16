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
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new HotelManagement.HotelManagementDataSet();
            this.hoaDonTableAdapter = new HotelManagement.HotelManagementDataSetTableAdapters.HoaDonTableAdapter();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.groupGT = new System.Windows.Forms.GroupBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.textQuocTich = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.inputNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textMaNV = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textCCCD = new System.Windows.Forms.TextBox();
            this.textMaHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listPhong = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            this.groupGT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
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
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightSkyBlue;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.back.Location = new System.Drawing.Point(938, 553);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 50);
            this.back.TabIndex = 93;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupGT
            // 
            this.groupGT.Controls.Add(this.radioNu);
            this.groupGT.Controls.Add(this.radioNam);
            this.groupGT.Location = new System.Drawing.Point(215, 209);
            this.groupGT.Name = "groupGT";
            this.groupGT.Size = new System.Drawing.Size(280, 40);
            this.groupGT.TabIndex = 92;
            this.groupGT.TabStop = false;
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
            // textQuocTich
            // 
            this.textQuocTich.Location = new System.Drawing.Point(215, 273);
            this.textQuocTich.Multiline = true;
            this.textQuocTich.Name = "textQuocTich";
            this.textQuocTich.Size = new System.Drawing.Size(283, 31);
            this.textQuocTich.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(545, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 26);
            this.label13.TabIndex = 90;
            this.label13.Text = "Ngày nhận";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.update.Location = new System.Drawing.Point(777, 553);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 50);
            this.update.TabIndex = 88;
            this.update.Text = "Cập nhật";
            this.update.UseVisualStyleBackColor = false;
            // 
            // inputNgayNhan
            // 
            this.inputNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.inputNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputNgayNhan.Location = new System.Drawing.Point(677, 17);
            this.inputNgayNhan.Name = "inputNgayNhan";
            this.inputNgayNhan.Size = new System.Drawing.Size(347, 26);
            this.inputNgayNhan.TabIndex = 87;
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(215, 425);
            this.textDiaChi.Multiline = true;
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(283, 31);
            this.textDiaChi.TabIndex = 83;
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(215, 323);
            this.textSDT.Multiline = true;
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(283, 31);
            this.textSDT.TabIndex = 82;
            // 
            // textMaNV
            // 
            this.textMaNV.Location = new System.Drawing.Point(215, 61);
            this.textMaNV.Multiline = true;
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.ReadOnly = true;
            this.textMaNV.Size = new System.Drawing.Size(283, 31);
            this.textMaNV.TabIndex = 81;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(215, 167);
            this.textHoTen.Multiline = true;
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(283, 31);
            this.textHoTen.TabIndex = 79;
            // 
            // textCCCD
            // 
            this.textCCCD.Location = new System.Drawing.Point(215, 117);
            this.textCCCD.Multiline = true;
            this.textCCCD.Name = "textCCCD";
            this.textCCCD.Size = new System.Drawing.Size(283, 31);
            this.textCCCD.TabIndex = 78;
            // 
            // textMaHD
            // 
            this.textMaHD.Location = new System.Drawing.Point(215, 12);
            this.textMaHD.Multiline = true;
            this.textMaHD.Name = "textMaHD";
            this.textMaHD.ReadOnly = true;
            this.textMaHD.Size = new System.Drawing.Size(283, 31);
            this.textMaHD.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 26);
            this.label9.TabIndex = 73;
            this.label9.Text = "Địa chỉ ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 26);
            this.label8.TabIndex = 72;
            this.label8.Text = "Email ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 26);
            this.label7.TabIndex = 71;
            this.label7.Text = "Mã Nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 69;
            this.label5.Text = "Giới tính ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "Họ tên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 66;
            this.label2.Text = "CCCD ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mã Hóa đơn";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.insert.Location = new System.Drawing.Point(641, 553);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 50);
            this.insert.TabIndex = 63;
            this.insert.Text = "Thêm";
            this.insert.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 94;
            this.label4.Text = "Quốc tịch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 95;
            this.label6.Text = "Phòng";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(215, 375);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(283, 31);
            this.textEmail.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 26);
            this.label10.TabIndex = 98;
            this.label10.Text = "Số điện thoại ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(550, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 435);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // listPhong
            // 
            this.listPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPhong.FormattingEnabled = true;
            this.listPhong.ItemHeight = 25;
            this.listPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.listPhong.Location = new System.Drawing.Point(217, 479);
            this.listPhong.Name = "listPhong";
            this.listPhong.ScrollAlwaysVisible = true;
            this.listPhong.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listPhong.Size = new System.Drawing.Size(280, 104);
            this.listPhong.TabIndex = 102;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1078, 652);
            this.Controls.Add(this.listPhong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupGT);
            this.Controls.Add(this.textQuocTich);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.update);
            this.Controls.Add(this.inputNgayNhan);
            this.Controls.Add(this.textDiaChi);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.textMaNV);
            this.Controls.Add(this.textHoTen);
            this.Controls.Add(this.textCCCD);
            this.Controls.Add(this.textMaHD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Checkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkin";
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            this.groupGT.ResumeLayout(false);
            this.groupGT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private HotelManagementDataSet hotelManagementDataSet;
        private HotelManagementDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupGT;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.TextBox textQuocTich;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DateTimePicker inputNgayNhan;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textMaNV;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textCCCD;
        private System.Windows.Forms.TextBox textMaHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listPhong;
    }
}