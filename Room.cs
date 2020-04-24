using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Room
    {

        Random generator = new Random();

        public HashSet<string> playersAnswer = new HashSet<string>();
        private string[] correctAnswers = { "milk", "nothing", "ribs", "kalcium", "people", "bonuts" };

        public HashSet<string> playersAnswer2 = new HashSet<string>();
        private string[] correctAnswers2 = { "trombone", "nothing", "ear drum", "xylobone", "saxobone", "bone harp" };


        InputManager InputManager = new InputManager();
        BigSkeleton BigSkeleton = new BigSkeleton();
        BigSpider BigSpider = new BigSpider();
        SmallSkeleton SmallSkeleton = new SmallSkeleton();
        SmallSpider SmallSpider = new SmallSpider();
        
       
        //kommer slumpa fram vilken fiende som man möter när man går in i ett fightroom
        public virtual Enemy EnterRoom()
        {


             List<Enemy> enemys = new List<Enemy>();

             enemys.Add(SmallSkeleton);
            enemys.Add(BigSkeleton);
            enemys.Add(SmallSpider);
            enemys.Add(BigSpider);

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

            return BigSpider;// Går något fel i koden kommer BigSpider att retuneras

        }

        //Denna metod har hand om hela fighten när spelaren går in i ett fightroom, parametrarna som tas in är spelaren och den fienden som slumpades fram i EnterRoom
        public virtual int Battle(ThePirates player, Character foe)
        {

            Console.WriteLine("You enter a room that seems to be pretty quiet. The cave is humongos with a little hole at the top for light to stream trhough");
            Console.WriteLine("However when you are distracted by the little hole you hear a screah and the tap of feet");
            Console.WriteLine("You tell your man to get ready for a scrap");
            

            //Det finns nio olika senarion som kan hända beroende på spelaren och fiendens val
            //fiendes val kommer att slumpas fram varje omgång 

            foe = EnterRoom(); // Det som retunardes från EnterRoom vilket var en enemy, kommer sparas i character foe 

            while (player.hp > 0 && foe.hp > 0)// Denna loop kommer köras så länge som båda kämparnas hp är över 0
            {


                Console.WriteLine("What would you like to do, press 1, 2 or 3 to decide");
                Console.WriteLine("1.Attack");
                Console.WriteLine("2.Dodge");
                Console.WriteLine("3.Charm");
                

                string input = Console.ReadLine();
                input = InputManager.NumberChose(input);

                int randomNumber = generator.Next(0,2);



                if (input == "1" && randomNumber == 0)// if player attack and foe attack
                {

                    Console.WriteLine("You attacked and your foe attacked");

                    int playerAttack = player.Attack();

                    int foeAttack = foe.Attack();

                    player.hp = player.GetDamaged(foeAttack);

                    foe.hp = foe.GetDamaged(playerAttack);

                    Console.WriteLine("You did " + playerAttack + " points of damage");
                    Console.WriteLine("The foe did " + foeAttack + " points of damage");
                    Console.WriteLine("your hp is at " + player.hp);

                }
                else if (input == "1" && randomNumber == 1) //  if player attack and foe dodge
                {

                    Console.WriteLine("You attacked and your foe dodged");

                    int playerAccuracy = player.HittingTarget();

                    int foeDodge = foe.Dodge();

                    if (playerAccuracy > foeDodge)
                    {

                        int playerAttack = player.Attack();

                        foe.hp = foe.GetDamaged(playerAttack);

                        Console.WriteLine("The foe did not manage to dodge");
                        Console.WriteLine("You did " + playerAttack + " points of damage");

                    }
                    else if (foeDodge > playerAccuracy)
                    {

                        Console.WriteLine("The foe manage to dodge");

                    }


                }
                else if (input == "1" && randomNumber == 2)// if player attack and foe charm
                {

                    Console.WriteLine("You attacked and your foe tried to charm you");

                    int playerAccuracy = player.HittingTarget();

                    int foeCharm = foe.Charm();

                    if (playerAccuracy > foeCharm)
                    {

                        int playerAttack = player.Attack();

                        foe.hp = foe.GetDamaged(playerAttack);

                        Console.WriteLine("The foe did not manage to charm you");
                        Console.WriteLine("You did " + playerAttack + " points of damage");

                    }
                    else if (foeCharm > playerAccuracy)
                    {

                        player.hp = player.hp - 8;
                        Console.WriteLine("The foe did not manage to charm you");
                        Console.WriteLine("you took 8 damage");

                    }


                }
                else if (input == "2" && randomNumber == 0) //if player dodge and foe attack
                {

                    Console.WriteLine("You dodged and your foe tried to attack you");

                    int foeAccuracy = foe.HittingTarget();

                    int playerDodge = player.Dodge();

                    if (foeAccuracy > playerDodge)
                    {

                        int foeAttack = foe.Attack();

                        player.hp = player.GetDamaged(foeAttack);

                        Console.WriteLine("The foe did " + foeAttack + " points of damage");
                        Console.WriteLine("your hp is at " + player.hp);

                    }
                    else if (playerDodge > foeAccuracy)
                    {

                        Console.WriteLine("you managed to dodge the attack");

                    }

                }
                else if (input == "2" && randomNumber == 1) //if player dodge and foe dodge
                {

                    Console.WriteLine("You both tried to dodge");

                   

                }
                else if (input == "2" && randomNumber == 2)// if player dodge and foe charm
                {

                    Console.WriteLine("You dodged and your foe tried to charm you");

                    int playerDodge = player.Dodge();
                    int foeCharm = foe.Charm();

                    if (playerDodge > foeCharm)
                    {

                        Console.WriteLine("You managed to dodge the attack");

                    }
                    else if (foeCharm > playerDodge)
                    {

                        player.hp = player.hp - 8;

                        Console.WriteLine("The foe did 8 points of damage");
                        Console.WriteLine("your hp is at " + player.hp);

                    }


                }

                else if (input == "3" && randomNumber == 0) //if player charm and foe attack
                {

                    Console.WriteLine("You tried to charm and your foe tried to attack you");

                    int foeAccuracy = foe.HittingTarget();

                    int playerCharm = player.Charm();

                    if (foeAccuracy > playerCharm)
                    {

                        Console.WriteLine("You didn`t manage to charm your foe");

                        int foeAttack = foe.Attack();

                        player.hp = player.GetDamaged(foeAttack);

                        Console.WriteLine("The foe did " + foeAttack + " points of damage");
                        Console.WriteLine("your hp is at " + player.hp);

                    }
                    else if (playerCharm > foeAccuracy)
                    {

                        foe.hp = foe.hp - 8;

                        Console.WriteLine("Your foe didn´T manage to get to you within time, your charm was a success");

                        Console.WriteLine("You dealt 8 damage to the foe");
                        

                    }

                }
                else if (input == "3" && randomNumber == 1) //if player charm and foe dodge
                {

                    Console.WriteLine("You tried to charm and your foe tried to dodge");

                    int foeDodge = foe.Dodge();
                    int playerCharm = player.Charm();

                    if (foeDodge > playerCharm)
                    {

                        Console.WriteLine("The foe managed to dodge");

                    }
                    else if (playerCharm > foeDodge)
                    {

                        foe.hp = foe.hp - 8;
                        Console.WriteLine("You dealt 8 damage to the foe");

                    }




                }
                else if (input == "3" && randomNumber == 2)// if player charm and foe charm
                {

                    Console.WriteLine("You and your foe tried to charm each other");

                    int playerCharm = player.Charm();
                    int foeCharm = foe.Charm();

                    if (foeCharm > playerCharm)
                    {

                        player.hp = player.hp - 8;
                        Console.WriteLine("You suffered 8 damage");
                        Console.WriteLine("Your hp at " + player.hp + " points");

                    }
                    else if (playerCharm > foeCharm)
                    {

                        foe.hp = foe.hp - 8;
                        Console.WriteLine("You dealt 8 damage to the foe");

                    }
                    else if (playerCharm == foeCharm)
                    {

                        Console.WriteLine("nothing happened you both charmed the the same amount");

                    }

                 
                }
                
            }


            if (player.hp > 0 && foe.hp < 0)
            {

                Console.WriteLine("Hurray you do not die");
                return player.hp;

            }
            else if (player.hp < 0 && foe.hp > 0)
            {

                Console.WriteLine("oh no you died");
                return player.hp;

            }
            else if (player.hp< 0 && foe.hp < 0)
            {

                Console.WriteLine("oh no you died, but so is your foe");
                return player.hp;


            }
            
            return player.hp;

        }

        public virtual int EnteringSeq1(ThePirates player)
        {


            Console.WriteLine("What does skeletons like to eat/drink?");
            Console.WriteLine("Write any answer you can think of however for every wrong answer you recive some damage");

            string input = Console.ReadLine();



            while (input != correctAnswers[0] && input != correctAnswers[1] && input != correctAnswers[2] && input != correctAnswers[3] && input != correctAnswers[4] && input != correctAnswers[5])
            {

                playersAnswer.Add(input);

                Console.WriteLine("Wrong answer take some damage, try again");
                player.hp = player.hp - 10;

                Console.WriteLine("Want to see your previous answers?");
                 input = Console.ReadLine();

                if (input == "yes")
                {

                    ShowAnswers();
                    Console.WriteLine("Try to answer the question again");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);



                }
                else if (input == "no")
                {

                    input = Console.ReadLine();

                }
                

            }


            if (input == correctAnswers[0] || input == correctAnswers[1] || input == correctAnswers[2] || input == correctAnswers[3] || input == correctAnswers[4] || input == correctAnswers[5])
            {


                Console.WriteLine("Congrats, you answered correctly");
                Console.WriteLine("You can now exit, your welcome");
               

            }
            
            return player.hp;

        }

        public virtual void ShowAnswers()
        {

            string[] answers = playersAnswer.ToArray();

            for (int i = 0; i < answers.Length; i++)
            {

                Console.WriteLine(answers[i]);

            }



        }
        public virtual int EnteringSeq2(ThePirates player)
        {


            Console.WriteLine("What instrument do a skeleton like to play");
            Console.WriteLine("Write any answer you can think of however for every wrong answer you recive some damage");

            string input = Console.ReadLine();



            while (input != correctAnswers2[0] && input != correctAnswers2[1] && input != correctAnswers2[2] && input != correctAnswers2[3] && input != correctAnswers2[4] && input != correctAnswers2[5])
            {

                playersAnswer2.Add(input);

                Console.WriteLine("Wrong answer take some damage, try again");
                player.hp = player.hp - 10;

                Console.WriteLine("Want to see your previous answers?");
                input = Console.ReadLine();

                if (input == "yes")
                {

                    ShowAnswers2();
                    Console.WriteLine("Try to answer the question again");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);



                }
                else if (input == "no")
                {

                    input = Console.ReadLine();

                }


            }


            if (input == correctAnswers2[0] || input == correctAnswers2[1] || input == correctAnswers2[2] || input == correctAnswers2[3] || input == correctAnswers2[4] || input == correctAnswers2[5])
            {


                Console.WriteLine("Congrats, you answered correctly");
                Console.WriteLine("You can now exit, your welcome");


            }

            return player.hp;

        }

        public virtual void ShowAnswers2()
        {

            string[] answers2 = playersAnswer2.ToArray();

            for (int i = 0; i < answers2.Length; i++)
            {

                Console.WriteLine(answers2[i]);

            }



        }

    }
    
}
