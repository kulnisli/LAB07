namespace LAB07
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Height { get; set; }

        public Triangle(double sideA, double sideB, double sideC) : base("Треугольник")
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны треугольника должны быть больше нуля.");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Треугольник с такими сторонами не существует.");

            A = sideA;
            B = sideB;
            C = sideC;
            Area = GetArea();
            Perimeter = GetPerimeter();
            Height = (2 * Area) / A;
        }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2.0;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
        }

        public override double GetPerimeter()
        {
            Perimeter = A + B + C;
            return Perimeter;
        }

        public override string ToString()
        {
            return $"{ShapeName} ({A}, {B}, {C}) | Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}";
        }
    }
}