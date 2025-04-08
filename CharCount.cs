namespace Fundamentals;

public class CharCount
{
    public static void Execute()
    {
        Console.WriteLine("Write your words below:");
        var words = Console.ReadLine();

        while(string.IsNullOrWhiteSpace(words))
        {
            Console.WriteLine("Please write at least one word.");
            Console.WriteLine("Write your words below:");
            words = Console.ReadLine();
        }

        string[] separatedWords = words.Trim().Split(" ");

        foreach (var word in separatedWords)
        {
            Console.WriteLine($"{word} -> {word.Length}");
        }
    }
}
