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
	internal class HoaDonMonBUS
	{
		HoaDonMonDAO dalhdMon;

		public HoaDonMonBUS()
		{
			dalhdMon = new HoaDonMonDAO();
		}
		public DataTable getAllHoaDonMon()
		{
			return dalhdMon.getAllHoaDonMon();
		}

		public bool insertHoaDonMon(HoaDonMonDTO hdmon)
		{
			return dalhdMon.insertHoaDonMon(hdmon);
		}

		public bool UpdateHoaDonMon(HoaDonMonDTO hdmon)
		{
			return dalhdMon.UpdateHoaDonMon(hdmon);
		}

		public bool DeleteHoaDonMon(HoaDonMonDTO hdmon)
		{
			return dalhdMon.DeleteHoaDonMon(hdmon);
		}

		public DataTable FindHoaDonMon(string cons)
		{
			return dalhdMon.FindHoaDonMon(cons);
		}
	}
}
