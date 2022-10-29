using Point3D;
Point Read3DPoint()
{
    Console.Write("Введите координаты x: ");
    var x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты y: ");
    var y = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z: ");
    var z = Convert.ToDouble(Console.ReadLine());
    return new Point(x, y, z);
}
Console.WriteLine("Введите первую точку:");
var p1 = Read3DPoint();
Console.WriteLine("Введите вторую точку:");
var p2 = Read3DPoint();
Console.WriteLine($"Расстояние между двумя точками равно: {p1.dist(p2)}");
Console.WriteLine($"Расстояние от точки до начала координат: {p1.dist0()}");
Console.WriteLine($"Сумма векторов равна: ({p1.sumX(p2)}, {p1.sumY(p2)}, {p1.sumZ(p2)})");
Console.WriteLine($"Скалярное произведение равно: {p1.scalar(p2)}");
Console.WriteLine($"Векторное произведение равно: {p1.vectori(p2)}i, {p1.vectorj(p2)}j, {p1.vectork(p2)}k");
Console.WriteLine($"Уравнение прямой через две точки: {p1.straight(p2)}");
Console.WriteLine("Введите третью точку:");
var p3 = Read3DPoint();
Console.WriteLine($"Уравнение плоскости через три точки - {Point.flat(p1,p2,p3)}");

