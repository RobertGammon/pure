using Pure.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{
    public class TestSuccessfulCommand : AtomicCommand<CommandOutcome, CommandImplementationOutcome>
    {
        public TestSuccessfulCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override CommandImplementationOutcome Implementation()
        {
            return new CommandImplementationOutcome
            {
                Outcome = CommandOutcomeType.Success
            };
        }
    }
}
