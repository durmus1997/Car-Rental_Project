using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public int ArabaId { get; set; }
        public string Ad { get; set; }
        public string Soyad{ get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string PostaKodu { get; set; }
        public string OdemeTipi { get; set; }
        public string KrediAd { get; set; }
        public string Kredino { get; set; }
        public string Cvv { get; set; }

        public Araba Araba { get; set; }

    }
}
