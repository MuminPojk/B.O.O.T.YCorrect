using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class BigSpider: Spider
    {

        public BigSpider()
        {

            hp = hp + 10;
            charm = charm + 1;
            dex = dex -1;
            strength = strength + 1;
            accuracy = accuracy - 2;






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
