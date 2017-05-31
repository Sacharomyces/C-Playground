using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes.Polimorphism
{
    class Rectangular: Shape
    {
        

        public  void Draw() => Console.WriteLine($"Rectangular with {Position} and {Size}");

        
           
    }
}
