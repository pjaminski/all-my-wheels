using System.Collections.Generic;
using AllMyWheels.Models;

namespace AllMyWheels.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetCarsWithImages();
    }
}
