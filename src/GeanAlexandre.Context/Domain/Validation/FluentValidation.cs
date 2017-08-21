using System;

namespace GeanAlexandre.Context.Domain.Validation
{
    public class FluentValidation<TTEntity> : IValidation<TTEntity>
    {
        private readonly TTEntity _entity;

        private FluentValidation(TTEntity entity)
        {
            _entity = entity;
        }

        public static FluentValidation<TTEntity> Validate(TTEntity entity)
        {
            return new FluentValidation<TTEntity>(entity);
        }

        public IValidation<TTEntity> ThrowCase(Predicate<TTEntity> predicate, string message)
        {
            if (predicate(_entity))
                throw new InvalidOperationException(message);

            return Validate(_entity);
        }

        public IValidation<TTEntity> Else(Action action)
        {
            action();

            return Validate(_entity);
        }

        public TReturn Else<TReturn>(Func<TTEntity, TReturn> elsefn)
        {
            return elsefn(_entity);
        }
    }
}