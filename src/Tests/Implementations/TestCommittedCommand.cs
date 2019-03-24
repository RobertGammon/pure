using System.Reflection;
using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestCommittedCommand : AtomicCommand
    {
        public TestCommittedCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override ICommandImplementationOutcome Implementation()
        {
            return new CommandImplementationOutcome(CommittalType.Commit);
        }
    }
}
