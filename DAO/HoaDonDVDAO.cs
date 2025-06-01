using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
	internal class HoaDonDVDAO
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public HoaDonDVDAO()
		{
			dc = new DataConnection();
		}
		// Lấy thông tin
		public DataTable getAllHoaDonDV()
		{
			// Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
			string sql = " SELECT  HDDV.MaHDDV, MaNV, MaKH, NgayDat,CTHDDV.NgaySD,CTHDDV.MaP, DV.TenDV,CTHDDV.SL_DV, CTHDDV.TrangThai,DV.GiaDV * CTHDDV.SL_DV AS \"ThanhTien\" FROM HoaDonDV HDDV JOIN CTHDDichVu CTHDDV ON HDDV.MaHDDV= CTHDDV.MaHDDV JOIN DichVu DV ON CTHDDV.MaDV = DV.MaDV;";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		// Thêm hoa don dich vu
		public bool insertHoaDonDV(HoaDonDVDTO hddv)
		{
			string sql = "INSERT INTO HoaDonDV (MaHDDV, MaNV, MaKH, NgayDat) VALUES (@MaHDDV, @MaNV, @MaKH, @NgayDat)";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.Parameters.Add("@MaHDDV", SqlDbType.VarChar).Value = hddv.MaHDDV;
				cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hddv.MaNV;
				cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hddv.MaKH;
				cmd.Parameters.Add("@NgayDat", SqlDbType.Date).Value = hddv.NgayDat;

				// Exu
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}
		// Update
		public bool UpdateHoaDonDV(HoaDonDVDTO hddv)
		{
			string sql = "UPDATE HoaDonDV SET MaHDDV = @MaHDDV, MaNV = @MaNV, MaKH = @MaKH, NgayDat = @NgayDat WHERE MaHDDV = @MaHDDV";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaHDDV", SqlDbType.VarChar).Value = hddv.MaHDDV;
				cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hddv.MaNV;
				cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = hddv.MaKH;
				cmd.Parameters.Add("@NgayDat", SqlDbType.Date).Value = hddv.NgayDat;
				// Exu
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		// Delete
		public bool DeleteHoaDonDV(HoaDonDVDTO hddv)
		{
			string sql = "DELETE FROM HoaDonDV WHERE MaHDDV = @MaHDDV";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaHDDV", SqlDbType.VarChar).Value = hddv.MaHDDV;
				// Exu
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}
		public DataTable FindHoaDonDV(string cons)
		{
			string sql = "SELECT * FROM HoaDonDV WHERE MaHDDV LIKE '%" + cons + "%'";
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
