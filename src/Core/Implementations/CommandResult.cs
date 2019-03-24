using Pure.Core.Contracts.Commands;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// The result of executing a command, indicating whether it was committed or rolled back
    /// </summary>
    public class CommandResult : ICommandOutcome
    {
        /// <summary>
        /// Initialises a command result, indicating the committal type
        /// </summary>
        /// <param name="committal"></param>
        public CommandResult(CommittalType committal)
        {
            Committal = committal;
        }

        /// <summary>
        /// Gets whether the command resulted in a <see cref="CommittalType.Commit"/> or <see cref="CommittalType.RollBack"/>
        /// </summary>
        public CommittalType Committal { get; }
    }
}
