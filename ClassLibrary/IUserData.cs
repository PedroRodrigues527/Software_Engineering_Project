
namespace ClassLibrary
{
    public interface IUserData
    {
        Task<List<User>> GetUser(string username);
        Task<List<User>> GetUsers();
        Task InsertUser(User user);
    }
}