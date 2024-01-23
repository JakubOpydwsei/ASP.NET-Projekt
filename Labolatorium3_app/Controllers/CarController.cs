using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Labolatorium3_app.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "Admin")]
    public class CarController : Controller 
    {
        private readonly ICar _carService;

        public CarController(ICar carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            return View(_carService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Car());
        }

        [HttpPost]
        public IActionResult Create(Car model)
        {
            if (ModelState.IsValid)
            {
                _carService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var car = _carService.FindById(id);
            return car != null ? View(car) : NotFound();
        }

        [HttpPost]
        public IActionResult Update(Car model)  // Car zamiast Contact
        {
            if (ModelState.IsValid)
            {
                _carService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var car = _carService.FindById(id);
            if (car != null)
            {
                return View(car);
            }
            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _carService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var car = _carService.FindById(id);
            if (car != null)
            {
                return View(car);
            }
            return NotFound();
        }




        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}