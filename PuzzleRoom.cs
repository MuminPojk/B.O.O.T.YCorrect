using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class PuzzleRoom : Room
    {

        public HashSet<string> playersAnswer = new HashSet<string>(); //Kommer spara alla svar som spelaren skriver in. Kommer däremot endast spara de unika svaren som spelaren skriver in i EnteringSeq1
        protected string[] correctAnswers = { "milk", "nothing", "ribs", "kalcium", "people", "bonuts" }; // en array med de rätta svaren för EnteringSeq1


        InputManager InputManager = new InputManager();

        public PuzzleRoom()
        {


            // Puninator, en mening kommer sakna ett ord och man måste fylla i det, men det måste vara ett acceptabelt ord och ett pun


            Console.WriteLine("You enter a room briefly illuminated when the door behind you shuts, It is completly and utterly dark");
            Console.WriteLine("After a few seconds brightly colored light splashes across the room as if a rave was happening");
            Console.WriteLine("From a hole in the ground comes a big screen with a small skeleton wearing a big fancy jacket and a mustasche beside it");
            Console.WriteLine("Welcome to the pundgeon, if you pass this question you may leave but if not pain will await you and remember this is the pundgeon");
            Console.WriteLine("(This question can have multiple answers)");
            Console.WriteLine("The screen lights up and forms a sentence...");




        }


        //Denna metod håller allt som händer i puzzelroom. Man kommer in i rummet och måste svara rätt på en fråga, svara spelaren fel kommer den att ta skada samt att dess svar längs in i en hashset som man kan få utskriven
        // Så länge spelarens svar inte är en av de som finns i correctAnswer arrayen kommer den behöva skriva om sitt svar tills den matchar en plats i arrayen eller tills spelarens hp når 0. då retuneras spelarens hp
        public override int EnteringSeq1(ThePirates player)
        {



            Console.WriteLine("What does skeletons like to eat/drink?");
            Console.WriteLine("Write any answer you can think of however for every wrong answer you recive some damage");

            string input = Console.ReadLine();



            while (input != correctAnswers[0] && input != correctAnswers[1] && input != correctAnswers[2] && input != correctAnswers[3] && input != correctAnswers[4] && input != correctAnswers[5])
            { // loopen kommer fortsätta tills spelaren skriver ett svar som lika med en av dem i arrayen correctAnswer

                playersAnswer.Add(input);// Spelaren svar läggs till i en hashset 

                Console.WriteLine("Wrong answer take some damage, try again");
                player.hp = player.hp - 10; // Svarar spelaren fel kommer 10 dras av från dess hp

                Console.WriteLine("Your hp is at " + player.hp);

                Console.WriteLine("Want to see your previous answers? (write yes or no)");
                input = Console.ReadLine();

                if (input == "yes") // Om spelaren skriver ja kommer dess svar att vissas annars fortsätter spelet tills spelare skrivit in ett svar som matchar med arrayen correctanswers
                {

                    ShowAnswers();
                    Console.WriteLine("Try to answer the question again");
                    input = Console.ReadLine();
                    input = InputManager.YesOrNo(input);



                }
                else if (input == "no")
                {
                    Console.WriteLine("Okay write your next answer and press enter to countinue");
                    input = Console.ReadLine();

                }

                if (player.hp <= 0) //När spelarens hp är vid 0 kommer dens värde att retuneras
                {
                    return player.hp;

                }

            }


            if (input == correctAnswers[0] || input == correctAnswers[1] || input == correctAnswers[2] || input == correctAnswers[3] || input == correctAnswers[4] || input == correctAnswers[5])
            {// När spelaren har skrivit ett svar som matcher med arrayen correctAnswers så kommer spelarens hp att retuneras.


                Console.WriteLine("Congrats, you answered correctly");
                Console.WriteLine("You can now exit, your welcome");
                return player.hp;

            }

            return player.hp;

        }


        // Gör om hashseten med spelarens svar till en array som sedan skrivs ut
        //Syftet med denna metod är att vissa spelaren vad den har svarat tidigare i fall den glömmer bort eller behöver ha insperation till nya svar
        public override void ShowAnswers()
        {


            string[] answers = playersAnswer.ToArray();// Hashseten med spelarens svar görs om till en array

            for (int i = 0; i < answers.Length; i++) // Loopen kommer köras för lika många platser som answers innehåller och kommer sedan skriva ut vad varje plats inneh¨åller
            {

                Console.WriteLine(answers[i]);

            }


        }




    }
}
