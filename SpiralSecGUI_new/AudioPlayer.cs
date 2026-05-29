using System;
using System.IO;
using System.Media;

namespace SpiralSecGUI
{//Namespace start
    public class AudioPlayer
    {//Class start
        public AudioPlayer()
        {//Method start

            //Auto play the audio file when the class is called
            string full_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SpiralSecAudio.wav");

            //Creating an instance for the AudioPlayer class with an object name greet
            SoundPlayer greet = new SoundPlayer(full_path);

            //Then greet the user
            greet.Play();



        }//Method end 
    }//Class end
}//Namespace end