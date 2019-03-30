using Pure.Core.Contracts.Domain;

namespace Pure.Core.Contracts.Repositories
{
    /// <summary>
    /// A repository that can retrieve <see cref="IAggregateRoot{TId}"/> entities
    /// from persistent store
    /// </summary>
    public interface IReadRepository<TEntity, TId> where TEntity : IAggregateRoot<TId>
    {
        /// <summary>
        /// Gets a single <typeparamref name="TEntity"/> entity from persistent store, given
        /// its <paramref name="id"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(TId id);
    }
}
