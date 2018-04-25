using System.Collections.Generic;
using AllMyWheels.Models;

namespace AllMyWheels.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly IDatabaseClient _databaseClient;

        public CarRepository(IDatabaseClient databaseClient)
        {
            _databaseClient = databaseClient;
        }

        public IEnumerable<Car> GetCars()
        {
            return _databaseClient.RunQuery<Car>(Queries.GetCars, null);
        }
    }
}
