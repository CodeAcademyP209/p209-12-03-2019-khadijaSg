using RentACar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class AjaxController : Controller
    {

        private readonly CarContext _context;
        public AjaxController()
        {
            _context = new CarContext();

        }

        // GET: Ajax
        public ActionResult GetCars(int id)
        {
            var model = _context.Cars.Where(c => c.Id == id).Select(c => new
            {
                c.Id,
                c.CarBrand,
                c.CarModel,
                c.CarYear,
                c.EngineVolume,
                c.HorsePower,
                c.MilageVolume,
                c.TypeOfEngine,
                c.Image
            });

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCarsHtml(int id)
        {
            var model = _context.Cars.Where(c => c.Id == id);

            return PartialView("Load",model);
        }

        public ActionResult Load(int skip)
        {
            return PartialView(_context.Cars.OrderBy(c => c.Id).Skip(skip).Take(3));
        }

    }
}