using GeanAlexandre.Context.Infra.CrossCutting;
using GeanAlexandre.Context.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace GeanAlexandre.Context
{
    public static class GeanAlexandreContextApi
    {
        public static void ConfigureGeanAlexandreContext(this IServiceCollection collection, IMongoSettings mongoSettings)
        {
            collection.ResolveDependencies(mongoSettings);
        }
    }
}