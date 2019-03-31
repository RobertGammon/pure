using Pure.Domain;

namespace Pure.Repositories
{
    /// <summary>
    /// A repository that can create and update <typeparamref name="TEntity"/> entities
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public interface IWriteRepository<TEntity, TId> where TEntity : IAggregateRoot<TId>
    {
        /// <summary>
        /// Updates the <paramref name="entity"/> in persistent store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <remarks>If saving the <paramref name="entity"/> for the first time, call <see cref="Create(TEntity)"/> instead</remarks>
        ISaveResult Update(TEntity entity);
        /// <summary>
        /// Saves a previously transient <paramref name="entity"/> to persistent store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ISaveResult Create(TEntity entity);
    }
}
