using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<User>> GetUsers()
        {
            string sql = "select * from dbo.[User]";

            return _db.LoadData<User, dynamic>(sql, new { });
        }

        public Task<List<User>> GetUser(int usernameId)
        {
            string sql = $"select * from dbo.[User] where [ID] = {usernameId};";

            return _db.LoadData<User, dynamic>(sql, new { });
        }

        public Task InsertUser(User user)
        {
            string sql = @"insert into dbo.[User] (Username, Email, Password)
                           values (@Username, @Email, @Password);";

            return _db.SaveData(sql, user);
        }

        public Task ChangePassword(User user)
        {
            string sql = @"update dbo.[User] set dbo.[User].[Password] = @Password
                           where [Id] = @ID;";

            return _db.SaveData(sql, user);
        }

        public Task PlanFinished(int usernameId)
        {
            string sql = $"update dbo.[User] set dbo.[User].[Plan] = 'FREE' AND dbo.[User].[DateExpirationPlan] = NULL where [Id] = '{usernameId}';";

            return _db.SaveData(sql, new { });
        }
    }
}
