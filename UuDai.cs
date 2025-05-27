using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.GUII
{
	public partial class UuDaiForm : Form
	{
		UuDaiBUS busUD;
		public UuDaiForm()
		{
			busUD = new UuDaiBUS();
			InitializeComponent();
		}
		// Hiển thị toàn bộ
		public void ShowAll()
		{
			DataTable dt = new DataTable();
			dt = busUD.getAll();
			bangUD.DataSource = dt;
		}

		private void UuDaiForm_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập tên ưu đãi";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 9, FontStyle.Italic);
			ShowAll();
		}

		//Kiểm tra nhập 
		public bool checkData()
		{
			if (string.IsNullOrEmpty(inputMaUD.Text))
			{
				MessageBox.Show("Chưa nhập mã ưu đãi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputMaUD.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputTenUD.Text))
			{
				MessageBox.Show("Chưa nhập tên ưu đãi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputTenUD.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputMucGiam.Text))
			{
				MessageBox.Show("Chưa nhập mức giảm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputMucGiam.Focus();
				return false;
			}

			if (!inputNgayBD.Checked)
			{
				MessageBox.Show("Chưa nhập ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputNgayBD.Focus();
				return false;
			}
			if (!inputNgayKT.Checked)
			{
				MessageBox.Show("Chưa nhập ngày kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputNgayKT.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputDieuKien.Text))
			{
				MessageBox.Show("Chưa nhập điều kiện", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputDieuKien.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputTrangThai.Text))
			{
				MessageBox.Show("Chưa nhập trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputTrangThai.Focus();
				return false;
			}

			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				UuDaiDTO nv = new UuDaiDTO();
				nv.MaUD = inputMaUD.Text;
				nv.TenUD = inputTenUD.Text;
				nv.MucGiam = float.Parse(inputMucGiam.Text);
				nv.DieuKien = inputDieuKien.Text;
				nv.TrangThai_UD = inputTrangThai.Text;
				nv.NgayBD = inputNgayBD.Value;
				nv.NgayKT = inputNgayKT.Value;
				if (busUD.Insert(nv))
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
				UuDaiDTO nv = new UuDaiDTO();
				nv.MaUD = inputMaUD.Text;
				nv.TenUD = inputTenUD.Text;
				nv.MucGiam = float.Parse(inputMucGiam.Text);
				nv.DieuKien = inputDieuKien.Text;
				nv.TrangThai_UD = inputTrangThai.Text;
				nv.NgayBD = inputNgayBD.Value;
				nv.NgayKT = inputNgayKT.Value;
				if (busUD.Update(nv))
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

		private void delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				UuDaiDTO nv = new UuDaiDTO();
				nv.MaUD = inputMaUD.Text;

				if (busUD.Delete(nv))
				{
					ShowAll();
				}
				else
				{
					MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		//Hiển thị khi nhấp
		private void bangUD_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			inputMaUD.Text = bangUD.Rows[index].Cells["MaUD"].Value.ToString();
			inputTenUD.Text = bangUD.Rows[index].Cells["TenUD"].Value.ToString();
			inputMucGiam.Text = bangUD.Rows[index].Cells["MucGiam"].Value.ToString();
			inputDieuKien.Text = bangUD.Rows[index].Cells["DieuKien"].Value?.ToString();
			inputTrangThai.Text = bangUD.Rows[index].Cells["TrangThai_UD"].Value.ToString();
			inputNgayBD.Value = Convert.ToDateTime(bangUD.Rows[index].Cells["NgayBD"].Value);
			inputNgayKT.Value = Convert.ToDateTime(bangUD.Rows[index].Cells["NgayKT"].Value);
		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập tên ưu đãi")
			{
				inputFind.Text = "";
				inputFind.ForeColor = Color.Black;
				inputFind.Font = new Font("Arial", 9, FontStyle.Regular);
			}
		}

		private void inputFind_TextChanged(object sender, EventArgs e)
		{
			string value = inputFind.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dataTable = busUD.FindUD(value);
				bangUD.DataSource = dataTable;
			}
			else
			{
				ShowAll();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime from = DateTime.MinValue;
			DateTime to = DateTime.MaxValue;
			string selected = cboTime.SelectedItem.ToString();
			switch (selected)
			{
				case "Hôm nay":
					from = to = DateTime.Today;
					break;
				case "Tuần này":
					from = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
					to = from.AddDays(6);
					break;
				case "Tháng này":
					from = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
					to = from.AddMonths(1).AddDays(-1);
					break;
				default:
					DateTime customDate;
					if (DateTime.TryParse(selected, out customDate))
					{
						from = to = customDate;
					}
					else
					{
						MessageBox.Show("Không thể xác định thời gian đã nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			DataTable dt = busUD.FindUuDaiToTime(from, to);
			bangUD.DataSource = dt;
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var dashboardForm = new Dashboard();
			dashboardForm.ShowDialog();
		}
	}
}
