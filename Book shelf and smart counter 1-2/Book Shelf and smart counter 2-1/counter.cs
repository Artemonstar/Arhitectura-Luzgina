using System;

namespace Counter
{
    class counter
    {
    
        public string name;

       
        private static int totalVisitors = 0;

        
        public counter(string visitorName)
        {
            name = visitorName;
            totalVisitors++; 
        }

        
        public void PrintInfo()
        {
            Console.WriteLine($"Посетитель: {name}");
        }

        
        public static void ShowTotalVisitors()
        {
            Console.WriteLine($"Всего создано посетителей: {totalVisitors}");
        }
    }
}