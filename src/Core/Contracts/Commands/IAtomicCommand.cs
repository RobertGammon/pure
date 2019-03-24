namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// An atomic command: either it is successful when it can be committed, or unsuccessful and can be rolled back.
    /// </summary>
    public interface IAtomicCommand
    {
        /// <summary>
        /// Executes the current <see cref="IAtomicCommand"/> and either commits or rolls back the results.
        /// </summary>
        /// <returns>An <see cref="ICommandOutcome"/> indicating the <see cref="IAtomicCommand"/>'s success or failure</returns>
        ICommandOutcome Execute();
    }
}
