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
	internal class MonBUS
	{
		MonDAO dalMon;

		public MonBUS()
		{
			dalMon = new MonDAO();
		}
		public DataTable getAllMon()
		{
			return dalMon.getAllMon();
		}

		public bool insertMon(MonDTO mon)
		{
			return dalMon.insertMon(mon);
		}

		public bool UpdateMon(MonDTO mon)
		{
			return dalMon.UpdateMon(mon);
		}

		public bool DeleteMon(MonDTO mon)
		{
			return dalMon.DeleteMon(mon);
		}

		public DataTable FindMon(string cons)
		{
			return dalMon.FindMon(cons);
		}
	}
}
