using KiralamaProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.ViewModels
{
    public class ListViewModel
    {
        public List<Marka> Markalar { get; set; }
        public List<Araba> Arabalar { get; set; }
        public Marka CurrentMarka { get; set; }
    }
}
