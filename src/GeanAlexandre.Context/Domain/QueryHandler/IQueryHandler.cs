using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Query;

namespace GeanAlexandre.Context.Domain.QueryHandler
{
    public interface IQueryHandler<in TQuery, TResult>
        where TQuery : IQuery
    {
        Task<TResult> ExecuteAsync(TQuery command);
    }
}