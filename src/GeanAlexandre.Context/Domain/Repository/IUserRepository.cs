using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Domain.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserNameAsync(string userName);
        bool VerifyIfUserExists(string userName);
    }
}