using System.Media;

public delegate string ResponseDelegate(string input);

public class ChatBot
{
    private ResponseSystem responseSystem;

    public ResponseSystem ResponseSystem// Expose the response system for testing purposes
    {
        get { return responseSystem; }
    }

    public ResponseDelegate GenerateResponse;

    public ChatBot()
    {
        responseSystem = new ResponseSystem();// Initialize the response system
    }

    public string Respond(string message)
    {
        return responseSystem.GetResponse(message);
    }

    public void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.Play();
        }
        catch
        {
        }
    }
}