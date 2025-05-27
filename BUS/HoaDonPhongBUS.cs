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
	internal class HoaDonPhongBUS
	{
		HoaDonPhongDAO dalhdPhong;

		public HoaDonPhongBUS()
		{
			dalhdPhong = new HoaDonPhongDAO();
		}
		public DataTable getAllHoaDonPhong()
		{
			return dalhdPhong.getAllHoaDonPhong();
		}
		public bool DeleteHoaDonPhong(HoaDonPhongDTO hdmon)
		{
			return dalhdPhong.DeleteHoaDonPhong(hdmon);
		}

		public DataTable FindHoaDonPhong(string cons)
		{
			return dalhdPhong.FindHoaDonPhong(cons);
		}
	}
}
