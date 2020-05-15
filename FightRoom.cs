using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class FightRoom : Room
    {

        InputManager InputManager = new InputManager();
       


        public FightRoom()//Konstruktor
        {


            Console.WriteLine("You leave your fabulous submarine behind as you and your team enter a cave that has strange carvings and symbols on the walls. As your team explore the cave you soon realise that you are not alone");



        }

        //Se Room för tydligare förklaring
        public override Enemy EnterRoom()
        {
            return base.EnterRoom();
        }

        //Denna metod har hand om hela fighten när spelaren går in i ett fightroom, parametrarna som tas in är spelaren och den fienden som slumpades fram i EnterRoom
        //Denna metod innehåller 9 olika scenarion som beror på vad fienden slumpar fram för val och vad spelaren själv väljer
        public override int Battle(ThePirates player, Character foe)
        {
            Console.WriteLine("You enter a room that seems to be pretty quiet. The cave is humongos with a little hole at the top for light to stream trhough");
            Console.WriteLine("However when you are distracted by the little hole you hear a screah and the tap of feet");
            Console.WriteLine("You tell your man to get ready for a scrap");


            //Det finns nio olika senarion som kan hända beroende på spelaren och fiendens val
            //fiendes val kommer att slumpas fram varje omgång 

            foe = EnterRoom(); // Det som retunardes från EnterRoom vilket var en enemy, kommer sparas i character foe. Det är den karaktären som spelaren kommer slåss mot

            while (player.hp > 0 && foe.hp > 0)// Denna loop kommer köras så länge som båda kämparnas hp är över 0
            {


                Console.WriteLine("What would you like to do, press 1, 2 or 3 to decide");
                Console.WriteLine("1.Attack");
                Console.WriteLine("2.Dodge");
                Console.WriteLine("3.Charm");


                string input = Console.ReadLine();
                input = InputManager.NumberChose(input);// KOllar att spelaren skrivit in ett nummer som är 1, 2 eller 3

                int randomNumber = generator.Next(0, 2);



                if (input == "1" && randomNumber == 0)// if player attack and foe attack, Både spelaren och fienden kommer ta skada 
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
                                                            // Om spelaren lyckas få en högre accuracy än fiendens dodge kommer spelaren skada fienden, annars kommer fienden komma undan och ingen tar skada
                {

                    Console.WriteLine("You attacked and your foe dodged");

                    int playerAccuracy = player.HittingTarget();

                    int foeDodge = foe.Dodge();

                    if (playerAccuracy >= foeDodge)
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
                else if (input == "1" && randomNumber == 2)// if player attack and foe charm // spelarens accuracy måste vara högre än fiendens charm. Är den det kommer fienden ta skada annars tar spelaren skada
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
                    else if (foeCharm >= playerAccuracy)
                    {

                        player.hp = player.hp - 8;
                        Console.WriteLine("The foe did manage to charm you");
                        Console.WriteLine("you took 8 damage");

                    }


                }
                else if (input == "2" && randomNumber == 0) //if player dodge and foe attack 
                                                            // Om spelaren lyckas få en högre dex score än fiendens accuracy kommer spelaren undan och ingen tar skada, annars träffar fienden spelaren och den tar skada
                {

                    Console.WriteLine("You dodged and your foe tried to attack you");

                    int foeAccuracy = foe.HittingTarget();

                    int playerDodge = player.Dodge();

                    if (foeAccuracy >= playerDodge)
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
                else if (input == "2" && randomNumber == 1) //if player dodge and foe dodge // Båda tar skydd och ingen tar skada eller får konsekvenser
                {

                    Console.WriteLine("You both tried to dodge");



                }
                else if (input == "2" && randomNumber == 2)// if player dodge and foe charm
                                                           // spelarens dex score måste vara högre än fiendens charm. Är den det kommer spelaren undan och ingen tar skada om fiendens charm är högre än spelarens dex kommer spelaren ta skada
                {

                    Console.WriteLine("You dodged and your foe tried to charm you");

                    int playerDodge = player.Dodge();
                    int foeCharm = foe.Charm();

                    if (playerDodge >= foeCharm)
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

                else if (input == "3" && randomNumber == 0) //if player charm and foe attack// spelarens charm score måste vara högre än fiendens accuracy. Är den det kommer fienden ta skada annars tar spelaren skada
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
                    else if (playerCharm >= foeAccuracy)
                    {

                        foe.hp = foe.hp - 8;

                        Console.WriteLine("Your foe didn´T manage to get to you within time, your charm was a success");

                        Console.WriteLine("You dealt 8 damage to the foe");


                    }

                }
                else if (input == "3" && randomNumber == 1) //if player charm and foe dodge
                {// spelarens charm score måste vara högre än fiendens dex. Är den det kommer fienden ta skada, däremot om fiendens dex score är högre än spelarens charm tar ingen skada

                    Console.WriteLine("You tried to charm and your foe tried to dodge");

                    int foeDodge = foe.Dodge();
                    int playerCharm = player.Charm();

                    if (foeDodge >= playerCharm)
                    {

                        Console.WriteLine("The foe managed to dodge");

                    }
                    else if (playerCharm > foeDodge)
                    {

                        foe.hp = foe.hp - 8;
                        Console.WriteLine("You dealt 8 damage to the foe");

                    }




                }
                else if (input == "3" && randomNumber == 2)// if player charm and foe charm // Om fiendens charm är högst tar spelaren skada men om spelarens charm är högst tar fienden skada
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


            if (player.hp > 0 && foe.hp < 0) //Kommer retunera spelarens hp om spelaren lever
            {

                Console.WriteLine("Hurray you do not die");
                return player.hp;

            }
            else if (player.hp < 0 && foe.hp > 0)//Kommer retunera spelarens hp om fienden lever
            {

                Console.WriteLine("oh no you died");
                return player.hp;

            }
            else if (player.hp < 0 && foe.hp < 0)//Kommer retunera spelarens hp om spelaren oc fienden är döda
            {

                Console.WriteLine("oh no you died, but so is your foe");
                return player.hp;


            }

            return player.hp;
        }


    }
        

    
}
