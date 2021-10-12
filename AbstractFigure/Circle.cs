using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Circle:Figure
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }

        public override double Area()
        {
            return Math.Round(Math.PI * (Radius * Radius), 2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", Name, Perimeter(), Area());
        }
    }
}
