using Pure.Domain;

namespace Pure.Core.Contracts.Validation
{
    /// <summary>
    /// A service responsible for validating entities of type <typeparamref name="TEntity"/>
    /// </summary>
    /// <typeparam name="TEntity">The type of <see cref="IEntity{TId}"/> that the service can validate</typeparam>
    /// <typeparam name="TId">The type of the <see cref="IEntity{TId}"/>'s <see cref="IEntity{TId}.Id"/></typeparam>
    public interface IEntityValidationService<TEntity, TId> where TEntity : IEntity<TId>
    {
        /// <summary>
        /// Validates the <paramref name="entity"/>
        /// </summary>
        /// <param name="entity">The entity to be validated</param>
        /// <returns>The outcome of validating the <paramref name="entity"/></returns>
        IValidationOutcome Validate(TEntity entity);
    }
}
