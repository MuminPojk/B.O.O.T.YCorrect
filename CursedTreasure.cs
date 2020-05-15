using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class CursedTreasure: Treasure
    {

        public CursedTreasure() // Ärver från Treasure, kommer finnas ett poängsystem där cursed treasure ger minus poäng, detta är en konstruktor som anropas varje gång som en ny instans av klassen skapas
        {

            Random generator = new Random();
            value = generator.Next(-100, 0);//innehåller en slumpad mängd minus poäng
           



        }
        
       

    }
}
