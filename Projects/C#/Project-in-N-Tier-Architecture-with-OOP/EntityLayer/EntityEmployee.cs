using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployee
    {
        private int id;
        private string name;
        private string surname;
        private string city;
        private string task;
        private int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public string Task { get => task; set => task = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
