using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new(" Square",5);
            Square square1 = new("Square first ", 10);
            Rectangle rectangle = new("Rectangle", 10, 25);


            //Square square_rectan=square + rectangle;
            //square_rectan.Show();

            // square--;
            // square++;
            // square.Area();
            //Square square2 = square / square1;
            //Console.WriteLine(square.SideLength == square1.SideLength);
            //Console.WriteLine(square<=square1);
            //square2.Show();


            //Console.WriteLine("Implicit Square conversion to Rectangle");
            //Square square3 = rectangle;
            //square3.Show();

            //Console.WriteLine("Implicit Square conversion to int");
            //Square square4 = 50;
            //square4.Show();

            //Console.WriteLine("Implicit int conversion to Square");
            //int number = square4;
            //Console.WriteLine($"Number is :{ number}");

            //Console.WriteLine("Explicit Rectangle conversion to Square");          
            //Square square2 = rectangle;
            //square2.Show();

            //Console.WriteLine("Explicit Rectangle conversion to int ");
            //Rectangle rectangle1 = (Rectangle)50;           
            //rectangle1.Show();



        }
    }
}
