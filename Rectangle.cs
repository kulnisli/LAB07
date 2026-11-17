namespace LAB07
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Прямоугольник")
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Стороны прямоугольника должны быть больше нуля.");

            Width = width;
            Height = height;
            Area = GetArea();
            Perimeter = GetPerimeter();
        }

        public override double GetArea()
        {
            Area = Width * Height;
            return Area;
        }

        public override double GetPerimeter()
        {
            Perimeter = 2 * (Width + Height);
            return Perimeter;
        }

        public override string ToString()
        {
            return $"{ShapeName} ({Width} x {Height}) | Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}";
        } 
    }
}