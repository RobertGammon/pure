using Moq;
using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestAtomicCommandFactory : AtomicCommandFactory
    {
        public TestAtomicCommandFactory(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        protected override IAtomicCommand InstantiateCommand(IUnitOfWork unitOfWork)
        {
            return new TestCommittedCommand(unitOfWork);
        }
    }
}
