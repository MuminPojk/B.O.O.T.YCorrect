using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class FightRoom : Room
    {

      

        public FightRoom()//Konstruktor
        {


            Console.WriteLine("You leave your fabulous submarine behind as you and your team enter a cave that has strange carvings and symbols on the walls. As your team explore the cave you soon realise that you are not alone");



        }

        public override Enemy EnterRoom()
        {
            return base.EnterRoom();

        }
        public override int Battle(ThePirates player, Character foe)
        {
            return base.Battle(player, foe);

        }


    }
        

    
}
