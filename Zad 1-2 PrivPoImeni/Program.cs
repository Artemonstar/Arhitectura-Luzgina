using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            SayHelloTo("Tom");
            SayHelloTo("Bob");
            SayHelloTo("Alice");
        }

        static void SayHelloTo(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}