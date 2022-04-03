using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Cap2 : Cap1
    {
        private float ly;
        private float hoa;

        public Cap2(string id, string name, int age, float toan, float van, float anh, float ly, float hoa) : base(id, name, age, toan, van, anh)
        {
            this.Ly = ly;
            this.Hoa = hoa;
        }

        public float Ly { get => ly; set => ly = value; }
        public float Hoa { get => hoa; set => hoa = value; }

        public override float DiemTrungBinh()
        {
            return (Toan + Van + Anh + ly + hoa) / 5;
        }

    }
}
