using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestRolledBackCommand : AtomicCommand
    {
        public TestRolledBackCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override ICommandImplementationOutcome Implementation()
        {
            return new CommandImplementationOutcome(CommittalType.RollBack);
        }
    }
}
