using Pure.Commands;

namespace Pure.UseCases
{
    /// <summary>
    /// Base class for UseCase entities
    /// </summary>
    /// <remarks>
    /// The intention is for a use case class to call <see cref="ICommand{TCommandOutcome}"/> objects
    /// </remarks>
    public class UseCaseBase
    {
        /// <summary>
        /// Initialises a use case class
        /// </summary>
        /// <param name="unitOfWorkFactory"></param>
        public UseCaseBase(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Gets the unit of work factory for the current use case
        /// </summary>
        protected IUnitOfWorkFactory UnitOfWorkFactory { get; }
    }
}
