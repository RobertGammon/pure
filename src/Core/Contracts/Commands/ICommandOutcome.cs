namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// The result of invoking <see cref="IAtomicCommand.Execute"/>
    /// </summary>
    public interface ICommandOutcome
    {
        /// <summary>
        /// Whether the 
        /// </summary>
        CommittalType Committal { get; }
    }
}