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
using HotelManagement.DTO;
using HotelManagement.GUII;
namespace HotelManagement
{
    public partial class bangNV : Form
    {
        NhanVienBUS busNV;
        public bangNV()
        {
            busNV = new NhanVienBUS();
            InitializeComponent();
        }


        // Hiển thị toàn bộ
        public void ShowAllNhanVien()
        {
            DataTable dt = new DataTable();
            dt = busNV.getAllNhanVien();
            dataGridViewNV.DataSource = dt;
        }
        // Xử lý hiển thị toàn bộ
        private void bangNV_Load(object sender, EventArgs e)
        {
            inputFind.Text = "Nhập mã, tên hoặc cccd để tìm";
            inputFind.ForeColor = Color.Gray;
            inputFind.Font = new Font("Arial", 11, FontStyle.Italic);
            ShowAllNhanVien();
        }
        //Hiển thị lên ô input thông tin nhân viên mỗi khi lia chuột đến row nhân viên bất kì
        int ID;
        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //ID = Int32.Parse(dataGridViewNV.Rows[index].Cells["ID"].Value.ToString());
            textMaNV.Text = dataGridViewNV.Rows[index].Cells["MaNV"].Value.ToString();
            textCCCD.Text = dataGridViewNV.Rows[index].Cells["CCCD"].Value.ToString();
            textHoTen.Text = dataGridViewNV.Rows[index].Cells["HoTen"].Value.ToString();
            inputNgaySinh.Value = Convert.ToDateTime(dataGridViewNV.Rows[index].Cells["NgaySinh"].Value);
            string gt = dataGridViewNV.Rows[index].Cells["GioiTinh"].Value.ToString();
            if (gt == "Nam")
            {
                radioNam.Checked=true;
            }
            else
            {
                radioNu.Checked = true;
            }
                textChucVu.Text = dataGridViewNV.Rows[index].Cells["ChucVu"].Value.ToString();
            textSDT.Text = dataGridViewNV.Rows[index].Cells["SDT_NV"].Value.ToString();
            textEmail.Text = dataGridViewNV.Rows[index].Cells["Email_NV"].Value.ToString();
            textDiaChi.Text = dataGridViewNV.Rows[index].Cells["DiaChi"].Value.ToString();
            textSoBHYT.Text = dataGridViewNV.Rows[index].Cells["SoBHYT"].Value.ToString();
            textSoHopDong.Text = dataGridViewNV.Rows[index].Cells["SoHopDong"].Value.ToString();
            textNamBatDau.Text = dataGridViewNV.Rows[index].Cells["NamBatDau"].Value.ToString();
            textMST.Text = dataGridViewNV.Rows[index].Cells["MaSoThueCaNhan"].Value.ToString();
        }

        // Kiểm tra nhập chưa
        public bool checkData()
        {
            if (string.IsNullOrEmpty(textMaNV.Text))
            {
                MessageBox.Show("Chưa nhập Mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textMaNV.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textCCCD.Text))
            {
                MessageBox.Show("Chưa nhập CCCD", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCCCD.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textHoTen.Text))
            {
                MessageBox.Show("Chưa nhập họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textHoTen.Focus();
                return false;
            }

            if (!inputNgaySinh.Checked)
            {
                MessageBox.Show("Chưa nhập ngày sinh", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputNgaySinh.Focus();
                return false;
            }

            if (!radioNam.Checked && !radioNu.Checked)
            {
                MessageBox.Show("Chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupGT.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textChucVu.Text))
            {
                MessageBox.Show("Chưa nhập chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textChucVu.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textSDT.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSDT.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Chưa nhập Email", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập Địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textSoBHYT.Text))
            {
                MessageBox.Show("Chưa nhập Số BHYT", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSoBHYT.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textSoHopDong.Text))
            {
                MessageBox.Show("Chưa nhập Số hợp đồng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSoHopDong.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textNamBatDau.Text))
            {
                MessageBox.Show("Chưa nhập Năm bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNamBatDau.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textMST.Text))
            {
                MessageBox.Show("Chưa nhập Năm bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNamBatDau.Focus();
                return false;
            }

            return true;
        }
        //Nút thêm
        private void insert_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = textMaNV.Text;
                nv.CCCD = textCCCD.Text;
                nv.SDT_NV = textSDT.Text;
                nv.ChucVu = textChucVu.Text;
                nv.Email_NV = textEmail.Text;
                nv.DiaChi = textDiaChi.Text;
                nv.HoTen = textHoTen.Text;
                nv.GioiTinh = (radioNu.Checked ? "Nữ" : "Nam");
                nv.SoBHYT = textSoBHYT.Text;
                nv.SoHopDong = textSoHopDong.Text;
                nv.NamBatDau = int.Parse(textNamBatDau.Text);
                nv.NgaySinh = inputNgaySinh.Value;
                nv.MaSoThueCaNhan = textMST.Text;

                if (busNV.insertNhanVien(nv))
                {
                    ShowAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Không thể chèn được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Nút xóa
        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = textMaNV.Text;

                if (busNV.DeleteNhanVien(nv))
                {
                    ShowAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = textMaNV.Text;
                nv.CCCD = textCCCD.Text;
                nv.SDT_NV = textSDT.Text;
                nv.ChucVu = textChucVu.Text;
                nv.Email_NV = textEmail.Text;
                nv.DiaChi = textDiaChi.Text;
                nv.HoTen = textHoTen.Text;
                nv.GioiTinh = (radioNu.Checked ? "Nữ" : "Nam");
                nv.SoBHYT = textSoBHYT.Text;
                nv.SoHopDong = textSoHopDong.Text;
                nv.NamBatDau = int.Parse(textNamBatDau.Text);
                nv.NgaySinh = inputNgaySinh.Value;
                nv.MaSoThueCaNhan=textMST.Text;

                if (busNV.UpdateNhanVien(nv))
                {
                    ShowAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inputFind_MouseEnter(object sender, EventArgs e)
        {
            if(inputFind.Text == "Nhập mã, tên hoặc cccd để tìm")
            {
                inputFind.Text = "";
                inputFind.ForeColor = Color.Black;
                inputFind.Font = new Font("Arial", 11, FontStyle.Regular);
            }
        }

        private void inputFind_TextChanged(object sender, EventArgs e)
        {
            string value = inputFind.Text; 
            if(!string.IsNullOrEmpty(value))
            {
                DataTable dt = busNV.FindNhanVien(value);
                dataGridViewNV.DataSource = dt;
            }
            else
            {
                ShowAllNhanVien();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();

        }

		private void lichLam_Click(object sender, EventArgs e)
		{
            this.Hide();
            var ll = new LichLamForm();
            ll.Show();
		}

		private void luong_Click(object sender, EventArgs e)
		{
			this.Hide();
			var lg = new LuongForm();
			lg.Show();
		}
	}
}
