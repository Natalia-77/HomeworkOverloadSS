using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Rectangle:Figure
    {
        public double Sidefirst { get; set; }
        public double Sidesecond { get; set; }

        public Rectangle(string name, double sidefirst, double sidesecond) : base(name)
        {
            Sidefirst = sidefirst;
            Sidesecond = sidesecond;

        }

        public override double Perimeter()
        {
            return 2 * (Sidefirst + Sidesecond);
        }

        public override double Area()
        {
            return Sidefirst * Sidesecond;
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", Name, Perimeter(), Area());
        }
    }
}
