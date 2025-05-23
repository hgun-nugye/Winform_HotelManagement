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

namespace HotelManagement.GUII
{
    public partial class PhongGUI : Form
    {
        PhongBUS busP;
        public PhongGUI()
        {
            busP = new PhongBUS();
            InitializeComponent();
        }

        // Hiển thị toàn bộ
        public void ShowAll()
        {
            DataTable dt = new DataTable();
            dt = busP.getAll();
            bangPhong.DataSource = dt;
        }
        private void PhongGUI_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        //Kiểm tra nhập 
        public bool checkData()
        {
            if (string.IsNullOrEmpty(inputMaP.Text))
            {
                MessageBox.Show("Chưa nhập mã phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputMaP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputMaLP.Text))
            {
                MessageBox.Show("Chưa nhập mã loại phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputMaLP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputTenLP.Text))
            {
                MessageBox.Show("Chưa nhập trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTenLP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputGiaMacDinh.Text))
            {
                MessageBox.Show("Chưa nhập giá mặc định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputGiaMacDinh.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputDienTich.Text))
            {
                MessageBox.Show("Chưa nhập diện tích", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputDienTich.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputTienNghi.Text))
            {
                MessageBox.Show("Chưa nhập tiện nghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTienNghi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputTrangThai.Text))
            {
                MessageBox.Show("Chưa nhập trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTrangThai.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbSoGiuong.Text))
            {
                MessageBox.Show("Chưa nhập số giường", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSoGiuong.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbSucChua.Text))
            {
                MessageBox.Show("Chưa nhập sức chứa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSucChua.Focus();
                return false;
            }
            return true;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                PhongDTO nv = new PhongDTO();
                nv.MaP = inputMaP.Text.Trim();
                nv.MaLP = inputMaLP.Text.Trim();
                nv.TenLP = inputTenLP.Text.Trim();
                nv.TrangThai = inputTenLP.Text.Trim();
                nv.GiaMacDinh = float.Parse(inputGiaMacDinh.Text.Trim());
                nv.TrangThai = inputTenLP.Text.Trim();
                nv.SoGiuong = int.Parse(cbSoGiuong.Text.Trim());
                nv.SucChua = int.Parse(cbSucChua.Text.Trim());
                nv.DienTich = float.Parse(inputDienTich.Text.Trim());
                nv.TienNghi = inputTienNghi.Text.Trim();
                if (busP.Insert(nv))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAll();
                }
                else
                {
                    MessageBox.Show("Không thể chèn được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                PhongDTO nv = new PhongDTO();
                nv.MaP = inputMaP.Text.Trim();
                nv.MaLP = inputMaLP.Text.Trim();
                nv.TenLP = inputTenLP.Text.Trim();
                nv.TrangThai = inputTenLP.Text.Trim();
                nv.GiaMacDinh = float.Parse(inputGiaMacDinh.Text.Trim());
                nv.TrangThai = inputTenLP.Text.Trim();
                nv.SoGiuong = int.Parse(cbSoGiuong.Text.Trim());
                nv.SucChua = int.Parse(cbSucChua.Text.Trim());
                nv.DienTich = float.Parse(inputDienTich.Text.Trim());
                nv.TienNghi = inputTienNghi.Text.Trim();

                if (busP.Update(nv))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAll();
                }
                else
                {
                    MessageBox.Show("Không thể sửa được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PhongDTO nv = new PhongDTO();
                nv.MaP = inputMaP.Text;

                if (busP.Delete(nv))
                {
                    ShowAll();
                }
                else
                {
                    MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Hiển thị khi nháy
        private void bangPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            inputMaP.Text = bangPhong.Rows[index].Cells["MaP"].Value.ToString();
            inputMaLP.Text = bangPhong.Rows[index].Cells["MaLP"].Value.ToString();
            inputTenLP.Text = bangPhong.Rows[index].Cells["TrangThai"].Value.ToString();
            inputGiaMacDinh.Text = bangPhong.Rows[index].Cells["GiaMacDinh"].Value.ToString();
            inputTrangThai.Text = bangPhong.Rows[index].Cells["TrangThai"].Value.ToString();
            cbSoGiuong.Text = bangPhong.Rows[index].Cells["SoGiuong"].Value.ToString();
            cbSucChua.Text = bangPhong.Rows[index].Cells["SucChua"].Value.ToString();
            inputTienNghi.Text = bangPhong.Rows[index].Cells["TienNghi"].Value.ToString();
            inputDienTich.Text = bangPhong.Rows[index].Cells["DienTich"].Value.ToString();
        }
    }
}
