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
	public partial class DoanhThuReport : Form
	{
		public DoanhThuReport()
		{
			InitializeComponent();
		}

		private void DoanhThuReport_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
        }
    }
}
