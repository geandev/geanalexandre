using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Uow;
using GeanAlexandre.Context.Infra.Database;

namespace GeanAlexandre.Context.Infra.Uow
{
    public class UowMemory : IUow
    {
        private readonly IMemoryDatabase _memoryDatabase;

        public UowMemory(IMemoryDatabase memoryDatabase)
        {
            _memoryDatabase = memoryDatabase;
        }

        public Task AddAndSave<TEntity>(TEntity entity) where TEntity : class
        {
            return Task.Factory.StartNew(() => _memoryDatabase.GetCollection().Add(entity as User));
        }
    }
}