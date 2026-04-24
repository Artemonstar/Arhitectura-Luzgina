using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CalculateAge(1990, 2024);
            CalculateAge(2005, 2024);

            // вызов в сокращённой форме
            CalculateAgeShort(1990, 2024);
        }

        static void CalculateAge(int birthYear, int currentYear)
        {
            int age = currentYear - birthYear;
            Console.WriteLine($"Возраст: {age} лет");
        }

        // Сокращённая форма 
        static void CalculateAgeShort(int birthYear, int currentYear) =>
            Console.WriteLine($"Возраст: {currentYear - birthYear} лет");
    }
}