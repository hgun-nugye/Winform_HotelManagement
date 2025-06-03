using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class Checkout : Form
	{
		DataConnection dc = new DataConnection();
		private string maloaiHD = string.Empty; // Biến để lưu mã loại hóa đơn nếu cần sử dụng sau này
		public Checkout()
		{
			InitializeComponent();
		}
		public void LoadUsedRooms()
		{
			try
			{
				// Xóa các mục cũ trong ComboBox trước khi load mới
				listPhong.Items.Clear();

				// Thêm một item mặc định (nếu cần)
				listPhong.Items.Add("-- Chọn phòng --");
				listPhong.SelectedIndex = 0;

				using (SqlConnection conn = dc.GetConnect())
				{
					string query = @"SELECT MaP, TrangThai 
                           FROM Phong 
                           WHERE TrangThai = N'Đang sử dụng' OR TrangThai = N'Đã đặt'
                           ORDER BY MaP"; // Sắp xếp theo mã phòng

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						conn.Open();
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								string maP = reader["MaP"].ToString();
								string trangThai = reader["TrangThai"].ToString();

								// Thêm vào ComboBox với định dạng: Mã phòng - Trạng thái
								listPhong.Items.Add(maP);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Checkout_Load(object sender, EventArgs e)
		{
			LoadUsedRooms();
		}
		private void dataCheckout(object sender, EventArgs e)
		{
			string maP = listPhong.SelectedItem.ToString();
			string maHD = textMaHD.Text;
			if (string.IsNullOrEmpty(maP))
			{
				MessageBox.Show("Vui lòng chọn phòng và nhập mã hóa đơn.");
				return;
			}
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

			string CCCD = textCCCD.Text;
			string hoTen = textHoTen.Text;
			string tongtien;
			string trangThai;

			using (SqlConnection con = dc.GetConnect())
			{
				con.Open();
				//show maHD
				string sql = @"SELECT hd.MaHD, hd.MaLoaiHD
								FROM HoaDon hd
								JOIN HoaDonPhong hdp ON hd.MaLoaiHD = hdp.MaHDP
								JOIN CTHDPhong ctp ON ctp.MaHDP = hdp.MaHDP
								JOIN Phong p ON p.MaP = ctp.MaP
								WHERE p.MaP = @maP;";
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.AddWithValue("@MaP", maP);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						maHD = reader["MaHD"].ToString();
						textMaHD.Text = maHD;
						// Nếu cần, có thể lưu maLoaiHD từ đây, nhưng hiện tại không sử dụng nó
						maloaiHD = reader["MaLoaiHD"].ToString();
					}
					else
					{
						MessageBox.Show("Không tìm thấy hóa đơn cho phòng này.");
						return;
					}
					reader.Close();

				}

				//show CCCD and hoTen
				string khachhang = @"SELECT kh.CCCD, kh.HoTen 
									 FROM KhachHang kh
									 JOIN HoaDon hd ON hd.MaKH = kh.MaKH
									 WHERE hd.MaHD = @MaHD;";
				using (SqlCommand cmd = new SqlCommand(khachhang, con))
				{
					cmd.Parameters.AddWithValue("@MaHD", maHD);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						CCCD = reader["CCCD"].ToString();
						textCCCD.Text = CCCD;
						hoTen = reader["HoTen"].ToString();
						textHoTen.Text = hoTen;
					}
					else
					{
						MessageBox.Show("Không tìm thấy thông tin khách hàng cho hóa đơn này.");
						return;
					}
					reader.Close();
				}

				//show NgayNhan
				string ngayNhanQuery = @"SELECT NgayNhan FROM CTHDPhong WHERE MaP = @MaP";
				using (SqlCommand cmd = new SqlCommand(ngayNhanQuery, con))
				{
					cmd.Parameters.AddWithValue("@MaP", maP);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						ngayNhan = Convert.ToDateTime(reader["NgayNhan"]);
						inputNgayNhan.Text = ngayNhan.ToString("dd-MM-yyyy"); // Định dạng ngày tháng theo chuẩn SQL
					}
					else
					{
						MessageBox.Show("Không tìm thấy ngày nhận cho phòng này.");
						return;
					}
					reader.Close();

				}

				//show TongTien
				string tongTienQuery = @"SELECT COALESCE(
											SUM(
												CASE 
													WHEN DATEDIFF(DAY, ctp.NgayNhan, ctp.NgayTra) = 0 THEN 1 
													ELSE DATEDIFF(DAY, ctp.NgayNhan, ctp.NgayTra) 
												END * p.GiaMacDinh
											) +
											COALESCE(SUM(DV.GiaDV * ctdv.SL_DV), 0) +
											COALESCE(SUM(M.GiaMon * ctm.SL_Mon), 0),
											0
										) AS TotalCost
							FROM CTHDPhong ctp
							JOIN Phong p ON ctp.MaP = p.MaP
							LEFT JOIN CTHDDichVu ctdv ON ctp.MaHDP = ctdv.MaHDDV
							LEFT JOIN DichVu DV ON ctdv.MaDV = DV.MaDV
							LEFT JOIN CTHDMon ctm ON ctp.MaHDP = ctm.MaHDM
							LEFT JOIN Mon M On M.MaMon=ctm.MaMon
							WHERE ctp.MaP = @MaP
							GROUP BY p.MaP;";
				using (SqlCommand cmd = new SqlCommand(tongTienQuery, con))
				{
					cmd.Parameters.AddWithValue("@MaP", maP);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						decimal totalCost = reader["TotalCost"] != DBNull.Value ?
							Convert.ToDecimal(reader["TotalCost"]) : 0;
						totalCost = Math.Round(totalCost, 2);
						textTongTien.Text = totalCost.ToString("N0");
					}
					else
					{
						MessageBox.Show("Không tìm thấy tổng tiền cho phòng này.");
						return;
					}
					reader.Close();

				}
			}
		}

		private void completeCheckout(object sender, EventArgs e)
		{
			string maP = listPhong.SelectedItem.ToString();
			string maHD = textMaHD.Text;
			if (string.IsNullOrEmpty(maP) || string.IsNullOrEmpty(maHD))
			{
				MessageBox.Show("Vui lòng chọn phòng và nhập mã hóa đơn.");
				return;
			}
			// Kiểm tra và chuyển đổi chuỗi ngày trả sang DateTime
			DateTime ngayTra;
			string CCCD = textCCCD.Text;
			string hoTen = textHoTen.Text;
			DateTime ngayNhan;
			string tongtien = textTongTien.Text;
			string trangThai = comboBoxTrangThai.SelectedItem.ToString();

			if (!DateTime.TryParse(inputNgayTra.Text, out ngayTra))
			{
				MessageBox.Show("Ngày trả không hợp lệ.");
				return;
			}
			using (SqlConnection con = dc.GetConnect())
			{
				con.Open();
				//update CTHDPhong
				string cthdPhong = @"UPDATE CTHDPhong SET NgayTra = @NgayTra, TrangThai = N'Đã thanh toán' WHERE MaP = @MaP";
				using (SqlCommand cmd = new SqlCommand(cthdPhong, con))
				{
					cmd.Parameters.AddWithValue("@MaP", maP);
					cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
					cmd.ExecuteNonQuery();
				}

				//insert tongtien into Doanhthu
				string insertDoanhThu = @"INSERT INTO DoanhThu (MaHD, MaLoaiHD, TongTien, NgayXuatHD) 
                          VALUES (@MaHD, @MaLoaiHD, @TongTien, @NgayXuatHD)";

				using (SqlCommand cmd = new SqlCommand(insertDoanhThu, con))
				{
					cmd.Parameters.AddWithValue("@MaHD", maHD);
					cmd.Parameters.AddWithValue("@MaLoaiHD", maloaiHD);
					cmd.Parameters.AddWithValue("@TongTien", decimal.Parse(tongtien, System.Globalization.CultureInfo.InvariantCulture)); // Ensure correct parsing
					cmd.Parameters.AddWithValue("@NgayXuatHD", ngayTra);

					try
					{
						int rowsAffected = cmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							MessageBox.Show("Đã cập nhật doanh thu thành công!");
						}
						else
						{
							MessageBox.Show("Không thể cập nhật doanh thu.");
						}
					}
					catch (SqlException ex)
					{
						MessageBox.Show("Lỗi: " + ex.Message); // Display error message
					}
				}

				//update status of the room
				string phong = @"UPDATE Phong SET TrangThai = N'Trống' WHERE MaP = @MaP";
				using (SqlCommand cmd = new SqlCommand(phong, con))
				{
					cmd.Parameters.AddWithValue("@MaP", maP);
					//cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
					cmd.ExecuteNonQuery();
				}

				//update status of the HoaDon
				string hoadonTT = @"UPDATE HoaDon SET NgayXuatHD = @NgayTra, TrangThai=N'Đã thanh toán' WHERE MaHD = @MaHD";
				using (SqlCommand cmd = new SqlCommand(hoadonTT, con))
				{
					cmd.Parameters.AddWithValue("@MaHD", maHD);
					cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
					cmd.ExecuteNonQuery();
				}
			}
			MessageBox.Show("Trả phòng thành công!");
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
		}
		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
		}
	}
}
