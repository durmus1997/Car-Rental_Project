using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.Models
{
    public class Marka
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public List<Araba> Arabalar { get; set; }
    }
}
