namespace ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // using Heron's fromula
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // using Pythagorean theorem: h ^ 2 = c1 ^ 2 + c2 ^ 2
        public bool IsRight()
        {
            double hypothenuse, cath1, cath2, eps = 1e-7;  //we need eps to overcome accumulating imprecision of floating point operations
            if (a > b && a > c)
            {
                hypothenuse = a;
                cath1 = b;
                cath2 = c;
            }
            else if (b > a && b > c)
            {
                hypothenuse = b;
                cath1 = c;
                cath2 = a;
            }
            else
            {
                hypothenuse = c;
                cath1 = a;
                cath2 = b;
            }

            if (Math.Abs(hypothenuse * hypothenuse - cath1 * cath1 - cath2 * cath2) < eps)
                return true;
            else
                return false;
        }
    }
}
