using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BUS;
using HotelManagement.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HotelManagement.GUII
{
	public partial class LichLamForm : Form
	{
		LichLamBUS busL;
		public LichLamForm()
		{
			busL = new LichLamBUS();
			InitializeComponent();
		}
		// Hiển thị toàn bộ
		public void ShowAll()
		{
			DataTable dt = new DataTable();
			dt = busL.getAll();
			bangLichLam.DataSource = dt;
		}
		private void LichLamForm_Load(object sender, EventArgs e)
		{
			inputfind.Text = "Nhập mã nhân viên hoặc ngày làm";
			inputfind.ForeColor = Color.Gray;
			inputfind.Font = new Font("Arial", 9, FontStyle.Italic);
			ShowAll();
		}

		//Kiểm tra nhập 
		public bool checkData()
		{
			if (string.IsNullOrEmpty(inputMaNV.Text))
			{
				MessageBox.Show("Chưa nhập mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputMaNV.Focus();
				return false;
			}


			if (string.IsNullOrEmpty(inputCaLam.Text))
			{
				MessageBox.Show("Chưa nhập ca làm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputCaLam.Focus();
				return false;
			}

			if (!inputNgayLam.Checked)
			{
				MessageBox.Show("Chưa nhập ngày làm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputNgayLam.Focus();
				return false;
			}

			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				LichLamDTO nv = new LichLamDTO();
				nv.MaNV = inputMaNV.Text;
				nv.CaLam = inputCaLam.Text;
				nv.NgayLam = inputNgayLam.Value;
				if (busL.Insert(nv))
				{
					MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ShowAll();
				}
				else
				{
					MessageBox.Show("Không thể chèn được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void update_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				LichLamDTO nv = new LichLamDTO();
				nv.MaNV = inputMaNV.Text;
				nv.CaLam = inputCaLam.Text;
				nv.NgayLam = inputNgayLam.Value;
				if (busL.Update(nv))
				{
					MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ShowAll();
				}
				else
				{
					MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				LichLamDTO nv = new LichLamDTO();
				nv.MaNV = inputMaNV.Text;

				if (busL.Delete(nv))
				{
					ShowAll();
				}
				else
				{
					MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void bangLichLam_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			if (index < 0 || index >= bangLichLam.Rows.Count)
				return;

			var maNVValue = bangLichLam.Rows[index].Cells["MaNV"].Value;
			var caLamValue = bangLichLam.Rows[index].Cells["CaLam"].Value;
			var ngayLamValue = bangLichLam.Rows[index].Cells["NgayLam"].Value;

			inputMaNV.Text = maNVValue?.ToString() ?? string.Empty;
			inputCaLam.Text = caLamValue?.ToString() ?? string.Empty;

			if (ngayLamValue != null && DateTime.TryParse(ngayLamValue.ToString(), out DateTime ngayLam))
			{
				inputNgayLam.Value = ngayLam;
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var nv = new bangNV();
			nv.ShowDialog();
		}

		private void bangLichLam_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void inputfind_MouseEnter(object sender, EventArgs e)
		{
			if (inputfind.Text == "Nhập mã nhân viên hoặc ngày làm")
			{
				inputfind.Text = "";
				inputfind.ForeColor = Color.Black;
				inputfind.Font = new Font("Arial", 9, FontStyle.Regular);
			}
		}

		private void inputfind_TextChanged(object sender, EventArgs e)
		{
			string value = inputfind.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = busL.FindLichLam(value);
				bangLichLam.DataSource = dt;
			}
			else
			{
				ShowAll();
			}
		}

	}
}

