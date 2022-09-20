public class Library
{
    protected List<User> userRegistered = new List<User>();

    protected List<Movie> Movies = new List<Movie>();

    protected List<Book> Books = new List<Book>();

    public void newUser(User user)
    {
        user.registered = true;
        userRegistered.Add(user);   
    }
}