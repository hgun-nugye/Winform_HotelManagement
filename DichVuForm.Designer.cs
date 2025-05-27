namespace HotelManagement
{
	partial class DichVuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVuForm));
			this.inputFind = new System.Windows.Forms.TextBox();
			this.textLoai_DV = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textGiaDV = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textMaDV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
			this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Loai_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textTenDV = new System.Windows.Forms.TextBox();
			this.back = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.hotelManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// inputFind
			// 
			this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.inputFind.Location = new System.Drawing.Point(485, 189);
			this.inputFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inputFind.Multiline = true;
			this.inputFind.Name = "inputFind";
			this.inputFind.Size = new System.Drawing.Size(438, 38);
			this.inputFind.TabIndex = 25;
			this.inputFind.Click += new System.EventHandler(this.inputFind_MouseEnter);
			this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
			// 
			// textLoai_DV
			// 
			this.textLoai_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textLoai_DV.Location = new System.Drawing.Point(665, 66);
			this.textLoai_DV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textLoai_DV.Multiline = true;
			this.textLoai_DV.Name = "textLoai_DV";
			this.textLoai_DV.Size = new System.Drawing.Size(258, 34);
			this.textLoai_DV.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(483, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 25);
			this.label4.TabIndex = 21;
			this.label4.Text = "Loại dịch vụ ";
			// 
			// textGiaDV
			// 
			this.textGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textGiaDV.Location = new System.Drawing.Point(665, 114);
			this.textGiaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textGiaDV.Multiline = true;
			this.textGiaDV.Name = "textGiaDV";
			this.textGiaDV.Size = new System.Drawing.Size(258, 34);
			this.textGiaDV.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(483, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 25);
			this.label3.TabIndex = 19;
			this.label3.Text = "Giá tiền dịch vụ ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 25);
			this.label2.TabIndex = 17;
			this.label2.Text = "Tên dịch vụ ";
			// 
			// textMaDV
			// 
			this.textMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaDV.Location = new System.Drawing.Point(203, 66);
			this.textMaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textMaDV.Multiline = true;
			this.textMaDV.Name = "textMaDV";
			this.textMaDV.Size = new System.Drawing.Size(209, 34);
			this.textMaDV.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 25);
			this.label1.TabIndex = 15;
			this.label1.Text = "Mã dịch vụ ";
			// 
			// dataGridViewDichVu
			// 
			this.dataGridViewDichVu.AutoGenerateColumns = false;
			this.dataGridViewDichVu.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.Loai_DV,
            this.GiaDV});
			this.dataGridViewDichVu.DataSource = this.dichVuBindingSource;
			this.dataGridViewDichVu.Location = new System.Drawing.Point(445, 250);
			this.dataGridViewDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewDichVu.Name = "dataGridViewDichVu";
			this.dataGridViewDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewDichVu.Size = new System.Drawing.Size(476, 224);
			this.dataGridViewDichVu.TabIndex = 13;
			this.dataGridViewDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDichVu_CellClick);
			// 
			// MaDV
			// 
			this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaDV.DataPropertyName = "MaDV";
			this.MaDV.HeaderText = "Mã Dịch vụ";
			this.MaDV.MinimumWidth = 8;
			this.MaDV.Name = "MaDV";
			this.MaDV.ReadOnly = true;
			// 
			// TenDV
			// 
			this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TenDV.DataPropertyName = "TenDV";
			this.TenDV.HeaderText = "Tên Dịch vụ";
			this.TenDV.MinimumWidth = 8;
			this.TenDV.Name = "TenDV";
			this.TenDV.ReadOnly = true;
			// 
			// Loai_DV
			// 
			this.Loai_DV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Loai_DV.DataPropertyName = "Loai_DV";
			this.Loai_DV.HeaderText = "Loại Dịch vụ";
			this.Loai_DV.MinimumWidth = 8;
			this.Loai_DV.Name = "Loai_DV";
			this.Loai_DV.ReadOnly = true;
			// 
			// GiaDV
			// 
			this.GiaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.GiaDV.DataPropertyName = "GiaDV";
			this.GiaDV.HeaderText = "Giá Dịch vụ";
			this.GiaDV.MinimumWidth = 8;
			this.GiaDV.Name = "GiaDV";
			this.GiaDV.ReadOnly = true;
			// 
			// textTenDV
			// 
			this.textTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTenDV.Location = new System.Drawing.Point(203, 111);
			this.textTenDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textTenDV.Multiline = true;
			this.textTenDV.Name = "textTenDV";
			this.textTenDV.Size = new System.Drawing.Size(209, 34);
			this.textTenDV.TabIndex = 26;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(364, 189);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(76, 40);
			this.back.TabIndex = 65;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(230, 189);
			this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(109, 40);
			this.update.TabIndex = 64;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(138, 189);
			this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(71, 40);
			this.delete.TabIndex = 63;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(42, 189);
			this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(76, 40);
			this.insert.TabIndex = 62;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// hotelManagementDataSetBindingSource
			// 
			this.hotelManagementDataSetBindingSource.AllowNew = true;
			this.hotelManagementDataSetBindingSource.CurrentChanged += new System.EventHandler(this.hotelManagementDataSetBindingSource_CurrentChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(40, 250);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(358, 224);
			this.pictureBox1.TabIndex = 66;
			this.pictureBox1.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Location = new System.Drawing.Point(322, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(268, 29);
			this.label14.TabIndex = 67;
			this.label14.Text = "DỊCH VỤ KHÁCH SẠN";
			// 
			// DichVuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(958, 499);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.textTenDV);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.textLoai_DV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textGiaDV);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textMaDV);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewDichVu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "DichVuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dịch vụ";
			this.Load += new System.EventHandler(this.DichVuForm_Load);
			this.Click += new System.EventHandler(this.DichVuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputFind;
		private System.Windows.Forms.TextBox textLoai_DV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textGiaDV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textMaDV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewDichVu;
		private System.Windows.Forms.TextBox textTenDV;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.BindingSource hotelManagementDataSetBindingSource;
		private System.Windows.Forms.BindingSource dichVuBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn Loai_DV;
		private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
		private System.Windows.Forms.Label label14;
	}
}