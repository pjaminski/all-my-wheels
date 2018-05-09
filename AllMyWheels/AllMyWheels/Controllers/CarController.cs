using System.Web.Mvc;
using AllMyWheels.Models;
using AllMyWheels.Services;

namespace AllMyWheels.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public ActionResult Index()
        {
            var viewModel = new CarListViewModel
            {
                Cars = _carService.GetCarsWithImages()
            };

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}