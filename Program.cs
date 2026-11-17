using LAB07;

Shape[] shapes =
{
    new Circle(5),
    new Rectangle(4, 6),
    new Triangle(3, 4, 5),
    new Circle(2.5),
    new Rectangle(10, 2),
    new Triangle(5, 5, 6),
    new Circle(7),
    new Rectangle(3, 8),
    new Triangle(6, 8, 10),
    new Rectangle(5, 5)
};

Console.WriteLine("=== Список всех фигур (10 шт.) ===");
for (int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine($"{i + 1}. {shapes[i]}");
}


Console.WriteLine("\n=== Проверка операторов сравнения ===");
Console.WriteLine($"Фигура 1 ({shapes[0].ShapeName}) > Фигура 2 ({shapes[1].ShapeName}): {shapes[0] > shapes[1]}");
Console.WriteLine($"Фигура 3 ({shapes[2].ShapeName}) < Фигура 1 ({shapes[0].ShapeName}): {shapes[2] < shapes[0]}");
Console.WriteLine($"Фигура 3 == Фигура 10: {shapes[2] == shapes[9]}");
Console.WriteLine($"Фигура 3 != Фигура 10: {shapes[2] != shapes[9]}");

// Пункт 6.1: Найти фигуру с максимальным отношением площади к периметру max(S / P)
Shape maxRatioShape = shapes[0];
double maxRatio = shapes[0].GetArea() / shapes[0].GetPerimeter();

// Пункт 6.2: Найти фигуру с минимальной площадью min(S)
Shape minAreaShape = shapes[0];
double minArea = shapes[0].GetArea();

for (int i = 0; i < shapes.Length; i++)
{
    double currentRatio = shapes[i].GetArea() / shapes[i].GetPerimeter();
    if (currentRatio > maxRatio)
    {
        maxRatio = currentRatio;
        maxRatioShape = shapes[i];
    }

    double currentArea = shapes[i].GetArea();
    if (currentArea < minArea)
    {
        minArea = currentArea;
        minAreaShape = shapes[i];
    }
}

Console.WriteLine("\n=== Результаты дополнительных задач ===");
Console.WriteLine($"1. Максимальное отношение (S / P = {maxRatio:F2}): {maxRatioShape}");
Console.WriteLine($"2. Минимальная площадь (min S = {minArea:F2}): {minAreaShape}");
