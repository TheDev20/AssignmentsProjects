using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsProjects.Classes;

namespace AssignmentsProjects
{
    internal class Program
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

        static void Main(string[] args)
        {
            // Create an array of BankAccount objects
            BankAccount[] ac = new BankAccount[2];

            ac[0] = new BankAccount();
            ac[1] = new SavingsAccount(0.05m);

            foreach (BankAccount acc in ac)
            {
                Console.WriteLine($"Account Type: {acc.GetAccountType()}");
                Console.WriteLine($"Balance: {acc.Balance}");
            }
            ac[0].Deposit(1000);
            Console.WriteLine(ac[0].Balance);

            //Shapes
            Shape[] shapes = new Shape[2];
            shapes[0] = new Circle(5);
            shapes[1] = new Rectangle(10, 20);

            foreach (Shape shape in shapes)
            {
                shape.Describe();
                if (shape is IDrawable drawable)
                {
                    drawable.Draw();
                }
            }
        }
    }
}
