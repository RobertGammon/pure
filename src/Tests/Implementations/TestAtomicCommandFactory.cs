using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestAtomicCommandFactory : AtomicCommandFactory<TestSuccessfulCommand, CommandOutcome>
    {
        public TestAtomicCommandFactory(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        protected override TestSuccessfulCommand InstantiateCommand(IUnitOfWork unitOfWork)
        {
            return new TestSuccessfulCommand(unitOfWork);
        }
    }
}
