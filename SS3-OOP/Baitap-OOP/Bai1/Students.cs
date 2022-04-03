using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Students
    {
        private string id;
        private string name;
        private int age;

        public Students()
        {
        }

        public Students(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

    }
}
