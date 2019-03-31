namespace Pure.Commands
{
    /// <summary>
    /// A key result of <see cref="ICommand{T}.Execute"/>: whether the results were committed or rolled back
    /// </summary>
    public enum CommandOutcomeType
    {
        /// <summary>
        /// The command's outcome has not been determined yet
        /// </summary>
        Unknown,
        /// <summary>
        /// The command succeeded
        /// </summary>
        Success,
        /// <summary>
        /// The command failed
        /// </summary>
        Failure
    }
}