namespace GeanAlexandre.Context.Domain.Model.Builder
{
    public interface IUserBuilder : IBuilder<User>
    {
        string UserName { get; }
    }
}