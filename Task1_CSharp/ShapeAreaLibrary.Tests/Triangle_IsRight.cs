using Xunit;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.UnitTests.ShapeTriangle
{
    public class Triangle_IsRight
    {
        [Fact]
        public void Triangle_3_4_5_IsRight_isTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            bool right = triangle.IsRight();

            // pythagorean triangle must be
            Assert.True(right);
        }

        [Fact]
        public void Triangle_3_3_3_IsRight_isFalse()
        {
            var triangle = new Triangle(3, 3, 3);
            bool right = triangle.IsRight();

            // equilateral triangle obviously is not
            Assert.False(right);
        }
    }
}