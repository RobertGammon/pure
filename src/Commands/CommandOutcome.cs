namespace Pure.Commands
{
    /// <summary>
    /// The result of executing a command, indicating whether it was committed or rolled back
    /// </summary>
    public class CommandOutcome : ICommandOutcome
    {
        /// <summary>
        /// Gets whether the command resulted in a <see cref="CommandOutcomeType.Success"/> or <see cref="CommandOutcomeType.Failure"/>
        /// </summary>
        public CommandOutcomeType Outcome { get; set; } = CommandOutcomeType.Unknown;
    }
}
