using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class VeMayBay
    {
        private string tenChuyen, ngayBay;
        private float giaVe;

        public VeMayBay()
        {
        }

        public VeMayBay(string tenChuyen, string ngayBay, float giaVe)
        {
            this.TenChuyen = tenChuyen;
            this.NgayBay = ngayBay;
            this.GiaVe = giaVe;
        }

        public string TenChuyen { get => tenChuyen; set => tenChuyen = value; }
        public string NgayBay { get => ngayBay; set => ngayBay = value; }
        public float GiaVe { get => giaVe; set => giaVe = value; }

        public float getGiaVe()
        {
            return giaVe;
        }
        ~VeMayBay() { }
    }
}
