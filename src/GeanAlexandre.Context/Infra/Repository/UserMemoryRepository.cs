using System.Linq;
using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Repository;
using GeanAlexandre.Context.Infra.Database;

namespace GeanAlexandre.Context.Infra.Repository
{
    public class UserMemoryRepository : IUserRepository
    {
        private readonly IMemoryDatabase _database;

        public UserMemoryRepository(IMemoryDatabase database)
        {
            _database = database;
        }

        public Task<User> GetUserNameAsync(string userName)
        {
            return Task.FromResult(_database.GetCollection().FirstOrDefault(u => u.UserName == userName));
        }

        public bool VerifyIfUserExists(string userName)
        {
            return _database.GetCollection().Any(u => u.UserName == userName);
        }
    }
}