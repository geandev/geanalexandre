using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Domain.Command
{
    public class CreateResumeCommand : ICommand
    {
        public string UserName { get; set; }
        public Resume Resume { get; set; }
    }
}