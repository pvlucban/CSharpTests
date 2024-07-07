using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class PersonName
    {
        public string First { get; set; } = "";
        public string Last { get; set; } = "";
        public string Full => $"{First} {Last}";

    }
}
