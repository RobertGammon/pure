using System;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{

    public class TestErroringCommand : AtomicCommand<CommandOutcome, CommandImplementationOutcome>
    {
        public TestErroringCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override CommandImplementationOutcome Implementation()
        {
            throw new InvalidOperationException("Testing invalid operation");
        }
    }
}
