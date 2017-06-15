using System;

namespace Generics.StaticMembers
{
    public static class StaticClass<T>
    {
        public static void Print(T item)
        {
            Console.WriteLine(item);
        }
    }
}