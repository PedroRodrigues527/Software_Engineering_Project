
namespace ClassLibrary
{
    public interface IUserData
    {
        Task<List<User>> GetUsers();
        Task InsertUser(User user);
    }
}