using System;

public class User
{
    public string Name { get; set; }
    public string FavouriteTopic { get; set; }

    public DateTime FirstInteraction { get; private set; }

    public User()
    {
        FirstInteraction = DateTime.Now;
    }
}