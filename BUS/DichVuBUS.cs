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
    internal class DichVuBUS
    {
        DichVuDAO dalDichVu;

        public DichVuBUS()
        {
            dalDichVu = new DichVuDAO();
        }
        public DataTable getAllDichVu()
        {
            return dalDichVu.getAllDichVu();
        }

        public bool insertDichVu(DichVuDTO dv)
        {
            return dalDichVu.insertDichVu(dv);
        }

        public bool UpdateDichVu(DichVuDTO dv)
        {
            return dalDichVu.UpdateDichVu(dv);
        }

        public bool DeleteDichVu(DichVuDTO dv)
        {
            return dalDichVu.DeleteDichVu(dv);
        }

        public DataTable FindDichVu(string cons)
        {
            return dalDichVu.FindDichVu(cons);
        }
    }
}
