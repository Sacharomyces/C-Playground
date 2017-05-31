using Objects_and_types.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_types
{
    class Program
    {
        static void Main(string[] args)
        {
        
            RefAndOut ref1 = new RefAndOut();
            Parameters param = new Parameters();

            int i;
            string OutString = "123";
            string before = "not changed";
            int[] arr = {2, 4, 5, 6, 7, 8 };

            

            param.OptionalParameters(1);

            param.ObjectArrayParams("param","czemu", 3, 45, 10 );

            ref1.ChangeStringRef(ref before);
            ref1.OutCheck(OutString,out i);

            Console.WriteLine($"Outside: {before}");

            Console.WriteLine($"int ouside: {i}");

            

            Singleton nu1 = Singleton.create();
            Singleton nu2 = Singleton.create();

            if(nu1 == nu2)
            {
                Console.WriteLine("ten sam obiekt");
            }

            var weekend = Enums.DaysOfWeekHex.Weekend;

            if ((weekend & Enums.DaysOfWeekHex.Saturday) == Enums.DaysOfWeekHex.Saturday)
            {
                Console.WriteLine("Weekend includes Saturday");
            }

            foreach (int day in Enum.GetValues(typeof(Enums.DaysOfWeekDec)))
            {
                Console.WriteLine(day);
            }

         
            
          
            
            Console.ReadLine();
        }
    }
}
