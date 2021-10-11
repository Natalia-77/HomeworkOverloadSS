using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class LandAnimal : Animal
    {
       
        public string Environment { get; set; }       

        public LandAnimal(string name,DateTime datebirth)
            :base(name,datebirth)
        {
            Environment = "Land";
                      
        }

        public LandAnimal()
        {
        }

        public new void PrintInfo()
        {
            Print();
            Console.WriteLine($"Environment: {Environment}");
        }

    }
}
