using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Query;
using GeanAlexandre.Context.Domain.Repository;

namespace GeanAlexandre.Context.Domain.QueryHandler
{
    public class GetUserQueryHandler : IGetUserQueryHandler
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> ExecuteAsync(GetUserQuery command)
        {
            return await _userRepository.GetUserNameAsync(command?.UserName);
        }
    }
}