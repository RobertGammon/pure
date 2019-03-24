using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;

namespace Pure.Core.Implementations
{
    /// <summary>
    /// A concrete factory that can create instances of <see cref="IAtomicCommand"/>
    /// </summary>
    public abstract class AtomicCommandFactory : IAtomicCommandFactory
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
        /// Gets an instance of the <see cref="IAtomicCommand"/> provided by the current factory
        /// </summary>
        /// <returns></returns>
        public IAtomicCommand GetCommand()
        {
            var unitOfWork = UnitOfWorkFactory.GetUnitOfWork();
            return InstantiateCommand(unitOfWork);
        }

        /// <summary>
        /// Instantiates a command of the correct type, all set up and ready to execute
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <returns></returns>
        protected abstract IAtomicCommand InstantiateCommand(IUnitOfWork unitOfWork);
    }
}
