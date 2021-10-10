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

        public double Width { get; set; }

        public LandAnimal(string name,string sound,DateTime datebirth, string env,double width)
            :base(name,sound,datebirth)
        {
            Environment = env;
            Width = width;
        }
       
    }
}
