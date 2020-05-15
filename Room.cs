using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Room
    {
        
        protected Random generator = new Random();
        BigSkeleton BigSkeleton = new BigSkeleton();
        BigSpider BigSpider = new BigSpider();
        SmallSkeleton SmallSkeleton = new SmallSkeleton();
        SmallSpider SmallSpider = new SmallSpider();


        //kommer slumpa fram vilken fiende som man möter när man går in i ett fightroom
        //Fienderna kommer läggas in i en lista som sedan slumpar fram ett tal beroende på hur lång listan är med fiender. 
        //Beroende på vilket tal som slumpas fram kommer en enemy i listan att retuneras.
        public virtual Enemy EnterRoom()
        {

            List<Enemy> enemys = new List<Enemy>();

            enemys.Add(SmallSkeleton);
            enemys.Add(BigSkeleton);
            enemys.Add(SmallSpider);
            enemys.Add(BigSpider); // En list skapas där en instans av varje enemy läggs in

            int randomNumber = generator.Next(enemys.Count);// slumpar mellan listan enemy`s index


            if (randomNumber == 0)// Beroende på vilken siffra som randomnumber har kommer en specifik enemy att retuneras
            {

                Console.WriteLine("A small skeleton approches you");

                return enemys[0];



            }
            else if (randomNumber == 1)
            {

                Console.WriteLine("A big skeleton approches you");

                return enemys[1];
            }
            else if (randomNumber == 2)
            {

                Console.WriteLine("A small spider approches you");

                return enemys[2];

            }
            else if (randomNumber == 3)
            {
                Console.WriteLine("A big spider approches you");

                return enemys[3];

            }

            return enemys[0];// Går något fel i koden kommer BigSpider att retuneras


        }

        // Se FightRoom eller FightRoom2 för tydligare förklaringar
        public virtual int Battle(ThePirates player, Character foe)
        {

            return player.hp;

        }

        // Se PuzzelRoom eller PuzzelRoom2 för tydligare förklaringar
        public virtual int EnteringSeq1(ThePirates player)
        {

            return player.hp;


        }

        //Se PuzzelRoom eller PuzzelRoom2 för tydligare förklaringar
        public virtual void ShowAnswers()
        {


        }


        //Se EnteringSeq1 för närmare förklaring
        public virtual int EnteringSeq2(ThePirates player)
        {

            return player.hp;

        }


        //Se ShowAnswers för närmare förklaring
        public virtual void ShowAnswers2()
        {



        }
        
    }
    
}
