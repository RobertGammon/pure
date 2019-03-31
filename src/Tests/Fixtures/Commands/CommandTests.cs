using System;
using FluentAssertions;
using NUnit.Framework;
using Pure.Commands;
using Pure.Tests.Implementations;

namespace Tests.Fixtures.Commands
{
    public class CommandTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void SuccessfulCommand_execute_should_succeed()
        {
            var sut = new SuccessfulCommand();

            var result = sut.Execute();

            result.Outcome.Should().Be(CommandOutcomeType.Success);
        }

        [Test]
        public void FailingCommand_execute_should_fail()
        {
            var sut = new FailingCommand();

            var result = sut.Execute();

            result.Outcome.Should().Be(CommandOutcomeType.Failure);
        }

        [Test]
        public void ExceptionCommand_execute_should_throw()
        {
            var cmd = new ExceptionCommand();

            Action sut = () => cmd.Execute();

            sut.Should().Throw<InvalidOperationException>();
        }
    }
}