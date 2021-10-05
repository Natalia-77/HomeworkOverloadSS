using System;


namespace Overload
{
    class Rectangle
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle( string name, double width,double height)
        {
            Width = width;
            Height = height;
            Name = name;
        }

        public double Area()
        {
            return Width*Height;
        }

        public double Perimeter()
        {
            return (Width+Height)*2;
        }

        public void Show()
        {
            Console.WriteLine($"Figure {Name} has area: {Area()} and perimeter {Perimeter()}");
        }

    }
}
