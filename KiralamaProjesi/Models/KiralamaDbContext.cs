using KiralamaProjesi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.Models
{
    public class KiralamaDbContext:DbContext
    {
        public KiralamaDbContext(DbContextOptions<KiralamaDbContext> options): base(options)
        {

        }

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
    }
    
}
