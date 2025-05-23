using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
	public partial class bangMon : Form
	{

		MonBUS busMon;

		// Hiển thị toàn bộ
		public void ShowAllMon()
		{
			DataTable dt = new DataTable();
			dt = busMon.getAllMon();
			dataGridViewMon.DataSource = dt;
		}
		public bangMon()
		{
			busMon = new MonBUS();
			InitializeComponent();
		}

		private void MonForm_Load(object sender, EventArgs e)
		{


		}
		private void frmMon_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã, tên món để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllMon();
		}

		//Hiển thị lên ô input thông tin mon an mỗi khi lia chuột đến row nhân viên bất kì
		int ID;
		private void dataGridViewMon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			//ID = Int32.Parse(dataGridViewNV.Rows[index].Cells["ID"].Value.ToString());
			textMaMon.Text = dataGridViewMon.Rows[index].Cells["Ma"].Value.ToString();
			textTenMon.Text = dataGridViewMon.Rows[index].Cells["Ten"].Value.ToString();
			textGiaMon.Text = dataGridViewMon.Rows[index].Cells["gia"].Value.ToString();
			comboTT.Text = dataGridViewMon.Rows[index].Cells["TrangThai"].Value.ToString();
		}
		public bool checkData()
		{
			if (string.IsNullOrEmpty(textMaMon.Text))
			{
				MessageBox.Show("Chưa nhập Mã món", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaMon.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textTenMon.Text))
			{
				MessageBox.Show("Chưa nhập tên món", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textTenMon.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textGiaMon.Text))
			{
				MessageBox.Show("Chưa nhập giá món", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textGiaMon.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(comboTT.Text))
			{
				MessageBox.Show("Chưa nhập trạng thái món", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				comboTT.Focus();
				return false;
			}
			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				MonDTO mon = new MonDTO();
				mon.MaMon = textMaMon.Text;
				mon.TenMon = textTenMon.Text;
				mon.GiaMon = float.Parse(textGiaMon.Text);
				mon.TrangThai_Mon = comboTT.Text;

				if (busMon.insertMon(mon))
				{
					ShowAllMon();
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
				MonDTO mon = new MonDTO();
				mon.MaMon = textMaMon.Text;

				if (busMon.DeleteMon(mon))
				{
					ShowAllMon();
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
				MonDTO mon = new MonDTO();
				mon.MaMon = textMaMon.Text;
				mon.TenMon = textTenMon.Text;
				mon.GiaMon = float.Parse(textGiaMon.Text);
				mon.TrangThai_Mon = comboTT.Text;

				if (busMon.UpdateMon(mon))
				{
					ShowAllMon();
				}
				else
				{
					MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã món, tên món để tìm")
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
				DataTable dt = busMon.FindMon(value);
				dataGridViewMon.DataSource = dt;
			}
			else
			{
				ShowAllMon();
			}
		}

		// nút back 
		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		private void inputFind_Click(object sender, EventArgs e)
		{
			inputFind.Text = null;
		}

		private void hotelManagementDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}
	}
}
