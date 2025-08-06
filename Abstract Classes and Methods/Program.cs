using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(7);
            Shape rectangle = new Rectangle(5, 8);

            Console.WriteLine($"The circle has an area of {circle.GetArea()} square units.");
            Console.WriteLine($"The rectangle has an area of {rectangle.GetArea()} square units.");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
