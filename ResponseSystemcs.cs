using System;
using System.Collections.Generic;

public class ResponseSystem
{
    private Dictionary<string, List<string>> responses;

    private Random random = new Random();

    public string LastTopic { get; private set; }
    public string GetLastTopic()
    {
        return LastTopic;
    }
    public ResponseSystem()
    {
        responses = new Dictionary<string, List<string>>
        {
            {
                "password",
                new List<string>
                {
                    "Use strong passwords with at least 12 characters.",
                    "Avoid personal information in passwords.",
                    "Use a password manager to store passwords safely."
                }
            },

            {
                "phishing",
                new List<string>
                {
                    "Never click suspicious email links.",
                    "Check the sender email carefully.",
                    "Phishing emails often create urgency."
                }
            },

            {
                "privacy",
                new List<string>
                {
                    "Review privacy settings regularly.",
                    "Avoid sharing personal details publicly.",
                    "Enable two-factor authentication."
                }
            },

            {
                "scam",
                new List<string>
                {
                    "Never share banking details online.",
                    "Scammers often pretend to be trusted companies.",
                    "Verify messages before responding."
                }
            },

            {
                "malware",
                new List<string>
                {
                    "Keep antivirus software updated.",
                    "Avoid downloading unknown attachments.",
                    "Update Windows regularly."
                }
            }
        };
    }

    public string GetResponse(string input)
    {
        input = input.ToLower();

        foreach (var topic in responses.Keys)
        {
            if (input.Contains(topic))
            {
                LastTopic = topic;

                var list = responses[topic];

                return list[random.Next(list.Count)];
            }
        }

        if (input.Contains("another tip") ||
           input.Contains("tell me more") ||
           input.Contains("explain more"))
        {
            if (LastTopic != null)
            {
                var list = responses[LastTopic];

                return "More about " + LastTopic +
                       ": " +
                       list[random.Next(list.Count)];
            }
        }


        return "I'm not sure I understand. Can you try rephrasing?";
    }
}