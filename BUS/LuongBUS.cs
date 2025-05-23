using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DTO;
namespace HotelManagement.BUS
{
	internal class LuongBUS
	{
		LuongDAO dalluong;

		public LuongBUS()
		{
			dalluong = new LuongDAO();
		}

		public DataTable getAll()
		{
			return dalluong.getAll();
		}

		public bool Insert(LuongDTO nv)
		{
			return dalluong.Insert(nv);
		}

		public bool Update(LuongDTO nv)
		{
			return dalluong.Update(nv);
		}

		public bool Delete(LuongDTO nv)
		{
			return dalluong.Delete(nv);
		}

		public DataTable FindLuong(string name)
		{
			return dalluong.FindLuong(name);
		}
	}
}
