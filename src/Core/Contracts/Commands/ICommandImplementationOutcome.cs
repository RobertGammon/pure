﻿namespace Pure.Core.Contracts.Commands
{
    /// <summary>
    /// An indication of whether a command's outcome should be committed
    /// </summary>
    public interface ICommandImplementationOutcome
    {
        /// <summary>
        /// Whether the outcome should be committed
        /// </summary>
        CommittalType ShouldCommit { get; }
    }
}