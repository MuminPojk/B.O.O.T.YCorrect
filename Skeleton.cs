using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Skeleton: Enemy
    {

        public Skeleton()//OBS se klassen character för mer djupgående förklaringar
        {

            // Alla dessa ärvs från klassen character, de tar alltså den variabeln som är deklarerad i klassen Character och slumpar fram ett nytt värde för vardera variabel
            //Detta sparas sedan i samma variabel som ärvts från basklassen och byter ut det värdet som orginellt fanns i variabeln
            charm = generator.Next(8,14);
            dex = generator.Next(8,14);
            strength = generator.Next(1,7);
            accuracy = generator.Next(1,7);



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
