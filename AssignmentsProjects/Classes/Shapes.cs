using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsProjects.Classes
{
    public class Circle : Shape, IDrawable
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        internal override double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {_radius}");
        }
    }

    public class Rectangle : Shape, IDrawable
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        internal override double Area()
        {
            return _width * _height;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {_width} and height {_height}");
        }
    }

    public class Triangle : Shape, IDrawable
    {
        private double _base;
        private double _height;

        public Triangle(double baseLength, double height)
        {
            _base = baseLength;
            _height = height;
        }

        internal override double Area()
        {
            return 0.5 * _base * _height;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a triangle with base {_base} and height {_height}");
        }
    }
}
