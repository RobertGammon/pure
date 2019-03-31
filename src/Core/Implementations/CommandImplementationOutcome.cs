using Pure.Commands;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// The result of executing an <see cref="AtomicCommand{TCommandOutcome, TCommandImplementationOutcome}"/>'s
    /// <see cref="AtomicCommand{TOutcome, TImplementationOutcome}.Implementation"/> method
    /// </summary>
    public class CommandImplementationOutcome : ICommandImplementationOutcome
    {
        /// <summary>
        /// Whether the command resulted in <see cref="CommandOutcomeType.Success"/> or <see cref="CommandOutcomeType.Failure"/>
        /// </summary>
        public CommandOutcomeType Outcome { get; set; } = CommandOutcomeType.Unknown;
    }
}
