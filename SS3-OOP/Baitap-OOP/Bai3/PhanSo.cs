using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo()
        {

        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            this.MauSo = mauSo;
        }

        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }

        ~PhanSo() { }
    }
}
