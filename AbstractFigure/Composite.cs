using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Composite:Figure
    {
         public Figure [] Figures { get; set; }

        public Composite(string name,Figure[] fig):base(name)
        {
            Figures = fig;

        }

        public override double Area()
        {
            double res = 0;
            for (int i = 0; i < Figures.Length; i++)
            {
                res += Figures[i].Area();

            }
            return res;

        }

        public override double Perimeter()
        {
            double perim = 0;
            for (int i = 0; i < Figures.Length; i++)
            {
                perim += Figures[i].Perimeter();

            }
            return perim;
        }
        public void Printres()
        {
            Console.WriteLine($"Площа результуючої фигури : {Math.Round(Area(),2)} \n" +
                $"Периметр:{Math.Round(Perimeter(),2)} ");

        }
    }
}
