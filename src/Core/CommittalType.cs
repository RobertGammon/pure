namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// A key result of <see cref="IAtomicCommand{T}.Execute"/>: whether the results were committed or rolled back
    /// </summary>
    public enum CommittalType
    {
        /// <summary>
        /// The command's outcome has not been determined yet
        /// </summary>
        Unknown,
        /// <summary>
        /// The command's outcome was committed
        /// </summary>
        Commit,
        /// <summary>
        /// The command's outcome was rolled back
        /// </summary>
        RollBack
    }
}