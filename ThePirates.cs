using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class ThePirates: Character
    {
        public Stack<Treasure> inventory = new Stack<Treasure>();

        public ThePirates()
        {

            

            hp = 77;

             charm = generator.Next(10, 14);
             dex = generator.Next(5, 10);
             strength = generator.Next(5, 10);
            accuracy = generator.Next(14, 17);

        }

        //Kommer ta in den skatt som spelaren hittade och lägga in den i dess inventory
        public Stack<Treasure> AddToInventory(Treasure treasure)
        {

            inventory.Push(treasure);

            return inventory;


        }
        

        public override int Attack()
        {

            return base.Attack();


        }
        public override int Dodge()
        {

            return base.Dodge();

        }
        public override int Charm()
        {

            return base.Charm();

        }
        public override int HittingTarget()
        {

            return base.HittingTarget();


        }

        public override int GetDamaged(int amount)
        {

            return base.GetDamaged(amount);


        }


    }
}
