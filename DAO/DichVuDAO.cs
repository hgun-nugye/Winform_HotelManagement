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
    internal class DichVuDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public DichVuDAO()
        {
            dc = new DataConnection();
        }
        // Lấy thông tin
        public DataTable getAllDichVu()
        {
            // Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
            string sql = "SELECT * FROM DichVu";
            SqlConnection con = dc.GetConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        // Thêm Dich vu 
        public bool insertDichVu(DichVuDTO dv)
        {
            string sql = "INSERT INTO DichVu (MaDV, TenDV, GiaDV, Loai_DV) VALUES (@MaDV, @TenDV, @GiaDV, @Loai_DV)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = dv.MaDV;
                cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = dv.TenDV;
                cmd.Parameters.Add("@GiaDv", SqlDbType.Decimal).Value = dv.GiaDV;
                cmd.Parameters.Add("@Loai_DV", SqlDbType.NVarChar).Value = dv.Loai_DV;

                // Exu
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				// Đóng kết nối
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
        public bool UpdateDichVu(DichVuDTO dv)
        {
            string sql = "UPDATE DichVu SET MaDV = @MaDV, TenDV = @TenDV, GiaDV = @GiaDV, Loai_DV = @Loai_DV WHERE MaDV = @MaDV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = dv.MaDV;
                cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = dv.TenDV;
                cmd.Parameters.Add("@GiaDV", SqlDbType.Decimal).Value = dv.GiaDV;
                cmd.Parameters.Add("@Loai_DV", SqlDbType.NVarChar).Value = dv.Loai_DV;
                // Exu
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool DeleteDichVu(DichVuDTO dv)
        {
            string sql = "DELETE FROM DichVu WHERE MaDV = @MaDV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = dv.MaDV;
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
        public DataTable FindDichVu(string cons)
        {
            string sql = "SELECT * FROM DichVu WHERE TenDV LIKE N'%" + cons + "%' OR MaDV LIKE '%" + cons + "%'";
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
