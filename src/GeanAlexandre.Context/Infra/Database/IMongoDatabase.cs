using MongoDB.Driver;

namespace GeanAlexandre.Context.Infra.Database
{
    public interface IMongoDatabase
    {
        IMongoCollection<TEntity> GetCollection<TEntity>();
    }
}