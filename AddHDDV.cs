using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class AddHDDV : Form
	{
		DataConnection dc = new DataConnection();
		string cccd;
		public AddHDDV(string maPhong, string cccd)
		{
			InitializeComponent();
			this.maPhong.Text = maPhong;
			this.cccd = cccd;

		}

		//thêm tên dịch vụ vào combobox
		public void LoadService()
		{
			using (SqlConnection conn = dc.GetConnect())
			{
				string query = "SELECT TenDV FROM DichVu";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();

					comboTenDV.Items.Clear();

					while (reader.Read())
					{
						// Thêm tên dịch vụ vào ComboBox
						comboTenDV.Items.Add(reader["TenDV"].ToString());
					}
				}
			}
		}

		//insert dữ liệu vào table HDDV
		private void InsertHDDV(object sender, EventArgs e)
		{
			DateTime ngayDat = DateTime.Now;
			DateTime ngayDung;

			// Kiểm tra và chuyển đổi chuỗi ngày sang DateTime			
			if (!DateTime.TryParse(ngaySD.Text, out ngayDung))
			{
				MessageBox.Show("Ngày trả không hợp lệ.");
				return;
			}

			// Ràng buộc ngày trả không nhỏ hơn ngày nhận và không lớn hơn ngày hiện tại
			if (ngayDung < ngayDat)
			{
				MessageBox.Show("Ngày dùng không được nhỏ hơn ngày đặt.");
				return;
			}


			// Kiểm tra và chuyển đổi chuỗi ngày sang DateTime			
			if (!DateTime.TryParse(NgayDat.Text, out ngayDat))
			{
				MessageBox.Show("Ngày đặt không hợp lệ.");
				return;
			}

			using (SqlConnection conn = dc.GetConnect())
			{
				string maKHSql = @" SELECT MaKH FROM KhachHang WHERE CCCD = @cccd";

				string maKH = null;

				using (SqlCommand cmd = new SqlCommand(maKHSql, conn))
				{
					cmd.Parameters.AddWithValue("@cccd", cccd); // Sử dụng cccd đã được truyền vào

					conn.Open();
					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						maKH = result.ToString(); // Lấy MaKH
					}
				}

				// Insert into table HHDV and retrieve MaHDDV
				string hoaDonDVSql = @"
									INSERT INTO HoaDonDV (MaHDDV, MaKH, MaNV, NgayDat) 
									OUTPUT INSERTED.MaHDDV 
									VALUES (dbo.GenerateMaHDDV(), @maKH, @maNV, @ngayDat)";

				string generatedMaHDDV = null;

				using (SqlCommand cmd = new SqlCommand(hoaDonDVSql, conn))
				{
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maNV", "NV002");
					cmd.Parameters.AddWithValue("@ngayDat", NgayDat);

					generatedMaHDDV = (string)cmd.ExecuteScalar(); // Lấy MaHDDV
				}

				// Lấy MaDV từ tên dịch vụ
				string maDVSql = @"SELECT MaDV FROM DichVu WHERE TenDV = @tenDV";

				string maDV = null;

				using (SqlCommand cmd = new SqlCommand(maDVSql, conn))
				{
					cmd.Parameters.AddWithValue("@tenDV", comboTenDV.Text); // tenDV là tên dịch vụ bạn đã có

					conn.Open();
					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						maDV = result.ToString(); // Lấy MaDV
					}
				}

				// Kiểm tra xem có tìm thấy MaDV không trước khi chèn vào CTHDDichVu
				if (maDV != null)
				{

					// Insert into CTHDDichVu and retrieve MaCTHDDV
					string cthdDichVuSql = @"INSERT INTO CTHDDichVu (MaCTHDDV, MaHDDV, MaDV, SL_DV, MaP, NgaySD, TrangThai) 
										VALUES (dbo.GenerateMaCTHDDV(), @maHDDV, @maDV, @slDV, @maP, @ngaySD, @trangThai)";

					using (SqlCommand cmd = new SqlCommand(cthdDichVuSql, conn))
					{
						cmd.Parameters.AddWithValue("@maHDDV", generatedMaHDDV); // MaHDDV đã được tạo
						cmd.Parameters.AddWithValue("@maDV", maDV); // Mã dịch vụ
						cmd.Parameters.AddWithValue("@slDV", soLuong.Text); // Số lượng dịch vụ
						cmd.Parameters.AddWithValue("@maP", maPhong.Text); // Mã phòng
						cmd.Parameters.AddWithValue("@ngaySD", ngaySD.Text); // Ngày sử dụng dịch vụ
						cmd.Parameters.AddWithValue("@trangThai", comboTT.Text); // Trạng thái

						cmd.ExecuteNonQuery(); // Thực thi câu lệnh
					}
				}
				MessageBox.Show("Thêm dịch vụ thành công!");
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
		}

		private void AddHDDV_Load(object sender, EventArgs e)
		{
			LoadService();
		}
	}
}
