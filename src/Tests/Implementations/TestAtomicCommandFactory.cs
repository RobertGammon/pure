using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestAtomicCommandFactory : AtomicCommandFactory<TestCommittedCommand, CommandOutcome>
    {
        public TestAtomicCommandFactory(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        protected override TestCommittedCommand InstantiateCommand(IUnitOfWork unitOfWork)
        {
            return new TestCommittedCommand(unitOfWork);
        }
    }
}
