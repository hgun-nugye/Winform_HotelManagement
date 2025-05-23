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
using HotelManagement.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace HotelManagement.GUII
{
    public partial class LuongGUI : Form
    {
        LuongBUS busLuong;
        
        public LuongGUI()
        {
            busLuong = new LuongBUS();
            InitializeComponent();
        }


        // Hiển thị toàn bộ
        public void ShowAllLuong()
        {
            DataTable dt = new DataTable();
            dt = busLuong.getAll();
            bangLuong.DataSource = dt;
        }
        private void LuongGUI_Load(object sender, EventArgs e)
        {
            ShowAllLuong();
        }

        //Kiểm tra nhập 
        public bool checkData()
        {
            if (string.IsNullOrEmpty(inputMaNV.Text))
            {
                MessageBox.Show("Chưa nhập Mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputMaNV.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputMucLuong.Text))
            {
                MessageBox.Show("Chưa nhập mức lương", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputMucLuong.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputThuong.Text))
            {
                MessageBox.Show("Chưa nhập thưởng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputThuong.Focus();
                return false;
            }

            if (!inputThangLuong.Checked)
            {
                MessageBox.Show("Chưa nhập tháng lương", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputThangLuong.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputPhat.Text))
            {
                MessageBox.Show("Chưa nhập phạt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputPhat.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(inputPhuCap.Text))
            {
                MessageBox.Show("Chưa nhập phụ cấp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputPhuCap.Focus();
                return false;
            }

            return true;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                LuongDTO nv = new LuongDTO();
                nv.MaNV = inputMaNV.Text;
                nv.MucLuong = decimal.Parse(inputMucLuong.Text);
                nv.Thuong = decimal.Parse(inputThuong.Text);
                nv.Phat = decimal.Parse(inputPhat.Text);
                nv.PhuCap = decimal.Parse(inputPhuCap.Text);
                nv.ThangLuong = inputThangLuong.Value;
                if(busLuong.Insert(nv))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllLuong();
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
                LuongDTO nv = new LuongDTO();
                nv.MaNV = inputMaNV.Text;
                nv.MucLuong = decimal.Parse(inputMucLuong.Text);
                nv.Thuong = decimal.Parse(inputThuong.Text);
                nv.Phat = decimal.Parse(inputPhat.Text);
                nv.PhuCap = decimal.Parse(inputPhuCap.Text);
                nv.ThangLuong = inputThangLuong.Value;
                if (busLuong.Update(nv))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllLuong();
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
                LuongDTO nv = new LuongDTO();
                nv.MaNV = inputMaNV.Text;

                if (busLuong.Delete(nv))
                {
                    ShowAllLuong();
                }
                else
                {
                    MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Hiên thị khi nháy
        int ID;
        private void bangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            inputMaNV.Text = bangLuong.Rows[index].Cells["MaNV"].Value.ToString();
            inputMucLuong.Text = bangLuong.Rows[index].Cells["MucLuong"].Value.ToString();
            inputThuong.Text = bangLuong.Rows[index].Cells["Thuong"].Value.ToString();
            inputPhat.Text = bangLuong.Rows[index].Cells["Phat"].Value.ToString();
            inputPhuCap.Text = bangLuong.Rows[index].Cells["PhuCap"].Value.ToString();
            inputThangLuong.Value = Convert.ToDateTime(bangLuong.Rows[index].Cells["ThangLuong"].Value);
        }

        private void inputTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = inputTimKiem.Text;
            if(!string.IsNullOrEmpty(value))
            {
                DataTable dt = busLuong.FindLuong(value);
                bangLuong.DataSource = dt;
            }
            else
            {
                ShowAllLuong();
            }
        }
    }
}
