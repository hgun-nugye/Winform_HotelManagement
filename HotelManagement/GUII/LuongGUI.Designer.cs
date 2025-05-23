namespace HotelManagement.GUII
{
    partial class LuongGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.inputThangLuong = new System.Windows.Forms.DateTimePicker();
            this.inputPhuCap = new System.Windows.Forms.TextBox();
            this.inputPhat = new System.Windows.Forms.TextBox();
            this.inputThuong = new System.Windows.Forms.TextBox();
            this.inputMucLuong = new System.Windows.Forms.TextBox();
            this.inputMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bangLuong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inputTimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.insert);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 475);
            this.panel1.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.delete.Location = new System.Drawing.Point(245, 401);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 50);
            this.delete.TabIndex = 13;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.update.Location = new System.Drawing.Point(139, 401);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 50);
            this.update.TabIndex = 12;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.insert.Location = new System.Drawing.Point(31, 401);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 50);
            this.insert.TabIndex = 11;
            this.insert.Text = "Thêm";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // inputThangLuong
            // 
            this.inputThangLuong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputThangLuong.Location = new System.Drawing.Point(214, 303);
            this.inputThangLuong.Name = "inputThangLuong";
            this.inputThangLuong.Size = new System.Drawing.Size(261, 26);
            this.inputThangLuong.TabIndex = 10;
            // 
            // inputPhuCap
            // 
            this.inputPhuCap.Location = new System.Drawing.Point(214, 245);
            this.inputPhuCap.Multiline = true;
            this.inputPhuCap.Name = "inputPhuCap";
            this.inputPhuCap.Size = new System.Drawing.Size(261, 30);
            this.inputPhuCap.TabIndex = 9;
            // 
            // inputPhat
            // 
            this.inputPhat.Location = new System.Drawing.Point(214, 191);
            this.inputPhat.Multiline = true;
            this.inputPhat.Name = "inputPhat";
            this.inputPhat.Size = new System.Drawing.Size(261, 30);
            this.inputPhat.TabIndex = 8;
            // 
            // inputThuong
            // 
            this.inputThuong.Location = new System.Drawing.Point(214, 139);
            this.inputThuong.Multiline = true;
            this.inputThuong.Name = "inputThuong";
            this.inputThuong.Size = new System.Drawing.Size(261, 30);
            this.inputThuong.TabIndex = 7;
            // 
            // inputMucLuong
            // 
            this.inputMucLuong.Location = new System.Drawing.Point(214, 89);
            this.inputMucLuong.Multiline = true;
            this.inputMucLuong.Name = "inputMucLuong";
            this.inputMucLuong.Size = new System.Drawing.Size(261, 30);
            this.inputMucLuong.TabIndex = 6;
            // 
            // inputMaNV
            // 
            this.inputMaNV.Location = new System.Drawing.Point(214, 34);
            this.inputMaNV.Multiline = true;
            this.inputMaNV.Name = "inputMaNV";
            this.inputMaNV.Size = new System.Drawing.Size(261, 30);
            this.inputMaNV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(15, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tháng lương :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(15, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phụ cấp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phạt : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thưởng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mức lương :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bangLuong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(506, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 475);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(162, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "HIỂN THỊ";
            // 
            // bangLuong
            // 
            this.bangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MucLuong,
            this.Thuong,
            this.Phat,
            this.PhuCap,
            this.ThangLuong});
            this.bangLuong.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.bangLuong.Location = new System.Drawing.Point(4, 72);
            this.bangLuong.Name = "bangLuong";
            this.bangLuong.RowHeadersWidth = 62;
            this.bangLuong.RowTemplate.Height = 28;
            this.bangLuong.Size = new System.Drawing.Size(465, 360);
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
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.back.Location = new System.Drawing.Point(357, 401);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 50);
            this.back.TabIndex = 14;
            this.back.Text = "Trở lại";
            this.back.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(15, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tìm kiếm theo tháng :";
            // 
            // inputTimKiem
            // 
            this.inputTimKiem.Location = new System.Drawing.Point(285, 355);
            this.inputTimKiem.Multiline = true;
            this.inputTimKiem.Name = "inputTimKiem";
            this.inputTimKiem.Size = new System.Drawing.Size(190, 30);
            this.inputTimKiem.TabIndex = 16;
            this.inputTimKiem.TextChanged += new System.EventHandler(this.inputTimKiem_TextChanged);
            // 
            // LuongGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 475);
            this.Controls.Add(this.inputTimKiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LuongGUI";
            this.Text = "Hiển thị lương";
            this.Load += new System.EventHandler(this.LuongGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker inputThangLuong;
        private System.Windows.Forms.TextBox inputPhuCap;
        private System.Windows.Forms.TextBox inputPhat;
        private System.Windows.Forms.TextBox inputThuong;
        private System.Windows.Forms.TextBox inputMucLuong;
        private System.Windows.Forms.TextBox inputMaNV;
        private System.Windows.Forms.DataGridView bangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox inputTimKiem;
    }
}