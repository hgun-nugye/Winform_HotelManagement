namespace HotelManagement.GUII
{
    partial class LichLamGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMaNV = new System.Windows.Forms.TextBox();
            this.inputCaLam = new System.Windows.Forms.TextBox();
            this.inputNgayLam = new System.Windows.Forms.DateTimePicker();
            this.bangLichLam = new System.Windows.Forms.DataGridView();
            this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputfind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bangLichLam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày làm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ca làm :";
            // 
            // inputMaNV
            // 
            this.inputMaNV.Location = new System.Drawing.Point(235, 85);
            this.inputMaNV.Multiline = true;
            this.inputMaNV.Name = "inputMaNV";
            this.inputMaNV.Size = new System.Drawing.Size(305, 30);
            this.inputMaNV.TabIndex = 6;
            // 
            // inputCaLam
            // 
            this.inputCaLam.Location = new System.Drawing.Point(235, 145);
            this.inputCaLam.Multiline = true;
            this.inputCaLam.Name = "inputCaLam";
            this.inputCaLam.Size = new System.Drawing.Size(305, 30);
            this.inputCaLam.TabIndex = 7;
            // 
            // inputNgayLam
            // 
            this.inputNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputNgayLam.Location = new System.Drawing.Point(235, 30);
            this.inputNgayLam.Name = "inputNgayLam";
            this.inputNgayLam.Size = new System.Drawing.Size(305, 26);
            this.inputNgayLam.TabIndex = 11;
            // 
            // bangLichLam
            // 
            this.bangLichLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangLichLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLam,
            this.MaNV,
            this.CaLam});
            this.bangLichLam.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.bangLichLam.Location = new System.Drawing.Point(12, 263);
            this.bangLichLam.Name = "bangLichLam";
            this.bangLichLam.RowHeadersWidth = 62;
            this.bangLichLam.RowTemplate.Height = 28;
            this.bangLichLam.Size = new System.Drawing.Size(528, 272);
            this.bangLichLam.TabIndex = 12;
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
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.delete.Location = new System.Drawing.Point(284, 552);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 50);
            this.delete.TabIndex = 19;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.update.Location = new System.Drawing.Point(178, 552);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 50);
            this.update.TabIndex = 18;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.insert.Location = new System.Drawing.Point(70, 552);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 50);
            this.insert.TabIndex = 17;
            this.insert.Text = "Thêm";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.back.Location = new System.Drawing.Point(393, 552);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 50);
            this.back.TabIndex = 20;
            this.back.Text = "Trở về";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tìm kiếm :";
            // 
            // inputfind
            // 
            this.inputfind.Location = new System.Drawing.Point(235, 204);
            this.inputfind.Multiline = true;
            this.inputfind.Name = "inputfind";
            this.inputfind.Size = new System.Drawing.Size(305, 30);
            this.inputfind.TabIndex = 22;
            this.inputfind.TextChanged += new System.EventHandler(this.inputfind_TextChanged);
            this.inputfind.MouseEnter += new System.EventHandler(this.inputfind_MouseEnter);
            // 
            // LichLamGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 617);
            this.Controls.Add(this.inputfind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.bangLichLam);
            this.Controls.Add(this.inputNgayLam);
            this.Controls.Add(this.inputCaLam);
            this.Controls.Add(this.inputMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LichLamGUI";
            this.Text = "FunctLL";
            this.Load += new System.EventHandler(this.LichLamGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangLichLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputMaNV;
        private System.Windows.Forms.TextBox inputCaLam;
        private System.Windows.Forms.DateTimePicker inputNgayLam;
        private System.Windows.Forms.DataGridView bangLichLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLam;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputfind;
    }
}