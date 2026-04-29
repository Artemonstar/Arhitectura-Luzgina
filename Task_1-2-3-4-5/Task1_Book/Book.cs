// Book.cs
using System;

public class Book
{
    
    public string title = "Неизвестно";
    public int pages;

    
    public void GetInfo()
    {
        Console.WriteLine($"Книга: {title}, страниц: {pages}");
    }
}