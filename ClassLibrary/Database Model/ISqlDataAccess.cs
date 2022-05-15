
namespace ClassLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
        List<T> LoadDataSync<T, U>(string sql, U parameters);
        void SaveDataSync<T>(string sql, T parameters);
    }
}