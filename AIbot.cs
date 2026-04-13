using System;
using System.Collections;
using System.Collections.Generic;

namespace SpiralSec
{
    public class AIbot
    {
        private Dictionary<string, string> knowledgeBase = new Dictionary<string, string>
        {
            { "how are you", "I’m functioning well, thank you!" },
            { "purpose", "I’m here to help you stay safe online." },
            { "password", "Use long, unique passwords and enable multi-factor authentication." },
            { "phishing", "Be cautious of suspicious emails and links. Verify before clicking." },
            { "browsing", "Stick to trusted websites and keep your browser updated." }
        };

        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            foreach (var keyword in knowledgeBase.Keys)
            {
                if (input.Contains(keyword))
                {
                    return knowledgeBase[keyword];
                }
            }

            return "I didn’t quite understand that. Could you rephrase?";
        }
    }
}