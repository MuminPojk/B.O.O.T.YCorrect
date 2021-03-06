﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class SmallSpider : Spider
    {


        public SmallSpider()//Detta är en konstruktor som skapas så fort klassen inistineras
        {//OBS se klassen character för mer djupgående förklaringar

            // Alla dessa ärvs från klassen character, de tar alltså den variabeln som är deklarerad i klassen Character och tar det värdet som är sparat i den variablen minus/plus ett annat tal som i detta fall är 6,2 eller 1
            //Detta sparas sedan i samma variabel som ärvts från basklassen och byter ut det värdet som orginellt fanns i variabeln
            hp = hp- 6;
            charm = charm + 2;
            dex = dex + 1;
            strength = strength -1;
            accuracy = accuracy + 1;


        }

        //För tydligare instruktioner för dessa metoder se klassen Character, alla metoder använder sig av basklassens version av metoden
        //För tydligare instruktioner för dessa metoder se klassen Character
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
