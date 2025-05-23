using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal interface DaoInterface<T>
    {
        DataTable getAll();
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
    }
}
