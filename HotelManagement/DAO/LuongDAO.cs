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
    internal class LuongDAO : DaoInterface<LuongDTO>
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public LuongDAO()
        {
            dc = new DataConnection();
        }

        public DataTable getAll()
        {
            string sql = "SELECT * FROM Luong";
            SqlConnection con = dc.GetConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Insert(LuongDTO nv)
        {
            string sql = "INSERT INTO Luong(MaNV, MucLuong, Thuong, Phat, PhuCap, ThangLuong) VALUES (@MaNV, @MucLuong, @Thuong, @Phat, @PhuCap, @ThangLuong)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@MucLuong", SqlDbType.Decimal).Value = nv.MucLuong;
                cmd.Parameters.Add("@Thuong", SqlDbType.Decimal).Value = nv.Thuong;
                cmd.Parameters.Add("@Phat", SqlDbType.Decimal).Value = nv.Phat;
                cmd.Parameters.Add("@PhuCap", SqlDbType.Decimal).Value = nv.PhuCap;
                cmd.Parameters.Add("@ThangLuong", SqlDbType.Date).Value = nv.ThangLuong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool Update(LuongDTO nv)
        {
            string sql = "UPDATE Luong SET MucLuong = @MucLuong, Thuong = @Thuong, Phat = @Phat, PhuCap = @PhuCap, ThangLuong = @ThangLuong WHERE MaNV = @MaNV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@MucLuong", SqlDbType.Decimal).Value = nv.MucLuong;
                cmd.Parameters.Add("@Thuong", SqlDbType.Decimal).Value = nv.Thuong;
                cmd.Parameters.Add("@Phat", SqlDbType.Decimal).Value = nv.Phat;
                cmd.Parameters.Add("@PhuCap", SqlDbType.Decimal).Value = nv.PhuCap;
                cmd.Parameters.Add("@ThangLuong", SqlDbType.Date).Value = nv.ThangLuong;
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

        public bool Delete(LuongDTO nv)
        {
            string sql = "DELETE FROM Luong WHERE MaNV = @MaNV";
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

        public DataTable FindLuong(string cons)
        {
            SqlConnection con = dc.GetConnect ();
            if(con.State == ConnectionState.Closed)
            {
                con.Open ();
            }
            int month;
            if(int.TryParse(cons, out month))
            {
                string sql = "SELECT * FROM Luong WHERE MONTH(ThangLuong) = @month";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@month", month);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
