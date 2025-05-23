using HotelManagement.DAO;
using HotelManagement.DTO;
using System.Data;
namespace HotelManagement.BUS
{
	internal class PhongBUS
	{
		PhongDAO dalP;

		public PhongBUS()
		{
			dalP = new PhongDAO();
		}

		public DataTable getAll()
		{
			return dalP.getAll();
		}

		public bool Insert(PhongDTO nv)
		{
			return dalP.Insert(nv);
		}

		public bool Delete(PhongDTO nv)
		{
			return dalP.Delete(nv);
		}

		public bool Update(PhongDTO nv)
		{
			return dalP.Update(nv);
		}

		public DataTable FindP(string name)
		{
			return dalP.FindPhong(name);
		}

		public DataTable FindBySucChua(string name)
		{
			return dalP.FindBySucChua(name);
		}

		public DataTable FindBySoGiuong(string name)
		{
			return dalP.FindBySoGiuong(name);
		}
	}
}
