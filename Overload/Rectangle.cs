using System;


namespace Overload
{
    class Rectangle
    {
        public string Name { get; set; }
       
        private double width;
        public double Width
        {
            get => width;
            set
            {
                if (value < 0) width = 1;
                else width = value;
            }
        }

        private double height;
        public double Height
        {
            get => height;
            set
            {
                if (value < 0) height = 1;
                else height = value;
            }
        }
       
        public Rectangle( string name, double width,double height)
        {
            Name = name;
            Width = width;
            Height = height;
           
        }

        public Rectangle()
        {
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

        public static Rectangle operator ++(Rectangle rectangle)
        {
            rectangle.Height += 2;
            rectangle.Width += 2;
            return rectangle;
        }
        public static Rectangle operator --(Rectangle rectangle)
        {
            rectangle.Height -= 2;
            rectangle.Width -= 2;
            return rectangle;
        }

        public static Rectangle operator +(Rectangle left, Rectangle right)
        {
            return new Rectangle()
            {
                Name = "Another rectangle",
                Width = left.Width + right.Width,
                Height=left.Height+right.Height

            };
        }              

        public static Rectangle operator -(Rectangle left, Rectangle right)
        {
            return new Rectangle()
            {
                Name = "Another rectangle",
                Width = left.Width - right.Width,
                Height=left.Height-right.Height
            };
        }
        public static Rectangle operator *(Rectangle left, Rectangle right)
        {
            return new Rectangle()
            {
                Name = "Another rectangle",
                Width = left.Width * right.Width,
                Height = left.Height * right.Height
            };
        }

        public static Rectangle operator /(Rectangle left, Rectangle right)
        {
            return new Rectangle()
            {
                Name = "Another rectangle",
                Width = left.Width / right.Width,
                Height = left.Height / right.Height
            };
        }

        public static bool operator >(Rectangle left, Rectangle right)
        {
            return left.Width > right.Width && left.Height > right.Height;

        }
        public static bool operator <(Rectangle left, Rectangle right)
        {
            return left.Width < right.Width && left.Height < right.Height;

        }

        public static bool operator ==(Rectangle left, Rectangle right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Rectangle left, Rectangle right)
        {
            return !(left == right);
        }

        public static bool operator <=(Rectangle left, Rectangle right)
        {
            return left.Width <= right.Width && left.Height<=right.Height;
        }

        public static bool operator >=(Rectangle left, Rectangle right)
        {
            return left.Width >= right.Width && left.Height >= right.Height;
        }

        public static bool operator true(Rectangle rectangle)
        {
            return  rectangle.Width > 0&& rectangle.Height>0;
        }
        public static bool operator false(Rectangle rectangle)
        {
            return rectangle.Width == 0 && rectangle.Height == 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                  Width == rectangle.Width
                  && Height==rectangle.Height;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Width,Height);
        }

        public static implicit operator Square(Rectangle r)
        {
            Square s = new(r.Height);
            return s;
        }

        public static implicit operator Square(int r)
        {
            Square s = new(r);
            return s;
        }

        public static implicit operator int(Square s)
        {
            return (int)s.SideLength;

        }



    }
}
