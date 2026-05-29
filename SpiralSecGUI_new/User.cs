using System.Linq;

namespace SpiralSecGUI
{
    public class User
    {
        public bool IsValid(string username, out string errorMessage)
        {
            // Empty check
            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Please enter a valid username.";
                return false;
            }

            // Length check
            if (username.Length < 3)
            {
                errorMessage = "Username must be at least 3 characters long.";
                return false;
            }

            // Character check (letters + digits only)
            if (!username.All(char.IsLetterOrDigit))
            {
                errorMessage = "Username can only contain letters and numbers.";
                return false;
            }

            // If valid
            errorMessage = string.Empty;

            return true;
        }
    }
}
