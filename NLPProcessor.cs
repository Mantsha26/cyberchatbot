using System.Text.RegularExpressions;

namespace CyberGuard
{
    public class NLPProcessor
    {
        public string DetectIntent(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "CHAT";

            string lower = input.ToLower();

            // Stronger match for add/create task phrasing
            if (Regex.IsMatch(lower, @"\b(add|create)\b.*\b(task|reminder|todo)\b") ||
                Regex.IsMatch(lower, @"\b(remind me to)\b") ||
                Regex.IsMatch(lower, @"\b(reminder)\b"))
            {
                return "ADD_TASK";
            }

            if (lower.Contains("remind"))
                return "REMINDER";

            if (lower.Contains("quiz"))
                return "QUIZ";

            if (lower.Contains("activity") || lower.Contains("what have you done"))
                return "LOG";

            if (lower.Contains("task"))
                return "TASK";

            return "CHAT";
        }

        // Extract a concise task title from user input using simple regex patterns
        public string ExtractTaskTitle(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "New Task";

            string lower = input.ToLower().Trim();

            // Pattern: add/create a task <title>
            var m = Regex.Match(lower, @"(?:add|create)\s+(?:a\s+)?(?:task|reminder|todo)\s*(?:to\s*)?(?<title>.+)");
            if (m.Success)
            {
                string title = m.Groups["title"].Value.Trim();
                return NormalizeTitle(title);
            }

            // Pattern: remind me to <title>
            m = Regex.Match(lower, @"remind\s+me\s+(?:to\s+)?(?<title>.+)");
            if (m.Success)
            {
                string title = m.Groups["title"].Value.Trim();
                return NormalizeTitle(title);
            }

            // Recognize 2fa or two-factor mentions
            m = Regex.Match(lower, @"(?:enable|turn on|set up)\s+(2fa|two[- ]factor(?: authentication)?)");
            if (m.Success)
            {
                return "Enable 2FA";
            }

            if (Regex.IsMatch(lower, "\b2fa\b") || Regex.IsMatch(lower, "two[- ]factor"))
            {
                return "Enable 2FA";
            }

            // Fallback: if the input contains the word 'task', remove it and use remainder
            if (lower.Contains("task"))
            {
                var fallback = Regex.Replace(lower, "\b(task|a task|add task|create task)\b", "", RegexOptions.IgnoreCase).Trim();
                if (!string.IsNullOrEmpty(fallback))
                    return NormalizeTitle(fallback);
            }

            // Last resort: return the original input trimmed and capitalized
            return NormalizeTitle(input);
        }

        private string NormalizeTitle(string raw)
        {
            raw = raw.Trim().Trim('.', '!');
            if (string.IsNullOrEmpty(raw))
                return "New Task";

            // Capitalize first letter
            return char.ToUpper(raw[0]) + raw.Substring(1);
        }
    }
}
