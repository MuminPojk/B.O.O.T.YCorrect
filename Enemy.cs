using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Enemy : Character//OBS se klassen character för mer djupgående förklaringar
    {

        public Enemy() // Denna konstrukor startas så fort som klassen instansieras, denna konstruktor slumpar mellan 50 och 90 som kommer bli alla subklassers hp, dena variable kommer senare ändras inom subklasserna
        {


            hp = generator.Next(50, 90);

        

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
