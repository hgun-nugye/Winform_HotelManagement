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
			if (!DateTime.TryParse(this.NgayDat.Text, out ngayDat))
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

				// Insert into table HDDV and retrieve MaHDDV
				string hoaDonDichVuSql = @"
									INSERT INTO HoaDonDV (MaHDDV, MaKH, MaNV, NgayDat) 
									OUTPUT INSERTED.MaHDDV
									VALUES (dbo.GenerateMaHDDV(), @maKH, @maNV, @ngayDat)";

				string generatedMaHDDV = null;

				using (SqlCommand cmd = new SqlCommand(hoaDonDichVuSql, conn))
				{
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maNV", "NV002");
					cmd.Parameters.AddWithValue("@ngayDat", ngayDat);

					generatedMaHDDV = (string)cmd.ExecuteScalar(); // Lấy MaHDDV
				}

				// Lấy MaDichVu từ tên dịch vụ
				string maDichVuSql = @"SELECT MaDV FROM DichVu WHERE TenDV = @tenDichVu";

				string maDichVu = null;

				using (SqlCommand cmd = new SqlCommand(maDichVuSql, conn))
				{
					cmd.Parameters.AddWithValue("@tenDichVu", comboTenDV.Text); // tenDichVu là tên dịch vụ bạn đã có

					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						maDichVu = result.ToString(); // Lấy MaDichVu
					}
				}

				//int soLuongValue;
				// Kiểm tra xem có tìm thấy MaDV không trước khi chèn vào CTHDDV
				string generatedMaCTHDDV= null;
				if (maDichVu != null)
				{

					// Insert into CTHDDV and retrieve MaCTHDDV
					string cthdDVSql = @"INSERT INTO CTHDDichVu (MaCTHDDV, MaHDDV, MaDV, SL_DV, MaP, NgaySD, TrangThai) 
										 OUTPUT INSERTED.MaCTHDDV
										VALUES (dbo.GenerateMaCTHDDV(), @maHDDV, @maDV, @slDV, @maP, @ngaySD, @trangThai)";

					using (SqlCommand cmd = new SqlCommand(cthdDVSql, conn))
					{
						cmd.Parameters.AddWithValue("@maHDDV", generatedMaHDDV); // MaHDDV đã được tạo
						cmd.Parameters.AddWithValue("@maDV", maDichVu); // Mã DV
						cmd.Parameters.AddWithValue("@slDV", soLuong.Text); // Số lượng 
						cmd.Parameters.AddWithValue("@maP", maPhong.Text); // Mã phòng
						cmd.Parameters.AddWithValue("@ngaySD", ngayDung); // Ngày sử dụng 
						cmd.Parameters.AddWithValue("@trangThai", comboTT.Text); // Trạng thái

						//generatedMaCTHDDV = (string)cmd.ExecuteScalar(); // Lấy MaCTHDDV

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
					cmd.Parameters.AddWithValue("@maLoaiHD", generatedMaHDDV);
					cmd.Parameters.AddWithValue("@trangThai", comboTT.Text);

					cmd.ExecuteNonQuery();
				}

				//// Lấy MaCTHDDV
				//string CTHDDVQuery = @"select CTHDDichVu.MaCTHDDV from CTHDDichVu
				//						where CTHDDichVu.MaHDDV=@maHDDV";

				//string maCTDV = null;

				//using (SqlCommand cmd = new SqlCommand(CTHDDVQuery, conn))
				//{
				//	cmd.Parameters.AddWithValue("@maHDDV", generatedMaHDDV); 

				//	var result = cmd.ExecuteScalar();
				//	if (result != null)
				//	{
				//		maCTDV = result.ToString(); // Lấy MaCTHDDichVu
				//	}
				//}

				// Insert into CTHoaDon
				string CTHD = "INSERT INTO CTHD (MaCTHD, MaHD, MaLoaiHD, MaKH, MaLoaiCTHD) VALUES" +
							 "(dbo.GenerateMaCTHD(), @maHD, @maLoaiHD, @maKH,@maLoaiCTHD)";

				using (SqlCommand cmd = new SqlCommand(CTHD, conn))
				{
					cmd.Parameters.AddWithValue("@maHD", maHD);
					cmd.Parameters.AddWithValue("@maLoaiHD", generatedMaHDDV);
					cmd.Parameters.AddWithValue("@maKH", maKH);
					cmd.Parameters.AddWithValue("@maLoaiCTHD", generatedMaCTHDDV);

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

		private void AddHDDV_Load(object sender, EventArgs e)
		{
			LoadService();
		}
	}
}
