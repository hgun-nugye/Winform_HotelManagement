using HotelManagement.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
	internal class HoaDonDAO
	{
		DataConnection dc;
		SqlDataAdapter da;

		public HoaDonDAO()
		{
			dc = new DataConnection();
		}

		public DataTable getAllHoaDon()
		{
			string sql = "WITH TongHoaDon AS ( " +
							" SELECT H.MaHD, H.MaKH, H.MaNV, H.NgayXuatHD, H.TrangThai, " +
							" FORMAT(SUM(COALESCE(CTM.SL_Mon * M.GiaMon, 0) + " +
							" COALESCE(CTHDDV.SL_DV * DV.GiaDV, 0) + " +
							" COALESCE(" +
							" CASE " +
							" WHEN DATEDIFF(DAY, CTP.NgayNhan, CTP.NgayTra) = 0 THEN 1 " +
							" ELSE DATEDIFF(DAY, CTP.NgayNhan, CTP.NgayTra) " +
							" END * P.GiaMacDinh, 0)), 'N0') AS TongHoaDon " + 
							" FROM HoaDon H " +
							" LEFT JOIN CTHD CTHD ON H.MaHD = CTHD.MaHD " +
							" LEFT JOIN CTHDPhong CTP ON CTHD.MaLoaiCTHD = CTP.MaCTHDP " +
							" LEFT JOIN CTHDMon CTM ON CTHD.MaLoaiCTHD = CTM.MaCTHDM " +
							" LEFT JOIN CTHDDichVu CTHDDV ON H.MaHD = CTHDDV.MaHDDV " +
							" LEFT JOIN DichVu DV ON CTHDDV.MaDV = DV.MaDV " +
							" LEFT JOIN Mon M ON CTM.MaMon = M.MaMon " +
							" LEFT JOIN Phong P ON CTP.MaP = P.MaP " +
							" GROUP BY H.MaHD, H.MaKH, H.MaNV, H.NgayXuatHD, H.TrangThai " +
							")" +
							" SELECT MaHD, MaKH, MaNV, NgayXuatHD, TongHoaDon, TrangThai " +
							" FROM TongHoaDon";

			using (SqlConnection con = dc.GetConnect())
			{
				con.Open();
				SqlDataAdapter da = new SqlDataAdapter(sql, con);
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}

		//update 
		public bool UpdateHoaDon(HoaDonDTO hd)
		{
			try
			{
				// Kiểm tra MaLoaiHD
				if (string.IsNullOrEmpty(hd.MaLoaiHD))
				{
					MessageBox.Show("Chưa nhập Mã loại hóa đơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				// Lấy loại hóa đơn hiện tại từ cơ sở dữ liệu
				string currentLoaiHD = GetCurrentLoaiHD(hd.MaHD);

				if (currentLoaiHD != hd.MaLoaiHD)
				{
					// Nếu loại hóa đơn khác, thêm một dòng mới
					return insertHoaDon(hd);
				}
				else
				{
					// Nếu loại hóa đơn giống, cập nhật
					string sql = "UPDATE HoaDon SET MaKH=@MaKH, MaNV=@MaNV, " +
								 "NgayXuatHD=@NgayXuatHD, TrangThai=@TrangThai WHERE MaHD=@MaHD";
					using (SqlConnection con = dc.GetConnect())
					{
						using (SqlCommand cmd = new SqlCommand(sql, con))
						{
							con.Open();
							cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = hd.MaHD;
							cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hd.MaKH;
							cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hd.MaNV;
							cmd.Parameters.Add("@NgayXuatHD", SqlDbType.Date).Value = hd.NgayXuatHD;
							cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = hd.TrangThai;

							cmd.ExecuteNonQuery();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		private string GetCurrentLoaiHD(string maHD)
		{
			string loaiHD = null;
			string sql = "SELECT MaLoaiHD FROM HoaDon WHERE MaHD = @MaHD";

			using (SqlConnection con = dc.GetConnect())
			{
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = maHD;
					con.Open();
					loaiHD = cmd.ExecuteScalar() as string;
				}
			}
			return loaiHD;
		}

		public bool insertHoaDon(HoaDonDTO hd)
		{
			string sql = "INSERT INTO HoaDon (MaHD, MaKH, MaNV, MaLoaiHD, NgayXuatHD, TrangThai) " +
						 "VALUES(@MaHD, @MaKH, @MaNV, @MaLoaiHD, @NgayXuatHD, @TrangThai)";

			using (SqlConnection con = dc.GetConnect())
			{
				try
				{
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						con.Open();
						cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = hd.MaHD;
						cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hd.MaKH;
						cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hd.MaNV;
						cmd.Parameters.Add("@MaLoaiHD", SqlDbType.VarChar).Value = hd.MaLoaiHD;
						cmd.Parameters.Add("@NgayXuatHD", SqlDbType.Date).Value = hd.NgayXuatHD;
						cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = hd.TrangThai;

						cmd.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}

		public bool DeleteHoaDon(HoaDonDTO hd)
		{
			string sql = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
			using (SqlConnection con = dc.GetConnect())
			{
				try
				{
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						con.Open();
						cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = hd.MaHD;
						cmd.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}

		public DataTable FindHoaDon(string cons)
		{
			string sql = "SELECT * FROM HoaDon WHERE MaHD LIKE @Search OR MaNV LIKE @Search OR MaKH LIKE @Search";
			using (SqlConnection con = dc.GetConnect())
			{
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.Add("@Search", SqlDbType.NVarChar).Value = "%" + cons + "%";
					con.Open();
					da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					return dt;
				}
			}
		}
	}
}