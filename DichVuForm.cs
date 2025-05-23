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
	public partial class DichVuForm : Form
	{
		DichVuBUS busDichVu;
		public DichVuForm()
		{
			busDichVu = new DichVuBUS();
			InitializeComponent();
		}

		public void ShowAllDichVu()
		{
			DataTable dt = new DataTable();
			dt = busDichVu.getAllDichVu();
			dataGridViewDichVu.DataSource = dt;
		}

		private void DichVuForm_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã, tên dịch vụ để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllDichVu();
		}
		//Hiển thị lên ô input thông tin dich vu mỗi khi lia chuột đến row nhân viên bất kì
		
		private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			textMaDV.Text = dataGridViewDichVu.Rows[index].Cells["MaDV"].Value.ToString();
			textTenDV.Text = dataGridViewDichVu.Rows[index].Cells["TenDV"].Value.ToString();
			textGiaDV.Text = dataGridViewDichVu.Rows[index].Cells["GiaDV"].Value.ToString();
			textLoai_DV.Text = dataGridViewDichVu.Rows[index].Cells["Loai_DV"].Value.ToString();
		}
		public bool checkData()
		{
			if (string.IsNullOrEmpty(textMaDV.Text))
			{
				MessageBox.Show("Chưa nhập Mã dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaDV.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textTenDV.Text))
			{
				MessageBox.Show("Chưa nhập tên dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textTenDV.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textGiaDV.Text))
			{
				MessageBox.Show("Chưa nhập giá dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textGiaDV.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textLoai_DV.Text))
			{
				MessageBox.Show("Chưa nhập loại dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textLoai_DV.Focus();
				return false;
			}
			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				DichVuDTO dv = new DichVuDTO();
				dv.MaDV = textMaDV.Text;
				dv.TenDV = textTenDV.Text;
				dv.GiaDV = float.Parse(textGiaDV.Text);
				dv.Loai_DV = textLoai_DV.Text;

				if (busDichVu.insertDichVu(dv))
				{
					ShowAllDichVu();
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
				DichVuDTO dv = new DichVuDTO();
				dv.MaDV = textMaDV.Text;

				if (busDichVu.DeleteDichVu(dv))
				{
					ShowAllDichVu();
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
				DichVuDTO dv = new DichVuDTO();
				dv.MaDV = textMaDV.Text;
				dv.TenDV = textTenDV.Text;
				dv.GiaDV = float.Parse(textGiaDV.Text);
				dv.Loai_DV = textLoai_DV.Text;

				if (busDichVu.UpdateDichVu(dv))
				{
					ShowAllDichVu();
				}
				else
				{
					MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã dịch vụ, tên dịch vụ để tìm")
			{
				inputFind.Text = " ";
				inputFind.ForeColor = Color.Black;
				inputFind.Font = new Font("Arial", 11, FontStyle.Regular);
			}
		}

		private void inputFind_TextChanged(object sender, EventArgs e)
		{
			string value = inputFind.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = busDichVu.FindDichVu(value);
				dataGridViewDichVu.DataSource = dt;
			}
			else
			{
				ShowAllDichVu();
			}
		}

		//nút back	
		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var dashboard = new Dashboard();
			dashboard.Show();
		}

		private void hotelManagementDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		
		private void inputFind_Click(object sender, EventArgs e)
		{
			inputFind.Text = null;
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			
		}
	}
}
