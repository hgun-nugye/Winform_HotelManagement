using HotelManagement.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement.DAO
{

	internal class HoaDonPhongDAO
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public HoaDonPhongDAO()
		{
			dc = new DataConnection();
		}
		// Lấy thông tin
		public DataTable getAllHoaDonPhong()
		{
			// Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
			string sql = "SELECT  HDPhong.MaHDP, MaNV, MaKH, NgayDat,CTHDP.NgayNhan,Lp.TenLP, CTHDP.NgayTra,CTHDP.MaP,CTHDP.TrangThai, P.GiaMacDinh*(DATEDIFF(DAY,CTHDP.NgayNhan, CTHDP.NgayTra)) AS \"Thành Tiền\"   FROM HoaDonPhong HDPhong JOIN CTHDPhong CTHDP ON HDPhong.MaHDP = CTHDP.MaHDP  JOIN Phong P ON CTHDP.MaP = P.MaP JOIN LoaiPhong Lp ON Lp.MaLP=P.MaLP";
			SqlConnection con = dc.GetConnect();
			con.Open();
			da = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}
					

		// Delete
		public bool DeleteHoaDonPhong(HoaDonPhongDTO hdp)
		{
			string sql = "DELETE FROM HoaDonPhong WHERE MaHDP = @MaHDP";
			SqlConnection con = dc.GetConnect();
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaHDP", SqlDbType.VarChar).Value = hdp.MaHDP;
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
		public DataTable FindHoaDonPhong(string cons)
		{
			string sql = "SELECT * FROM HoaDonPhong WHERE MaHDP LIKE '%" + cons + "%'";
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
