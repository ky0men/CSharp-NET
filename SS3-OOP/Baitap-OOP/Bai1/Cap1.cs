using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Cap1 : Students
    {
        private float toan;
        private float van;
        private float anh;

        public Cap1() { }

        public Cap1(string id, string name, int age, float toan, float van, float anh) : base(id, name, age)
        {
            this.Toan = toan;
            this.Van = van;
            this.Anh = anh;
        }

        public float Toan { get => toan; set => toan = value; }
        public float Van { get => van; set => van = value; }
        public float Anh { get => anh; set => anh = value; }

        public virtual float DiemTrungBinh()
        {
            return (toan + van + anh) / 3;
        }

        public void InputMark(float toan, float van, float anh)
        {
            Console.Write("Nhap diem toan: ");
            toan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            van = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            anh = float.Parse(Console.ReadLine());
        }
    }
}
