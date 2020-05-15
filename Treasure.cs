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
        protected int value; //Hur mycket som treasuren är värd. Poäng alltså.

        //Denna metod slumpar fram en siffra mellan 1 och 100. Är siffran över 40 kommer en ny Treasure subklass instansieras och retuneras, är den under kommer en annan typ av Treasure subklass instansieras och retuneras
        //Syftet med metoden är helt enkelt att slumpa fram om spelaren kommer få en cursed tresure eller en helt vanlig. I slutet av spelet skulle de kunna räknas som poäng
        //Cursed Treasure skulle kkunna ge minus poäng och normala treasures skulle kunna ge pluspoäng
        public Treasure CreateTreasure()
        {

            
            int randomNumber = generator.Next(1,100);// En siffra mellan 1 till 100 slumpas fram

            if (randomNumber >= 40) // Om det slumpade talet är över 40 kommer en instans av useful treasure att skapas och retuneras
            {

                UsefulTreasure nonCursed = new UsefulTreasure();
                return nonCursed;

            }
            else if (randomNumber <= 40)// Om det slumpade talet är under 40 kommer en instans av cursed treasure att skapas och retuneras
            {

                CursedTreasure Curesd = new CursedTreasure();
                return Curesd;


            }



            UsefulTreasure nonCuresd = new UsefulTreasure();
            return nonCuresd;



        }


    }
}
