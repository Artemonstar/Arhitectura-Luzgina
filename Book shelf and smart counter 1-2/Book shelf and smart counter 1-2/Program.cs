using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book myBook = new Book();

            
            myBook.title = "Война и мир";
            myBook.author = "Лев Толстой";
            myBook.year = 1869;

           
            Console.Write("Информация о myBook: ");
            myBook.GetInfo();

         
            Book unknownBook = new Book();

            
            Console.Write("Информация о unknownBook: ");
            unknownBook.GetInfo();

            
            Console.ReadLine();
        }
    }
}