using System;
using Pure.Commands;
using Pure.Core.Contracts.UnitsOfWork;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// An atomic command, which, when <see cref="Execute"/> is called, succeeds and commits, or fails and rolls back.
    /// </summary>
    public abstract class AtomicCommand<TCommandOutcome, TCommandImplementationOutcome> : IAtomicCommand<TCommandOutcome>
        where TCommandOutcome : class, ICommandOutcome, new()
        where TCommandImplementationOutcome : class, ICommandImplementationOutcome, new()
    {
        /// <summary>
        /// Gets the unit of work
        /// </summary>
        private IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Initialises a new <see cref="AtomicCommand{TCommandOutcome, TCommandImplementationOutcome}"/> instance
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
        public TCommandOutcome Execute()
        {
            UnitOfWork.Begin();

            TCommandOutcome result;
            try
            {
                var implementationResult = Implementation();

                if (implementationResult.Outcome == CommandOutcomeType.Success)
                {
                    UnitOfWork.Commit();
                }
                else
                {
                    UnitOfWork.Rollback();
                }

                result = new TCommandOutcome
                {
                    Outcome = implementationResult.Outcome
                };
            }
            catch (Exception)
            {
                // todo: don't just swallow the exception

                UnitOfWork.Rollback();
                result = new TCommandOutcome
                {
                    Outcome = CommandOutcomeType.Failure
                };
            }

            return result;
        }

        /// <summary>
        /// Override this method to implement the logic of an <see cref="AtomicCommand{TCommandOutcome, TCommandImplementationOutcome}"/> type.
        /// Setup should have been done before the command is <see cref="Execute"/>d, including dependencies on on any ports and adapters,
        /// such as repositories and services, being made explicit in the constructor of the concrete class.
        /// </summary>
        /// <returns></returns>
        protected abstract TCommandImplementationOutcome Implementation();
    }
}
