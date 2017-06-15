using System.Collections.Generic;
using System.Security.Policy;

namespace Generics.Inheritance
{
    
    public class BaseClass<T>
    {
        public List<T> list = new List<T>();

        public void AddSomething(T letter)
        {    
            list.Add(letter);
        }
    }


}