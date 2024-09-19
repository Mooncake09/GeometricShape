namespace GeometricShape
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// a, b, c - стороны треугольника
        /// </summary>
        public Triangle(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Стороны треугольника не могут быть меньше нуля");

            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            var height = _a * Math.Sqrt(3) / 2;
            return 0.5 * _a * height;
        }

        public bool IsRightAngled()
        {
            var list = new List<double>() { _a, _b, _c };
            list.Sort();

            var hypotenuse = list[2];
            var cathetusA = list[1];
            var cathetusB = list[0];


            if (hypotenuse == cathetusA || hypotenuse == cathetusB)
                return false;

            return Math.Pow(hypotenuse, 2) == Math.Pow(cathetusA, 2) + Math.Pow(cathetusB, 2);
        }
    }
}
