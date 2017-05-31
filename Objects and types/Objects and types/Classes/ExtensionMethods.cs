using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_types.Classes
{
    public static class ExtensionMethods
    {
        public static void Logi (this string str)
        {
            Console.WriteLine(str);
        }

        public static void RefChange (this RefAndOut refAndOut)
        {

        }

        public static void DefaultMethod(this Type t) 
        {
            Console.WriteLine("ohhh yeah");
            
        }
    }
}
