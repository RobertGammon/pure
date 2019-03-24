namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// A factory that can create <see cref="IAtomicCommand"/> objects.
    /// </summary>
    public interface IAtomicCommandFactory
    {
        /// <summary>
        /// Gets a command
        /// </summary>
        /// <returns>An <see cref="IAtomicCommand"/></returns>
        IAtomicCommand GetCommand();
    }
}
