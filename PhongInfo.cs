using System;
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
			string MaP = buttonName; // Get the button name clicked
			string sql = @"SELECT p.MaP, hd.MaHD, hdp.MaHDP, kh.CCCD, cthdp.NgayNhan, p.TrangThai,
                        p.GiaMacDinh AS ThanhTien 
                   FROM Phong p 
                   JOIN CTHDPhong cthdp ON cthdp.MaP = p.MaP
                   JOIN HoaDonPhong hdp ON hdp.MaHDP = cthdp.MaHDP
                   LEFT JOIN KhachHang kh ON kh.MaKH = hdp.MaKH
                   JOIN HoaDon hd ON hd.MaLoaiHD = hdp.MaHDP                  
                   WHERE p.MaP = @MaP AND (p.TrangThai = N'Đã đặt' OR p.TrangThai = N'Đang sử dụng')";

			maPhong.Text = MaP;

			using (SqlConnection con = dc.GetConnect())
			{
				con.Open(); // Open connection
				 
				try
				{
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@MaP", MaP);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
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
				catch (SqlException sqlEx)
				{
					MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void addMon_Click(object sender, EventArgs e)
		{
			this.Hide();
			var addMon = new AddHDM(maPhong.Text, textCCCD.Text);
			addMon.Show();
		}

		private void addDV_Click(object sender, EventArgs e)
		{
			this.Hide();
			var addDV = new AddHDDV(maPhong.Text, textCCCD.Text);
			addDV.Show();
		}
	}
}