using System;

namespace SpiralSec
{
    public class User
    {
    //Global variable
    private string username = string.Empty;

    //Void method to welcome the user

        public void welcome()
        { //Start of method
          //Message to welcome with text color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Welcome Chatbot]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------");

            //Reset the color
            Console.ResetColor();


        }//end of method

        //Method to ask for the user name 
        public void ask_user()
        {//start of method

            //AI message and name with text color 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("AI name:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter your name..");

            //Reset the color 
            Console.ResetColor();

            //Do while to re-prompt the user for the username.
            do
            {//Start of the do while.

                //Prompt and text color
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("User:  ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();


            } while (!empty());//end of do while






        }//end of method ask_user

        //Boolean method to check the username if not empty
        private Boolean empty()
        {//Start of method
         //Check if not empty by if statement
            if (username != "")
            {//Start of if 
             //Success message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("AI NAME: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey" + username);
                //Return true
                return true;
            }//End of if
            else
            {//Start of else
             //Error Message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("AI NAME: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter your name...");
                //Return false
                return false;




            }//End of else




        }//End of method




    }//class2
}//namespace2
    
