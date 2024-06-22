using Xunit;
using ShapeLibrary.Shapes;
using System;

namespace ShapeLibrary.Tests
{
    public class Disk_Constructor
    {

        [Fact]
        public void Disk_ConstructorWithNegativeRadius_ThrowsArgumentOutOfRangeException()
        {
            var caughtException = Assert.Throws<ArgumentOutOfRangeException>(() => new Disk(-1));
            Assert.Equal("Radius must be non-negative.", caughtException.Message);
        }
    }
}
