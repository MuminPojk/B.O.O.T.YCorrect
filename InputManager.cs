using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class InputManager
    {


        //Alla metoder här under kollar om spelaren har skrivit in en av de accepterade svaren

        //Först ser metoden till att spelraens svar är i gemener. Är spelarens svar inte ja eller nej kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string YesOrNo(string input){


            input = input.ToLower();


            while (input != "yes" && input != "no")
            {


                if (input != "yes" && input != "no")
                {

                    Console.WriteLine("Your answer is invalid, try to write either yes or no, nothing else");


                }


                input = Console.ReadLine();
                input = input.ToLower();

            }



            if (input == "yes" || input == "no")
            {

                return input;

            }

            return input;

        }

        // Är spelarens svar inte 1,2 eller 3 kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string NumberChose(string input)
        {

         


            while (input != "1" && input != "2" && input != "3")
            {


                if (input != "1" && input != "2" && input != "3")
                {

                    Console.WriteLine("Your answer is invalid, try to write either 1, 2 or 3 with numbers");


                }


                input = Console.ReadLine();
                

            }



            if (input == "1" || input == "2" || input == "3")
            {

                return input;

            }

            return input;





        }

        //Först ser metoden till att spelarens svar är i gemener Är spelarens svar inte left eller right kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string LeftRight(string input)
        {
            
            input = input.ToLower();


            while (input != "left" && input != "right")
            {


                if (input != "left" && input != "right")
                {

                    Console.WriteLine("Your answer is invalid, try to write either left or right, nothing else");


                }


                input = Console.ReadLine();
                input = input.ToLower();

            }



            if (input == "left" || input == "right")
            {

                return input;

            }

            return input;


        }

        //Först ser metoden till att spelarens svar är i gemener Är spelarens svar inte left eller forward kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string LeftForward(string input)
        {

            input = input.ToLower();


            while (input != "left" && input != "forward")
            {


                if (input != "left" && input != "forward")
                {

                    Console.WriteLine("Your answer is invalid, try to write either left or forward, nothing else");


                }


                input = Console.ReadLine();
                input = input.ToLower();

            }



            if (input == "left" || input == "forward")
            {

                return input;

            }

            return input;



        }

        //Först ser metoden till att spelarens svar är i gemener Är spelarens svar inte forward eller right kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string RightForward(string input)
        {

            input = input.ToLower();


            while (input != "forward" && input != "right")
            {


                if (input != "forward" && input != "right")
                {

                    Console.WriteLine("Your answer is invalid, try to write either forward or right, nothing else");


                }


                input = Console.ReadLine();
                input = input.ToLower();

            }



            if (input == "forward" || input == "right")
            {

                return input;

            }

            return input;


        }

        


    }
}
