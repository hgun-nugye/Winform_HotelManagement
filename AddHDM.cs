using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class AddHDM : Form
	{
		DataConnection dc = new DataConnection();
		string cccd;
		public AddHDM(string maPhong, string cccd)
		{
			InitializeComponent();
			this.maPhong.Text = maPhong;
			this.cccd = cccd;

		}

		//thêm tên món vào combobox
		public void LoadDish()
		{
			using (SqlConnection conn = dc.GetConnect())
			{
				string query = "SELECT TenMon FROM Mon";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();

					comboTenMon.Items.Clear();

					while (reader.Read())
					{
						// Thêm tên món vào ComboBox
						comboTenMon.Items.Add(reader["TenMon"].ToString());
					}
				}
			}
		}

		private void InsertHDMon(object sender, EventArgs e)
		{
			DateTime ngayDat = DateTime.Now;
			DateTime ngayDung;

			// Kiểm tra và chuyển đổi chuỗi ngày sang DateTime			
			if (!DateTime.TryParse(ngaySD.Text, out ngayDung))
			{
				MessageBox.Show("Ngày trả không hợp lệ.");
				return;
			}

			// Ràng buộc ngày đặt không lớn hơn ngày hiện tại
			if (ngayDat > DateTime.Now)
			{
				MessageBox.Show("Ngày đặt không được lớn hơn ngày hiện tại.");
				return;
			}

			// Ràng buộc ngày dùng không nhỏ hơn ngày đặt và không lớn hơn ngày hiện tại
			if (ngayDung < ngayDat)
			{
				MessageBox.Show("Ngày dùng không được nhỏ hơn ngày đặt.");
				return;
			}


			// Kiểm tra và chuyển đổi chuỗi ngày sang DateTime			
			if (!DateTime.TryParse(this.ngayDat.Text, out ngayDat))
			{
				MessageBox.Show("Ngày đặt không hợp lệ.");
				return;
			}

			using (SqlConnection conn = dc.GetConnect())
			{
				string maKHSql = @" SELECT MaKH FROM KhachHang WHERE CCCD = @cccd";

				string maKH = null;
				conn.Open();

				using (SqlCommand cmd = new SqlCommand(maKHSql, conn))
				{
					cmd.Parameters.AddWithValue("@cccd", cccd); // Sử dụng cccd đã được truyền vào


					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						maKH = result.ToString(); // Lấy MaKH
					}
				}

				// Insert into table HDMon and retrieve MaHDMon
				string hoaDonMonSql = @"
									INSERT INTO HoaDonMon (MaHDM, MaKH, MaNV, NgayDat) 
									OUTPUT INSERTED.MaHDM
									VALUES (dbo.GenerateMaHDM(), @maKH, @maNV, @ngayDat)";

				string generatedMaHDMon = null;

				using (SqlCommand cmd = new SqlCommand(hoaDonMonSql, conn))
				{
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maNV", "NV002");
					cmd.Parameters.AddWithValue("@ngayDat", ngayDat);

					generatedMaHDMon = (string)cmd.ExecuteScalar(); // Lấy MaHDMon
				}

				// Lấy MaMon từ tên món
				string maMonSql = @"SELECT MaMon FROM Mon WHERE TenMon = @tenMon";

				string maMon = null;

				using (SqlCommand cmd = new SqlCommand(maMonSql, conn))
				{
					cmd.Parameters.AddWithValue("@tenMon", comboTenMon.Text); // tenMon là tên món bạn đã có

					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						maMon = result.ToString(); // Lấy MaMon
					}
				}

				// Kiểm tra xem có tìm thấy MaMon không trước khi chèn vào CTHDMon
				string generatedMaCTHDM = null;
				if (maMon != null)
				{

					// Insert into CTHDMon and retrieve MaCTHDMon
					string cthdMonSql = @"INSERT INTO CTHDMon (MaCTHDM, MaHDM, MaMon, SL_Mon, MaP, NgaySD, TrangThai) 
										 OUTPUT INSERTED.MaCTHDM
										VALUES (dbo.GenerateMaCTHDM(), @maHDM, @maMon, @slMon, @maP, @ngaySD, @trangThai)";

					using (SqlCommand cmd = new SqlCommand(cthdMonSql, conn))
					{
						cmd.Parameters.AddWithValue("@maHDM", generatedMaHDMon); // MaHDMon đã được tạo
						cmd.Parameters.AddWithValue("@maMon", maMon); // Mã món
						cmd.Parameters.AddWithValue("@slMon", soLuong.Text); // Số lượng món
						cmd.Parameters.AddWithValue("@maP", maPhong.Text); // Mã phòng
						cmd.Parameters.AddWithValue("@ngaySD", ngaySD.Text); // Ngày sử dụng món
						cmd.Parameters.AddWithValue("@trangThai", comboTT.Text); // Trạng thái

						generatedMaCTHDM = (string)cmd.ExecuteScalar(); // Lấy MaCTHDMon

					}
				}

				// Lấy MaHD 
				string maHDQuery = @"select HoaDon.MaHD from HoaDon join HoaDonPhong on HoaDonPhong.MaKH=HoaDon.MaKH 
									join CTHDPhong on CTHDPhong.MaHDP=HoaDonPhong.MaHDP
									WHERE HoaDon.MaKH = @maKH";

				string maHD = null;

				using (SqlCommand cmd = new SqlCommand(maHDQuery, conn))
				{
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maP", maPhong.Text); // Số phòng

					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						maHD = result.ToString(); // Lấy MaHD
					}
				}

				// Tạo hóa đơn mới
				string hoaDonSql = @"
									INSERT INTO HoaDon (MaHD, MaKH, MaNV, MaLoaiHD, NgayXuatHD, TrangThai) 
									OUTPUT INSERTED.MaHD 
									VALUES (@maHD, @maKH, 'NV002', @maLoaiHD, NULL, @trangThai)";

				using (SqlCommand cmd = new SqlCommand(hoaDonSql, conn))
				{
					cmd.Parameters.AddWithValue("@maHD", maHD);
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maLoaiHD", generatedMaHDMon);
					cmd.Parameters.AddWithValue("@trangThai", comboTT.Text);

					cmd.ExecuteNonQuery();
				}

				// Insert into CTHoaDon
				string CTHD = "INSERT INTO CTHD (MaCTHD, MaHD, MaLoaiHD, MaKH, MaLoaiCTHD) VALUES" +
							 "(dbo.GenerateMaCTHD(), @maHD, @maLoaiHD, @maKH,@maLoaiCTHD)";

				using (SqlCommand cmd = new SqlCommand(CTHD, conn))
				{
					cmd.Parameters.AddWithValue("@maHD", maHD);
					cmd.Parameters.AddWithValue("@maLoaiHD", generatedMaHDMon); // Use the generated MaHDMon
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maLoaiCTHD", generatedMaCTHDM); // Use the generated MaCTHDMon

					cmd.ExecuteNonQuery();
					MessageBox.Show("Cập nhật thành công!");
				}
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			var phong = new PhongInfo();
			phong.ShowDialog();
		}

		private void AddHDM_Load(object sender, EventArgs e)
		{
			LoadDish();
		}
	}
}
