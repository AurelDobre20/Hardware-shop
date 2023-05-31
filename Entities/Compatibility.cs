using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Shop.Entities
{
    [Serializable]
    public class Compatibility
    {
        Computer Computer { get; set; }
        Component Component { get; set; }


        public Compatibility(Computer computer, Component component)
        {
            this.Computer = computer;
            this.Component = component;
        }

        


    }
}
