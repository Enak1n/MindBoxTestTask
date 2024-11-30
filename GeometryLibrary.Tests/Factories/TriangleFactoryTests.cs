using FluentAssertions;
using GeometryLibrary.Exceptions;
using GeometryLibrary.Factories;
using GeometryLibrary.Shapes;

namespace GeometryLibrary.Tests.Factories
{
    [TestFixture]
    public class TriangleFactoryTests
    {
        [Test]
        public void CreateTriangle_CorrectArguments_ShouldReturnNewTriangle()
        {
            var expectedTriangle = new Triangle(3, 6, 5);

            var fabric = new TriangleFactory(3, 6, 5);

            var newTriangle = fabric.CreatreShape();

            newTriangle.Should().BeEquivalentTo(expectedTriangle);
        }

        [Test]
        public void CreateTriangle_SidesAreNotCorrect_ShouldThrowInvalidShapeException()
        {
            var fabric = new TriangleFactory(1, 2, 3);

            var action = new Action(() => fabric.CreatreShape());

            action.Should().Throw<InvalidShapeException>();
        }

        [Test]
        public void CreateTriangle_SidesWithNegativeValues_ShouldThrowInvalidShapeException()
        {
            var fabric = new TriangleFactory(-1, -2, -3);

            var action = new Action(() => fabric.CreatreShape());

            action.Should().Throw<InvalidShapeException>();
        }
    }
}
