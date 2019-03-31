using Pure.Commands;
using Pure.Core.Contracts.UnitsOfWork;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// A concrete factory that can create instances of <typeparamref name="TCommand"/>
    /// </summary>
    public abstract class AtomicCommandFactory<TCommand, TCommandOutcome> : IAtomicCommandFactory<TCommand, TCommandOutcome>
        where TCommand : IAtomicCommand<TCommandOutcome>
    {
        /// <summary>
        /// Initialises an atomic command factory instance.
        /// </summary>
        /// <param name="unitOfWorkFactory"></param>
        public AtomicCommandFactory(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        private IUnitOfWorkFactory UnitOfWorkFactory { get; }

        /// <summary>
        /// Gets an instance of the <see cref="IAtomicCommand{TCommand}"/> provided by the current factory
        /// </summary>
        /// <returns></returns>
        public TCommand GetCommand()
        {
            var unitOfWork = UnitOfWorkFactory.GetUnitOfWork();
            return InstantiateCommand(unitOfWork);
        }

        /// <summary>
        /// Instantiates a command of the correct type, all set up and ready to execute
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <returns></returns>
        protected abstract TCommand InstantiateCommand(IUnitOfWork unitOfWork);
    }
}
