using GeanAlexandre.Context.Domain.CommandHandler;
using GeanAlexandre.Context.Infra.CrossCutting.IoC;
using GeanAlexandre.Context.Infra.CrossCutting.Seed;
using GeanAlexandre.Context.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace GeanAlexandre.Context.Infra.CrossCutting
{
    public static class CrossCuttingApi
    {
        public static void ResolveDependencies(this IServiceCollection serviceCollection,
            IMongoSettings mongoSettings)
        {
            new DependencyInject(serviceCollection).Resolve(mongoSettings);
            GeanAlexandreSeed.Factory(
                serviceCollection.BuildServiceProvider().GetService<ICreateResumeCommandHandler>());
        }
    }
}