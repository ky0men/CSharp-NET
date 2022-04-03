using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Cap3 : Cap2
    {
        private float tinHoc;
        private float tiengPhap;

        public Cap3(string id, string name, int age, float toan, float van, float anh, float ly, float hoa, float tinHoc, float tiengPhap) : base(id, name, age, toan, van, anh, ly, hoa)
        {
            this.TinHoc = tinHoc;
            this.TiengPhap = tiengPhap;
        }

        public float TinHoc { get => tinHoc; set => tinHoc = value; }
        public float TiengPhap { get => tiengPhap; set => tiengPhap = value; }

        public override float DiemTrungBinh()
        {
            return (Toan + Van + Anh + Ly + Hoa + tinHoc + tiengPhap) / 7;
        }

    }
}
