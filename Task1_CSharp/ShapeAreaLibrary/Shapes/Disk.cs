namespace ShapeLibrary.Shapes
{
    public class Disk : IShape
    {
        private double radius;
        public Disk(double radius)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(radius, nameof(radius));
            this.radius = radius;
        }

        public double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
