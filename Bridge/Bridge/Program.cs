using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var blue = new Blue();
            var red = new Red();
            Rectangle rectangleBlue = new Rectangle { color = blue };
            Rectangle rectangleRed = new Rectangle { color = red };
            Circle circleBlue = new Circle { color = blue };
            Circle circleRed = new Circle { color = red };
            

            Console.WriteLine($"Blue rectangle's color: {rectangleBlue.GetColor()}");
            Console.WriteLine($"Red rectange's color: {rectangleRed.GetColor()}");
            Console.WriteLine($"Blue cirlce's color: {circleBlue.GetColor()}");
            Console.WriteLine($"Red circle's color: {circleRed.GetColor()}");

        }
    }
}
