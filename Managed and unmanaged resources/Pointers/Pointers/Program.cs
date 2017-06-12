using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pointers
{
    class Program
    {
        unsafe static void Main(string[] args)
        { 
            // Casting pointers to other types//

            int x = 10;
            int* pX, pY;
            pX = &x;
            pY = pX;
            *pY = 20;
            ulong y = (ulong) pY;
            int* pI = (int*) y;

            byte b = 8;
            byte* pB = &b;
            byte e = *pB;
           
            // Pointers and structs//

            var mystruct = new MyStruct();

            mystruct.i = 4;
            mystruct.l = 20;

            MyStruct* pStruct;

            pStruct = &mystruct;

            pStruct->i = 8;
            pStruct->l = 40;

            int* pStructI = &mystruct.i;
            long* pStructL = &mystruct.l;

            int ValueOfI = *pStructI; 

            // Pointers with a members of a class  "fixed" keyword//

            var myclass = new MyClass();

            fixed (int* pClassI = &myclass.i)
            fixed (long* pClassL = &myclass.l)
            {
                //do something
            }

            Console.WriteLine($"I = {mystruct.i} and L = {mystruct.l} and ValueOfI = {ValueOfI}");
            Console.ReadKey();

        }

        public struct MyStruct
        {
           public int i;
           public long l;
        }

        public class MyClass
        {
            public int i;
            public long l;
        }
    }
}
