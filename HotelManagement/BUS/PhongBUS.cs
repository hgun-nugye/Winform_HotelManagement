using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DTO;
using HotelManagement.DAO;
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
    }
}
