using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes.Polimorphism
{
    class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString() => $"Position X: {X} and Y: {Y}";
        
          
        
    }
}
