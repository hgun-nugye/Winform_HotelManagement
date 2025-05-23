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
	public partial class bangHoaDonDV : Form
	{
		HoaDonDVBUS busHDDV;
		public bangHoaDonDV()
		{
			busHDDV = new HoaDonDVBUS();
			InitializeComponent();
		}
		public void ShowAllHoaDonDV()
		{
			DataTable dt = new DataTable();
			dt = busHDDV.getAllHoaDonDV();
			dataGridViewHDDV.DataSource = dt;
		}

		private void bangHoaDonDV_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã hóa đơn dịch vụ để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllHoaDonDV();
		}
		//Hiển thị lên ô input thông tin hoa don dich vu mỗi khi lia chuột đến row nhân viên bất kì
		int ID;

		private void dataGridViewHDDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			//ID = Int32.Parse(dataGridViewNV.Rows[index].Cells["ID"].Value.ToString());
			textMaHDDV.Text = dataGridViewHDDV.Rows[index].Cells["MaHDDV"].Value.ToString();
			dateNgayDat.Value = Convert.ToDateTime(dataGridViewHDDV.Rows[index].Cells["NgayDat"].Value);
			textMaKH.Text = dataGridViewHDDV.Rows[index].Cells["MaKH"].Value.ToString();

			if (double.TryParse(dataGridViewHDDV.Rows[index].Cells["ThanhTien"].Value.ToString(), out double thanhTien))
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
			if (string.IsNullOrEmpty(textMaHDDV.Text))
			{
				MessageBox.Show("Chưa nhập Mã hóa đơn dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaHDDV.Focus();
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
				MessageBox.Show("Chưa nhập ngày đặt dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateNgayDat.Focus();
				return false;
			}
			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				HoaDonDVDTO hddv = new HoaDonDVDTO();
				hddv.MaHDDV = textMaHDDV.Text;
				hddv.NgayDat = dateNgayDat.Value;
				hddv.MaKH = textMaKH.Text;

				if (busHDDV.insertHoaDonDV(hddv))
				{
					ShowAllHoaDonDV();
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
				HoaDonDVDTO hddv = new HoaDonDVDTO();
				hddv.MaHDDV = textMaHDDV.Text;

				if (busHDDV.DeleteHoaDonDV(hddv))
				{
					ShowAllHoaDonDV();
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
				HoaDonDVDTO hddv = new HoaDonDVDTO();
				hddv.MaHDDV = textMaHDDV.Text;
				hddv.NgayDat = dateNgayDat.Value;
				hddv.MaKH = textMaKH.Text;

				if (busHDDV.UpdateHoaDonDV(hddv))
				{
					ShowAllHoaDonDV();
				}
				else
				{
					MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã dịch vụ món để tìm")
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
				DataTable dt = busHDDV.FindHoaDonDV(value);
				dataGridViewHDDV.DataSource = dt;
			}
			else
			{
				ShowAllHoaDonDV();
			}
		}

		//nút back
		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var dashboard = new Dashboard();
			dashboard.ShowDialog();
		}
	}
}
