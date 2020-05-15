using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class UsefulTreasure: Treasure
    {

        public UsefulTreasure() // Ärver från Treasure, kommer finnas ett poängsystem där useful treasure ger plus poäng,detta är en konstruktor som anropas varje gång som en ny instans av klassen skapas
        {

            Random generator = new Random();
            value = generator.Next(10,100); //Pluspoäng
           

        }
       
     

    }
}
