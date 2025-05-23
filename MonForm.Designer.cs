namespace HotelManagement.DAO
{
    partial class bangMon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bangMon));
			this.inputFind = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textGiaMon = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textTenMon = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewMon = new System.Windows.Forms.DataGridView();
			this.textMaMon = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.comboTT = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// inputFind
			// 
			this.inputFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.inputFind.Location = new System.Drawing.Point(585, 198);
			this.inputFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.inputFind.Multiline = true;
			this.inputFind.Name = "inputFind";
			this.inputFind.Size = new System.Drawing.Size(437, 50);
			this.inputFind.TabIndex = 25;
			this.inputFind.Click += new System.EventHandler(this.inputFind_Click);
			this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
			this.inputFind.MouseEnter += new System.EventHandler(this.inputFind_MouseEnter);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(580, 121);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 29);
			this.label4.TabIndex = 21;
			this.label4.Text = "Trạng thái";
			// 
			// textGiaMon
			// 
			this.textGiaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textGiaMon.Location = new System.Drawing.Point(723, 27);
			this.textGiaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textGiaMon.Multiline = true;
			this.textGiaMon.Name = "textGiaMon";
			this.textGiaMon.Size = new System.Drawing.Size(299, 40);
			this.textGiaMon.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(580, 40);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 29);
			this.label3.TabIndex = 19;
			this.label3.Text = "Giá món ";
			// 
			// textTenMon
			// 
			this.textTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTenMon.Location = new System.Drawing.Point(185, 103);
			this.textTenMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textTenMon.Multiline = true;
			this.textTenMon.Name = "textTenMon";
			this.textTenMon.Size = new System.Drawing.Size(283, 37);
			this.textTenMon.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 114);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 29);
			this.label2.TabIndex = 17;
			this.label2.Text = "Tên món ";
			// 
			// dataGridViewMon
			// 
			this.dataGridViewMon.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridViewMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.gia,
            this.TrangThai});
			this.dataGridViewMon.Location = new System.Drawing.Point(49, 283);
			this.dataGridViewMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridViewMon.Name = "dataGridViewMon";
			this.dataGridViewMon.RowHeadersWidth = 62;
			this.dataGridViewMon.Size = new System.Drawing.Size(492, 306);
			this.dataGridViewMon.TabIndex = 16;
			this.dataGridViewMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMon_CellClick);
			// 
			// textMaMon
			// 
			this.textMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaMon.Location = new System.Drawing.Point(185, 26);
			this.textMaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textMaMon.Multiline = true;
			this.textMaMon.Name = "textMaMon";
			this.textMaMon.Size = new System.Drawing.Size(283, 43);
			this.textMaMon.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 29);
			this.label1.TabIndex = 14;
			this.label1.Text = "Mã món ";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.LightSkyBlue;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.back.Location = new System.Drawing.Point(412, 197);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(90, 50);
			this.back.TabIndex = 65;
			this.back.Text = "BACK";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.update.Location = new System.Drawing.Point(270, 197);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(118, 50);
			this.update.TabIndex = 64;
			this.update.Text = "Cập nhật";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.delete.Location = new System.Drawing.Point(157, 197);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(90, 50);
			this.delete.TabIndex = 63;
			this.delete.Text = "Xóa";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// insert
			// 
			this.insert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.insert.Location = new System.Drawing.Point(49, 197);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(90, 50);
			this.insert.TabIndex = 62;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = false;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// comboTT
			// 
			this.comboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTT.FormattingEnabled = true;
			this.comboTT.Items.AddRange(new object[] {
            "availble",
            "not availble"});
			this.comboTT.Location = new System.Drawing.Point(725, 113);
			this.comboTT.Name = "comboTT";
			this.comboTT.Size = new System.Drawing.Size(297, 37);
			this.comboTT.TabIndex = 66;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(594, 294);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(428, 295);
			this.pictureBox1.TabIndex = 67;
			this.pictureBox1.TabStop = false;
			// 
			// Ma
			// 
			this.Ma.DataPropertyName = "MaMon";
			this.Ma.HeaderText = "Mã Món";
			this.Ma.MinimumWidth = 8;
			this.Ma.Name = "Ma";
			this.Ma.Width = 80;
			// 
			// Ten
			// 
			this.Ten.DataPropertyName = "TenMon";
			this.Ten.HeaderText = "Tên Món";
			this.Ten.MinimumWidth = 8;
			this.Ten.Name = "Ten";
			// 
			// gia
			// 
			this.gia.DataPropertyName = "GiaMon";
			this.gia.HeaderText = "Giá Món";
			this.gia.MinimumWidth = 8;
			this.gia.Name = "gia";
			this.gia.Width = 70;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai_Mon";
			this.TrangThai.HeaderText = "Trạng Thái";
			this.TrangThai.MinimumWidth = 8;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 70;
			// 
			// bangMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(1078, 624);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboTT);
			this.Controls.Add(this.back);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.inputFind);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textGiaMon);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textTenMon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewMon);
			this.Controls.Add(this.textMaMon);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "bangMon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách Món";
			this.Load += new System.EventHandler(this.frmMon_Load);
			this.Click += new System.EventHandler(this.frmMon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox inputFind;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textGiaMon;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textTenMon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewMon;
		private System.Windows.Forms.TextBox textMaMon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.ComboBox comboTT;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
		private System.Windows.Forms.DataGridViewTextBoxColumn GiaMon;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_Mon;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn gia;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
	}
}