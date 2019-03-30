namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// The result of invoking <see cref="IAtomicCommand{TCommandOutcome}.Execute"/>
    /// </summary>
    public interface ICommandOutcome
    {
        /// <summary>
        /// Whether a command should be committed (<see cref="CommittalType.Commit"/>) or rolled back
        /// (<see cref="CommittalType.RollBack"/>)
        /// </summary>
        CommittalType Committal { get; set; }
    }
}