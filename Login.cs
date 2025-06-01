using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			this.ActiveControl = userName;
		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			string user = userName.Text.Trim().ToString();
			string pass = password.Text.Trim().ToString();

			if(user == "Manager" && pass == "12345")
			{
				this.Hide();
				Dashboard dashboard = new Dashboard();
				dashboard.ShowDialog();
			}
			else
			{
				MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			var welcome=new Welcome();
			welcome.ShowDialog();
		}

		private void password_Enter(object sender, EventArgs e)
		{

		}

		private void password_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnlogin_Click(sender, e);
			}

		}
	}
}
