using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Circle circle = new Circle(10,10,20);
            shapes.Add(circle);
            Rectangle rectangle = new Rectangle(20,10);
            shapes.Add(rectangle);
            List<Shape> copyShapes = new List<Shape>();
            foreach (var shape in shapes)
            {
                copyShapes.Add(shape.Clone());
            }

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"{shapes[i].GetHashCode()} ------- {copyShapes[i].GetHashCode()}");
                Console.WriteLine($"I: {shapes[i].ToString()} ------- {copyShapes[i].ToString()}");
            }
            Console.ReadLine();
        }
    }
}
