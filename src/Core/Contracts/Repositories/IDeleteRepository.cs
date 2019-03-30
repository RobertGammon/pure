using Pure.Core.Contracts.Domain;

namespace Pure.Core.Contracts.Repositories
{
    /// <summary>
    /// A repository that can delete <typeparamref name="TEntity"/> entities
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public interface IDeleteRepository<TEntity, TId> where TEntity : IAggregateRoot<TId>
    {
        /// <summary>
        /// Deletes the <typeparamref name="TEntity"/> entity from persistent store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ISaveResult Delete(TId entity);
    }
}
