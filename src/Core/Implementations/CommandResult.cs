using Pure.Core.Contracts.Commands;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// The result of executing a command, indicating whether it was committed or rolled back
    /// </summary>
    public class CommandOutcome : ICommandOutcome
    {
        /// <summary>
        /// Gets whether the command resulted in a <see cref="CommittalType.Commit"/> or <see cref="CommittalType.RollBack"/>
        /// </summary>
        public CommittalType Committal { get; set; } = CommittalType.Unknown;
    }
}
