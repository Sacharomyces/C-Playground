using System;

namespace Generics.Inheritance
{
    public class GenericDerivered<T> : BaseClass<T>
    {
        public void Print()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}