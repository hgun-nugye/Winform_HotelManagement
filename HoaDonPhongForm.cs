using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class bangHoaDonPhong : Form
	{
		HoaDonPhongBUS busHDPhong;
		public bangHoaDonPhong()
		{
			busHDPhong = new HoaDonPhongBUS();
			InitializeComponent();
		}
		public void ShowAllHoaDonPhong()
		{
			DataTable dt = new DataTable();
			dt = busHDPhong.getAllHoaDonPhong();
			dataGridViewHDP.DataSource = dt;
		}
		private void frmHoaDonPhong_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã hóa đơn phòng để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllHoaDonPhong();
		}
		//Hiển thị lên ô input thông tin hoa don mon an mỗi khi lia chuột đến row nhân viên bất kì
		private void dataGridViewHDP_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index < 0) return;

			textMaHDP.Text = GetCellValue(dataGridViewHDP.Rows[index].Cells["MaHDP"]);

			if (DateTime.TryParse(GetCellValue(dataGridViewHDP.Rows[index].Cells["NgayDat"]), out DateTime ngayDat))
			{
				dateNgayDat.Value = ngayDat;
			}

			textMaKH.Text = GetCellValue(dataGridViewHDP.Rows[index].Cells["MaKH"]);

			if (double.TryParse(GetCellValue(dataGridViewHDP.Rows[index].Cells["ThanhTien"]), out double thanhTien))
			{
				textThanhTien.Text = Math.Round(thanhTien, 2).ToString("N2");
			}
			else
			{
				textThanhTien.Text = "0.00";
			}
		}

		private string GetCellValue(DataGridViewCell cell)
		{
			return cell.Value != DBNull.Value ? cell.Value.ToString() : string.Empty;
		}
		public bool checkData()
		{
			if (string.IsNullOrEmpty(textMaHDP.Text))
			{
				MessageBox.Show("Chưa nhập Mã hóa đơn phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaHDP.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textMaKH.Text))
			{
				MessageBox.Show("Chưa nhập mã khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaKH.Focus();
				return false;
			}

			if (!dateNgayDat.Checked)
			{
				MessageBox.Show("Chưa nhập ngày đặt phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateNgayDat.Focus();
				return false;
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			var dashboard = new Dashboard();
			dashboard.ShowDialog();
		}

		private void inputFind_TextChanged(object sender, EventArgs e)
		{
			string value = inputFind.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = busHDPhong.FindHoaDonPhong(value);
				dataGridViewHDP.DataSource = dt;
			}
			else
			{
				ShowAllHoaDonPhong();
			}
		}
		private void inputFind_Click(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã, tên hoặc cccd để tìm")
			{
				inputFind.Text = "";
				inputFind.ForeColor = Color.Black;
				inputFind.Font = new Font("Arial", 11, FontStyle.Regular);
			}

		}

		private void bangHoaDonPhong_Click(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã hóa đơn món để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
		}
	}
}
