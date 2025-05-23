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
	internal class LichLamDAO : DaoInterface<LichLamDTO>
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public LichLamDAO()
		{
			dc = new DataConnection();
		}

		public DataTable getAll()
		{
			string sql = "SELECT * FROM LichLam";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		public bool Insert(LichLamDTO nv)
		{
			string sql = "INSERT INTO LichLam(NgayLam, MaNV, CaLam) VALUES (@NgayLam, @MaNV, @CaLam)";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.Parameters.Add("@NgayLam", SqlDbType.Date).Value = nv.NgayLam;
				cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
				cmd.Parameters.Add("@CaLam", SqlDbType.NVarChar).Value = nv.CaLam;
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

		public bool Update(LichLamDTO nv)
		{
			string sql = "UPDATE LichLam SET NgayLam = @NgayLam, MaNV = @MaNV, CaLam = @CaLam WHERE MaNV = @MaNV";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@NgayLam", SqlDbType.Date).Value = nv.NgayLam;
				cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
				cmd.Parameters.Add("@CaLam", SqlDbType.NVarChar).Value = nv.CaLam;
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

		public bool Delete(LichLamDTO nv)
		{
			string sql = "DELETE FROM UdDai WHERE MaUD = @MaUD AND NgayLam = @NgayLam";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
				cmd.Parameters.Add("@NgayLam", SqlDbType.Date).Value = nv.NgayLam;
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

		public DataTable FindLichLam(string cons)
		{
			string sql = "SELECT * FROM LichLam WHERE MaNV LIKE @cons OR CONVERT(varchar, NgayLam, 23) LIKE @cons";

			SqlConnection con = dc.GetConnect();
			con.Open();

			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@cons", "%" + cons + "%");

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			con.Close();
			return dt;
		}
	}
}
