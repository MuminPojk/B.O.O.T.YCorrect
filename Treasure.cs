using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Treasure
    {
        Random generator = new Random();
        protected int value;


        public Treasure CreateTreasure()
        {

            
            int randomNumber = generator.Next(1,100);

            if (randomNumber >= 40)
            {

                UsefulTreasure nonCursed = new UsefulTreasure();
                return nonCursed;

            }
            else if (randomNumber <= 40)
            {

                CursedTreasure Curesd = new CursedTreasure();
                return Curesd;


            }



            UsefulTreasure nonCuresd = new UsefulTreasure();
            return nonCuresd;



        }


    }
}
