// Program.cs (Задача 4)
using System;

class Program
{
    static void Main()
    {
        
        Triangle validTriangle = new Triangle(3, 4, 5);
        Triangle invalidTriangle = new Triangle(1, 2, 4);

        
        validTriangle.PrintSides();
        Console.WriteLine($"Треугольник валидный: {validTriangle.IsValid()}\n");

        
        invalidTriangle.PrintSides();
        Console.WriteLine($"Треугольник валидный: {invalidTriangle.IsValid()}");
    }
}