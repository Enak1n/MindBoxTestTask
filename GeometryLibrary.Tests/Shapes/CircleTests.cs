using FluentAssertions;
using GeometryLibrary.Shapes;

namespace GeometryLibrary.Tests.Shapes
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();

            area.Should().BeApproximately(78.5398, 0.0001);
        }
    }
}
