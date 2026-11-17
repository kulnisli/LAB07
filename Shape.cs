namespace LAB07
{
    public class Shape
    {
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }
        public string ShapeName { get; set; }

        public Shape(string shapeName)
        {
            ShapeName = shapeName;
        }

        public virtual double GetArea()
        {
            return Area;
        }

        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public override string ToString()
        {
            return $"{ShapeName} | Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}";
        }

        public static bool operator ==(Shape? s1, Shape? s2)
        {
            if (ReferenceEquals(s1, s2)) return true;
            if (s1 is null || s2 is null) return false;
            return Math.Abs(s1.GetArea() - s2.GetArea()) < 1e-6;
        }

        public static bool operator !=(Shape? s1, Shape? s2)
        {
            return !(s1 == s2);
        }

        public static bool operator >(Shape? s1, Shape? s2)
        {
            if (s1 is null || s2 is null) return false;
            return s1.GetArea() > s2.GetArea();
        }

        public static bool operator <(Shape? s1, Shape? s2)
        {
            if (s1 is null || s2 is null) return false;
            return s1.GetArea() < s2.GetArea();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Shape other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return GetArea().GetHashCode();
        }
    }
}

