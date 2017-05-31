using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_types.Classes
{
    class Singleton
    {
       

        private static Singleton _nul;


        private Singleton()
        {

        }

        public static Singleton create()
        {
          _nul = _nul ??  new Singleton();

            return _nul;

        }
    }
}
