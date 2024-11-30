using FluentAssertions;
using GeometryLibrary.Factories;
using GeometryLibrary.Shapes;
using GeometryLibrary.Exceptions;

namespace GeometryLibrary.Tests.Factories
{
    [TestFixture]  
    public class CircleFactoriesTests
    {
        [Test]
        public void CreateCircle_CorrectArguments_ShouldReturnNewCircle()
        {
            var expectedCircle = new Circle(4);

            var fabric = new CircleFactory(4);

            var newCircle = fabric.CreatreShape();

            newCircle.Should().BeEquivalentTo(expectedCircle);
        }

        [Test]
        public void CreateCircle_IncorrectAgruments_ShouldThrowException()
        {
            var fabric = new CircleFactory(-1);

            var action = new Action(() => fabric.CreatreShape());

            action.Should().Throw<InvalidShapeException>();
        }
    }
}
