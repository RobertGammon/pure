namespace Pure.Commands
{
    /// <summary>
    /// The result of invoking <see cref="ICommand{TCommandOutcome}.Execute"/>
    /// </summary>
    public interface ICommandOutcome
    {
        /// <summary>
        /// Whether a command succeeded (<see cref="CommandOutcomeType.Success"/>) or failed
        /// (<see cref="CommandOutcomeType.Failure"/>)
        /// </summary>
        CommandOutcomeType Outcome { get; set; }
    }
}