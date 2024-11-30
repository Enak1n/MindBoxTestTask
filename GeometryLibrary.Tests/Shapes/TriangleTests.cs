using FluentAssertions;
using GeometryLibrary.Shapes;

namespace GeometryLibrary.Tests.Shapes
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);

            var area = triangle.CalculateArea();

            area.Should().BeApproximately(6, 0.0001);
        }
    }
}
