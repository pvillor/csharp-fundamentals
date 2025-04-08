namespace Fundamentals;

public class FullName
{
    public static void Execute()
    {
        Console.WriteLine("Write your first name below:");
        var firstName = Console.ReadLine();

        Console.WriteLine("Write your last name below:");
        var lastName = Console.ReadLine();

        Console.WriteLine($"{firstName} {lastName}");
    }
}
