using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes.Polimorphism
{
    class Shape
    {
        public Position Position { get; } = new Position();

        public Size Size { get; } = new Size();


        public void Draw() => Console.WriteLine($"Shape with {Position} and {Size}");

        public virtual void Greet(string str) => Console.WriteLine($"Base {str}");

    }
}

