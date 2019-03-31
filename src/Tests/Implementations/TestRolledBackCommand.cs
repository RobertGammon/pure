using Pure.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestRolledBackCommand : AtomicCommand<CommandOutcome, CommandImplementationOutcome>
    {
        public TestRolledBackCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override CommandImplementationOutcome Implementation()
        {
            return new CommandImplementationOutcome
            {
                Outcome = CommandOutcomeType.Failure
            };
        }
    }
}
