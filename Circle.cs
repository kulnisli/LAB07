namespace LAB07
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Окружность")
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше нуля.");
            
            Radius = radius;
            Area = GetArea();
            Perimeter = GetPerimeter();
        }

        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        public override double GetPerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }

        public override string ToString()
        {
            return $"{ShapeName} (R = {Radius}) | Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}";
        }
    }
}
    