using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class Checkin : Form
	{
		DataConnection dc = new DataConnection();

		public Checkin()
		{
			InitializeComponent();
		}

		public void LoadAvailableRooms()
		{
			using (SqlConnection conn = dc.GetConnect())
			{
				string query = "\tSELECT MaP FROM Phong WHERE Phong.TrangThai=N'Trống';";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();

					// Xóa các mục cũ trong ComboBox
					listPhong.Items.Clear();

					while (reader.Read())
					{
						// Thêm phòng trống vào ComboBox
						listPhong.Items.Add(reader["MaPhong"].ToString());
					}
				}
			}
		}

		private void dataCheckin(object sender, EventArgs e)
		{
			DateTime ngayNhan;
			DateTime ngayTra;

			// Kiểm tra và chuyển đổi chuỗi ngày sang DateTime
			if (!DateTime.TryParse(inputNgayNhan.Text, out ngayNhan))
			{
				MessageBox.Show("Ngày nhận không hợp lệ.");
				return;
			}

			if (!DateTime.TryParse(inputNgayTra.Text, out ngayTra))
			{
				MessageBox.Show("Ngày trả không hợp lệ.");
				return;
			}

			// Ràng buộc ngày trả không nhỏ hơn ngày nhận và không lớn hơn ngày hiện tại
			if (ngayTra < ngayNhan)
			{
				MessageBox.Show("Ngày trả không được nhỏ hơn ngày nhận.");
				return;
			}

			if (ngayNhan > DateTime.Now || ngayTra > DateTime.Now)
			{
				MessageBox.Show("Ngày nhận và ngày trả không được lớn hơn ngày giờ hiện tại.");
				return;
			}

			string cccd = textCCCD.Text;
			string hoTen = textHoTen.Text;
			string gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
			string quocTich = textQuocTich.Text;
			string soDienThoai = textSDT.Text;
			string email = textEmail.Text;
			string diaChi = textDiaChi.Text;
			string phong = listPhong.SelectedItem.ToString();
			string trangThai = comboTT.SelectedItem.ToString();

			using (SqlConnection conn = dc.GetConnect())
			{
				// Insert into KhachHang and retrieve MaKH
				string KH = "INSERT INTO KhachHang (MaKH, CCCD, SDT_KH, GioiTinh, HoTen, DiaChi, QuocTich, Email_KH) " +
							 "OUTPUT INSERTED.MaKH " +
							 "VALUES (dbo.GenerateMaKH(), @cccd, @soDienThoai, @gioiTinh, @hoTen, @diaChi, @quocTich, @Email)";

				string generatedMaKH;

				using (SqlCommand cmd = new SqlCommand(KH, conn))
				{
					cmd.Parameters.AddWithValue("@cccd", cccd);
					cmd.Parameters.AddWithValue("@hoTen", hoTen);
					cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
					cmd.Parameters.AddWithValue("@quocTich", quocTich);
					cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);
					cmd.Parameters.AddWithValue("@Email", email);
					cmd.Parameters.AddWithValue("@diaChi", diaChi);

					conn.Open();
					generatedMaKH = (string)cmd.ExecuteScalar();
				}

				// Update Status of the room to "Đã đặt"
				string updateRoomStatus = "UPDATE Phong SET TrangThai = N'Đã đặt' WHERE MaP = @maPhong";
				using (SqlCommand cmd = new SqlCommand(updateRoomStatus, conn))
				{
					cmd.Parameters.AddWithValue("@maPhong", phong);
					cmd.ExecuteNonQuery();
				}

				// Insert into HoaDonPhong and retrieve MaHDP
				string HDPhong = "INSERT INTO HoaDonPhong (MaHDP, MaNV, MaKH, NgayDat) " +
								 "OUTPUT INSERTED.MaHDP " +
								 "VALUES (dbo.GenerateMaHDP(), 'NV002', @maKH, @ngayNhan)";

				string generatedMaHDP;

				using (SqlCommand cmd = new SqlCommand(HDPhong, conn))
				{
					cmd.Parameters.AddWithValue("@maKH", generatedMaKH);
					cmd.Parameters.AddWithValue("@ngayNhan", ngayNhan);

					generatedMaHDP = (string)cmd.ExecuteScalar(); // Get the generated MaHDP
				}

				// Insert into CTHoaDonPhong and retrieve MaCTHDP
				string CTHDPhong = "INSERT INTO CTHDPhong (MaCTHDP, MaHDP, MaP, NgayNhan, NgayTra, MaUD, TrangThai)" +
								 "OUTPUT INSERTED.MaCTHDP " +
								 "VALUES (dbo.GenerateMaCTHDP(), @maHDP, @maP, @ngayNhan, @ngayTra, NULL, @trangThai)";

				string generatedMaCTHDP;

				using (SqlCommand cmd = new SqlCommand(CTHDPhong, conn))
				{
					cmd.Parameters.AddWithValue("@maHDP", generatedMaHDP);
					cmd.Parameters.AddWithValue("@maP", phong);
					cmd.Parameters.AddWithValue("@ngayNhan", ngayNhan);
					cmd.Parameters.AddWithValue("@ngayTra", ngayTra);
					cmd.Parameters.AddWithValue("@trangThai", trangThai);

					generatedMaCTHDP = (string)cmd.ExecuteScalar(); // Get the generated MaCTHDP
				}

				// Insert into HoaDon retrieve MaHD
				string HD = "INSERT INTO HoaDon (MaHD, MaKH, MaNV, MaLoaiHD, NgayXuatHD, MaUD, TrangThai) " +
					 "OUTPUT INSERTED.MaHD " +
							 " VALUES (dbo.GenerateMaHD(), @maKH, 'NV002', @maLoaiHD, NULL, NULL, @trangThai)";
				string generatedMaHD;

				using (SqlCommand cmd = new SqlCommand(HD, conn))
				{
					cmd.Parameters.AddWithValue("@maKH", generatedMaKH);
					cmd.Parameters.AddWithValue("@maLoaiHD", generatedMaHDP); // Use the generated MaHDP
					cmd.Parameters.AddWithValue("@trangThai", trangThai);

					generatedMaHD = (string)cmd.ExecuteScalar(); // Get the generated MaHD
				}

				// Insert into CTHoaDon
				string CTHD = "INSERT INTO CTHD (MaCTHD, MaHD, MaLoaiHD, MaKH, MaLoaiCTHD) VALUES" +
							 "(dbo.GenerateMaCTHD(), @maHD, @maLoaiHD, @maKH,@maLoaiCTHD)";

				using (SqlCommand cmd = new SqlCommand(CTHD, conn))
				{
					cmd.Parameters.AddWithValue("@maHD", generatedMaHD);
					cmd.Parameters.AddWithValue("@maLoaiHD", generatedMaHDP); // Use the generated MaHDP
					cmd.Parameters.AddWithValue("@maKH", generatedMaKH);
					cmd.Parameters.AddWithValue("@maLoaiCTHD", generatedMaCTHDP); // Use the generated MaCTHDP

					cmd.ExecuteNonQuery();
					MessageBox.Show("Cập nhật thành công!");
				}
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
		}

		private void listPhong_DropDown(object sender, EventArgs e)
		{
			using (SqlConnection conn = dc.GetConnect())
			{
				string query = "SELECT MaP FROM Phong WHERE Phong.TrangThai = N'Trống';";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();

					// Xóa các mục cũ trong ComboBox
					listPhong.Items.Clear();

					while (reader.Read())
					{
						// Kiểm tra nếu giá trị không phải là DBNull
						if (!reader.IsDBNull(reader.GetOrdinal("MaP")))
						{
							// Thêm phòng trống vào ComboBox
							listPhong.Items.Add(reader["MaP"].ToString());
						}
					}
				}
			}
		}
	}
}
