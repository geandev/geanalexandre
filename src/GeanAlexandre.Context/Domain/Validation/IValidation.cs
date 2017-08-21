using System;

namespace GeanAlexandre.Context.Domain.Validation
{
    public interface IValidation<out TType>
    {
        IValidation<TType> ThrowCase(Predicate<TType> predicate, string message);
        IValidation<TType> Else(Action action);
        TReturn Else<TReturn>(Func<TType, TReturn> elsefn);
    }
}