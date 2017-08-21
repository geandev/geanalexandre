using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Command;

namespace GeanAlexandre.Context.Domain.CommandHandler
{
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        Task ExecuteAsync(TCommand command);
    }
}

