using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes.Polimorphism
{
    class Elipse: Shape
    {

        public new void Greet(string str) => Console.WriteLine($"Hello {str}");

        public void ElipDraw()
        {
            base.Draw();
            Console.WriteLine("base method called");
        }
    }
}
