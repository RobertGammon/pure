namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// A factory that can create <see cref="IAtomicCommand{TCommandOutcome}"/> objects.
    /// </summary>
    public interface IAtomicCommandFactory<TCommand, TCommandOutcome>
        where TCommand : IAtomicCommand<TCommandOutcome>
    {
        /// <summary>
        /// Gets a command
        /// </summary>
        /// <returns>An <typeparamref name="TCommand"/></returns>
        TCommand GetCommand();
    }
}
