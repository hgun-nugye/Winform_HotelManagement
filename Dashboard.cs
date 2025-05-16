using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BUS;

namespace HotelManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            P101.Hide();
            P102.Hide();
            P103.Hide();
            P104.Hide();
            P105.Hide();
            P106.Hide();
            P107.Hide();
            P108.Hide();
            P109.Hide();
            P110.Hide();
            P201.Hide();
            P202.Hide();
            P203.Hide();
            P204.Hide();
            P205.Hide();
            P206.Hide();                
            P207.Hide();
            P208.Hide();
            P209.Hide();
            P210.Hide();
        }

        private void room_Click(object sender, EventArgs e)
        {
            pictureDashboard.Hide();
            P101.Show();
            P102.Show();
            P103.Show();
            P104.Show();
            P105.Show();
            P106.Show();
            P107.Show();
            P108.Show();
            P109.Show();
            P110.Show();
            P201.Show();
            P202.Show();
            P203.Show();
            P204.Show();
            P205.Show();
            P206.Show();
            P207.Show();
            P208.Show();
            P209.Show();
            P210.Show();

        }

        private void receipt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var receipt=new HoaDonForm();
            receipt.Show();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nv = new bangNV();
            nv.Show();
        }

        private void checkin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var checkin = new Checkin();
            checkin.Show();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var checkout = new Checkout();
            checkout.Show();
        }
    }
}
