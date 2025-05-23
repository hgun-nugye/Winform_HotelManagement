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
	internal class LoaiPhongDAO : DaoInterface<LoaiPhongDTO>
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public LoaiPhongDAO()
		{
			dc = new DataConnection();
		}

		public DataTable getAll()
		{
			string sql = "SELECT * FROM LoaiPhong";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		public bool Insert(LoaiPhongDTO nv)
		{
			string sql = "INSERT INTO LoaiPhong(MaLP, TenLP, SucChua, SoGiuong, DienTich, TienNghi) VALUES (@MaLP, @TenLP, @SucChua, @SoGiuong, @DienTich, @TienNghi)";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.Parameters.Add("@MaLP", SqlDbType.NVarChar).Value = nv.MaLP;
				cmd.Parameters.Add("@TenLP", SqlDbType.NVarChar).Value = nv.TenLP;
				cmd.Parameters.Add("@SucChua", SqlDbType.Int).Value = nv.SucChua;
				cmd.Parameters.Add("@SoGiuong", SqlDbType.Int).Value = nv.SoGiuong;
				cmd.Parameters.Add("@DienTich", SqlDbType.Float).Value = nv.DienTich;
				cmd.Parameters.Add("@TienNghi", SqlDbType.NVarChar).Value = nv.TienNghi;
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

		public bool Update(LoaiPhongDTO nv)
		{
			string sql = "UPDATE LoaiPhong SET MaLP = @MaLP, TenLP = @TenLP, SucChua = @SucChua, SoGiuong = @SoGiuong, DienTich = @DienTich, TienNghi = @TienNghi WHERE MaLP = @MaLP";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaLP", SqlDbType.NVarChar).Value = nv.MaLP;
				cmd.Parameters.Add("@TenLP", SqlDbType.NVarChar).Value = nv.TenLP;
				cmd.Parameters.Add("@SucChua", SqlDbType.Int).Value = nv.SucChua;
				cmd.Parameters.Add("@SoGiuong", SqlDbType.Int).Value = nv.SoGiuong;
				cmd.Parameters.Add("@DienTich", SqlDbType.Float).Value = nv.DienTich;
				cmd.Parameters.Add("@TienNghi", SqlDbType.NVarChar).Value = nv.TienNghi;
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

		public bool Delete(LoaiPhongDTO nv)
		{
			string sql = "DELETE FROM LoaiPhong WHERE MaLP = @MaLP";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaLP", SqlDbType.NVarChar).Value = nv.MaLP;
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

		public DataTable FindLoaiPhong(string cons)
		{
			string sql = "SELECT * FROM LoaiPhong WHERE TenLP LIKE N'%" + cons + "%' OR MaLP LIKE '%" + cons + "%'";
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
