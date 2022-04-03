using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Students
    {
        private string id;
        private string name;
        private string phone;
        private string address;

        public Students()
        {

        }

        public Students(string id, string name, string phone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
