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
    internal class PhongDAO : DaoInterface<PhongDTO>
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PhongDAO()
        {
            dc = new DataConnection();
        }

        public DataTable getAll()
        {
            string sql = @"SELECT P.MaP,P.MaLP, P.TrangThai, P.GiaMacDinh, L.TenLP, L.SucChua, L.SoGiuong, L.DienTich, L.TienNghi FROM Phong P JOIN LoaiPhong L ON P.MaLP = L.MaLP";
            SqlConnection con = dc.GetConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Insert(PhongDTO nv)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open() ;
                }
                //Check tồn tại MaLP
                string checkLP = "SELECT COUNT(*) FROM LoaiPhong WHERE MaLP = @MaLP";
                SqlCommand checkCmd = new SqlCommand(checkLP, con);
                checkCmd.Parameters.AddWithValue("@MaLP", nv.MaLP);
                int count = (int)checkCmd.ExecuteScalar();

                if(count == 0)
                {
                    string sql = @"INSERT INTO LoaiPhong (MaLP, TenLP, SucChua, SoGiuong, DienTich, TienNghi) VALUES (@MaLP, @TenLP, @SucChua, @SoGiuong, @DienTich, @TienNghi)";
                    SqlCommand sqlLP = new SqlCommand(sql, con);
                    sqlLP.Parameters.Add("@MaLP", SqlDbType.NVarChar).Value = nv.MaLP;
                    sqlLP.Parameters.Add("@TenLP", SqlDbType.NVarChar).Value = nv.TenLP;
                    sqlLP.Parameters.Add("@SucChua", SqlDbType.Int).Value = nv.SucChua;
                    sqlLP.Parameters.Add("@SoGiuong", SqlDbType.Int).Value = nv.SoGiuong;
                    sqlLP.Parameters.Add("@DienTich", SqlDbType.Float).Value = nv.DienTich;
                    sqlLP.Parameters.Add("@TienNghi", SqlDbType.NVarChar).Value = nv.TienNghi;
                    sqlLP.ExecuteNonQuery();
                }
                //Check tồn tại MaLP
                string checkP = "SELECT COUNT(*) FROM Phong WHERE MaP = @MaP";
                checkCmd = new SqlCommand(checkP, con);
                checkCmd.Parameters.AddWithValue("@MaP", nv.MaP);
                count = (int)checkCmd.ExecuteScalar();
                if(count == 0)
                {
                    string insertPhong = @"INSERT INTO Phong (MaP, MaLP, TrangThai, GiaMacDinh) VALUES (@MaP, @MaLP, @TrangThai, @GiaMacDinh)";
                    SqlCommand insertP = new SqlCommand(insertPhong, con);
                    insertP.Parameters.AddWithValue("@MaP", nv.MaP);
                    insertP.Parameters.AddWithValue("@MaLP", nv.MaLP);
                    insertP.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
                    insertP.Parameters.AddWithValue("@GiaMacDinh", nv.GiaMacDinh);
                    insertP.ExecuteNonQuery();
                    con.Close();    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool Update(PhongDTO nv)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //Check tồn tại MaLP
                string checkLP = "SELECT COUNT(*) FROM LoaiPhong WHERE MaLP = @MaLP";
                SqlCommand checkCmd = new SqlCommand(checkLP, con);
                checkCmd.Parameters.AddWithValue("@MaLP", nv.MaLP);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string sql = @"UPDATE LoaiPhong SET TenLP = @TenLP, SucChua = @SucChua, SoGiuong = @SoGiuong, DienTich = @DienTich, TienNghi = @TienNghi WHERE MaLP = @MaLP";
                    SqlCommand sqlLP = new SqlCommand(sql, con);
                    sqlLP.Parameters.Add("@MaLP", SqlDbType.NVarChar).Value = nv.MaLP;
                    sqlLP.Parameters.Add("@TenLP", SqlDbType.NVarChar).Value = nv.TenLP;
                    sqlLP.Parameters.Add("@SucChua", SqlDbType.Int).Value = nv.SucChua;
                    sqlLP.Parameters.Add("@SoGiuong", SqlDbType.Int).Value = nv.SoGiuong;
                    sqlLP.Parameters.Add("@DienTich", SqlDbType.Float).Value = nv.DienTich;
                    sqlLP.Parameters.Add("@TienNghi", SqlDbType.NVarChar).Value = nv.TienNghi;
                    sqlLP.ExecuteNonQuery();
                }
                //Check tồn tại MaLP
                string checkP = "SELECT COUNT(*) FROM Phong WHERE MaP = @MaP";
                checkCmd = new SqlCommand(checkP, con);
                checkCmd.Parameters.AddWithValue("@MaP", nv.MaP);
                count = (int)checkCmd.ExecuteScalar();
                if (count == 0)
                {
                    string insertPhong = @"UPDATE Phong SET TrangThai = @TrangThai, GiaMacDinh = @GiaMacDinh WHERE MaP = @MaP";
                    SqlCommand insertP = new SqlCommand(insertPhong, con);
                    insertP.Parameters.AddWithValue("@MaP", nv.MaP);
                    insertP.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
                    insertP.Parameters.AddWithValue("@GiaMacDinh", nv.GiaMacDinh);
                    insertP.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool Delete(PhongDTO nv)
        {
            string sql = "DELETE FROM Phong WHERE MaP = @MaP";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaP", SqlDbType.NVarChar).Value = nv.MaP;
                // Exu
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

        public DataTable FindPhong(string cons)
        {
            string sql = @"SELECT P.MaP, P.TrangThai, P.GiaMacDinh, L.TenLP, L.SucChua, L.SoGiuong, L.DienTich, L.TienNghi FROM Phong P JOIN LoaiPhong L ON P.MaLP = L.MaLP WHERE P.MaP LIKE @MaP";
            SqlConnection con = dc.GetConnect();
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@MaP", SqlDbType.NVarChar).Value = "%" + cons + "%";
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
