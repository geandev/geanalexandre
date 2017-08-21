using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Command;
using GeanAlexandre.Context.Domain.Model.Builder;
using GeanAlexandre.Context.Domain.Repository;
using GeanAlexandre.Context.Domain.Uow;

namespace GeanAlexandre.Context.Domain.CommandHandler
{
    public class CreateResumeCommandHandler : ICreateResumeCommandHandler
    {
        private readonly IUow _uow;
        private readonly IUserRepository _userRepository;

        public CreateResumeCommandHandler(IUow uow,
            IUserRepository userRepository)
        {
            _uow = uow;
            _userRepository = userRepository;
        }

        public async Task ExecuteAsync(CreateResumeCommand command)
        {
            await Validation.FluentValidation<CreateResumeCommand>
                .Validate(command)
                .ThrowCase(c => _userRepository.VerifyIfUserExists(c.UserName),
                    $"Error in CreateReumeCommandHandler.ExecuteAsync({command.UserName}) already exists")
                .Else(c => UserBuilder
                    .SetUserName(c.UserName)
                    .ThenBuild(user => user.CreateNewResume(c.Resume))
                    .ThenParse(_uow.AddAndSave));
        }
    } }