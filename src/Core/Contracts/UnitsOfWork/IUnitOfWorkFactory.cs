namespace Pure.Core.Contracts.UnitsOfWork
{
    /// <summary>
    /// A factory that can create <see cref="IUnitOfWork"/> objects
    /// </summary>
    public interface IUnitOfWorkFactory
    {
        /// <summary>
        /// Gets an <see cref="IUnitOfWork"/> instance
        /// </summary>
        /// <returns>An <see cref="IUnitOfWork"/></returns>
        IUnitOfWork GetUnitOfWork();
    }
}
