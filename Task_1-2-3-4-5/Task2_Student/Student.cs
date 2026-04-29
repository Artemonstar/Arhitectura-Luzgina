// Student.cs
using System;

public class Student
{
    
    public string name;
    public int age;

   
    public Student() : this("Иван", 18)
    {
    }

    
    public Student(string name) : this(name, 18)
    {
    }

    
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

   
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}