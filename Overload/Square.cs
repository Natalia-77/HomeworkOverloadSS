using System;

namespace Overload
{
    class Square
    {
        public string NameFigure { get; set; }
        private double sideLength;
        public double SideLength
        {
            get => sideLength;
            set
            {
                if (value < 0) sideLength = 1;
                else sideLength = value;
            }
            
        }
        public Square()
        {

        }

        public Square(double sidelength)
        {
            SideLength = sidelength;
        }
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

        public static Square operator ++(Square square)
        {
            square.sideLength += 2;
            return square;
        }
        public static Square operator --(Square square)
        {
            square.sideLength -= 2;
            return square;
        }

        public static Square operator +(Square left, Square right)
        {
            return new Square()
            {
                NameFigure = "Another square",
                SideLength = left.SideLength + right.SideLength
               
            };
        }
        public static Square operator +(Square left, int values)
        {
            return new Square()
            {
               NameFigure="Another square",
               SideLength=left.SideLength+values
            };
        }

        public static Square operator -(Square left,Square right)
        {
            return new Square()
            {
                NameFigure="Another aquare",
               SideLength=left.SideLength-right.SideLength                
            };
        }
        public static Square operator *(Square left, Square right)
        {
            return new Square()
            {
                NameFigure = "Another aquare",
                SideLength = left.SideLength * right.SideLength
            };
        }

        public static Square operator /(Square left, Square right)
        {
            return new Square()
            {
                NameFigure = "Another aquare",
                SideLength = left.SideLength / right.SideLength
            };
        }

        public static bool operator >(Square left, Square right)
        {
            return left.SideLength > right.SideLength;
        }
        public static bool operator <(Square left, Square right)
        {
            return !(left > right);
        }

        public static bool operator ==(Square left, Square right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Square left, Square right)
        {
            return !(left == right);
        }

        public static bool operator <=(Square left, Square right)
        {
            return (left.SideLength <= right.SideLength);
        }

        public static bool operator >=(Square left, Square right)
        {
            return (left.SideLength >= right.SideLength);
        }          
              
        public static bool operator true(Square s)
        {
            return s.SideLength > 0;
        }
        public static bool operator false(Square s)
        {
            return s.SideLength == 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Square suqare &&
                   SideLength == suqare.SideLength;
        }

        public override int GetHashCode()
        {
             return HashCode.Combine(SideLength);
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

