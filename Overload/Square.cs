using System;

namespace Overload
{
    class Square
    {
        public string NameFigure { get; set; }
        public double SideLength { get; set; }

        public Square(string name, double sidelength)
        {
            SideLength = sidelength;
            NameFigure = name;
        }

        public double Area()
        {
            return SideLength * SideLength;
        }

        public double Perimeter()
        {
            return SideLength * 4;
        }        

        public void Show()
        {
            Console.WriteLine($"Figure {NameFigure} has area: {Area()} and perimeter {Perimeter()}");
        }
    }
}
