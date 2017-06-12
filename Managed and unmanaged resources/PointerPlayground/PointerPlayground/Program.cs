using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerPlayground
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int x = 10;
            short y = -1;
            byte y2 = 4;
            double z = 1.5;
            int* pX = &x;
            short* pY = &y;
            double* pZ = &z;

            Console.WriteLine($" Address of x is 0x{(ulong)&x:X} and 0x{(ulong)pX:x8}" + $" size is {sizeof(int)}, value is {x}");
            Console.ReadKey();


        }
    }
}
