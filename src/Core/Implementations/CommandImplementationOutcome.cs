using Pure.Core.Contracts.Commands;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// The result of executing an <see cref="AtomicCommand{TCommandOutcome, TCommandImplementationOutcome}"/>'s
    /// <see cref="AtomicCommand{TOutcome, TImplementationOutcome}.Implementation"/> method
    /// </summary>
    public class CommandImplementationOutcome : ICommandImplementationOutcome
    {
        /// <summary>
        /// Whether the outcome of the command should be committed
        /// </summary>
        public CommittalType ShouldCommit { get; set; } = CommittalType.Unknown;
    }
}
