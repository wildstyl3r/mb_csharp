using Xunit;
using ShapeLibrary.Shapes;
using System;

namespace ShapeLibrary.Tests
{
    public class Triangle_Constructor
    {
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void Triangle_ConstructorTriangleInequalityViolation_ThrowsArgumentOutOfRangeException(double a, double b, double c)
        {
            var caughtException = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
            Assert.Equal("Triangle inequality must be satisfied.", caughtException.Message);
        }
    }
}
