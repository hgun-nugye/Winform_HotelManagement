using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class bangHoaDonMon : Form
	{
		HoaDonMonBUS busHDMon;
		public bangHoaDonMon()
		{
			busHDMon = new HoaDonMonBUS();
			InitializeComponent();
		}
		public void ShowAllHoaDonMon()
		{
			DataTable dt = new DataTable();
			dt = busHDMon.getAllHoaDonMon();
			dataGridViewHDM.DataSource = dt;
		}

		private void frmHoaDonMon_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã hóa đơn món để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllHoaDonMon();
		}
		//Hiển thị lên ô input thông tin hoa don mon an mỗi khi lia chuột đến row nhân viên bất kì

		private void dataGridViewHDM_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			if (index < 0 || index >= dataGridViewHDM.Rows.Count || dataGridViewHDM.Rows[index].IsNewRow)
				return;

			textMaHDM.Text = dataGridViewHDM.Rows[index].Cells["MaHDM"].Value?.ToString() ?? string.Empty;

			if (dataGridViewHDM.Rows[index].Cells["NgayDat"].Value != DBNull.Value)
			{
				dateNgayDat.Value = Convert.ToDateTime(dataGridViewHDM.Rows[index].Cells["NgayDat"].Value);
			}
			else
			{
				dateNgayDat.Value = DateTime.Now; // or any default value you prefer
			}

			textMaKH.Text = dataGridViewHDM.Rows[index].Cells["MaKH"].Value?.ToString() ?? string.Empty;

			if (dataGridViewHDM.Rows[index].Cells["ThanhTien"].Value != DBNull.Value &&
				double.TryParse(dataGridViewHDM.Rows[index].Cells["ThanhTien"].Value.ToString(), out double thanhTien))
			{
				textThanhTien.Text = Math.Round(thanhTien, 2).ToString();
			}
			else
			{
				textThanhTien.Text = "0.00";
			}
		}
		public bool checkData()
		{
			if (string.IsNullOrEmpty(textMaHDM.Text))
			{
				MessageBox.Show("Chưa nhập Mã hóa đơn món", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaHDM.Focus();
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
				MessageBox.Show("Chưa nhập ngày đặt món", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateNgayDat.Focus();
				return false;
			}
			return true;
		}

		private void delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				HoaDonMonDTO hdm = new HoaDonMonDTO();
				hdm.MaHDM = textMaHDM.Text;

				if (busHDMon.DeleteHoaDonMon(hdm))
				{
					ShowAllHoaDonMon();
				}
				else
				{
					MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void update_Click(object sender, EventArgs e)
		{

		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã hóa đơn món để tìm")
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
				DataTable dt = busHDMon.FindHoaDonMon(value);
				dataGridViewHDM.DataSource = dt;
			}
			else
			{
				ShowAllHoaDonMon();
			}
		}

		private void hotelManagementDataSet9BindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var dashboard = new Dashboard();
			dashboard.ShowDialog();
		}

		private void inputFind_Click(object sender, EventArgs e)
		{
			inputFind.Text = "";
		}

		private void bangHoaDonMon_Click(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã hóa đơn món để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
		}
	}
}
