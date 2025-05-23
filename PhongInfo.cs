using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class PhongInfo : Form
	{
		DataConnection dc = new DataConnection();

		public PhongInfo()
		{
			InitializeComponent();
		}

		private string buttonName;

		public PhongInfo(string buttonName)
		{
			InitializeComponent();
			this.buttonName = buttonName;
			
		}

		private void PhongInfo_Load(object sender, EventArgs e)
		{
			string MaP = buttonName; // Lấy tên button đã click
			string sql = @"SELECT p.MaP, hd.MaHD, hdp.MaHDP, kh.CCCD, cthdp.NgayNhan, 
                          p.GiaMacDinh * (1 - COALESCE(ud.MucGiam, 0) / 100) AS ThanhTien, p.TrangThai 
                   FROM KhachHang kh 
                   JOIN HoaDon hd ON hd.MaKH = kh.MaKH 
                   JOIN HoaDonPhong hdp ON hdp.MaKH = kh.MaKH 
                   JOIN CTHDPhong cthdp ON cthdp.MaHDP = hdp.MaHDP 
                   JOIN Phong p ON p.MaP = cthdp.MaP 
                   LEFT JOIN UuDai ud ON ud.MaUD = cthdp.MaUD 
                   WHERE p.MaP = @MaP"; // Sử dụng tham số

			using (SqlConnection con = dc.GetConnect())
			{
				try
				{
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@MaP", MaP);
						con.Open(); // Mở kết nối

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								maPhong.Text = reader["MaP"].ToString();
								textMaHD.Text = reader["MaHD"]?.ToString() ?? "N/A";
								textMaHDP.Text = reader["MaHDP"]?.ToString() ?? "N/A";
								textCCCD.Text = reader["CCCD"]?.ToString() ?? "N/A";

								ngayVao.Text = reader["NgayNhan"] != DBNull.Value
									? Convert.ToDateTime(reader["NgayNhan"]).ToString("dd/MM/yyyy")
									: "N/A";

								decimal thanhTien = reader["ThanhTien"] != DBNull.Value
								? Convert.ToDecimal(reader["ThanhTien"])
								: 0;

								tongTien.Text = Math.Round(thanhTien, 2).ToString("F2");								
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải thông tin phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
		}
	}
}