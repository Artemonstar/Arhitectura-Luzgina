// Program.cs (Задача 2)
class Program
{
    static void Main()
    {
        
        Student student1 = new Student();              
        Student student2 = new Student("Мария");       
        Student student3 = new Student("Петр", 22);    

        // Вывод информации
        student1.PrintInfo();
        student2.PrintInfo();
        student3.PrintInfo();
    }
}