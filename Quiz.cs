using System.Collections.Generic;

namespace SpiralSecGUI
{
    public class Quiz
    {
        private List<Question> questions = new List<Question>();
        private int score = 0;
        private int currentIndex = 0;

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
            // Add your 15 questions here
            questions.Add(new Question(
                "What should you do if you receive an email asking for your password?",
                new[] { "Reply with password", "Delete email", "Report as phishing", "Ignore it" },
                2,
                "Correct! Reporting phishing emails helps prevent scams."
            ));

            // ... add the rest of your questions
        }

        public string StartQuiz()
        {
            score = 0;
            currentIndex = 0;
            return ShowQuestion();
        }

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
