﻿using System;
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
	public partial class Welcome : Form
	{
		public Welcome()
		{
			InitializeComponent();
		}

		private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private void next_Click(object sender, EventArgs e)
		{
			this.Hide();
			var login = new Login();
			login.ShowDialog();

		}
	}
}
