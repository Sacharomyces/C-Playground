using Inheritance.Classes.Polimorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {

       


        static void Main(string[] args)
        {
            var shape = new Shape();
            var elip = new Elipse();
            var r = new Rectangular();



            elip.Position.X = 2;
            elip.Position.Y = 2;
            

            r.Position.X = 1;
            r.Position.Y = 1;
            r.Size.Width = 10;
            r.Size.Height = 10;

            r.Draw();

            elip.Greet("Bartek");
            shape.Greet("Bartek");
            GreetShape(elip);
            GreetShape(r);
            GreetShape(shape);

            elip.ElipDraw();

            Console.ReadKey();
        }

        static void GreetShape(Shape shape)
        {
            shape.Greet("hehe");
        }
    }
}
