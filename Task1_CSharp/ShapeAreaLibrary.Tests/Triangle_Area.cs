using Xunit;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.UnitTests.ShapeTriangle
{
    public class Triangle_Area
    {
        [Fact]
        public void Triangle_3_4_5_Area_is6()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.Area();

            // area must be half of rectangle's with sides 3 and 4
            // because the 3 4 5 triangle is Pythagorean and hence right
            Assert.Equal(6, area, 1e-7);
        }
    }
}