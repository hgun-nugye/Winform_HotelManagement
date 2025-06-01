using System.Data;
using System.Data.SqlClient;

namespace HotelManagement.DAO
{
	internal class DoanhThuDAO
	{
		DataConnection dc;
		SqlDataAdapter da;
		public DoanhThuDAO()
		{
			dc = new DataConnection();
		}

		// Lấy thông tin
		public DataTable getAllDoanhThu()
		{
			// Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
			string sql = "SELECT * FROM DoanhThu WHERE MONTH(NgayXuatHD) = MONTH(GETDATE());";
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
