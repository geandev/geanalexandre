namespace GeanAlexandre.Context.Domain.Query
{
    public class GetUserQuery : IQuery
    {
        public GetUserQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; }

        public static GetUserQuery CreateCommand(string userName)
        {
            return new GetUserQuery(userName);
        }
    }
}