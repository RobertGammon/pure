namespace Pure.UseCases
{
    /// <summary>
    /// A unit of work. Outcome of associated operation is to be evaluated, and either wholly committed or wholly rolled back.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Begins the current <see cref="IUnitOfWork"/>
        /// </summary>
        void Begin();
        /// <summary>
        /// Commits the current <see cref="IUnitOfWork"/>
        /// </summary>
        /// <returns></returns>
        void Commit();
        /// <summary>
        /// Rolls back the current <see cref="IUnitOfWork"/>
        /// </summary>
        /// <returns></returns>
        void Rollback();
    }
}
