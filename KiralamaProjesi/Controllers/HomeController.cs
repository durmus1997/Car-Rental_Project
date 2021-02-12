using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiralamaProjesi.Models;
using KiralamaProjesi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KiralamaProjesi.Controllers
{
    public class HomeController : Controller
    {
        private KiralamaDbContext _context;

        public HomeController(KiralamaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Markalar.Include("Arabalar").ToList();  // Count kullandıgımız ıcın burda arabalar tablosunu dahıl ettık..

            return View(list);
        }

        public IActionResult List(int? id)
        {
            ListViewModel model = new ListViewModel();

            if (id != null)
            {
                model.Arabalar = _context.Arabalar.Where(x => x.MarkaId == id).Include("Marka").ToList();
                model.CurrentMarka = _context.Markalar.Where(x => x.Id == id).SingleOrDefault();
            }
            else
            {
                model.Arabalar = _context.Arabalar.Include("Marka").ToList();
            }
            model.Markalar = _context.Markalar.ToList();
            


            return View(model);
        }

        public IActionResult Rezervasyon(int id)
        {
            ViewBag.Araba = _context.Arabalar.Where(x => x.Id == id).SingleOrDefault();

            return View();
        }

        [HttpPost]
        public IActionResult Rezervasyon(RezervasyonViewModel model)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = model.Musteri.Ad;
            musteri.Soyad = model.Musteri.Soyad;
            musteri.Telefon = model.Musteri.Telefon;
            musteri.Email = model.Musteri.Email;
            musteri.Adres = model.Musteri.Adres;
            musteri.Ulke = model.Musteri.Ulke;
            musteri.Sehir = model.Musteri.Sehir;
            musteri.KrediAd = model.Musteri.KrediAd;
            musteri.Kredino = model.Musteri.Kredino;
            musteri.Cvv = model.Musteri.Cvv;
            musteri.ArabaId = model.ArabaID;

            _context.Musteriler.Add(musteri);
            _context.SaveChanges();

            Musteri sonMusteri = _context.Musteriler.Last();

            return RedirectToAction("RezervasyonDetay", "Home", new { id = sonMusteri.Id});
        }

        public IActionResult RezervasyonDetay(int id)
        {
            RezervasyonDetayViewModel model = new RezervasyonDetayViewModel();
            model.Musteri = _context.Musteriler.Where(x => x.Id == id).Include("Araba").SingleOrDefault();
            model.GMusteriler = _context.Musteriler.Where(x => x.ArabaId == model.Musteri.ArabaId).ToList();

            TempData["Message"] = "Rezervasyonunuz başarıyla tamamlanmıştır. Teşekkür ederiz";

            return View(model);
        }


    }
}