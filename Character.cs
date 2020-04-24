using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Character
    {

    
        


        public Random generator = new Random();
        public int hp;
        protected int charm;   //Charming ability
        protected int dex;      //High dex = Higher chance of dodging
        protected int strength;  // High strength = deals more damage
        protected int accuracy; // High accuracy = Higher chances to hit


        //Denna metod beräknar hur mycket damage som karaktären kan kommer göra beroende på dens styrka och slump
        public virtual int Attack()
        {

            int attackDamage = generator.Next(1, 10);

            attackDamage = attackDamage + strength;

            return attackDamage;


        }
        

        //Denna metod beräknar hur om karkatäreren hinner dodga beroende på dens dex och slump
        public virtual int Dodge()
        {

            int dexStat = generator.Next(1, 10);

            dexStat = dexStat + dex;

            return dexStat;


        }

        //Denna metod beräknar om karaktären kan charmera fienden beroende på dens charm och slump
        public virtual int Charm()
        {

            int charmingStat = generator.Next(1, 10);

            charmingStat = charmingStat + charm;

            return charmingStat;

        }

        //Denna metod beräknar om karkatären kan träffa sin fiende beroende på dens accuracy och slump
        public virtual int HittingTarget()
        {

            int accuracyStat = generator.Next(1, 10);

            accuracyStat = accuracyStat + accuracy;

            return accuracyStat;



        }

        //Denna metod beräknar hur mycket damage som karaktären kommer ta
        public virtual int GetDamaged(int amount)
        {

            hp = hp - amount;

            return hp;


        }





    }

}
