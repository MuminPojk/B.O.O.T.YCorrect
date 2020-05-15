using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class PuzzleRoom2: Room
    {

        public HashSet<string> playersAnswer2 = new HashSet<string>(); //Kommer spara alla svar som spelaren skriver in. Kommer däremot endast spara de unika svaren som spelaren skriver in i EnteringSeq1
        private string[] correctAnswers2 = { "trombone", "nothing", "ear drum", "xylobone", "saxobone", "bone harp" }; // en array med de rätta svaren för EnteringSeq2

        InputManager InputManager = new InputManager();

        public PuzzleRoom2()
        {



            Console.WriteLine("You enter a room briefly illuminated when the door behind you shuts, It is completly and utterly dark, ");
            Console.WriteLine("After a few seconds brightly colored light splashes across the room as if a rave was happening");
            Console.WriteLine("From a hole in the ground comes a big screen with a small skeleton wearing a big fancy jacket and a mustasche beside it");
            Console.WriteLine("Welcome to the pundgeon, if you pass this question you may leave but if not damage of random will await you and remember this is the pundgeon");
            Console.WriteLine("(This question can have multiple answers)");
            Console.WriteLine("The screen lights up and forms a sentence...");



        }

        //Denna metod håller allt som händer i puzzelroom. Man kommer in i rummet och måste svara rätt på en fråga, svara spelaren fel kommer den att ta skada samt att dess svar längs in i en hashset som man kan få utskriven
        // Så länge spelarens svar inte är en av de som finns i correctAnswer arrayen kommer den behöva skriva om sitt svar tills den matchar en plats i arrayen eller tills spelarens hp når 0. då retuneras spelarens hp
        //Se PuzzelRoom för en tydligare förklaring
        public override int EnteringSeq2(ThePirates player)
        {


            Console.WriteLine("What instrument do a skeleton like to play");
            Console.WriteLine("Write any answer you can think of however for every wrong answer you recive some damage");

            string input = Console.ReadLine();



            while (input != correctAnswers2[0] && input != correctAnswers2[1] && input != correctAnswers2[2] && input != correctAnswers2[3] && input != correctAnswers2[4] && input != correctAnswers2[5])
            {

                playersAnswer2.Add(input);

                Console.WriteLine("Wrong answer take some damage, try again");
                player.hp = player.hp - 10;

                Console.WriteLine("Your hp is at " + player.hp);

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

                if (player.hp <= 0)//När spelarens hp är vid 0 kommer dens värde att retuneras
                {
                    return player.hp;

                }


            }


            if (input == correctAnswers2[0] || input == correctAnswers2[1] || input == correctAnswers2[2] || input == correctAnswers2[3] || input == correctAnswers2[4] || input == correctAnswers2[5])
            {


                Console.WriteLine("Congrats, you answered correctly");
                Console.WriteLine("You can now exit, your welcome");


            }

            return player.hp;



        }



        // Gör om hashseten med spelarens svar till en array som sedan skrivs ut
        //Syftet med denna metod är att vissa spelaren vad den har svarat tidigare i fall den glömmer bort eller behöver ha insperation till nya svar
        //Se puzzelRoom för en tydligare förklaring
        public override void ShowAnswers2()
        {



            string[] answers2 = playersAnswer2.ToArray();

            for (int i = 0; i < answers2.Length; i++)
            {

                Console.WriteLine(answers2[i]);

            }




        }


    }
}
