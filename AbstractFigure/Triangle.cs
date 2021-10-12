using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Triangle:Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Perimeter()
        {
            return Math.Round((SideA + SideB + SideC), 2);
        }

        public override double Area()
        {
            double P = 0.5 * (SideA + SideB + SideC);
            return Math.Round(Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC)), 2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", Name, Perimeter(), Area());
        }

    }
}
