using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsProjects.Classes
{
    internal interface IDrawable
    {
        void Draw();
    }

    public abstract class Shape
    {
        internal abstract double Area();

        internal void Describe()
        {
            Console.WriteLine($"This {this.GetType().Name} has an area of {Area()}");
        }
    }
}
