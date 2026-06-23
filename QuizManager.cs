using System.Collections.Generic;
using System.Text;

public class QuizManager
{
    private List<QuizQuestion> questions;

    private int currentQuestion = 0;

    public int Score { get; private set; }

    public QuizManager()
    {
        questions = new List<QuizQuestion>()
    {
        new QuizQuestion()
        {
            Question = "What should you do if you receive a suspicious email asking for personal information?",
            OptionA = "Reply immediately",
            OptionB = "Click the link",
            OptionC = "Report the email",
            OptionD = "Forward it to friends",
            CorrectAnswer = "C",
            Explanation = "Suspicious emails should be reported and not interacted with."
        },

        new QuizQuestion()
        {
            Question = "True or False: Using the same password for multiple accounts is safe.",
            OptionA = "True",
            OptionB = "False",
            OptionC = "",
            OptionD = "",
            CorrectAnswer = "B",
            Explanation = "Each account should have a unique password."
        },

        new QuizQuestion()
        {
            Question = "Which password is the strongest?",
            OptionA = "123456",
            OptionB = "Password1",
            OptionC = "John1998",
            OptionD = "T!m#8Pq$21X",
            CorrectAnswer = "D",
            Explanation = "Strong passwords use a mix of letters, numbers and symbols."
        },

        new QuizQuestion()
        {
            Question = "True or False: Two-factor authentication improves account security.",
            OptionA = "True",
            OptionB = "False",
            OptionC = "",
            OptionD = "",
            CorrectAnswer = "A",
            Explanation = "2FA adds an extra layer of protection."
        },

        new QuizQuestion()
        {
            Question = "What is phishing?",
            OptionA = "A type of antivirus",
            OptionB = "A cyberattack using fake messages",
            OptionC = "A firewall setting",
            OptionD = "A web browser",
            CorrectAnswer = "B",
            Explanation = "Phishing tricks users into revealing sensitive information."
        },

        new QuizQuestion()
        {
            Question = "Which website is generally safer?",
            OptionA = "http://example.com",
            OptionB = "https://example.com",
            OptionC = "Both are the same",
            OptionD = "Neither",
            CorrectAnswer = "B",
            Explanation = "HTTPS encrypts communication between you and the website."
        },

        new QuizQuestion()
        {
            Question = "True or False: You should download attachments from unknown senders.",
            OptionA = "True",
            OptionB = "False",
            OptionC = "",
            OptionD = "",
            CorrectAnswer = "B",
            Explanation = "Unknown attachments may contain malware."
        },

        new QuizQuestion()
        {
            Question = "What is social engineering?",
            OptionA = "Building websites",
            OptionB = "Programming software",
            OptionC = "Manipulating people into giving information",
            OptionD = "Repairing computers",
            CorrectAnswer = "C",
            Explanation = "Social engineering exploits human trust."
        },

        new QuizQuestion()
        {
            Question = "Which action helps protect against malware?",
            OptionA = "Ignoring updates",
            OptionB = "Using outdated software",
            OptionC = "Keeping software updated",
            OptionD = "Sharing passwords",
            CorrectAnswer = "C",
            Explanation = "Updates often fix security vulnerabilities."
        },

        new QuizQuestion()
        {
            Question = "True or False: Public Wi-Fi networks are always secure.",
            OptionA = "True",
            OptionB = "False",
            OptionC = "",
            OptionD = "",
            CorrectAnswer = "B",
            Explanation = "Public Wi-Fi can expose your data to attackers."
        },

        new QuizQuestion()
        {
            Question = "What should you check before clicking a link in an email?",
            OptionA = "The sender and URL",
            OptionB = "The font style",
            OptionC = "The email color",
            OptionD = "Nothing",
            CorrectAnswer = "A",
            Explanation = "Always verify links before clicking."
        },

        new QuizQuestion()
        {
            Question = "True or False: Antivirus software should be updated regularly.",
            OptionA = "True",
            OptionB = "False",
            OptionC = "",
            OptionD = "",
            CorrectAnswer = "A",
            Explanation = "Updated antivirus software can detect newer threats."
        },

        new QuizQuestion()
        {
            Question = "Which is an example of sensitive information?",
            OptionA = "Your favourite movie",
            OptionB = "Your bank account number",
            OptionC = "Your favourite food",
            OptionD = "Your shoe size",
            CorrectAnswer = "B",
            Explanation = "Bank account details should be protected."
        },

        new QuizQuestion()
        {
            Question = "What should you do if a website asks for unusual personal information?",
            OptionA = "Provide it immediately",
            OptionB = "Verify the website's legitimacy",
            OptionC = "Ignore all websites",
            OptionD = "Share it publicly",
            CorrectAnswer = "B",
            Explanation = "Always verify a website before sharing personal information."
        },

        new QuizQuestion()
        {
            Question = "True or False: Regular backups help protect against ransomware.",
            OptionA = "True",
            OptionB = "False",
            OptionC = "",
            OptionD = "",
            CorrectAnswer = "A",
            Explanation = "Backups allow recovery of files if ransomware strikes."
        }
    };
    }

    public void Reset()
    {
        currentQuestion = 0;
        Score = 0;
    }

    public QuizQuestion GetCurrentQuestion()
    {
        if (currentQuestion >= questions.Count)
            return null;

        return questions[currentQuestion];
    }

    public string SubmitAnswer(string answer)
    {
        if (currentQuestion >= questions.Count)
            return "No active question.";

        QuizQuestion q = questions[currentQuestion];

        string result;

        if (!string.IsNullOrWhiteSpace(answer) && answer.ToUpper().Contains(q.CorrectAnswer.ToUpper()))
        {
            Score++;
            result = " " + q.Explanation;
        }
        else
        {
            result = " " + q.Explanation;
        }

        currentQuestion++;

        return result;
    }

    public bool IsFinished()
    {
        return currentQuestion >= questions.Count;
    }

    // Return total number of questions
    public int TotalQuestions => questions.Count;

    // Build a summary of correct answers and short explanations
    public string GetAnswersSummary()
    {
        var sb = new StringBuilder();

        for (int i = 0; i < questions.Count; i++)
        {
            var q = questions[i];
            sb.AppendFormat("{0}. Correct: {1} - {2}", i + 1, q.CorrectAnswer, q.Explanation);
            sb.AppendLine();
        }

        return sb.ToString();
    }
}
