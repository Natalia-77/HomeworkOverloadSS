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

        public double Width { get; set; }

        public WaterAnimal(string name, DateTime datebirth,double width)
            : base(name, datebirth)
        {
            Environment = "Land";
            Width = width;
        }

        public new void PrintInfo()
        {
            Print();
            Console.WriteLine($"Environment: {Environment}\n" +
                $"Width: {Width}");
        }

    }
}
