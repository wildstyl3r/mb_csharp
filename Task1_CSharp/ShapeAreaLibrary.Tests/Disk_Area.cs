using Xunit;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.UnitTests.ShapeDisk
{
    public class Disk_Area
    {

        [Fact]
        public void Disk_r3_Area_is9PI()
        {
            var disk = new Disk(3);
            double area = disk.Area();

            Assert.Equal(9 * Math.PI, area, 1e-7);
        }
    }
}