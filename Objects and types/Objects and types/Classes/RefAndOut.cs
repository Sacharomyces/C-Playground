using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_types.Classes
{
     public class RefAndOut
    {
        public void ChangeStringRef(ref string str)
        {
            str = "zmieniony";

            Console.WriteLine($"in method: {str}");
        }

        public void OutCheck (string str,out int i)
        {
            i = int.Parse(str);
            Console.WriteLine("i in method: " + i);
        }
    }
}
