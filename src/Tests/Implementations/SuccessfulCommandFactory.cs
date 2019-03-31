using Pure.Commands;

namespace Pure.Tests.Implementations
{
    public class SuccessfulCommandFactory : ICommandFactory<SuccessfulCommand, CommandOutcome>
    {
        public SuccessfulCommand GetCommand()
        {
            return new SuccessfulCommand();
        }
    }
}
