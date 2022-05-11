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

        public Task InsertUser(User user)
        {
            string sql = @"insert into dbo.[User] (Username, Email, Password)
                           values (@Username, @Email, @Password);";

            return _db.SaveData(sql, user);
        }
    }
}
