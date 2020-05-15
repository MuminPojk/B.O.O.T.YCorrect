using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Dungeon
    {
        

        public void PlayGame()
        {

            //Gör instanser av ett antal klasser
            Room currentRoom = new Room();
            Character Character = new Character();
            Treasure Treasure = new Treasure();
            ThePirates ThePirates = new ThePirates();
            InputManager InputManager = new InputManager();


            currentRoom = new StartRoom(); //Skapar en instans av subklassen startroom som sparas i variabeln currentroom som från början var av datatypen Room, 

            Console.WriteLine("You come to a crossroad, do you go to the right or to the left? (Write either right or left to choose)");
            string input = Console.ReadLine();

            input = InputManager.LeftRight(input); //Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

            if (input == "right") // Om spelaren väljer höger
            {

                currentRoom = new FightRoom(); // Efter att spelaren  valt riktning sparas en ny subklass i variablen currentRoom, detta signalerar att man har bytt rum


                ThePirates.hp = currentRoom.Battle(ThePirates, Character);// Här kallas den subklassen som sparats i currentrooms Battle-metod, parametarna som åker in är av klassen character och thepirates
                // det som returneras sparas sedan i the pirates hp som är en publik variabel


                if (ThePirates.hp <= 0) // Är spelarens hp under 0 kommer spelet automatiskt avslutas och spelaren får spela om spelet
                {

                    Console.WriteLine("you ded, Try again another time, press enter to quit");
                    Console.ReadLine();
                    return;
                }

                Treasure = Treasure.CreateTreasure();// Här kallas klassens treasures metod för att bestämma om skatten som spelaren hittar förtrollad eller inte, detta sparas sedan i variabeln treasure som instaniserades innan
                Console.WriteLine("your team has found treasure! Do you pick it up? (Write either yes or no)");
                input = Console.ReadLine();
                input = InputManager.YesOrNo(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                if (input == "yes")// Om spelaren väljer/ skriver ja
                {

                    ThePirates.AddToInventory(Treasure);// spelaren svarade ja så stoppas treasuren som har hittats in i the pirates inventory som också är spelarens inventory

                }
                else
                {

                    Console.WriteLine("Okay, you leave it where you found it and instead countiune on to the next crossroad");

                }



                Console.WriteLine("Do you choose to go forward or left?(Write either forward or left to choose)");
                input = Console.ReadLine();
                input = InputManager.LeftForward(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                if (input == "forward")// Om spelaren väljer/ skriver framåt
                {


                    currentRoom = new FightRoom2(); // Efter att spelaren  valt riktning sparas en ny subklass i variablen currentRoom, detta signalerar att man har bytt rum


                    ThePirates.hp = currentRoom.Battle(ThePirates, Character);// Här kallas den subklassen som sparats i currentrooms Battle-metod, parametarna som åker in är av klassen characters
                                                                              // det som returneras sparas sedan i the pirates hp som är en publik variabel


                    if (ThePirates.hp <= 0) // Är spelarens hp under 0 kommer spelet automatiskt avslutas och spelaren får spela om spelet
                    {

                        Console.WriteLine("you ded, Try again another time, press enter to quit");
                        Console.ReadLine();
                        return;
                    }


                    Treasure Treasure2 = Treasure.CreateTreasure();// här instaniseras en ny treasure där en ny treasure sparas som är en av de 2 tillgängliga subklasserna
                    Console.WriteLine("your team has found treasure! Do you pick it up? (Write yes or no)");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                    if (input == "yes")// Om spelaren väljer/ skriver ja
                    {

                        ThePirates.AddToInventory(Treasure);// spelaren svarade ja så stoppas treasuren som har hittats in i the pirates inventory som också är spelarens inventory

                    }
                    else
                    {

                        Console.WriteLine("Okay, you leave it where you found it");

                    }




                    Console.WriteLine("Congrats you and your team survived the journey, Press enter to quit");
                    Console.ReadLine();
                    return;

                }
                else if (input == "left")// Om spelaren väljer/ skriver vänster
                {

                    //Play puzzel sequence
                    currentRoom = new PuzzleRoom2(); //Play puzzelroom 2, Efter att spelaren  valt riktning sparas en ny subklass i variablen currentRoom, detta signalerar att man har bytt rum

                    ThePirates.hp = currentRoom.EnteringSeq2(ThePirates);// Här kallas den subklassen som sparats i currentrooms Enteringsequence-metod, parametarna som åker in är av klassen character
                                                                         // det som returneras sparas sedan i the pirates hp som är en publik variabel

                    if (ThePirates.hp <= 0) // Är spelarens hp under 0 kommer spelet automatiskt avslutas och spelaren får spela om spelet
                    {

                        Console.WriteLine("you ded, Try again another time, press enter to quit");
                        Console.ReadLine();
                        return;
                    }


                    Treasure Treasure3 = Treasure.CreateTreasure();// här instaniseras en ny treasure där en ny treasure sparas som är en av de 2 tillgängliga subklasserna
                    Console.WriteLine("your team has found treasure! Do you pick it up? (Write yes or no)");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                    if (input == "yes")// Om spelaren väljer/ skriver ja
                    {

                        ThePirates.AddToInventory(Treasure);// spelaren svarade ja så stoppas treasuren som har hittats in i the pirates inventory som också är spelarens inventory

                    }
                    else
                    {

                        Console.WriteLine("Okay, you leave it where you found it");

                    }

                    Console.WriteLine("Congrats you and your team survived the journey, Press enter to quit");
                    Console.ReadLine();
                    return;

                }



            }
            else if (input == "left")// Om spelaren väljer/ skriver vänster
            {

                currentRoom = new PuzzleRoom(); // Efter att spelaren  valt riktning sparas en ny subklass i variablen currentRoom, detta signalerar att man har bytt rum
                ThePirates.hp = currentRoom.EnteringSeq1(ThePirates);// Här kallas den subklassen som sparats i currentrooms Enteringsequence-metod, parametarna som åker in är av klassen character
                                                                     // det som returneras sparas sedan i the pirates hp som är en publik variabel

                if (ThePirates.hp <= 0) // Är spelarens hp under 0 kommer spelet automatiskt avslutas och spelaren får spela om spelet
                {

                    Console.WriteLine("you ded, Try again another time, press enter to quit");
                    Console.ReadLine();
                    return;
                }


                Treasure Treasure4 = Treasure.CreateTreasure();// här instaniseras en ny treasure där en ny treasure sparas som är en av de 2 tillgängliga subklasserna
                Console.WriteLine("your team has found treasure! Do you pick it up? (Write yes or no)");
               
                input = Console.ReadLine();
                input = InputManager.YesOrNo(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                if (input == "yes")// Om spelaren väljer/ skriver ja
                {

                    ThePirates.inventory = ThePirates.AddToInventory(Treasure);// spelaren svarade ja så stoppas treasuren som har hittats in i the pirates inventory som också är spelarens inventory

                }
                else
                {


                    Console.WriteLine("Okay, you leave it where you found it");

                }

                Console.WriteLine("forward or right?(Write either right or forward to choose)");
                input = Console.ReadLine();
                input = InputManager.RightForward(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt



                if (input == "forward")// Om spelaren väljer/ skriver framåt
                {

                    //Play puzzel sequence
                    currentRoom = new PuzzleRoom2();// Efter att spelaren  valt riktning sparas en ny subklass i variablen currentRoom, detta signalerar att man har bytt rum
                    ThePirates.hp = currentRoom.EnteringSeq2(ThePirates);// Här kallas den subklassen som sparats i currentrooms Enteringsequence-metod, parametarna som åker in är av klassen character
                                                                         // det som returneras sparas sedan i the pirates hp som är en publik variabel

                    if (ThePirates.hp <= 0) // Är spelarens hp under 0 kommer spelet automatiskt avslutas och spelaren får spela om spelet
                    {

                        Console.WriteLine("you ded, Try again another time, press enter to quit");
                        Console.ReadLine();
                        return;
                    }

                    Treasure Treasure5 = Treasure.CreateTreasure();// här instaniseras en ny treasure där en ny treasure sparas som är en av de 2 tillgängliga subklasserna
                    Console.WriteLine("your team has found treasure! Do you pick it up? (Write yes or no)");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                    if (input == "yes")// Om spelaren väljer/ skriver ja
                    {

                        ThePirates.AddToInventory(Treasure);// spelaren svarade ja så stoppas treasuren som har hittats in i the pirates inventory som också är spelarens inventory

                    }
                    else
                    {

                        Console.WriteLine("Okay, you leave it where you found it");

                    }

                    Console.WriteLine("Congrats you and your team survived the journey, Press enter to quit");
                    Console.ReadLine();
                    return;

                }
                else if (input == "right")// Om spelaren väljer/ skriver höger
                {


                    //Play fight sequence
                    currentRoom = new FightRoom2();// Efter att spelaren  valt riktning sparas en ny subklass i variablen currentRoom, detta signalerar att man har bytt rum


                    ThePirates.hp = currentRoom.Battle(ThePirates, Character);// Här kallas den subklassen som sparats i currentrooms Battle-metod, parametarna som åker in är av klassen characters
                                                                              // det som returneras sparas sedan i the pirates hp som är en publik variabel


                    if (ThePirates.hp <= 0)// Är spelarens hp under 0 kommer spelet automatiskt avslutas och spelaren får spela om spelet
                    {

                        Console.WriteLine("you ded, Try again another time, press enter to quit");
                        Console.ReadLine();
                        return;
                    }


                    Treasure Treasure6 = Treasure.CreateTreasure();// här instaniseras en ny treasure där en ny treasure sparas som är en av de 2 tillgängliga subklasserna
                    Console.WriteLine("your team has found treasure! Do you pick it up? (Write yes or no)");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);//Kallar på en metod från Inputmanager som kollar om spelaren skrivit ett acceptabelt

                    if (input == "yes")// Om spelaren skriver ja
                    {

                        ThePirates.AddToInventory(Treasure);// spelaren svarade ja så stoppas treasuren som har hittats in i the pirates inventory som också är spelarens inventory

                    }
                    else
                    {

                        Console.WriteLine("Okay, you leave it where you found it");

                    }

                    Console.WriteLine("Congrats you and your team survived the journey, Press enter to quit");
                    Console.ReadLine();
                    return;

                }


            }







        }




    }
}
