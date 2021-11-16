using DIYPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DIYPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Secim> secimler = _db.Malzemeler
                .Select(m => new Secim() 
                { 
                    MalzemeId = m.Id,
                    MalzemeAd = m.Ad,
                    SeciliMi = false
                })
                .ToList();

            var vm = new SiparisViewModel()
            {
                Secimler = secimler
            };
            return View(vm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(SiparisViewModel vm)
        {
            if (vm.Secimler.Count(x => x.SeciliMi) < 2)
            {
                ModelState.AddModelError("", "En az 2 adet malzeme seçmeniz gerekmektedir.");
            }

            if (ModelState.IsValid)
            {
                var secilenler = vm.Secimler.Where(x => x.SeciliMi).ToList();
                // TempData["SecilenMalzemeler"] = JsonSerializer.Serialize(secilenler);

                int[] secimIdler = secilenler.Select(s => s.MalzemeId).ToArray();

                Siparis siparis = new Siparis()
                {
                    Adres = vm.Adres,
                    Malzemeler = _db.Malzemeler.Where(m => secimIdler.Contains(m.Id)).ToList()
                };
                _db.Add(siparis);
                _db.SaveChanges();

                return RedirectToAction("Siparis", new { siparisNo = siparis.Id });
            }
            return View(vm);
        }

        public IActionResult Siparis(int siparisNo)
        {
            //string json = (string)TempData["SecilenMalzemeler"];
            //List<Secim> secimler = JsonSerializer.Deserialize<List<Secim>>(json);

            return View(_db.Siparisler.Include(s => s.Malzemeler).FirstOrDefault(s => s.Id == siparisNo));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
