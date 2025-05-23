using HotelManagement.DAO;
using HotelManagement.DTO;
using System.Data;

namespace HotelManagement.BUS
{
	internal class LichLamBUS
	{
		LichLamDAO dalL;

		public LichLamBUS()
		{
			dalL = new LichLamDAO();
		}

		public DataTable getAll()
		{
			return dalL.getAll();
		}

		public bool Insert(LichLamDTO nv)
		{
			return dalL.Insert(nv);
		}

		public bool Delete(LichLamDTO nv)
		{
			return dalL.Delete(nv);
		}

		public bool Update(LichLamDTO nv)
		{
			return dalL.Update(nv);
		}

		public DataTable FindLichLam(string name)
		{
			return dalL.FindLichLam(name);
		}
	}
}
