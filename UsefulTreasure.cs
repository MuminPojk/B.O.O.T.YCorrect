using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class UsefulTreasure: Treasure
    {

        public UsefulTreasure()
        {

            Random generator = new Random();
            value = generator.Next(10,100); //Pluspoäng
           

        }
       
     

    }
}
