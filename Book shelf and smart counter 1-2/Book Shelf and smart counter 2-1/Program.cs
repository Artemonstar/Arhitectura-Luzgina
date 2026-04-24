using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            counter counter1 = new counter("Анна");
            counter counter2 = new counter("Борис");
            counter counter3 = new counter("Виктор");

            
            Console.WriteLine("=== Список посетителей ===");
            counter1.PrintInfo();
            counter2.PrintInfo();
            counter3.PrintInfo();

            Console.WriteLine(); 

            
            counter.ShowTotalVisitors();

           
            Console.ReadLine();
        }
    }
}