using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public class Employee
    {
        private static int fakeId = 0;
        private int id;
        private string name;
        private int age;
        private string address;
        private int yearOfExperience;
        private string qualification;
        private string phone;
        private string email;

        public Employee()
        {
        }

        public Employee(string name, int age, string address, int yearOfExperience, string qualification, string phone, string email)
        {
            fakeId++;
            id = fakeId;
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.YearOfExperience = yearOfExperience;
            this.Qualification = qualification;
            this.Phone = phone;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public int YearOfExperience { get => yearOfExperience; set => yearOfExperience = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
