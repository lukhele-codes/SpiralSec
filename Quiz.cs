using System.Collections.Generic;
using System.IO.Packaging;
using System.Windows.Documents;

namespace SpiralSecGUI.SpiralSecGUI
{//Namespace start
    using System.Collections.Generic;

    namespace SpiralSecGUI
    {
        public class Quiz
        {
            private List<Question> questions = new List<Question>();
            private int score = 0;
            private int currentIndex = 0;

            //Question class
            private class Question
            {
                public string Text { get; set; }
                public string[] Options { get; set; }
                public int CorrectOptionIndex { get; set; }
                public string Feedback { get; set; }

                public Question(string text, string[] options, int correctIndex, string feedback)
                {
                    Text = text;
                    Options = options;
                    CorrectOptionIndex = correctIndex;
                    Feedback = feedback;
                }
            }

            public Quiz()
            {
                //Questions
                questions.Add(new Question(
                    "What should you do if you receive an email asking for your password?",
                    new[] { "Reply with password", "Delete email", "Report as phishing", "Ignore it" },
                    2,
                    "Correct! Reporting phishing emails helps prevent scams."
                ));

                questions.Add(new Question(
                    "True or False: Using '123456' is a strong password.",
                    new[] { "True", "False" },
                    1,
                    "Correct! Always use complex passwords."
                ));

                questions.Add(new Question(
                    "Which of these is a safe browsing practice?",
                    new[] { "Clicking unknown links", "Using HTTPS websites", "Sharing passwords", "Ignoring updates" },
                    1,
                    "Correct! HTTPS ensures secure communication."
                ));
            }

            // Start the quiz
            public string StartQuiz()
            {
                score = 0;
                currentIndex = 0;
                return ShowQuestion();
            }

            // Show current question
            private string ShowQuestion()
            {
                if (currentIndex >= questions.Count)
                    return ShowFinalScore();

                var q = questions[currentIndex];
                string output = $"{q.Text}\n";
                for (int i = 0; i < q.Options.Length; i++)
                {
                    output += $"{i + 1}. {q.Options[i]}\n";
                }
                return output;
            }

            // Process an answer
            public string AnswerQuestion(int choice)
            {
                if (currentIndex >= questions.Count)
                    return "Quiz already finished.";

                var q = questions[currentIndex];
                string response;

                if (choice - 1 == q.CorrectOptionIndex)
                {
                    score++;
                    response = q.Feedback;
                }
                else
                {
                    response = $"Incorrect. {q.Feedback}";
                }

                currentIndex++;
                if (currentIndex < questions.Count)
                {
                    response += "\n\nNext Question:\n" + ShowQuestion();
                }
                else
                {
                    response += "\n\n" + ShowFinalScore();
                }

                return response;
            }

            // Final score summary
            private string ShowFinalScore()
            {
                string feedback;
                if (score == questions.Count)
                    feedback = "Excellent! You’re a cybersecurity pro!";
                else if (score >= questions.Count / 2)
                    feedback = "Good job! Keep practicing to improve.";
                else
                    feedback = "Keep learning to stay safe online.";

                return $"Quiz finished! Your score: {score}/{questions.Count}\n{feedback}";
            }
        }
    }
}


