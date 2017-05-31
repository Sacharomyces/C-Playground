using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Objects_and_types.Classes

{
    class Parameters
    {
        public void OptionalParameters (int i, int opt1 = 12, int opt2 = 13)
        {
            Console.WriteLine($"Parameters: {i}, {opt1}, {opt2}");
        }

        public void VariableNumberOfParams (params int[] data)
        {
            foreach (var x in data)
            {
                Console.WriteLine(x);

            }

        }


        public void ObjectArrayParams(string str, params object[] data)
        {
            foreach (var x in data)
            {
                Console.WriteLine($"{str} : {x}");

            }
        }
    }
}
