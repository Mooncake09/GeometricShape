namespace GeometricShape
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("Радиус не может быть меньше нуля");
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius;
        }
    }
}
