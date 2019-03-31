using Pure.Commands;

namespace Pure.Tests.Implementations
{
    public class SuccessfulCommand : ICommand<CommandOutcome>
    {
        public CommandOutcome Execute()
        {
            return new CommandOutcome
            {
                Outcome = CommandOutcomeType.Success
            };
        }
    }
}
