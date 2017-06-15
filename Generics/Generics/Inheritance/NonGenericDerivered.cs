using System;
using System.Collections.Generic;

namespace Generics.Inheritance
{
    public class NonGenericDerivered<T>:BaseClass<string>// making a non generic derivered class
    {
        public void Print()
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}