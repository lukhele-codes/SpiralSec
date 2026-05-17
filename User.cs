using System.Security.Cryptography.X509Certificates;

namespace SpiralSecGUI
{//Namespace start
    public class User
    {//Class start
        public bool IsValid(string username, out string errorMessage)
        {//Method start
         //Getting username
         if(string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Please enter a valid username.";
                return false
            }

            //Length check
            if (username.Length < 3)
            //Message displaying a minimum length requirement for the username
            {
                errorMessage = "Username must be at least 3 characters long.";
                return false;
            }

            //Character check(letters + digits only)
            if (!username.All(char.IsLetterOrDigit))
            { 
            errorMessage = "Username can only contain letters"
            
            }

            //If the username is valid return true
            errorMessage = string.Empty
            return true;






            }//Method end
    }//Class end
}//Namespace end 