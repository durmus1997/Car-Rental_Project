using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.Models
{
    public class Araba
    {
        public int Id { get; set; }
        public int MarkaId { get; set; }
        public string Ad { get; set; }
        public string KisiSayisi { get; set; }
        public string Bagaj { get; set; }
        public string KmSiniri { get; set; }
        public string YasSiniri { get; set; }
        public string Guvenlik { get; set; }
        public string Picture { get; set; }
        public int Fiyat { get; set; }


        public Marka Marka { get; set; }
        public List<Musteri> Musteriler { get; set; }
    }
}
