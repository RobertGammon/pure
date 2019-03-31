using System;
using Pure.Commands;

namespace Pure.Tests.Implementations
{

    public class ExceptionCommand : ICommand<CommandOutcome>
    {
        public CommandOutcome Execute()
        {
            throw new InvalidOperationException("Testing invalid operation");
        }
    }
}
