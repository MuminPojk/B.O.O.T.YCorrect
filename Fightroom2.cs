using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class FightRoom2: Room
    {


        public FightRoom2()
        {

            Console.WriteLine("You enter another cave, but this time you hear the enemy before it attacks");


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
