using System;
using OOPWorkshop;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== TASK 1 ===");
        Task1();

        Console.WriteLine("\n=== TASK 2 ===");
        Task2();

        Console.WriteLine("\n=== TASK 3 ===");
        Task3();

        Console.WriteLine("\n=== TASK 4 ===");
        Task4();

        Console.WriteLine("\n=== TASK 5 ===");
        Task5();

        Console.WriteLine("\n=== TASK 6 ===");
        Task6();
    }

    // ---------------------- TASK 1 ----------------------
    static void Task1()
    {
        Student s1 = new Student();
        s1.name = "Rahul";
        s1.age = 20;
        s1.address = "Kathmandu";

        Student s2 = new Student();
        s2.name = "Priya";
        s2.age = 22;
        s2.address = "Pokhara";

        Console.WriteLine($"{s1.name}, {s1.age}, {s1.address}");
        Console.WriteLine($"{s2.name}, {s2.age}, {s2.address}");
        Console.WriteLine("Static College: " + Student.collegeName);
    }

    // ---------------------- TASK 2 ----------------------
    static void Task2()
    {
        Calculator calc = new Calculator();
        calc.PrintWelcome();

        Console.WriteLine("Add: " + calc.Add(5, 10));
        Console.WriteLine("Multiply default: " + calc.Multiply(5));
        Console.WriteLine("Multiply normal: " + calc.Multiply(5, 3));
    }

    // ---------------------- TASK 3 ----------------------
    static void Task3()
    {
        ParameterDemo demo = new ParameterDemo();

        int num = 10;
        demo.Increase(ref num);
        Console.WriteLine("Increased: " + num);

        demo.GetFullName(out string fullname);
        Console.WriteLine("Fullname: " + fullname);

        int total = demo.SumAll(1, 2, 3, 4);
        Console.WriteLine("SumAll: " + total);
    }

    // ---------------------- TASK 4 ----------------------
    static void Task4()
    {
        Player p1 = new Player();
        Player p2 = new Player("Ninja", 10, 200);

        Console.WriteLine($"Player2 → Name: {p2.playerName}, Level: {p2.level}, HP: {p2.health}");
    }

    // ---------------------- TASK 5 ----------------------
    static void Task5()
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine()?.ToLower() ?? "";


        if (day == "friday" || day == "saturday")
            Console.WriteLine(DayType.Weekend);
        else
            Console.WriteLine(DayType.Weekday);

        Book b1 = new Book("C# Basics", "John Doe", 500);
        Book b2 = b1 with { title = "Advanced C#", price = 900 };

        Console.WriteLine(b1);

        var (title, author, price) = b2;
        Console.WriteLine($"Deconstructed → {title}, {author}, {price}");
    }

    // ---------------------- TASK 6 ----------------------
    static void Task6()
    {
        Console.Write("Enter marks: ");
        bool markOk = int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        bool totalOk = int.TryParse(Console.ReadLine(), out int total);

        if (!markOk || !totalOk || total == 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        double percentage = (double)marks / total * 100;
        Console.WriteLine("Percentage: " + percentage);
    }
}
