using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentACar.DAL;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class HomeController : Controller
    {

        private readonly CarContext _context;
        public HomeController()
        {
            _context = new CarContext();

        }

        public ActionResult Index()
        {
            ViewBag.TotalCarsCount = _context.Cars.Count();
            return View(_context.Cars.OrderBy(c => c.Id).Take(3));
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if(!ModelState.IsValid)
            {

                return View(car);

            }


            _context.Cars.Add(car);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}