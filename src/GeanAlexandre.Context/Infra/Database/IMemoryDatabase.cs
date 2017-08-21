using System.Collections.Generic;
using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Infra.Database
{
    public interface IMemoryDatabase
    {
        IList<User> GetCollection();
    }
}