namespace Fundamentals;

public class Greetings
{
    public static void Execute()
    {
        Console.WriteLine("Write your name below:");
        var name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}! Welcome to C#");
    }
}
