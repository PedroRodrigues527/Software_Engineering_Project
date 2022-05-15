
namespace ClassLibrary
{
    public interface IUserData
    {
        Task ChangePassword(User user);
        Task ChangeBiography(User userWithId);
        Task ChangeEmail(User user);
        Task<List<User>> GetUser(int usernameId);
        Task<List<User>> GetUsers();
        Task InsertUser(User user);
        Task PlanFinished(int usernameId);
    }
}