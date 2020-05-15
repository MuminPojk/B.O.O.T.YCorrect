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


            input = input.ToLower(); // Gör så att spelarens bokstäver alla blir gemener oberoende på hur de skriver


            while (input != "yes" && input != "no") // Loopen kommer köras om tills så länge spelaren skriver något som inte är lika med "yes " eller "no"
            {


                if (input != "yes" && input != "no")// kommer köras om tills så länge spelaren skriver något som inte är lika med "yes " eller "no"
                {

                    Console.WriteLine("Your answer is invalid, try to write either yes or no, nothing else");


                }


                input = Console.ReadLine();// Spelaren kommer få skriva om tills de skrivit ett acceptabelt svar
                input = input.ToLower();

            }



            if (input == "yes" || input == "no")// Om spelaren   "yes " eller "no" kommer deras input att retuneras
            {

                return input;

            }

            return input;

        }

        // Är spelarens svar inte 1,2 eller 3 kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string NumberChose(string input)
        {

         


            while (input != "1" && input != "2" && input != "3")// Loopen kommer köras om tills så länge spelaren skriver något som inte är lika med 1,2 eller 3
            {


                if (input != "1" && input != "2" && input != "3")// kommer köras om tills så länge spelaren skriver något som inte är lika med 1,2 eller 3
                {

                    Console.WriteLine("Your answer is invalid, try to write either 1, 2 or 3 with numbers");


                }


                input = Console.ReadLine();// Spelaren kommer få skriva om tills de skrivit ett acceptabelt svar


            }



            if (input == "1" || input == "2" || input == "3")// Om spelaren 1,2 eller 3 kommer deras input att retuneras
            {

                return input;

            }

            return input;





        }

        //Först ser metoden till att spelarens svar är i gemener Är spelarens svar inte left eller right kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string LeftRight(string input)
        {
            
            input = input.ToLower();// Gör så att spelarens bokstäver alla blir gemener oberoende på hur de skriver


            while (input != "left" && input != "right")// Loopen kommer köras om tills så länge spelaren skriver något som inte är lika med "left " eller "right"
            {


                if (input != "left" && input != "right")// kommer köras om tills så länge spelaren skriver något som inte är lika med "left " eller "rigt"
                {

                    Console.WriteLine("Your answer is invalid, try to write either left or right, nothing else");


                }


                input = Console.ReadLine();// Spelaren kommer få skriva om tills de skrivit ett acceptabelt svar
                input = input.ToLower();

            }



            if (input == "left" || input == "right")// Om spelaren   "left " eller "right" kommer deras input att retuneras
            {

                return input;

            }

            return input;


        }

        //Först ser metoden till att spelarens svar är i gemener Är spelarens svar inte left eller forward kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string LeftForward(string input)
        {

            input = input.ToLower();// Gör så att spelarens bokstäver alla blir gemener oberoende på hur de skriver


            while (input != "left" && input != "forward")// Loopen kommer köras om tills så länge spelaren skriver något som inte är lika med "left " eller "right"
            {


                if (input != "left" && input != "forward")// kommer köras om tills så länge spelaren skriver något som inte är lika med "left " eller "forward"
                {

                    Console.WriteLine("Your answer is invalid, try to write either left or forward, nothing else");


                }


                input = Console.ReadLine();// Spelaren kommer få skriva om tills de skrivit ett acceptabelt svar
                input = input.ToLower();

            }



            if (input == "left" || input == "forward")// Om spelaren   "left " eller "forward" kommer deras input att retuneras
            {

                return input;

            }

            return input;



        }

        //Först ser metoden till att spelarens svar är i gemener Är spelarens svar inte forward eller right kommer loopen köras om tills spelaren skriver ett acceptabelt svar
        public string RightForward(string input)
        {

            input = input.ToLower();// Gör så att spelarens bokstäver alla blir gemener oberoende på hur de skriver


            while (input != "forward" && input != "right")// Loopen kommer köras om tills så länge spelaren skriver något som inte är lika med "left " eller "right"
            {


                if (input != "forward" && input != "right")// kommer köras om tills så länge spelaren skriver något som inte är lika med "forward " eller "right"
                {

                    Console.WriteLine("Your answer is invalid, try to write either forward or right, nothing else");


                }


                input = Console.ReadLine();// Spelaren kommer få skriva om tills de skrivit ett acceptabelt svar
                input = input.ToLower();

            }



            if (input == "forward" || input == "right")// Om spelaren   "forward " eller "right" kommer deras input att retuneras
            {

                return input;

            }

            return input;


        }

        


    }
}
