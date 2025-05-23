using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    internal class NhanVienDTO
    {
        public string MaNV {  get; set; }
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string SDT_NV { get; set; }
        public string Email_NV { get; set; }
        public string DiaChi { get; set; }
        public string SoBHYT { get; set; }
        public string SoHopDong { get; set; }
        public int NamBatDau { get; set; }
    }
}
