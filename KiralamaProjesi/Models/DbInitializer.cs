using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiralamaProjesi.Models
{
    public static class DbInitializer
    {
        public static void InitializeDb(IApplicationBuilder app)
        {
            KiralamaDbContext context = app.ApplicationServices.GetRequiredService<KiralamaDbContext>();

           context.Database.Migrate();

            if (context.Markalar.Any() == false)
            {
                context.Markalar.AddRange(
                    new Marka() { Ad="BMW" , Description= "Münihin otomobil devi olan BMW yi tercih etmek ve kiralamak için tıklayınız.", Picture= "bmw-logo.png" },
                    new Marka() { Ad ="Mercedes", Description = "Stuttgart ın Devi olan Mercedesi kiralamak için hemen inceleyiniz.", Picture = "mcds-logo.png" },
                    new Marka() { Ad ="Lamborghini", Description = "Bir rüya kiralamak istiyorsanız seçmeniz gereken araç markası. Hemen inceleyin.", Picture = "Lam-logo.jpg" },
                    new Marka() { Ad ="Skoda", Description = "Çok fazla reklama ihtiyacı olmayan Skoda yı kiralamak bir ayrıcalıktır.Uygun fiyatlı kaliteli ve müşteri memnuniyeti sağlayan markadır.Hemen inceleyiniz.", Picture = "skoda-logo.jpg" },
                    new Marka() { Ad ="Ferrari", Description = "Ferrari'yi asıl efsane yapan mekanik başarısıydı. Çok güçlü olan Ferrari motorları hem yarış pistleri hem de normal trafik için üretildi.Hemen inceleyiniz.", Picture = "ferrarii-logo.png" },
                    new Marka() { Ad ="Volkswagen", Description = "Ne tork ne de güç kaybı var.Efsane bir araba kiralamak istyorsanız daha fazla beklemeyin.Hemen inceleyin. ", Picture = "volk-logo.png" }
                    
                    );
                context.SaveChanges();
            }

            if (context.Arabalar.Any() == false)
            {
                context.Arabalar.AddRange(
                   new Araba() { Ad ="320i", KisiSayisi="5", Bagaj="3 Bavul", Guvenlik="ABS", KmSiniri="400", YasSiniri="25", Picture= "bmw320i.webp", Fiyat= 150, MarkaId=1 },
                   new Araba() { Ad ="x5", KisiSayisi="5", Bagaj="3 Bavul", Guvenlik="ABS", KmSiniri="400",YasSiniri="27", Picture = "x5.png", Fiyat = 200, MarkaId =1 },
                   new Araba() { Ad ="z4", KisiSayisi="2", Bagaj="2 Bavul", Guvenlik="ABS", KmSiniri="350",  YasSiniri="27", Picture = "z4.png", Fiyat = 250, MarkaId =1 },
                   new Araba() { Ad ="520i", KisiSayisi="5", Bagaj="3 Bavul", Guvenlik="ABS", KmSiniri="350",  YasSiniri="27", Picture = "i8.png", Fiyat = 300, MarkaId =1},
                   new Araba() { Ad ="C180", KisiSayisi="5", Bagaj= "3 Bavul", Guvenlik= "ABS", KmSiniri="400",  YasSiniri="25", Picture = "c180.png", Fiyat = 250, MarkaId =2 },
                   new Araba() { Ad ="C200", KisiSayisi="5", Bagaj= "3 Bavul", Guvenlik= "ABS", KmSiniri="400",  YasSiniri="25", Picture = "c200.jpg", Fiyat = 350, MarkaId =2 },
                    new Araba() { Ad = "Gallordo LP550", KisiSayisi = "2", Bagaj = "1 Bavul", Guvenlik = "ABS", KmSiniri = "250", YasSiniri = "27", Picture = "gallardo.png", Fiyat = 400, MarkaId = 3 },
                   new Araba() { Ad = "Superb", KisiSayisi = "5", Bagaj = "3 Bavul", Guvenlik = "ABS", KmSiniri = "500", YasSiniri = "20", Picture = "superb.png", Fiyat = 500, MarkaId = 4 },
                    new Araba() { Ad = "812 Superfast", KisiSayisi = "2", Bagaj = "2 Bavul", Guvenlik = "ABS", KmSiniri = "250",  YasSiniri = "25", Picture = "812.png", Fiyat = 420, MarkaId = 5 },
                   new Araba() { Ad = "Golf", KisiSayisi = "5", Bagaj = "3 Bavul", Guvenlik = "ABS", KmSiniri = "500",  YasSiniri = "25", Picture = "golf.png", Fiyat = 425, MarkaId = 6 },
                    new Araba() { Ad = "Passat", KisiSayisi = "5", Bagaj = "3 Bavul", Guvenlik = "ABS", KmSiniri = "500", YasSiniri = "25", Picture = "passat.png", Fiyat = 325, MarkaId = 6}

               );
                context.SaveChanges();
            }
        }

    }
}
