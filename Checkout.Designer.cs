namespace HotelManagement
{
    partial class Checkout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.update = new System.Windows.Forms.Button();
			this.inputNgayTra = new System.Windows.Forms.DateTimePicker();
			this.textHoTen = new System.Windows.Forms.TextBox();
			this.textCCCD = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.submit = new System.Windows.Forms.Button();
			this.textMaHD = new System.Windows.Forms.TextBox();
			this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.textTongTien = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.inputNgayNhan = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
			this.listPhong = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(508, 112);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(408, 291);
			this.pictureBox1.TabIndex = 127;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(44, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 24);
			this.label6.TabIndex = 123;
			this.label6.Text = "Phòng";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(836, 444);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 121;
			this.back.Text = "BACK";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(504, 68);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(103, 24);
			this.label13.TabIndex = 118;
			this.label13.Text = "Ngày xuất";
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(672, 444);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(123, 40);
			this.update.TabIndex = 117;
			this.update.Text = "Checkout";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.completeCheckout);
			// 
			// inputNgayTra
			// 
			this.inputNgayTra.CustomFormat = "dd-MM-yyyy";
			this.inputNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgayTra.Location = new System.Drawing.Point(629, 70);
			this.inputNgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputNgayTra.Name = "inputNgayTra";
			this.inputNgayTra.Size = new System.Drawing.Size(287, 22);
			this.inputNgayTra.TabIndex = 116;
			// 
			// textHoTen
			// 
			this.textHoTen.Location = new System.Drawing.Point(197, 165);
			this.textHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textHoTen.Multiline = true;
			this.textHoTen.Name = "textHoTen";
			this.textHoTen.Size = new System.Drawing.Size(252, 26);
			this.textHoTen.TabIndex = 112;
			// 
			// textCCCD
			// 
			this.textCCCD.Location = new System.Drawing.Point(197, 117);
			this.textCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textCCCD.Multiline = true;
			this.textCCCD.Name = "textCCCD";
			this.textCCCD.Size = new System.Drawing.Size(252, 26);
			this.textCCCD.TabIndex = 111;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 104;
			this.label2.Text = "CCCD ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 103;
			this.label1.Text = "Mã Hóa đơn";
			// 
			// submit
			// 
			this.submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submit.Location = new System.Drawing.Point(541, 444);
			this.submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(90, 40);
			this.submit.TabIndex = 102;
			this.submit.Text = "Submit";
			this.submit.UseVisualStyleBackColor = false;
			this.submit.Click += new System.EventHandler(this.dataCheckout);
			// 
			// textMaHD
			// 
			this.textMaHD.Location = new System.Drawing.Point(197, 70);
			this.textMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textMaHD.Multiline = true;
			this.textMaHD.Name = "textMaHD";
			this.textMaHD.ReadOnly = true;
			this.textMaHD.Size = new System.Drawing.Size(252, 26);
			this.textMaHD.TabIndex = 110;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 24);
			this.label3.TabIndex = 105;
			this.label3.Text = "Họ tên ";
			// 
			// textTongTien
			// 
			this.textTongTien.Location = new System.Drawing.Point(197, 321);
			this.textTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textTongTien.Multiline = true;
			this.textTongTien.Name = "textTongTien";
			this.textTongTien.Size = new System.Drawing.Size(252, 26);
			this.textTongTien.TabIndex = 129;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(44, 325);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 24);
			this.label4.TabIndex = 128;
			this.label4.Text = "Tổng tiền";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(44, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 24);
			this.label5.TabIndex = 135;
			this.label5.Text = "Ngày nhận";
			// 
			// inputNgayNhan
			// 
			this.inputNgayNhan.CustomFormat = "dd-MM-yyyy";
			this.inputNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgayNhan.Location = new System.Drawing.Point(197, 273);
			this.inputNgayNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputNgayNhan.Name = "inputNgayNhan";
			this.inputNgayNhan.Size = new System.Drawing.Size(252, 22);
			this.inputNgayNhan.TabIndex = 134;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(44, 376);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 24);
			this.label9.TabIndex = 136;
			this.label9.Text = "Trạng thái";
			// 
			// comboBoxTrangThai
			// 
			this.comboBoxTrangThai.DropDownHeight = 200;
			this.comboBoxTrangThai.FormattingEnabled = true;
			this.comboBoxTrangThai.IntegralHeight = false;
			this.comboBoxTrangThai.ItemHeight = 16;
			this.comboBoxTrangThai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
			this.comboBoxTrangThai.Location = new System.Drawing.Point(197, 375);
			this.comboBoxTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxTrangThai.MaximumSize = new System.Drawing.Size(252, 0);
			this.comboBoxTrangThai.Name = "comboBoxTrangThai";
			this.comboBoxTrangThai.Size = new System.Drawing.Size(252, 24);
			this.comboBoxTrangThai.TabIndex = 138;
			// 
			// listPhong
			// 
			this.listPhong.DropDownHeight = 200;
			this.listPhong.FormattingEnabled = true;
			this.listPhong.IntegralHeight = false;
			this.listPhong.Location = new System.Drawing.Point(197, 220);
			this.listPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listPhong.Name = "listPhong";
			this.listPhong.Size = new System.Drawing.Size(252, 24);
			this.listPhong.TabIndex = 140;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Crimson;
			this.label14.Location = new System.Drawing.Point(123, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(197, 36);
			this.label14.TabIndex = 141;
			this.label14.Text = "CHECK OUT";
			// 
			// Checkout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 515);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.listPhong);
			this.Controls.Add(this.comboBoxTrangThai);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.inputNgayNhan);
			this.Controls.Add(this.textTongTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.update);
			this.Controls.Add(this.inputNgayTra);
			this.Controls.Add(this.textHoTen);
			this.Controls.Add(this.textCCCD);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.submit);
			this.Controls.Add(this.textMaHD);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Checkout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Checkout";
			this.Load += new System.EventHandler(this.Checkout_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DateTimePicker inputNgayTra;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textMaHD;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inputNgayNhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
		private System.Windows.Forms.ComboBox listPhong;
		private System.Windows.Forms.Label label14;
	}
}