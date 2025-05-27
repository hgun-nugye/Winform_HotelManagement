using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DAO
{

	internal class HoaDonMonDAO
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public HoaDonMonDAO()
		{
			dc = new DataConnection();
		}
		// Lấy thông tin
		public DataTable getAllHoaDonMon()
		{
			// Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
			string sql = "SELECT  HDMon.MaHDM, MaNV, MaKH, NgayDat,CTHDM.NgaySD,CTHDM.MaP, M.TenMon,CTHDM.SL_Mon, CTHDM.TrangThai,  UDM.MaUD, M.GiaMon * CTHDM.SL_Mon * (1 - ISNULL(UDM.MucGiam, 0) / 100) AS \"Thành Tiền\"  FROM HoaDonMon HDMon JOIN CTHDMon CTHDM ON HDMon.MaHDM = CTHDM.MaHDM JOIN Mon M ON CTHDM.MaMon = M.MaMon LEFT JOIN UuDai UDM ON UDM.MaUD = CTHDM.MaUD ";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		// Thêm hoa don mon
		public bool insertHoaDonMon(HoaDonMonDTO hdmon)
		{
			string sql = "INSERT INTO HoaDonMon (MaHDM, MaNV, MaKH, NgayDat) VALUES (@MaHDM, @MaNV, @MaKH, @NgayDat)";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.Parameters.Add("@MaHDM", SqlDbType.VarChar).Value = hdmon.MaHDM;
				cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hdmon.MaNV;
				cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hdmon.MaKH;
				cmd.Parameters.Add("@NgayDat", SqlDbType.Date).Value = hdmon.NgayDat;

				// Exu
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}
		// Update
		public bool UpdateHoaDonMon(HoaDonMonDTO hdmon)
		{
			string sql = "UPDATE HoaDonMon SET MaHDM = @MaHDM, MaNV = @MaNV, MaKH = @MaKH, NgayDat = @NgayDat WHERE MaHDM = @MaHDM";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaHDM", SqlDbType.VarChar).Value = hdmon.MaHDM;
				cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hdmon.MaNV;
				cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hdmon.MaKH;
				cmd.Parameters.Add("@NgayDat", SqlDbType.Date).Value = hdmon.NgayDat;
				// Exu
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		// Delete
		public bool DeleteHoaDonMon(HoaDonMonDTO hdmon)
		{
			string sql = "DELETE FROM HoaDonMon WHERE MaHDM = @MaHDM";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaHDM", SqlDbType.VarChar).Value = hdmon.MaHDM;
				// Exu
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}
		public DataTable FindHoaDonMon(string cons)
		{
			string sql = "SELECT * FROM HoaDonMon WHERE MaHDM LIKE '%" + cons + "%'";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}
	}
}
