using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class bangKhachHang : Form
	{
		KhachHangBUS buskh;
		public bangKhachHang()
		{
			buskh = new KhachHangBUS();
			InitializeComponent();
		}

		public void ShowAllKhachHang()
		{
			DataTable dt = new DataTable();
			dt = buskh.getAllKhachHang();
			dataGridViewKH.DataSource = dt;
		}

		private void bangKhachHang_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã, tên hoặc cccd để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllKhachHang();
		}
		//Hiển thị lên ô input thông tin khách hàng mỗi khi lia chuột đến row nhân viên bất kì
		int ID;

		private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			//ID = Int32.Parse(dataGridViewNV.Rows[index].Cells["ID"].Value.ToString());
			textMaKH.Text = dataGridViewKH.Rows[index].Cells["MaKH"].Value.ToString();
			textCCCD_KH.Text = dataGridViewKH.Rows[index].Cells["CCCD"].Value.ToString();
			textSDT_KH.Text = dataGridViewKH.Rows[index].Cells["SDT_KH"].Value.ToString();
			textHoTen.Text = dataGridViewKH.Rows[index].Cells["HoTen"].Value.ToString();
			string gt = dataGridViewKH.Rows[index].Cells["GioiTinh"].Value.ToString();
			if (gt == "Nam")
			{
				radioNam.Checked = true;
			}
			else
			{
				radioNu.Checked = true;
			}
			textDiaChi.Text = dataGridViewKH.Rows[index].Cells["DiaChi"].Value.ToString();
			textQuocTich.Text = dataGridViewKH.Rows[index].Cells["QuocTich"].Value.ToString();
			textEmail_KH.Text = dataGridViewKH.Rows[index].Cells["Email_KH"].Value.ToString();
		}
		public bool checkData()
		{
			if (string.IsNullOrEmpty(textMaKH.Text))
			{
				MessageBox.Show("Chưa nhập Mã khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaKH.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textCCCD_KH.Text))
			{
				MessageBox.Show("Chưa nhập CCCD", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textCCCD_KH.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textHoTen.Text))
			{
				MessageBox.Show("Chưa nhập họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textHoTen.Focus();
				return false;
			}

			if (!radioNam.Checked && !radioNu.Checked)
			{
				MessageBox.Show("Chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				groupGT.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textSDT_KH.Text))
			{
				MessageBox.Show("Chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textSDT_KH.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textEmail_KH.Text))
			{
				MessageBox.Show("Chưa nhập Email", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textEmail_KH.Focus();
				return false;
			}
					
			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				KhachHangDTO kh = new KhachHangDTO();
				kh.MaKH = textMaKH.Text;
				kh.CCCD = textCCCD_KH.Text;
				kh.SDT_KH = textSDT_KH.Text;
				kh.Email_KH = textEmail_KH.Text;
				kh.DiaChi = textDiaChi.Text;
				kh.HoTen = textHoTen.Text;
				kh.GioiTinh = (radioNu.Checked ? "Nữ" : "Nam");
				kh.QuocTich = textQuocTich.Text;

				if (buskh.insertKhachHang(kh))
				{
					ShowAllKhachHang();
				}
				else
				{
					MessageBox.Show("Không thể chèn được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				KhachHangDTO kh = new KhachHangDTO();
				kh.MaKH = textMaKH.Text;

				if (buskh.DeleteKhachHang(kh))
				{
					ShowAllKhachHang();
				}
				else
				{
					MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void update_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				KhachHangDTO kh = new KhachHangDTO();
				kh.MaKH = textMaKH.Text;
				kh.CCCD = textCCCD_KH.Text;
				kh.SDT_KH = textSDT_KH.Text;
				kh.Email_KH = textEmail_KH.Text;
				kh.DiaChi = textDiaChi.Text;
				kh.HoTen = textHoTen.Text;
				kh.GioiTinh = (radioNu.Checked ? "Nữ" : "Nam");
				kh.QuocTich = textQuocTich.Text;

				if (buskh.UpdateKhachHang(kh))
				{
					ShowAllKhachHang();
				}
				else
				{
					MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã, tên hoặc cccd để tìm")
			{
				inputFind.Text = "";
				inputFind.ForeColor = Color.Black;
				inputFind.Font = new Font("Arial", 11, FontStyle.Regular);
			}
		}

        private void inputFind_TextChanged(object sender, EventArgs e)
		{
			string value = inputFind.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = buskh.FindKhachHang(value);
				dataGridViewKH.DataSource = dt;
			}
			else
			{
				ShowAllKhachHang();
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var dashboard = new Dashboard();
			dashboard.ShowDialog();
		}
	}
}
