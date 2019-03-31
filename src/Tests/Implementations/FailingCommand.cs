using Pure.Commands;

namespace Pure.Tests.Implementations
{
    public class FailingCommand : ICommand<CommandOutcome>
    {
        public CommandOutcome Execute()
        {
            return new CommandOutcome
            {
                Outcome = CommandOutcomeType.Failure
            };
        }
    }
}
