using System;
using System.Media;

namespace SpiralSec
{//Namespace start
    public class Play
    {//Class start
     //Adding voice greeting
    public void voicegreeting() 
    { //Start of constructor

    //Call the greet method 
    greet();
    }//End of constructor
     
    //Method to play the voice

    private void greet()
    {//Start of method 
    //Auto get the path of the voice record.
    string paths = AppDomain.CurrentDomain.BaseDirectory;

    //Then rename the path.
    string fullpath = paths.Replace(@"bin\Debug\", "SpiralSecAudio.wav");

    //Load the audio, then Play the audio after the instance.
    SoundPlayer voice_play = new SoundPlayer(fullpath);

    //Load the audio
    voice_play.Load();

    //Play audio.
    voice_play.Play();


    }//End of method
    
    }//Class end
}//Namespace end