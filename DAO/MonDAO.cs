using HotelManagement.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
	internal class MonDAO
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public MonDAO()
		{
			dc = new DataConnection();
		}

		// Lấy thông tin
		public DataTable getAllMon()
		{
			// Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
			string sql = "SELECT * FROM Mon";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		// Thêm mon
		public bool insertMon(MonDTO mon)
		{
			string sql = "INSERT INTO Mon (MaMon, TenMon, GiaMon, TrangThai_Mon) VALUES (@MaMon, @TenMon, @GiaMon, @TrangThai_Mon)";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.Parameters.Add("@MaMon", SqlDbType.VarChar).Value = mon.MaMon;
				cmd.Parameters.Add("@TenMon", SqlDbType.NVarChar).Value = mon.TenMon;
				cmd.Parameters.Add("@GiaMon", SqlDbType.Decimal).Value = mon.GiaMon;
				cmd.Parameters.Add("@TrangThai_Mon", SqlDbType.VarChar).Value = mon.TrangThai_Mon;

				// Exu
				cmd.ExecuteNonQuery();
				MessageBox.Show("Thêm món thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		public bool UpdateMon(MonDTO mon)
		{
			string sql = "UPDATE Mon SET MaMon = @MaMon, TenMon = @TenMon, GiaMon = @GiaMon, TrangThai_Mon = @TrangThai_Mon WHERE MaMon = @MaMon";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaMon", SqlDbType.VarChar).Value = mon.MaMon;
				cmd.Parameters.Add("@TenMon", SqlDbType.NVarChar).Value = mon.TenMon;
				cmd.Parameters.Add("@GiaMon", SqlDbType.Decimal).Value = mon.GiaMon;
				cmd.Parameters.Add("@TrangThai_Mon", SqlDbType.NVarChar).Value = mon.TrangThai_Mon;
				// Exu
				cmd.ExecuteNonQuery();
				MessageBox.Show("Cập nhật món thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		public bool DeleteMon(MonDTO mon)
		{
			string sql = "DELETE FROM Mon WHERE MaMon = @MaMon";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaMon", SqlDbType.VarChar).Value = mon.MaMon;
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
		public DataTable FindMon(string cons)
		{
			string sql = "SELECT * FROM Mon WHERE TenMon LIKE N'%" + cons + "%' OR MaMon LIKE '%" + cons + "%'";
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
