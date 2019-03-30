using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestCommittedCommand : AtomicCommand<CommandOutcome, CommandImplementationOutcome>
    {
        public TestCommittedCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override CommandImplementationOutcome Implementation()
        {
            return new CommandImplementationOutcome
            {
                ShouldCommit = CommittalType.Commit
            };
        }
    }
}
