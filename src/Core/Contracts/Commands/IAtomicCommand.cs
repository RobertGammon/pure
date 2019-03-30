namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// An atomic command: either it is successful when it can be committed, or unsuccessful and can be rolled back.
    /// </summary>
    public interface IAtomicCommand<TCommandOutcome>
    {
        /// <summary>
        /// Executes the current <see cref="IAtomicCommand{TCommandOutcome}"/> and either commits or rolls back the results.
        /// </summary>
        /// <returns>An <typeparamref name="TCommandOutcome"/> indicating the <see cref="IAtomicCommand{TCommandOutcome}"/>'s success or failure</returns>
        TCommandOutcome Execute();
    }
}
