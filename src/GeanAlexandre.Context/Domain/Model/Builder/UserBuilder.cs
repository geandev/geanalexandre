using System;

namespace GeanAlexandre.Context.Domain.Model.Builder
{
    public class UserBuilder : IUserBuilder
    {
        public string UserName { get; }

        private User _user;

        private UserBuilder(string userName)
        {
            UserName = userName;
        }


        public static IUserBuilder SetUserName(string userName)
        {
            return new UserBuilder(userName);
        }

        public IBuilder<User> ThenBuild(Func<User, User> action)
        {
            _user = action(new User(this));
            return this;
        }

        public TReturn ThenParse<TReturn>(Func<User, TReturn> parseFn)
        {
            return parseFn(_user);
        }
    }
}