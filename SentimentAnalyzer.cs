public enum Sentiment
{
    Normal,
    Worried,
    Curious,
    Frustrated
}

public class SentimentAnalyzer
{
    public Sentiment Detect(string input)
    {
        input = input.ToLower();

        if (input.Contains("worried") ||
            input.Contains("scared") ||
            input.Contains("afraid"))
            return Sentiment.Worried;

        if (input.Contains("curious") ||
            input.Contains("interested"))
            return Sentiment.Curious;

        if (input.Contains("frustrated") ||
            input.Contains("annoyed"))
            return Sentiment.Frustrated;

        return Sentiment.Normal;
    }
}
