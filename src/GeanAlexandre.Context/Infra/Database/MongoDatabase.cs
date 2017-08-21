using GeanAlexandre.Context.Settings;
using MongoDB.Driver;

namespace GeanAlexandre.Context.Infra.Database
{
    public class MongoDatabase : IMongoDatabase
    {
        private readonly MongoDB.Driver.IMongoDatabase _database;

        public MongoDatabase(IMongoSettings settings)
        {
            _database = new MongoClient(settings.ConnectionString).GetDatabase("Resume");
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name);
        }
    }
}