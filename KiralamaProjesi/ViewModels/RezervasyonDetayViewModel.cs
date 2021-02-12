using KiralamaProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.ViewModels
{
    public class RezervasyonDetayViewModel
    {
        public Musteri Musteri { get; set; }
        public List<Musteri> GMusteriler { get; set; }
    }
}
