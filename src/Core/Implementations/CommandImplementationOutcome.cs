using Pure.Core.Contracts.Commands;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// The result of executing an <see cref="AtomicCommand"/>'s <see cref="AtomicCommand.Implementation"/> method
    /// </summary>
    public class CommandImplementationOutcome : ICommandImplementationOutcome
    {
        /// <summary>
        /// Initialises a new implementation result, <paramref name="shouldCommit"/> indicating whether to commit the outcome
        /// </summary>
        /// <param name="shouldCommit"></param>
        public CommandImplementationOutcome(CommittalType shouldCommit)
        {
            ShouldCommit = shouldCommit;
        }

        /// <summary>
        /// Whether the outcome of the command should be committed
        /// </summary>
        public CommittalType ShouldCommit { get; set; }
    }
}
