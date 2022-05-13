
namespace ClassLibrary
{
    public interface IUserData
    {
        Task ChangePassword(User user);
        Task<List<User>> GetUser(int usernameId);
        Task<List<User>> GetUsers();
        Task InsertUser(User user);
    }
}