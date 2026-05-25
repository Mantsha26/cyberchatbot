public class MemoryManager
{
    private User currentUser;

    public MemoryManager(User user)
    {
        currentUser = user;
    }

    public void SaveFavouriteTopic(string topic)
    {
        currentUser.FavouriteTopic = topic;
    }

    public string RecallTopic()
    {
        return currentUser.FavouriteTopic;
    }
}