using System;
using Pure.Core.Contracts.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Core.Implementations;

namespace Pure.Tests.Implementations
{

    public class TestErroringCommand : AtomicCommand
    {
        public TestErroringCommand(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override ICommandImplementationOutcome Implementation()
        {
            throw new InvalidOperationException("Testing invalid operation");
        }
    }
}
