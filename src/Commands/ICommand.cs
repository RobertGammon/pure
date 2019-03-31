namespace Pure.Commands
{
    /// <summary>
    /// An atomic command: either it is successful when it can be committed, or unsuccessful and can be rolled back.
    /// </summary>
    public interface ICommand<TCommandOutcome>
    {
        /// <summary>
        /// Executes the current <see cref="ICommand{TCommandOutcome}"/> and either commits or rolls back the results.
        /// </summary>
        /// <returns>An <typeparamref name="TCommandOutcome"/> indicating the <see cref="ICommand{TCommandOutcome}"/>'s success or failure</returns>
        TCommandOutcome Execute();
    }
}
