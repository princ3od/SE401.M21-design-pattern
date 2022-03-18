using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        private readonly int _width;
        private readonly int _height;

        public Rectangle(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            this._width = rectangle._width;
            this._height = rectangle._height;
        }


        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }

    public abstract class Shape
    {
        protected int x;
        protected int y;
        protected string color;
        protected Shape(){}


        protected Shape(Shape shape)
        {
            this.x = shape.x;
            this.y = shape.y;
            this.color = shape.color;
        }

        public abstract Shape Clone();



        

      

    }

    public class Circle : Shape
    {
        private readonly int _radius;

        public Circle(int x, int y, int radius)
        {
            this._radius = radius;
            this.x = x;
            this.y = y;
        }

        public Circle(Circle circle) : base(circle)
        {
            this._radius = circle._radius;
        }


        public override Shape Clone()
        {
            return new Circle(this);
        }
    }

}
