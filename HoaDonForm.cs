using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HotelManagement
{
	public partial class HoaDonForm : Form
	{
		HoaDonBUS busHD;
		public HoaDonForm()
		{
			busHD = new HoaDonBUS();
			InitializeComponent();
		}

		// Hiển thị toàn bộ ở bảng  
		public void ShowAllHoaDon()
		{
			DataTable dt = new DataTable();
			dt = busHD.getAllHoaDon();
			dataGridViewHD.DataSource = dt;
		}
		// Xử lý hiển thị toàn bộ
		private void HoaDonForm_Load(object sender, EventArgs e)
		{
			inputFind.Text = "Nhập mã, tên hoặc cccd để tìm";
			inputFind.ForeColor = Color.Gray;
			inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			ShowAllHoaDon();
		}
		//Hiển thị lên ô input thông tin nhân viên mỗi khi lia chuột đến row nhân viên bất kì
		private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			if (index >= 0)
			{
				textMaHD.Text = dataGridViewHD.Rows[index].Cells["MaHD"].Value?.ToString() ?? string.Empty;
				textMaKH.Text = dataGridViewHD.Rows[index].Cells["MaKH"].Value?.ToString() ?? string.Empty;
				textMaNV.Text = dataGridViewHD.Rows[index].Cells["MaNV"].Value?.ToString() ?? string.Empty;

				// Kiểm tra và chuyển đổi Ngày Xuất
				if (dataGridViewHD.Rows[index].Cells["NgayXuatHD"].Value != DBNull.Value)
				{
					inputNgayXuat.Value = Convert.ToDateTime(dataGridViewHD.Rows[index].Cells["NgayXuatHD"].Value);
				}
				else
				{
					inputNgayXuat.Value = DateTime.Now; // Hoặc một giá trị mặc định khác
				}

				textUuDai.Text = dataGridViewHD.Rows[index].Cells["MaUD"].Value?.ToString() ?? string.Empty;
				comboTT.Text = dataGridViewHD.Rows[index].Cells["TrangThai"].Value?.ToString() ?? string.Empty;

				string maHoaDon = dataGridViewHD.Rows[index].Cells["MaHD"].Value?.ToString() ?? string.Empty;
				LoadLoaiHoaDon(maHoaDon);
			}
		}
		private void LoadLoaiHoaDon(string maHoaDon)
		{
			string connectionString = "Data Source=LAPTOP-0ILAPBDO; Initial Catalog=HotelManagement; Integrated Security=true; TrustServerCertificate=True";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				// Lọc hóa đơn phòng
				string queryPhong = "SELECT MaLoaiHD FROM HoaDon WHERE MaHD = @MaHD and MaLoaiHD like 'HDP%' ";
				SqlDataAdapter daPhong = new SqlDataAdapter(queryPhong, conn);
				daPhong.SelectCommand.Parameters.AddWithValue("@MaHD", maHoaDon);
				DataTable dtPhong = new DataTable();
				daPhong.Fill(dtPhong);
				listHDP.DataSource = dtPhong;
				listHDP.DisplayMember = "MaLoaiHD"; // Hiển thị mã phòng

				// Lọc món ăn
				string queryMon = "SELECT MaLoaiHD FROM HoaDon WHERE MaHD = @MaHD and MaLoaiHD like 'HDM%' ";
				SqlDataAdapter daMon = new SqlDataAdapter(queryMon, conn);
				daMon.SelectCommand.Parameters.AddWithValue("@MaHD", maHoaDon);
				DataTable dtMon = new DataTable();
				daMon.Fill(dtMon);
				listHDM.DataSource = dtMon;
				listHDM.DisplayMember = "MaLoaiHD"; // Hiển thị tên món ăn

				// Lọc dịch vụ
				string queryDichVu = "SELECT MaLoaiHD FROM HoaDon WHERE MaHD = @MaHD and MaLoaiHD like 'HDDV%' ";
				SqlDataAdapter daDichVu = new SqlDataAdapter(queryDichVu, conn);
				daDichVu.SelectCommand.Parameters.AddWithValue("@MaHD", maHoaDon);
				DataTable dtDichVu = new DataTable();
				daDichVu.Fill(dtDichVu);
				listHDDV.DataSource = dtDichVu;
				listHDDV.DisplayMember = "MaLoaiHD"; // Hiển thị tên dịch vụ
			}
		}

		// Kiểm tra nhập chưa
		public bool checkData()
		{
			if (string.IsNullOrEmpty(textMaHD.Text))
			{
				MessageBox.Show("Chưa nhập Mã Hóa đơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaHD.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textMaKH.Text))
			{
				MessageBox.Show("Chưa nhập Mã khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaKH.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(textMaNV.Text))
			{
				MessageBox.Show("Chưa nhập Mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textMaNV.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(listHDP.Text) && string.IsNullOrEmpty(listHDM.Text) && string.IsNullOrEmpty(listHDDV.Text))
			{
				MessageBox.Show("Chưa nhập Mã loại hóa đơn ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				listHDP.Focus();
				listHDM.Focus();
				listHDDV.Focus();
				return false;
			}

			if (!inputNgayXuat.Checked)
			{
				MessageBox.Show("Chưa nhập ngày xuất hóa đơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				inputNgayXuat.Focus();
				return false;
			}


			if (string.IsNullOrEmpty(comboTT.Text))
			{
				MessageBox.Show("Chưa nhập trạng thái Hóa đơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				comboTT.Focus();
				return false;
			}
			return true;
		}
		// phương thức tạo HoaDonDTO
		private HoaDonDTO CreateHoaDonDTO(string loaiHD)
		{
			return new HoaDonDTO
			{
				MaHD = textMaHD.Text,
				MaKH = textMaKH.Text,
				MaNV = textMaNV.Text,
				NgayXuatHD = inputNgayXuat.Value,
				MaLoaiHD = loaiHD,
				MaUD = textUuDai.Text,
				TrangThai = comboTT.Text
			};
		}

		//nút update 
		private void update_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				//TextBox[] textBoxes = { listHDP, textHDM, textHDDV };

				//foreach (var textBox in textBoxes)
				//{
				//    if (!string.IsNullOrEmpty(textBox.Text)) // Check if TextBox is not empty
				//    {
				//        HoaDonDTO hd = CreateHoaDonDTO(textBox.Text);

				//        if (busHD.UpdateHoaDon(hd)) // Make sure to call the Update method
				//        {
				//            ShowAllHoaDon();
				//        }
				//        else
				//        {
				//            MessageBox.Show("Không thể cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//        }
				//    }
				//}
			}
		}

		// nút xóa
		private void delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				HoaDonDTO hd = new HoaDonDTO();
				hd.MaHD = textMaHD.Text;

				if (busHD.DeleteHoaDon(hd))
				{
					ShowAllHoaDon();
				}
				else
				{
					MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void inputFind_MouseEnter(object sender, EventArgs e)
		{
			if (inputFind.Text == "Nhập mã, tên hoặc cccd để tìm")
			{
				inputFind.Text = "";
				inputFind.ForeColor = Color.Gray;
				inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
			}
		}

		private void inputFind_TextChanged(object sender, EventArgs e)
		{
			string value = inputFind.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = busHD.FindHoaDon(value);
				dataGridViewHD.DataSource = dt;
			}
			else
			{
				ShowAllHoaDon();
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}
	}
}
