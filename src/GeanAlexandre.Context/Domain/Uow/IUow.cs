using System.Threading.Tasks;

namespace GeanAlexandre.Context.Domain.Uow
{
    public interface IUow
    {
        Task AddAndSave<TEntity>(TEntity entity)
            where TEntity : class;
    }
}