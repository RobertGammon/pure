namespace Pure.Core.Contracts
{
    /// <summary>
    /// A composition root that represents an application
    /// </summary>
    public interface ICompositionRoot
    {
        /// <summary>
        /// Performs any required bootstrapping (such as IoC/DI registrations)
        /// </summary>
        void Bootstrap();
    }
}
