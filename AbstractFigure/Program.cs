using System;
using System.Text;

namespace AbstractFigure
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Figure[] figures =
            {
               new Rectangle("Прямокутник", 5.2,7),
               new Circle("Коло", 5.6),
               new Triangle("Трикутник",7,7,8)
            };

            foreach (Figure el in figures)
            {
                el.Show();
            }

        }
    }
}
