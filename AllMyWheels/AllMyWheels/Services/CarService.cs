using System.Collections.Generic;
using System.Linq;
using AllMyWheels.DAL.Repositories;
using AllMyWheels.Models;

namespace AllMyWheels.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> GetCarsWithImages()
        {
            var cars = _carRepository.GetCars();

            var carsWithImages = cars.ToList();

            foreach (var car in carsWithImages)
            {
                car.ImageUrl = $"\\Pics\\{car.Id}.jpg";//todo: add path to config, replace to model
            }

            return carsWithImages;
        }
    }
}
