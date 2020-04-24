﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Skeleton: Enemy
    {

        public Skeleton()
        {

            
            charm = generator.Next(8,14);
            dex = generator.Next(8,14);
            strength = generator.Next(1,7);
            accuracy = generator.Next(1,7);



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