using System.Collections.Generic;
using AllMyWheels.Models;

namespace AllMyWheels.DAL.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
    }
}
