using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.GUII
{
	public partial class PhongForm : Form
	{
		PhongBUS busP;
		public PhongForm()
		{
			busP = new PhongBUS();
			InitializeComponent();
		}

		// Hiển thị toàn bộ
		public void ShowAll()
		{
			DataTable dt = new DataTable();
			dt = busP.getAll();
			bangPhong.DataSource = dt;
		}
		private void PhongForm_Load(object sender, EventArgs e)
		{
			inputMaP.Text = null;
			inputMaLP.Text = null;
			inputTenLP.Text = null;
			inputGiaMacDinh.Text = null;
			comboTT.Text = "Trống";
			cbSoGiuong.Text = null;
			cbSucChua.Text = null;
			inputTienNghi.Text = null;
			inputDienTich.Text = null;
			ShowAll();
		}

		//Hiển thị khi nháy
		private void bangPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			// Kiểm tra chỉ số hàng hợp lệ
			if (index < 0 || index >= bangPhong.Rows.Count || bangPhong.Rows[index].IsNewRow)
				return;

			Console.WriteLine($"RowIndex: {index}, Total Rows: {bangPhong.Rows.Count}");

			// Lấy giá trị từ các ô và gán vào các input
			try
			{
				inputMaP.Text = bangPhong.Rows[index].Cells["MaP"].Value?.ToString() ?? string.Empty;
				inputMaLP.Text = bangPhong.Rows[index].Cells["MaLP"].Value?.ToString() ?? string.Empty;
				inputTenLP.Text = bangPhong.Rows[index].Cells["TenLP"].Value?.ToString() ?? string.Empty;
				inputGiaMacDinh.Text = bangPhong.Rows[index].Cells["GiaMacDinh"].Value?.ToString() ?? string.Empty;
				comboTT.Text = bangPhong.Rows[index].Cells["TrangThai"].Value?.ToString() ?? string.Empty;
				cbSoGiuong.Text = bangPhong.Rows[index].Cells["SoGiuong"].Value?.ToString() ?? string.Empty;
				cbSucChua.Text = bangPhong.Rows[index].Cells["SucChua"].Value?.ToString() ?? string.Empty;
				inputTienNghi.Text = bangPhong.Rows[index].Cells["TienNghi"].Value?.ToString() ?? string.Empty;
				inputDienTich.Text = bangPhong.Rows[index].Cells["DienTich"].Value?.ToString() ?? string.Empty;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		//Kiểm tra nhập 
		public bool checkData()
		{
			if (string.IsNullOrEmpty(inputMaP.Text))
			{
				MessageBox.Show("Chưa nhập mã phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputMaP.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputMaLP.Text))
			{
				MessageBox.Show("Chưa nhập mã loại phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputMaLP.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputTenLP.Text))
			{
				MessageBox.Show("Chưa nhập trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputTenLP.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputGiaMacDinh.Text))
			{
				MessageBox.Show("Chưa nhập giá mặc định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputGiaMacDinh.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputDienTich.Text))
			{
				MessageBox.Show("Chưa nhập diện tích", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputDienTich.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(inputTienNghi.Text))
			{
				MessageBox.Show("Chưa nhập tiện nghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputTienNghi.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(comboTT.Text))
			{
				MessageBox.Show("Chưa nhập trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				comboTT.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(cbSoGiuong.Text))
			{
				MessageBox.Show("Chưa nhập số giường", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cbSoGiuong.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(cbSucChua.Text))
			{
				MessageBox.Show("Chưa nhập sức chứa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cbSucChua.Focus();
				return false;
			}
			return true;
		}

		private void insert_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				PhongDTO nv = new PhongDTO();
				nv.MaP = inputMaP.Text.Trim();
				nv.MaLP = inputMaLP.Text.Trim();
				nv.TenLP = inputTenLP.Text.Trim();
				nv.TrangThai = comboTT.SelectedItem.ToString().Trim();
				nv.GiaMacDinh = float.Parse(inputGiaMacDinh.Text.Trim());
				nv.SoGiuong = int.Parse(cbSoGiuong.Text.Trim());
				nv.SucChua = int.Parse(cbSucChua.Text.Trim());
				nv.DienTich = float.Parse(inputDienTich.Text.Trim());
				nv.TienNghi = inputTienNghi.Text.Trim();
				if (busP.Insert(nv))
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
				PhongDTO nv = new PhongDTO();
				nv.MaP = inputMaP.Text.Trim();
				nv.MaLP = inputMaLP.Text.Trim();
				nv.TenLP = inputTenLP.Text.Trim();
				nv.TrangThai = comboTT.SelectedItem.ToString().Trim();
				nv.GiaMacDinh = float.Parse(inputGiaMacDinh.Text.Trim());
				nv.SoGiuong = int.Parse(cbSoGiuong.Text.Trim());
				nv.SucChua = int.Parse(cbSucChua.Text.Trim());
				nv.DienTich = float.Parse(inputDienTich.Text.Trim());
				nv.TienNghi = inputTienNghi.Text.Trim();

				if (busP.Update(nv))
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
				PhongDTO nv = new PhongDTO();
				nv.MaP = inputMaP.Text;

				if (busP.Delete(nv))
				{
					ShowAll();
				}
				else
				{
					MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void cbSucChua_TextChanged(object sender, EventArgs e)
		{
			string value = cbSucChua.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = busP.FindP(value);
				bangPhong.DataSource = dt;
			}
			else
			{
				ShowAll();
			}
		}

		private void cbSoGiuong_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbSucChua_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = cbSucChua.SelectedItem.ToString().Trim();
			if (!string.IsNullOrEmpty(selected))
			{
				DataTable dt = busP.FindBySucChua(selected);
				bangPhong.DataSource = dt;
			}
		}

		private void cbSoGiuong_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = cbSoGiuong.SelectedItem.ToString().Trim();
			if (!string.IsNullOrEmpty(selected))
			{
				DataTable dt = busP.FindBySoGiuong(selected);
				bangPhong.DataSource = dt;
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
