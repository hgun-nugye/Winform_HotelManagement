using HotelManagement.DAO;
using HotelManagement.GUII;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class Dashboard : Form
	{
		DataConnection dc = new DataConnection();

		public Dashboard()
		{
			InitializeComponent();
		}

		private void NavigateTo(Form form)
		{
			form.Show();
			this.Hide();
		}

		private void room_Click(object sender, EventArgs e) => NavigateTo(new PhongForm());
		private void receipt_Click(object sender, EventArgs e) => NavigateTo(new HoaDonForm());
		private void employee_Click(object sender, EventArgs e) => NavigateTo(new bangNV());
		private void checkin_Click(object sender, EventArgs e) => NavigateTo(new Checkin());
		private void checkout_Click(object sender, EventArgs e) => NavigateTo(new Checkout());
		private void dish_Click(object sender, EventArgs e) => NavigateTo(new bangMon());
		private void service_Click(object sender, EventArgs e) => NavigateTo(new DichVuForm());
		private void customer_Click(object sender, EventArgs e) => NavigateTo(new bangKhachHang());

		private void toolStripComboBoxHD_Click(object sender, EventArgs e)
		{
			switch (toolStripComboBoxHD.SelectedItem.ToString())
			{
				case "HÓA ĐƠN PHÒNG":
					NavigateTo(new bangHoaDonPhong());
					break;
				case "HÓA ĐƠN MÓN":
					NavigateTo(new bangHoaDonMon());
					break;
				case "HÓA ĐƠN DỊCH VỤ":
					NavigateTo(new bangHoaDonDV());
					break;
				case "TỔNG HÓA ĐƠN":
					NavigateTo(new HoaDonForm());
					break;
			}
		}

		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

		private void P101_Click(object sender, EventArgs e) => ShowRoomInfo(sender);
		private void dsPhong_Click(object sender, EventArgs e) => NavigateTo(new PhongForm());

		private void ShowRoomInfo(object sender)
		{
			Button btn = sender as Button;
			if (btn != null)
			{
				string buttonName = btn.Name;
				var phongInfo = new PhongInfo(buttonName);
				phongInfo.Show();
				this.Hide();
			}
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			// Thực hiện truy vấn cho từng phòng
			UpdateRoomStatus(P101);
			UpdateRoomStatus(P102);
			UpdateRoomStatus(P103);
			UpdateRoomStatus(P104);
			UpdateRoomStatus(P105);
			UpdateRoomStatus(P106);
			UpdateRoomStatus(P107);
			UpdateRoomStatus(P108);
			UpdateRoomStatus(P109);
			UpdateRoomStatus(P110);
			UpdateRoomStatus(P201);
			UpdateRoomStatus(P202);
			UpdateRoomStatus(P203);
			UpdateRoomStatus(P204);
			UpdateRoomStatus(P205);
			UpdateRoomStatus(P206);
			UpdateRoomStatus(P207);
			UpdateRoomStatus(P208);
			UpdateRoomStatus(P209);
			UpdateRoomStatus(P210);
		}

		private void UpdateRoomStatus(Button roomButton)
		{
			string maP = roomButton.Name; // Lấy tên button để làm tham số truy vấn
			string sql = @"SELECT p.TrangThai FROM Phong p WHERE p.MaP = @MaP";

			using (SqlConnection con = dc.GetConnect())
			{
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.AddWithValue("@MaP", maP);
					con.Open();

					object result = cmd.ExecuteScalar();
					if (result != null && result != DBNull.Value)
					{
						string trangThai = result.ToString();
						SetButtonColor(roomButton, trangThai);
					}
					else
					{
						SetButtonColor(roomButton, "Không có dữ liệu");
					}
				}
			}
		}

		private void SetButtonColor(Button button, string trangThai)
		{
			switch (trangThai)
			{
				case "Đã đặt":
					button.BackColor = Color.LemonChiffon;
					button.ForeColor = Color.Black;
					break;
				case "Đang sử dụng":
					button.BackColor = Color.Crimson;
					button.ForeColor = Color.Black;
					break;
				case "Đang dọn dẹp":
					button.BackColor = Color.Gray;
					button.ForeColor = Color.Black;
					break;
			}
		}

		private void statis_Click(object sender, EventArgs e)
		{

		}
	}
}