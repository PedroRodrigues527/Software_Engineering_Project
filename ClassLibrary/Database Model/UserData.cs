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
            string sql = $"update dbo.[User] set dbo.[User].[Password] = '{user.Password}' where [Id] = '{user.Id}';";

            return _db.SaveData(sql, new { });
        }

        public Task ChangeEmail(User user)
        {
            string sql = $"update dbo.[User] set dbo.[User].[Email] = '{user.Email}' where [Id] = '{user.Id}';";

            return _db.SaveData(sql, new { });
        }

        public Task ChangeBiography(User userWithId)
        {
            string sql = $"update dbo.[User] set dbo.[User].[Biography] = '{userWithId.Biography}' where [Id] = '{userWithId.Id}';";

            return _db.SaveData(sql, new { });
        }

        public Task PlanFinished(int usernameId)
        {
            string sql = $"update dbo.[User] set dbo.[User].[Plan] = 'FREE', dbo.[User].[DateExpirationPlan] = NULL WHERE [Id] = '{usernameId}';";

            return _db.SaveData(sql, new { });
        }

        public List<CreditCard> GetCreditCard(CreditCard card)
        {
            string sql = $"select * from dbo.[CreditCard] where [Number] = '{card.Number}' AND [HolderName] = '{card.HolderName}' " +
                $"AND [ExpirationDate] = '{card.ExpirationDate}' AND [PIN] = '{card.Pin}';";

            return _db.LoadDataSync<CreditCard, dynamic>(sql, new { });
        }

        public void Payment(CreditCard card  , double cost, string plan, User user ,string date)
        {
            double updatedBalance = card.Balance - cost;
            string sql = $"update dbo.[CreditCard] set dbo.[CreditCard].[Balance] = '{updatedBalance}' WHERE [Number] = '{card.Number}';\n" +
                $"update dbo.[User] set dbo.[User].[Plan] = '{plan}' AND [DateExpirationPlan]='{date}' WHERE [Id] = '{ user.Id }'; ";

            _db.SaveData(sql, new { });
        }

        public void InsertCreditCard(CreditCard card)
        {
            string sql = @"insert into dbo.[CreditCard] (Number, HolderName, ExpirationDate, Pin, Balance) values (@Number, @HolderName, @ExpirationDate, @Pin, @Balance);";

            _db.SaveData(sql, card);
        }

        public List<User> GetUserSync(int usernameId)
        {
            string sql = $"select * from dbo.[User] where [ID] = {usernameId};";

            return _db.LoadDataSync<User, dynamic>(sql, new { });
        }
    }
}
