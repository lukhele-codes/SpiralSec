using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralSec
{//Namespace start
    public class Program
    {//Class start
    static void Main(string[] args)
    {//Main start 
            //Creating an instance for ASCII logo
            Spiral logo = new Spiral();
            logo.ascii_logo();
            //Creating an instance for voice greeting
            Play greeting = new Play();
            greeting.voicegreeting();
            //Creating an instance for user input 
            User input = new User();
            input.welcome();
            input.ask_user();
            //Creating an instance for AIbot answers and exception handling
            AIbot answers = new AIbot();
            answers.StartConversation(input.GetUsername());
    }//Main end



    }//Class end
}//Namespace end
