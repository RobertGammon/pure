using System;
using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// An atomic command, which, when <see cref="Execute"/> is called, succeeds and commits, or fails and rolls back.
    /// </summary>
    public abstract class AtomicCommand : IAtomicCommand
    {

        /// <summary>
        /// Gets the unit of work
        /// </summary>
        private IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Initialises a new <see cref="AtomicCommand"/> instance
        /// </summary>
        /// <param name="unitOfWork">The type of </param>
        public AtomicCommand(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Executes the current command. The command should be all set up ready to execute before calling this method.
        /// </summary>
        /// <returns>An <see cref="ICommandOutcome"/> indicating the outcome of the command</returns>
        public ICommandOutcome Execute()
        {
            UnitOfWork.Begin();

            ICommandOutcome result;
            try
            {
                var implementationResult = Implementation();

                if (implementationResult.ShouldCommit == CommittalType.Commit)
                {
                    UnitOfWork.Commit();
                }
                else
                {
                    UnitOfWork.Rollback();
                }

                result = new CommandResult(implementationResult.ShouldCommit);
            }
            catch (Exception)
            {
                // todo: don't just swallow the exception

                UnitOfWork.Rollback();
                result = new CommandResult(CommittalType.RollBack);
            }

            return result;
        }

        /// <summary>
        /// Override this method to implement the logic of an <see cref="AtomicCommand"/> type. Setup should have
        /// been done before the command is <see cref="Execute"/>d, including dependencies on on any ports and adapters
        /// such as repositories and services being made explicit in the constructor of the concrete class.
        /// </summary>
        /// <returns></returns>
        protected abstract ICommandImplementationOutcome Implementation();
    }
}
