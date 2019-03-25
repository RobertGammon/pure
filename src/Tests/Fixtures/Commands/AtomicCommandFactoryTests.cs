using Moq;
using NUnit.Framework;
using Pure.Core.Contracts.UnitsOfWork;
using Pure.Tests.Implementations;

namespace Pure.Tests.Fixtures.Commands
{
    internal class AtomicCommandFactoryTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void AtomicCommandFactory_base_class_constructor_sets_unit_of_work()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            var unitOfWorkFactory = new Mock<IUnitOfWorkFactory>();
            unitOfWorkFactory.Setup(x => x.GetUnitOfWork()).Returns(unitOfWork.Object);

            var sut = new TestAtomicCommandFactory(unitOfWorkFactory.Object);

            var command = sut.GetCommand();

            command.Execute();

            unitOfWork.Verify(x => x.Begin(), Times.Once);
            unitOfWork.Verify(x => x.Commit(), Times.Once);
        }
    }
}
