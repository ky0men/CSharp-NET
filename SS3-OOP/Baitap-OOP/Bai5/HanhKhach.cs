using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class HanhKhach : Nguoi, IComparable<HanhKhach>
    {
        private VeMayBay ve;
        private int soLuong;

        public HanhKhach()
        {
        }

        public HanhKhach(string name, string gender, int age, VeMayBay ve, int soLuong) : base(name, gender, age)
        {
            this.Ve = ve;
            this.SoLuong = soLuong;
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }
        internal VeMayBay Ve { get => ve; set => ve = value; }

        public float TongTien()
        {
            return ve.GiaVe * soLuong;
        }

        public int CompareTo(HanhKhach other)
        {
            if (other == null) return 1;
            return other.TongTien().CompareTo(this.TongTien());
        }

        ~HanhKhach() { }
    }
}
