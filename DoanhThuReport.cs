using HotelManagement.DAO;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class DoanhThuReport : Form
	{
		public DoanhThuReport()
		{
			InitializeComponent();
		}

		DoanhThuDAO doanhThuDAO = new DoanhThuDAO();

		private void DoanhThuReport_Load(object sender, EventArgs e)
		{
			try
			{
				reportViewer1.LocalReport.ReportEmbeddedResource = "HotelManagement.ReportDoanhThu.rdlc";

				ReportDataSource reportDataSource = new ReportDataSource
				{
					Name = "DataSet1", // Tên của DataSet trong báo cáo
					Value = doanhThuDAO.getAllDoanhThu() // DataTable trả về từ DAO
				};

				reportViewer1.LocalReport.DataSources.Clear(); // Xóa các nguồn dữ liệu cũ
				reportViewer1.LocalReport.DataSources.Add(reportDataSource);

				reportViewer1.RefreshReport(); // Làm mới báo cáo
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			DoanhThuReport_Load(sender, e);
		}
	}
}