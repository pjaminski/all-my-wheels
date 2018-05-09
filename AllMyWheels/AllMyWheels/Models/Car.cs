using System;

namespace AllMyWheels.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        public string ProducerName { get; set; }

        public string ModelName { get; set; }

        public int ProducedFrom { get; set; }

        public int ProducedTo { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}