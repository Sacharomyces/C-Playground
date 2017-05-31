using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes.Polimorphism
{
    class Size
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public override string ToString() => $" Width: {Width} and  Height: {Height}";
        
            
        
    }
}
