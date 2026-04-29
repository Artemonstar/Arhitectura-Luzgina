// Program.cs (Задача 1)
class Program
{
    static void Main()
    {
        
        Book book1 = new Book();
        book1.title = "Война и мир";
        book1.pages = 1200;

        Book book2 = new Book();
        book2.title = "1984";
        book2.pages = 300;

        Book book3 = new Book();
        book3.title = "Неизвестно"; 
        book3.pages = 500;

        
        book1.GetInfo();
        book2.GetInfo();
        book3.GetInfo();
    }
}