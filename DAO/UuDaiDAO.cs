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
	internal class UuDaiDAO : DaoInterface<UuDaiDTO>
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public UuDaiDAO()
		{
			dc = new DataConnection();
		}

		public DataTable getAll()
		{
			string sql = "SELECT * FROM UuDai";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		public bool Insert(UuDaiDTO nv)
		{
			string sql = "INSERT INTO UuDai(MaUD, TenUD, MucGiam, NgayBD, NgayKT, DieuKien, TrangThai_UD) VAlUES (@MaUD, @TenUD, @MucGiam, @NgayBD, @NgayKT, @DieuKien, @TrangThai_UD)";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.Parameters.Add("@MaUD", SqlDbType.NVarChar).Value = nv.MaUD;
				cmd.Parameters.Add("@TenUD", SqlDbType.NVarChar).Value = nv.TenUD;
				cmd.Parameters.Add("@MucGiam", SqlDbType.Float).Value = nv.MucGiam;
				cmd.Parameters.Add("@NgayBD", SqlDbType.Date).Value = nv.NgayBD;
				cmd.Parameters.Add("@NgayKT", SqlDbType.Date).Value = nv.NgayKT;
				cmd.Parameters.Add("@DieuKien", SqlDbType.NVarChar).Value = nv.DieuKien;
				cmd.Parameters.Add("@TrangThai_UD", SqlDbType.NVarChar).Value = nv.TrangThai_UD;
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối! Không thể chèn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		public bool Update(UuDaiDTO nv)
		{
			string sql = "UPDATE UuDai SET MaUD = @MaUD, TenUD = @TenUD,  MucGiam = @MucGiam, NgayBD = @NgayBD, NgayKT = @NgayKT, DieuKien = @DieuKien, TrangThai_UD = @TrangThai_UD WHERE MaUD = @MaUD";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaUD", SqlDbType.NVarChar).Value = nv.MaUD;
				cmd.Parameters.Add("@TenUD", SqlDbType.NVarChar).Value = nv.TenUD;
				cmd.Parameters.Add("@MucGiam", SqlDbType.Float).Value = nv.MucGiam;
				cmd.Parameters.Add("@NgayBD", SqlDbType.Date).Value = nv.NgayBD;
				cmd.Parameters.Add("@NgayKT", SqlDbType.Date).Value = nv.NgayKT;
				cmd.Parameters.Add("@DieuKien", SqlDbType.NVarChar).Value = nv.DieuKien;
				cmd.Parameters.Add("@TrangThai_UD", SqlDbType.NVarChar).Value = nv.TrangThai_UD;
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

		public bool Delete(UuDaiDTO nv)
		{
			string sql = "DELETE FROM UdDai WHERE MaUD = @MaUD";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaUD", SqlDbType.NVarChar).Value = nv.MaUD;
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

		public DataTable FindUuDai(string cons)
		{
			string sql = "SELECT * FROM UuDai WHERE TenUD LIKE N'%" + cons + "%'";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		public DataTable FindUuDaiToTime(DateTime fromDate, DateTime toDate)
		{
			string sql = "SELECT * FROM UuDai WHERE NgayBD >= @fromDate AND NgayKT <= @toDate";
			SqlConnection con = dc.GetConnect();
			SqlCommand cmd = new SqlCommand(sql, con);
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
			cmd.Parameters.AddWithValue("@fromDate", fromDate);
			cmd.Parameters.AddWithValue("@toDate", toDate);

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
	}
}
