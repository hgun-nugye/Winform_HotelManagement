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
	internal class LoaiPhongBUS
	{
		LoaiPhongDAO dalLP;
		public LoaiPhongBUS()
		{
			dalLP = new LoaiPhongDAO();
		}

		public DataTable getAll()
		{
			return dalLP.getAll();
		}

		public bool Insert(LoaiPhongDTO nv)
		{
			return dalLP.Insert(nv);
		}

		public bool Delete(LoaiPhongDTO nv)
		{
			return dalLP.Delete(nv);
		}

		public bool Update(LoaiPhongDTO nv)
		{
			return dalLP.Update(nv);
		}

		public DataTable FindLP(string name)
		{
			return dalLP.FindLoaiPhong(name);
		}
	}
}
