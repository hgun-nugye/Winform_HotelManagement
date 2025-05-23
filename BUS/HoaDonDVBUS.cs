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
	internal class HoaDonDVBUS
	{
		HoaDonDVDAO dalhdDV;

		public HoaDonDVBUS()
		{
			dalhdDV = new HoaDonDVDAO();
		}
		public DataTable getAllHoaDonDV()
		{
			return dalhdDV.getAllHoaDonDV();
		}

		public bool insertHoaDonDV(HoaDonDVDTO hddv)
		{
			return dalhdDV.insertHoaDonDV(hddv);
		}

		public bool UpdateHoaDonDV(HoaDonDVDTO hddv)
		{
			return dalhdDV.UpdateHoaDonDV(hddv);
		}

		public bool DeleteHoaDonDV(HoaDonDVDTO hddv)
		{
			return dalhdDV.DeleteHoaDonDV(hddv);
		}

		public DataTable FindHoaDonDV(string cons)
		{
			return dalhdDV.FindHoaDonDV(cons);
		}
	}
}
