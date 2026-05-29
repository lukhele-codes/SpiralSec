# SpiralSec
. Project Overview
SpiralSec is a modular C# console chatbot designed to raise cybersecurity awareness.

Built with a focus on professional workflow, modular design, and creative branding.

Features include ASCII art branding, colored UI, typing effects, and input validation.

2. Objectives
Educate users about cybersecurity topics (phishing, VPNs, passwords, firewalls, etc.).

Provide interactive responses with a “tell me more” feature for deeper learning.

Store user interests (e.g., “I’m interested in phishing”) and recall them later.

Enhance user experience with a thinking effect before replies.

Maintain a conversation history for memory and context-aware responses.

3. Class Structure
AIbots.cs

Stores responses in ArrayList.

Tracks LastTopic and userInterests.

Implements GetResponse() with keyword matching and “tell me more” logic.

User.cs

Holds user information (name, preferences, interests).

Can be extended to store memory (e.g., topics of interest).

MainWindow.xaml.cs (WPF GUI)

Displays chat bubbles with borders and colors.

Implements thinking effect (typing dots).

Handles user input and bot responses.

4. Features Implemented
Keyword Matching: Bot responds based on first word of stored answers.

Tell Me More: Bot remembers LastTopic and provides extra tips.

Interest Memory: User can say “I’m interested in X” and bot stores it.

Thinking Effect: Temporary “AIbot is thinking…” bubble before reply.

Conversation History: Stores all exchanges for later retrieval.

UI Enhancements:

Chat bubbles with borders and colors.

Different background for user vs bot.

Foreground colors (DarkBlue for bot, DarkGreen for user).

5. Example Interaction
Code
You: What is phishing?
Bot: Phishing is a scam where attackers pretend to be trusted sources to steal information. Would you like me to tell you more about phishing?

You: Tell me more
Bot: Check the sender’s address carefully; attackers often mimic legitimate domains.

You: I'm interested in VPN
Bot: Got it! I'll remember that you're interested in VPN.

You: What is cybersecurity?
Bot: Cybersecurity is about protecting systems and networks from digital threats. By the way, since you mentioned you're interested in VPN, I can share more about it anytime.
6. GitHub Workflow
Meaningful commits documenting milestones (UI enhancement, memory feature, tell me more logic, etc.).

GitHub Actions CI workflow set up for automated builds and checks.

README updated to reflect progress and features.

7. Future Enhancements
Sequential cycling of tips (instead of random).

Persistent memory across sessions (saving interests to file/database).

Dark mode toggle in WPF (black background option).

Expanded knowledge base with more cybersecurity topics.
