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
    internal class HoaDonBUS
    {
        HoaDonDAO dalhd;

        public HoaDonBUS()
        {
            dalhd = new HoaDonDAO();
        }
        public DataTable getAllHoaDon()
        {
            return dalhd.getAllHoaDon();
        }

        public bool insertHoaDon(HoaDonDTO hd)
        {
            return dalhd.insertHoaDon(hd);
        }

        public bool UpdateHoaDon(HoaDonDTO hd)
        {
            return dalhd.UpdateHoaDon(hd);
        }

        public bool DeleteHoaDon(HoaDonDTO hd)
        {
            return dalhd.DeleteHoaDon(hd);
        }

        public DataTable FindHoaDon(string cons)
        {
            return dalhd.FindHoaDon(cons);
        }
    }
}
