using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class PuzzleRoom : Room
    {
        Random generator = new Random();
        

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

        public override int EnteringSeq1(ThePirates player)
        {


            return base.EnteringSeq1(player);

        }

        public override void ShowAnswers()
        {


            base.ShowAnswers();


        }




    }
}
