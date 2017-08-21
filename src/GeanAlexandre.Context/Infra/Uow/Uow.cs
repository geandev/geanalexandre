using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Uow;
using GeanAlexandre.Context.Infra.Database;

namespace GeanAlexandre.Context.Infra.Uow
{
    public class Uow : IUow
    {
        private readonly IMongoDatabase _database;

        public Uow(IMongoDatabase database)
        {
            _database = database;
        }

        public Task AddAndSave<TEntity>(TEntity entity) where TEntity : class
        {
            return _database.GetCollection<TEntity>().InsertOneAsync(entity);
        }
    }
}