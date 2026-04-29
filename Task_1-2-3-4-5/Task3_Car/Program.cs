// Program.cs (Задача 3)
using System;

class Program
{
    static void Main()
    {
       
        Car car1 = new Car { brand = "Toyota", model = "Camry", year = 2020 };
        Car car2 = new Car { brand = "BMW", model = "X5", year = 2022 };
        Car car3 = new Car { brand = "Lada", model = "Vesta" }; 

        
        Console.WriteLine($"Машина: {car1.brand} {car1.model}, год: {car1.year}");
        Console.WriteLine($"Машина: {car2.brand} {car2.model}, год: {car2.year}");
        Console.WriteLine($"Машина: {car3.brand} {car3.model}, год: {car3.year}");
    }
}