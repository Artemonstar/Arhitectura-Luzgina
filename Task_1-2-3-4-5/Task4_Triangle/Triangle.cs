// Triangle.cs
using System;

public class Triangle
{
    
    public double a;
    public double b;
    public double c;

    
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    
    public bool IsValid()
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

  
    public void PrintSides()
    {
        Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
    }
}