// Program.cs (Задача 5)
using System;

class Program
{
    static void Main()
    {
        
        Point point1 = new Point(10, 20);

        
        (int x, int y) = point1;
        Console.WriteLine($"Координаты точки: X = {x}, Y = {y}");

        
        Point point2 = new Point(5, 7);

       
        (_, int y2) = point2;
        Console.WriteLine($"Координата Y второй точки: {y2}");
    }
}