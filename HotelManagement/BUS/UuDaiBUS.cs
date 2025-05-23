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
    internal class UuDaiBUS
    {
        UuDaiDAO dalUD;

        public UuDaiBUS()
        {
            dalUD = new UuDaiDAO();
        }

        public DataTable getAll()
        {
            return dalUD.getAll();
        }

        public bool Insert(UuDaiDTO nv)
        {
            return dalUD.Insert(nv);
        }

        public bool Delete(UuDaiDTO nv)
        {
            return dalUD.Delete(nv);
        }

        public bool Update(UuDaiDTO nv)
        {
           return dalUD.Update(nv);
        }

        public DataTable FindUD(string name)
        {
            return dalUD.FindUuDai(name);
        }

        public DataTable FindUuDaiToTime(DateTime from, DateTime to)
        {
            return dalUD.FindUuDaiToTime(from, to);
        }
    }
}
