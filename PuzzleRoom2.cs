using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class PuzzleRoom2: Room
    {
        public PuzzleRoom2()
        {



            Console.WriteLine("You enter a room briefly illuminated when the door behind you shuts, It is completly and utterly dark, ");
            Console.WriteLine("After a few seconds brightly colored light splashes across the room as if a rave was happening");
            Console.WriteLine("From a hole in the ground comes a big screen with a small skeleton wearing a big fancy jacket and a mustasche beside it");
            Console.WriteLine("Welcome to the pundgeon, if you pass this question you may leave but if not damage of random will await you and remember this is the pundgeon");
            Console.WriteLine("(This question can have multiple answers)");
            Console.WriteLine("The screen lights up and forms a sentence...");



        }

        public override int EnteringSeq2(ThePirates player)
        {


            return base.EnteringSeq2(player);

        }

        public override void ShowAnswers2()
        {


            base.ShowAnswers2();


        }


    }
}
