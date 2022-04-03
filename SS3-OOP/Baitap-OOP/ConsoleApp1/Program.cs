using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentClass
    {
        private int id;
        private string name;
        private int age;

        public StudentClass()
        {
        }

        public StudentClass(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }
    }
    class Cap1 : StudentClass
    {
        private double toan;
        private double van;
        private double anh;

        public Cap1()
        {
        }

        public Cap1(int id, string name, int age, double toan, double van, double anh)
        {
            Id = id;
            Name = name;
            Age = age;
            this.toan = toan;
            this.van = van;
            this.anh = anh;
        }

        public double Toan { get => toan; set => toan = value; }
        public double Van { get => van; set => van = value; }
        public double Anh { get => anh; set => anh = value; }

        public double DTB()
        {
            return ((double)Toan + (double)Van + (double)Anh) / 3;
        }
        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Age: " + Age + ", DTB: " + DTB();
        }
    }
    class Cap2 : StudentClass
    {
        private double toan;
        private double van;
        private double anh;
        private double ly;
        private double hoa;

        public Cap2(int id, string name, int age, double toan, double van, double anh, double ly, double hoa)
        {
            Id = id;
            Name = name;
            Age = age;
            this.toan = toan;
            this.van = van;
            this.anh = anh;
            this.ly = ly;
            this.hoa = hoa;
        }

        public double Toan { get => toan; set => toan = value; }
        public double Van { get => van; set => van = value; }
        public double Anh { get => anh; set => anh = value; }
        public double Ly { get => ly; set => ly = value; }
        public double Hoa { get => hoa; set => hoa = value; }
        public double DTB()
        {
            return ((double)Toan + (double)Van + (double)Anh + (double)Ly + (double)Hoa) / 5;
        }
        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Age: " + Age + ", DTB: " + DTB();
        }
    }
    class Cap3 : StudentClass
    {
        private double toan;
        private double van;
        private double anh;
        private double ly;
        private double hoa;
        private double tinhoc;
        private double tiengPhap;

        public Cap3(int id, string name, int age, double toan, double van, double anh, double ly, double hoa, double tinhoc, double tiengPhap)
        {
            Id = id;
            Name = name;
            Age = age;
            this.toan = toan;
            this.van = van;
            this.anh = anh;
            this.ly = ly;
            this.hoa = hoa;
            this.tinhoc = tinhoc;
            this.tiengPhap = tiengPhap;
        }

        public double Toan { get => toan; set => toan = value; }
        public double Van { get => van; set => van = value; }
        public double Anh { get => anh; set => anh = value; }
        public double Ly { get => ly; set => ly = value; }
        public double Hoa { get => hoa; set => hoa = value; }
        public double TiengPhap { get => tiengPhap; set => tiengPhap = value; }
        public double Tinhoc { get => tinhoc; set => tinhoc = value; }
        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Age: " + Age + ", DTB: " + DTB();
        }
        public double DTB()
        {
            return ((double)Toan + (double)Van + (double)Anh + (double)Ly + (double)Hoa + (double)TiengPhap + (double)Tinhoc) / 7;
        }
    }
}
