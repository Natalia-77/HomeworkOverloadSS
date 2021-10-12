using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
   abstract class Figure
    {
        protected string Name { get; set; }//назва.

        public Figure(string name)
        {
            Name = name;
        }

        public abstract double Area();//площа.
        public abstract double Perimeter();//периметр.

        public virtual void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", Name, Perimeter(), Area());
        }
    }
}
