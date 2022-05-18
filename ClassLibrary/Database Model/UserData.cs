namespace ClassLibrary.Database_Model
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<User>> GetUsers() => _db.LoadData<User, dynamic>(
            "select * " +
            "from dbo.[User]", new { });
        public Task<List<User>> GetUser(int usernameId) => _db.LoadData<User, dynamic>(
            $"select * " +
            $"from dbo.[User] " +
            $"where [ID] = {usernameId};", new { });
        public Task InsertUser(User user) => _db.SaveData(
            @"insert into dbo.[User] (Username, Email, Password) 
            values (@Username, @Email, @Password);", user);
        public Task ChangePassword(User user) => _db.SaveData(
            $"update dbo.[User] " +
            $"set dbo.[User].[Password] = '{user.Password}' " +
            $"where [Id] = '{user.Id}';", new { });
        public Task ChangeEmail(User user) => _db.SaveData(
            $"update dbo.[User] " +
            $"set dbo.[User].[Email] = '{user.Email}' " +
            $"where [Id] = '{user.Id}';", new { });
        public Task ChangeBiography(User userWithId) => _db.SaveData(
            $"update dbo.[User] " +
            $"set dbo.[User].[Biography] = '{userWithId.Biography}' " +
            $"where [Id] = '{userWithId.Id}';", new { });
        public Task PlanFinished(int usernameId) => _db.SaveData(
            $"update dbo.[User] " +
            $"set dbo.[User].[Plan] = 'FREE', dbo.[User].[DateExpirationPlan] = NULL " +
            $"WHERE [Id] = '{usernameId}';", new { });

        public List<CreditCard> GetCreditCard(CreditCard card) => _db.LoadDataSync<CreditCard, dynamic>(
            $"select * " +
            $"from dbo.[CreditCard] " +
            $"where [Number] = '{card.Number}'" +
            $" AND [HolderName] = '{card.HolderName}'" +
            $" AND [ExpirationDate] = '{card.ExpirationDate}'" +
            $" AND [PIN] = '{card.Pin}';", new { });
        public void Payment(CreditCard card, double cost, string plan, User user, string date) => _db.SaveData(
            $"update dbo.[CreditCard] " +
            $"set dbo.[CreditCard].[Balance] = '{(double)(card.Balance - cost)}' " +
            $"WHERE [Number] = '{card.Number}';\n" +
            $"update dbo.[User] " +
            $"set dbo.[User].[Plan] = '{plan}'" +
            $" AND [DateExpirationPlan]='{date}' " +
            $"WHERE [Id] = '{ user.Id }'; ", new { });
        public void InsertCreditCard(CreditCard card) => _db.SaveData(
            @"insert into dbo.[CreditCard] (Number, HolderName, ExpirationDate, Pin, Balance) 
            values (@Number, @HolderName, @ExpirationDate, @Pin, @Balance);", card);

        public List<User> GetUserSync(int usernameId) => _db.LoadDataSync<User, dynamic>(
            $"select * " +
            $"from dbo.[User] " +
            $"where [ID] = {usernameId};", new { });
    }
}
