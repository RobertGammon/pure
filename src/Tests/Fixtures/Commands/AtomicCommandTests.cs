using FluentAssertions;
using Moq;
using NUnit.Framework;
using Pure.Commands;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Tests.Implementations;

namespace Tests.Fixtures.Commands
{
    public class AtomicCommandTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void AtomicCommand_execute_when_committed_should_return_committed()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var sut = new TestSuccessfulCommand(unitOfWork.Object);

            var result = sut.Execute();

            result.Outcome.Should().Be(CommandOutcomeType.Success);
        }

        [Test]
        public void AtomicCommand_execute_when_committed_should_call_commit()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var sut = new TestSuccessfulCommand(unitOfWork.Object);

            var result = sut.Execute();

            unitOfWork.Verify(x => x.Commit(), Times.Once);
            unitOfWork.Verify(x => x.Rollback(), Times.Never);
        }

        [Test]
        public void AtomicCommand_execute_when_rolled_back_should_return_rolled_back()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var sut = new TestRolledBackCommand(unitOfWork.Object);

            var result = sut.Execute();

            result.Outcome.Should().Be(CommandOutcomeType.Failure);
        }

        [Test]
        public void AtomicCommand_execute_when_rolled_back_should_call_rollback()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var sut = new TestRolledBackCommand(unitOfWork.Object);

            var result = sut.Execute();

            unitOfWork.Verify(x => x.Commit(), Times.Never);
            unitOfWork.Verify(x => x.Rollback(), Times.Once);
        }

        [Test]
        public void AtomicCommand_execute_when_exception_thrown_should_return_rolled_back()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var sut = new TestErroringCommand(unitOfWork.Object);

            var result = sut.Execute();

            result.Outcome.Should().Be(CommandOutcomeType.Failure);
        }

        [Test]
        public void AtomicCommand_execute_when_exception_should_call_rollback()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var sut = new TestErroringCommand(unitOfWork.Object);

            var result = sut.Execute();

            unitOfWork.Verify(x => x.Commit(), Times.Never);
            unitOfWork.Verify(x => x.Rollback(), Times.Once);
        }
    }
}