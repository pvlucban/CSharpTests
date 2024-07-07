using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PersonName PersonName { get; set; }

        public List<Contact> Contacts { get; set; } = new();

        public List<string> Tags { get; set; } = new();
    }

    public class Contact
    {
        public string CountryCode { get; set; } = "65";
        public string Number { get; set; } = "";
    }
}
