double b1, k1, b2, k2;

Console.Write("Введите значение b1: ");
b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1: ");
k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2: ");
k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения: ({x}; {y})");