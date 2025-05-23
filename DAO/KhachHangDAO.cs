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
    internal class KhachHangDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public KhachHangDAO()
        {
            dc = new DataConnection();
        }

        // Lấy thông tin
        public DataTable getAllKhachHang()
        {
            // Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
            string sql = "SELECT * FROM KhachHang";
            SqlConnection con = dc.GetConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Thêm khách hàng 
        public bool insertKhachHang(KhachHangDTO kh)
        {
            string sql = "INSERT INTO KhachHang(MaKH, CCCD, SDT_KH, HoTen, GioiTinh, DiaChi, QuocTich, Email_KH) VALUES (@MaKH, @CCCD, @SDT_KH, @HoTen, @GioiTinh, @DiaChi, @QuocTich, @Email_KH)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = kh.MaKH;
                cmd.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = kh.CCCD;
                cmd.Parameters.Add("@SDT_KH", SqlDbType.VarChar).Value = kh.SDT_KH;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.HoTen;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@QuocTich", SqlDbType.NVarChar).Value = kh.QuocTich;
                cmd.Parameters.Add("@Email_KH", SqlDbType.VarChar).Value = kh.Email_KH;

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
        public bool UpdateKhachHang(KhachHangDTO kh)
        {
            string sql = "UPDATE KhachHang SET MaKH = @MaKH, CCCD = @CCCD, HoTen = @HoTen, GioiTinh = @GioiTinh, SDT_KH = @SDT_KH, Email_KH = @Email_KH, DiaChi = @DiaChi, QuocTich = @QuocTich  WHERE MaKH = @MaKH";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = kh.MaKH;
                cmd.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = kh.CCCD;
                cmd.Parameters.Add("@SDT_KH", SqlDbType.VarChar).Value = kh.SDT_KH;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.HoTen;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@QuocTich", SqlDbType.NVarChar).Value = kh.QuocTich;
                cmd.Parameters.Add("@Email_KH", SqlDbType.VarChar).Value = kh.Email_KH;
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
        public bool DeleteKhachHang(KhachHangDTO kh)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = kh.MaKH;
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

        //Tìm nhân viên theo tên hoặc mã hoặc cccd
        public DataTable FindKhachHang(string cons)
        {
            string sql = "SELECT * FROM KhachHang WHERE Hoten LIKE N'%" + cons + "%' OR MaKH LIKE '%" + cons + "%' OR CCCD LIKE '%" + cons + "$'";
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
