namespace Pure.Core.Contracts
{
    /// <summary>
    /// An aggregate root that represents the application as a whole
    /// </summary>
    public interface IAggregateRoot
    {
        /// <summary>
        /// Performs any required bootstrapping (such as IoC/DI registrations)
        /// </summary>
        void Bootstrap();
    }
}
