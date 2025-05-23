namespace HotelManagement.GUII
{
    partial class UuDaiGUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputFind = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.inputTrangThai = new System.Windows.Forms.TextBox();
            this.inputNgayKT = new System.Windows.Forms.DateTimePicker();
            this.inputNgayBD = new System.Windows.Forms.DateTimePicker();
            this.inputDieuKien = new System.Windows.Forms.TextBox();
            this.inputMucGiam = new System.Windows.Forms.TextBox();
            this.inputTenUD = new System.Windows.Forms.TextBox();
            this.inputMaUD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bangUD = new System.Windows.Forms.DataGridView();
            this.MaUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_UD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTime);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.inputFind);
            this.panel2.Controls.Add(this.a);
            this.panel2.Controls.Add(this.inputTrangThai);
            this.panel2.Controls.Add(this.inputNgayKT);
            this.panel2.Controls.Add(this.inputNgayBD);
            this.panel2.Controls.Add(this.inputDieuKien);
            this.panel2.Controls.Add(this.inputMucGiam);
            this.panel2.Controls.Add(this.inputTenUD);
            this.panel2.Controls.Add(this.inputMaUD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 495);
            this.panel2.TabIndex = 1;
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này"});
            this.cboTime.Location = new System.Drawing.Point(209, 446);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(261, 28);
            this.cboTime.TabIndex = 18;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(12, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Lọc :";
            // 
            // inputFind
            // 
            this.inputFind.Location = new System.Drawing.Point(209, 404);
            this.inputFind.Multiline = true;
            this.inputFind.Name = "inputFind";
            this.inputFind.Size = new System.Drawing.Size(261, 30);
            this.inputFind.TabIndex = 16;
            this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
            this.inputFind.MouseEnter += new System.EventHandler(this.inputFind_MouseEnter);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.a.ForeColor = System.Drawing.SystemColors.Highlight;
            this.a.Location = new System.Drawing.Point(13, 405);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(135, 29);
            this.a.TabIndex = 15;
            this.a.Text = "Tìm kiếm :";
            // 
            // inputTrangThai
            // 
            this.inputTrangThai.Location = new System.Drawing.Point(209, 328);
            this.inputTrangThai.Multiline = true;
            this.inputTrangThai.Name = "inputTrangThai";
            this.inputTrangThai.Size = new System.Drawing.Size(261, 67);
            this.inputTrangThai.TabIndex = 14;
            // 
            // inputNgayKT
            // 
            this.inputNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputNgayKT.Location = new System.Drawing.Point(209, 230);
            this.inputNgayKT.Name = "inputNgayKT";
            this.inputNgayKT.Size = new System.Drawing.Size(261, 26);
            this.inputNgayKT.TabIndex = 13;
            // 
            // inputNgayBD
            // 
            this.inputNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputNgayBD.Location = new System.Drawing.Point(209, 178);
            this.inputNgayBD.Name = "inputNgayBD";
            this.inputNgayBD.Size = new System.Drawing.Size(261, 26);
            this.inputNgayBD.TabIndex = 12;
            // 
            // inputDieuKien
            // 
            this.inputDieuKien.Location = new System.Drawing.Point(209, 275);
            this.inputDieuKien.Multiline = true;
            this.inputDieuKien.Name = "inputDieuKien";
            this.inputDieuKien.Size = new System.Drawing.Size(261, 30);
            this.inputDieuKien.TabIndex = 11;
            // 
            // inputMucGiam
            // 
            this.inputMucGiam.Location = new System.Drawing.Point(209, 120);
            this.inputMucGiam.Multiline = true;
            this.inputMucGiam.Name = "inputMucGiam";
            this.inputMucGiam.Size = new System.Drawing.Size(261, 30);
            this.inputMucGiam.TabIndex = 10;
            // 
            // inputTenUD
            // 
            this.inputTenUD.Location = new System.Drawing.Point(209, 71);
            this.inputTenUD.Multiline = true;
            this.inputTenUD.Name = "inputTenUD";
            this.inputTenUD.Size = new System.Drawing.Size(261, 30);
            this.inputTenUD.TabIndex = 9;
            // 
            // inputMaUD
            // 
            this.inputMaUD.Location = new System.Drawing.Point(209, 23);
            this.inputMaUD.Multiline = true;
            this.inputMaUD.Name = "inputMaUD";
            this.inputMaUD.Size = new System.Drawing.Size(261, 30);
            this.inputMaUD.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(12, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày kết thúc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mức giảm : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên ưu đãi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điều kiện :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ưu đãi :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Controls.Add(this.update);
            this.panel3.Controls.Add(this.insert);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.bangUD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(506, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 495);
            this.panel3.TabIndex = 1;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.back.Location = new System.Drawing.Point(358, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 50);
            this.back.TabIndex = 17;
            this.back.Text = "Trở về";
            this.back.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.delete.Location = new System.Drawing.Point(250, 405);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 50);
            this.delete.TabIndex = 16;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.update.Location = new System.Drawing.Point(144, 405);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 50);
            this.update.TabIndex = 15;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.insert.Location = new System.Drawing.Point(36, 405);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 50);
            this.insert.TabIndex = 14;
            this.insert.Text = "Thêm";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(167, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "HIỂN THỊ";
            // 
            // bangUD
            // 
            this.bangUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaUD,
            this.TenUD,
            this.MucGiam,
            this.NgayBD,
            this.NgayKT,
            this.DieuKien,
            this.TrangThai_UD});
            this.bangUD.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.bangUD.Location = new System.Drawing.Point(7, 82);
            this.bangUD.Name = "bangUD";
            this.bangUD.RowHeadersWidth = 62;
            this.bangUD.RowTemplate.Height = 28;
            this.bangUD.Size = new System.Drawing.Size(465, 299);
            this.bangUD.TabIndex = 1;
            this.bangUD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangUD_CellClick);
            // 
            // MaUD
            // 
            this.MaUD.DataPropertyName = "MaUD";
            this.MaUD.HeaderText = "Mã ưu đãi";
            this.MaUD.MinimumWidth = 8;
            this.MaUD.Name = "MaUD";
            this.MaUD.ReadOnly = true;
            this.MaUD.Width = 150;
            // 
            // TenUD
            // 
            this.TenUD.DataPropertyName = "TenUD";
            this.TenUD.HeaderText = "Tên ưu đãi";
            this.TenUD.MinimumWidth = 8;
            this.TenUD.Name = "TenUD";
            this.TenUD.ReadOnly = true;
            this.TenUD.Width = 150;
            // 
            // MucGiam
            // 
            this.MucGiam.DataPropertyName = "MucGiam";
            this.MucGiam.HeaderText = "Mức giảm";
            this.MucGiam.MinimumWidth = 8;
            this.MucGiam.Name = "MucGiam";
            this.MucGiam.ReadOnly = true;
            this.MucGiam.Width = 150;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.MinimumWidth = 8;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.ReadOnly = true;
            this.NgayBD.Width = 150;
            // 
            // NgayKT
            // 
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.MinimumWidth = 8;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.ReadOnly = true;
            this.NgayKT.Width = 150;
            // 
            // DieuKien
            // 
            this.DieuKien.DataPropertyName = "DienKien";
            this.DieuKien.HeaderText = "Điều kiện";
            this.DieuKien.MinimumWidth = 8;
            this.DieuKien.Name = "DieuKien";
            this.DieuKien.ReadOnly = true;
            this.DieuKien.Width = 150;
            // 
            // TrangThai_UD
            // 
            this.TrangThai_UD.DataPropertyName = "TrangThai_UD";
            this.TrangThai_UD.HeaderText = "Trạng thái";
            this.TrangThai_UD.MinimumWidth = 8;
            this.TrangThai_UD.Name = "TrangThai_UD";
            this.TrangThai_UD.ReadOnly = true;
            this.TrangThai_UD.Width = 150;
            // 
            // UuDaiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UuDaiGUI";
            this.Text = "Hiển thị Ưu đãi";
            this.Load += new System.EventHandler(this.UuDaiGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputDieuKien;
        private System.Windows.Forms.TextBox inputMucGiam;
        private System.Windows.Forms.TextBox inputTenUD;
        private System.Windows.Forms.TextBox inputMaUD;
        private System.Windows.Forms.TextBox inputTrangThai;
        private System.Windows.Forms.DateTimePicker inputNgayKT;
        private System.Windows.Forms.DateTimePicker inputNgayBD;
        private System.Windows.Forms.DataGridView bangUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_UD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputFind;
        private System.Windows.Forms.ComboBox cboTime;
    }
}