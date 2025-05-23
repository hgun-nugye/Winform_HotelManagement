using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class KhachHangBUS
    {
        KhachHangDAO dalkh;

        public KhachHangBUS()
        {
            dalkh = new KhachHangDAO();
        }
        public DataTable getAllKhachHang()
        {
            return dalkh.getAllKhachHang();
        }

        public bool insertKhachHang(KhachHangDTO kh)
        {
            return dalkh.insertKhachHang(kh);
        }

        public bool UpdateKhachHang(KhachHangDTO kh)
        {
            return dalkh.UpdateKhachHang(kh);
        }

        public bool DeleteKhachHang(KhachHangDTO kh)
        {
            return dalkh.DeleteKhachHang(kh);
        }

        public DataTable FindKhachHang(string cons)
        {
            return dalkh.FindKhachHang(cons);
        }
    }
}
