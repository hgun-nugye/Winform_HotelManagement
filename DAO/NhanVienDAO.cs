using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DTO;

namespace HotelManagement.DAO
{
    internal class NhanVienDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhanVienDAO()
        {
            dc = new DataConnection();
        }

        // Lấy thông tin
        public DataTable getAllNhanVien()
        {
            // Tạo lệnh - Mở kết nối - Tạo adap/command - Đổ dữ liệu/ xử lý dữ liệu đầu - đóng cổng
            string sql = "SELECT * FROM NhanVien";
            SqlConnection con = dc.GetConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Thêm nhân viên
        public bool insertNhanVien(NhanVienDTO nv)
        {
            string sql = "INSERT INTO NhanVien(MaNV, CCCD, HoTen, NgaySinh, GioiTinh, ChucVu, SDT_NV, Email_NV, DiaChi, SoBHYT, SoHopDong, NamBatDau, MaSoThueCaNhan) VALUES (@MaNV, @CCCD, @HoTen, @NgaySinh, @GioiTinh, @ChucVu, @SDT_NV, @Email_NV, @DiaChi, @SoBHYT, @SoHopDong, @NamBatDau, @MaSoThueCaNhan)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open() ;
                }
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = nv.CCCD;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;
                cmd.Parameters.Add("@SDT_NV", SqlDbType.VarChar).Value = nv.SDT_NV;
                cmd.Parameters.Add("@Email_NV", SqlDbType.VarChar).Value = nv.Email_NV;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@SoBHYT", SqlDbType.VarChar).Value = nv.SoBHYT;
                cmd.Parameters.Add("@SoHopDong", SqlDbType.VarChar).Value = nv.SoHopDong;
                cmd.Parameters.Add("@NamBatDau", SqlDbType.Int).Value = nv.NamBatDau;
                cmd.Parameters.Add("@MaSoThueCaNhan", SqlDbType.VarChar).Value = nv.MaSoThueCaNhan;
                // Exu
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        // Update
        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            string sql = "UPDATE NhanVien SET MaNV = @MaNV, CCCD = @CCCD, HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, ChucVu = @ChucVu, SDT_NV = @SDT_NV, Email_NV = @Email_NV, SoBHYT = @SoBHYT, SoHopDong = @SoHopDong, NamBatDau = @NamBatDau, MaSoThueCaNhan=@MaSoThueCaNhan WHERE MaNV = @MaNV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = nv.CCCD;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;
                cmd.Parameters.Add("@SDT_NV", SqlDbType.VarChar).Value = nv.SDT_NV;
                cmd.Parameters.Add("@Email_NV", SqlDbType.VarChar).Value = nv.Email_NV;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@SoBHYT", SqlDbType.VarChar).Value = nv.SoBHYT;
                cmd.Parameters.Add("@SoHopDong", SqlDbType.VarChar).Value = nv.SoHopDong;
                cmd.Parameters.Add("@NamBatDau", SqlDbType.Int).Value = nv.NamBatDau;
                cmd.Parameters.Add("@MaSoThueCaNhan", SqlDbType.VarChar).Value = nv.MaSoThueCaNhan;
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
        public bool DeleteNhanVien(NhanVienDTO nv)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
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
        public DataTable FindNhanVien(string cons)
        {
            string sql = "SELECT * FROM NhanVien WHERE Hoten LIKE N'%" + cons +"%' OR MaNV LIKE '%" + cons + "%' OR CCCD LIKE '%" + cons + "$'";
            SqlConnection con = dc.GetConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close() ;
            return dt;
        }
    }
}
