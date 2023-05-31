using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Shop.Entities
{
    [Serializable]
    public class Computer
    {
        public long computerId { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public long RAM { get; set; }
        public long Storage { get; set; }
        public string GraphicsCard { get; set; }
        public decimal Price { get; set; }

        public Computer()
        {

        }

        public Computer(long computerId, string brand, string processor, long rAM, long storage, string graphicsCard, decimal price)
        {
            this.computerId = computerId;
            Brand = brand;
            Processor = processor;
            RAM = rAM;
            Storage = storage;
            GraphicsCard = graphicsCard;
            Price = price;
        }



    }
}
