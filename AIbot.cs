using System;
using System.Collections;
using System.Collections.Generic;

namespace SpiralSec
{//Namespace start
    public class AIbot
    {//Class start

        //Adding a knowledge which has predefined questions and answers mapped to keywords.
        private Dictionary<string, string> knowledgeBase = new Dictionary<string, string>
        {
            { "how are you", "I’m functioning well, thank you!" },
            { "what can i do", "You can ask me about safe passwords, phishing, browsing securely, using VPNs, and general cybersecurity tips." },
            { "purpose", "I’m here to help you stay safe online." },
            { "password", "Use long, unique passwords and enable multi-factor authentication." },
            { "phishing", "Be cautious of suspicious emails and links. Verify before clicking." },
            { "browsing", "Stick to trusted websites and keep your browser updated." },
            { "virus", "Install antivirus software and keep it updated to protect against malware." },
            { "wifi", "Avoid using public Wi-Fi for sensitive activities unless you use a VPN." },
            { "vpn", "A VPN encrypts your internet traffic, making it harder for attackers to spy on you." },
            { "social media", "Limit what personal information you share online. Cybercriminals can use it against you." },
            { "updates", "Always update your operating system and apps to patch security vulnerabilities." },
            { "identity theft", "Monitor your accounts regularly and report suspicious activity immediately." },
            { "cybersecurity tips", "Think before you click, use strong passwords, and keep your software updated." },
            { "data breach", "If your data is exposed, change your passwords and enable multi-factor authentication." },
            { "ransomware", "Back up your files regularly so you don’t lose them if attacked." },
            { "safe shopping", "Shop only on secure websites (look for HTTPS) and avoid saving card details online." }
        };
        //Method to generate a response based on user input
        public string GetResponse(string input, string username)
        {
            input = input.ToLower().Trim();

            foreach (var keyword in knowledgeBase.Keys)
            {
                if (input.Contains(keyword))
                {
                    return $"{username}, {knowledgeBase[keyword]}";
                }
            }

            return $"{username},I didn’t quite understand that. Try asking about passwords, phishing, or browsing safely.";
        }

        // Conversation loop until the user types "exit".
        public void StartConversation(string username)
        {
            string userInput = string.Empty;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Type 'exit' to quit the chatbot.");
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                Console.ResetColor();

                userInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "exit")
                {
                    string response = GetResponse(userInput, username);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SpiralSec: " + response);
                    Console.ResetColor();
                }

            } while (userInput.ToLower() != "exit");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Goodbye! Stay safe online.");
            Console.ResetColor();
        }
    

    }//Class end
}//Namespace end