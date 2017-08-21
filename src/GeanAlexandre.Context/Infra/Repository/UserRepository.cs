using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Repository;
using MongoDB.Driver;
using IMongoDatabase = GeanAlexandre.Context.Infra.Database.IMongoDatabase;

namespace GeanAlexandre.Context.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoDatabase _database;

        public UserRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public Task<User> GetUserNameAsync(string userName)
        {
            var filter = Builders<User>.Filter.Eq("UserName", userName);
            return _database.GetCollection<User>().Find(filter).FirstOrDefaultAsync();
        }

        public bool VerifyIfUserExists(string userName)
        {
            var filter = Builders<User>.Filter.Eq("UserName", userName);
            return _database.GetCollection<User>().Find(filter).Any();
        }
    }
}