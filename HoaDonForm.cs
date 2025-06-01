using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
			textMaHD.Text = string.Empty;
			textMaKH.Text = string.Empty;
			textMaNV.Text = string.Empty;
			comboTT.Text = string.Empty;
			listHDP.Text = string.Empty;
			listHDM.Text = string.Empty;
			listHDDV.Text = string.Empty;
			inputNgayXuat.Text = string.Empty;
			// Hiển thị toàn bộ hóa đơn khi form được tải
			ShowAllHoaDon();
		}
		//Hiển thị lên ô input thông tin nhân viên mỗi khi lia chuột đến row nhân viên bất kì
		private string GetCellValue(DataGridViewCell cell)
		{
			return cell?.Value != DBNull.Value ? cell.Value.ToString() : string.Empty;
		}
		private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			if (index < 0 || index >= dataGridViewHD.Rows.Count) return;

			var row = dataGridViewHD.Rows[index];

			string mahd = GetCellValue(row.Cells["MaHD"]);
			string makh = GetCellValue(row.Cells["MaKH"]);
			string manv = GetCellValue(row.Cells["MaNV"]);
			textMaHD.Text = mahd;
			textMaKH.Text = makh;
			textMaNV.Text = manv;

			string maHoaDon = textMaHD.Text;
			LoadLoaiHoaDon(maHoaDon);

			// Check and convert Ngày Xuất
			if (DateTime.TryParse(GetCellValue(row.Cells["NgayXuatHD"]), out DateTime ngayXuat))
			{
				inputNgayXuat.Value = ngayXuat;
			}
			else
			{
				inputNgayXuat.Value = DateTime.Now;
			}

			comboTT.Text = GetCellValue(row.Cells["TrangThai"]);

			// Check and convert ThanhTien
			if (double.TryParse(GetCellValue(row.Cells["ThanhTien"]), out double thanhTien))
			{
				TongHD.Text = Math.Round(thanhTien, 2).ToString("N2");
			}
			else
			{
				TongHD.Text = "0.00";
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

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
