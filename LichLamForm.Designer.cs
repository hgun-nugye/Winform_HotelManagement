namespace HotelManagement.GUII
{
	partial class LichLamForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichLamForm));
			this.bangLichLam = new System.Windows.Forms.DataGridView();
			this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inputNgayLam = new System.Windows.Forms.DateTimePicker();
			this.inputCaLam = new System.Windows.Forms.TextBox();
			this.inputMaNV = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.inputfind = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bangLichLam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bangLichLam
			// 
			this.bangLichLam.BackgroundColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.bangLichLam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.bangLichLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bangLichLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLam,
            this.MaNV,
            this.CaLam});
			this.bangLichLam.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.bangLichLam.Location = new System.Drawing.Point(39, 243);
			this.bangLichLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bangLichLam.Name = "bangLichLam";
			this.bangLichLam.RowHeadersWidth = 62;
			this.bangLichLam.RowTemplate.Height = 28;
			this.bangLichLam.Size = new System.Drawing.Size(430, 267);
			this.bangLichLam.TabIndex = 29;
			this.bangLichLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangLichLam_CellClick);
			this.bangLichLam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangLichLam_CellContentClick);
			// 
			// NgayLam
			// 
			this.NgayLam.DataPropertyName = "NgayLam";
			this.NgayLam.HeaderText = "Ngày làm";
			this.NgayLam.MinimumWidth = 8;
			this.NgayLam.Name = "NgayLam";
			this.NgayLam.ReadOnly = true;
			this.NgayLam.Width = 150;
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
			// CaLam
			// 
			this.CaLam.DataPropertyName = "CaLam";
			this.CaLam.HeaderText = "Ca làm";
			this.CaLam.MinimumWidth = 8;
			this.CaLam.Name = "CaLam";
			this.CaLam.ReadOnly = true;
			this.CaLam.Width = 150;
			// 
			// inputNgayLam
			// 
			this.inputNgayLam.CustomFormat = "dd-MM-yyyy";
			this.inputNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputNgayLam.Location = new System.Drawing.Point(196, 63);
			this.inputNgayLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputNgayLam.Name = "inputNgayLam";
			this.inputNgayLam.Size = new System.Drawing.Size(272, 22);
			this.inputNgayLam.TabIndex = 28;
			// 
			// inputCaLam
			// 
			this.inputCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputCaLam.Location = new System.Drawing.Point(645, 46);
			this.inputCaLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputCaLam.Multiline = true;
			this.inputCaLam.Name = "inputCaLam";
			this.inputCaLam.Size = new System.Drawing.Size(272, 39);
			this.inputCaLam.TabIndex = 27;
			// 
			// inputMaNV
			// 
			this.inputMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputMaNV.Location = new System.Drawing.Point(198, 104);
			this.inputMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputMaNV.Multiline = true;
			this.inputMaNV.Name = "inputMaNV";
			this.inputMaNV.Size = new System.Drawing.Size(272, 41);
			this.inputMaNV.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label3.Location = new System.Drawing.Point(508, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 25);
			this.label3.TabIndex = 25;
			this.label3.Text = "Ca làm ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label2.Location = new System.Drawing.Point(39, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 25);
			this.label2.TabIndex = 24;
			this.label2.Text = "Mã nhân viên ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label1.Location = new System.Drawing.Point(37, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 25);
			this.label1.TabIndex = 23;
			this.label1.Text = "Ngày làm ";
			// 
			// inputfind
			// 
			this.inputfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputfind.Location = new System.Drawing.Point(647, 104);
			this.inputfind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputfind.Multiline = true;
			this.inputfind.Name = "inputfind";
			this.inputfind.Size = new System.Drawing.Size(272, 41);
			this.inputfind.TabIndex = 35;
			this.inputfind.Click += new System.EventHandler(this.inputfind_MouseEnter);
			this.inputfind.TextChanged += new System.EventHandler(this.inputfind_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label4.Location = new System.Drawing.Point(508, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 25);
			this.label4.TabIndex = 34;
			this.label4.Text = "Tìm kiếm ";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(377, 182);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(80, 40);
			this.back.TabIndex = 65;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(236, 182);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(121, 40);
			this.update.TabIndex = 64;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(135, 182);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(80, 40);
			this.delete.TabIndex = 63;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(39, 182);
			this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(80, 40);
			this.insert.TabIndex = 62;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(505, 186);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(411, 323);
			this.pictureBox1.TabIndex = 66;
			this.pictureBox1.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Location = new System.Drawing.Point(94, 14);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(193, 29);
			this.label14.TabIndex = 72;
			this.label14.Text = "LỊCH LÀM VIỆC";
			// 
			// LichLamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 534);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.bangLichLam);
			this.Controls.Add(this.inputNgayLam);
			this.Controls.Add(this.inputCaLam);
			this.Controls.Add(this.inputMaNV);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputfind);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LichLamForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lịch làm Nhân viên";
			this.Load += new System.EventHandler(this.LichLamForm_Load);
			this.Click += new System.EventHandler(this.LichLamForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bangLichLam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView bangLichLam;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayLam;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn CaLam;
		private System.Windows.Forms.DateTimePicker inputNgayLam;
		private System.Windows.Forms.TextBox inputCaLam;
		private System.Windows.Forms.TextBox inputMaNV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputfind;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label14;
	}
}