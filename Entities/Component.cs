using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Shop.Entities
{
    [Serializable]
    public class Component{
        public int componentId { get; set; }
        public string Name { get; set; }
        public  string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        //public enum ComponentType
        //{
        //    CPU,
        //    GPU,
        //    RAM,
        //    Motherboard,
        //    HardDrive,

        //}

        public Component()
        {

        }

        public Component(int componentId, string name, string type, string manufacturer, string model, decimal price)
        {
            this.componentId = componentId;
            Name = name;
            Type = type;
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
        }



    }
}
