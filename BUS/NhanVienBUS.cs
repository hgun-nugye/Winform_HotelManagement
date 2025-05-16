using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    internal class NhanVienBUS
    {
        NhanVienDAO dalnv;

        public NhanVienBUS()
        {
            dalnv = new NhanVienDAO();
        }
        public DataTable getAllNhanVien()
        {
            return dalnv.getAllNhanVien();
        }

        public bool insertNhanVien(NhanVienDTO nv)
        {
            return dalnv.insertNhanVien(nv);
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            return dalnv.UpdateNhanVien(nv);
        }

        public bool DeleteNhanVien(NhanVienDTO nv)
        {
            return dalnv.DeleteNhanVien(nv);
        }

        public DataTable FindNhanVien(string cons)
        {
            return dalnv.FindNhanVien(cons);
        }
    }
}
