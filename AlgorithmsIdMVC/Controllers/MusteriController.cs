using Microsoft.AspNetCore.Mvc;
using ValidationMVC.Models.Context;
using ValidationMVC.Models.Entities;

namespace ValidationMVC.Controllers
{
    public class MusteriController : Controller
    {
        public IActionResult Index()
        {
            return View(MusteriFabrikası.FabrikayıGetir.Musteriler);
        }
        public IActionResult Create()
        {
            return View(new Musteri());
        }
        [HttpPost]
        public IActionResult Create(Musteri musteri)
        {
            if (!ModelState.IsValid)  return View(musteri); 
            MusteriFabrikası.FabrikayıGetir.Musteriler.Add(musteri);
            return RedirectToAction("Index");
        }
    }
}
