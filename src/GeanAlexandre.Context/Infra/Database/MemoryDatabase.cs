using System.Collections.Generic;
using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Infra.Database
{
    public class MemoryDatabase : IMemoryDatabase
    {
        private static IList<User> Collection;

        static MemoryDatabase()
        {
            Collection = new List<User>();
        }
        
        public IList<User> GetCollection()
        {
            return Collection;
        }
    }
}