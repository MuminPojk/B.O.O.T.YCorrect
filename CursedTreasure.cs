using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class CursedTreasure: Treasure
    {

        public CursedTreasure()
        {

            Random generator = new Random();
            value = generator.Next(-100, 0);
           



        }
        
       

    }
}
