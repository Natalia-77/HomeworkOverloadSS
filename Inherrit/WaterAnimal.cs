using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class WaterAnimal:Animal
    {
        public string Environment { get; set; }

       

        public WaterAnimal(string name, DateTime datebirth)
            : base(name, datebirth)
        {
            Environment = "Water";           
        }

        public WaterAnimal()
        {
        }

        public override void Print()
        {            
            Console.WriteLine($"Environment: {Environment}");
        }

    }
}
