using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class InputManager
    {



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
