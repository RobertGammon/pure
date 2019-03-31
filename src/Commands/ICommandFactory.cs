namespace Pure.Commands
{
    /// <summary>
    /// A factory that can create <see cref="ICommand{TCommandOutcome}"/> objects.
    /// </summary>
    public interface ICommandFactory<TCommand, TCommandOutcome>
        where TCommand : ICommand<TCommandOutcome>
    {
        /// <summary>
        /// Gets a command
        /// </summary>
        /// <returns>An <typeparamref name="TCommand"/></returns>
        TCommand GetCommand();
    }
}
