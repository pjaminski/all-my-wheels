using System.Web.Mvc;
using AllMyWheels.DAL.Repositories;

namespace AllMyWheels.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public ActionResult Index()
        {
            var cars = _carRepository.GetCars();
            return View();//todo: add viewmodel for this view
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