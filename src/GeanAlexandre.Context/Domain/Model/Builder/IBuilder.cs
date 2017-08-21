using System;

namespace GeanAlexandre.Context.Domain.Model.Builder
{
    public interface IBuilder<TEntity>
    {
        IBuilder<TEntity> ThenBuild(Func<TEntity,TEntity> action);
        TReturn ThenParse<TReturn>(Func<TEntity, TReturn> parseFn);
    }
}