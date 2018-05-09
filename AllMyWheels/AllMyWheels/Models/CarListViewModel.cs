using System.Collections.Generic;

namespace AllMyWheels.Models
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }

        //todo: add filters
    }
}