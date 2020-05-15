using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class ThePirates: Character//OBS se klassen character för mer djupgående förklaringar
    {
        public Stack<Treasure> inventory = new Stack<Treasure>(); // Är en en stack som har hand om allt som spelaren plockade upp under spelets gång

        public ThePirates()//Detta är en konstruktor som skapas så fort klassen inistineras
        {
            // Alla dessa ärvs från klassen character, de tar alltså den variabeln som är deklarerad i klassen Character och tar det värdet som är sparat i den variablen minus/plus ett annat tal som i detta fall är 10,2 eller 1
            //Detta sparas sedan i samma variabel som ärvts från basklassen och byter ut det värdet som orginellt fanns i variabeln



            hp = 77;

             charm = generator.Next(10, 14);
             dex = generator.Next(5, 10);
             strength = generator.Next(5, 10);
            accuracy = generator.Next(14, 17);

        }

        //Kommer ta in den skatt som spelaren hittade och lägga in den i dess inventory. Sedan retuneras stacken.
        //Denna metods syfte är att placera de saker som spelaren hittar på ett säkert ställe så att spelaren vid ett senare tillfälle kan använda föremålen
        public Stack<Treasure> AddToInventory(Treasure treasure)
        {

            inventory.Push(treasure);

            return inventory;


        }

        //För tydligare instruktioner för dessa metoder se klassen Character, alla metoder använder sig av basklassens version av metoden
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
