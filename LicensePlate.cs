using System.Text.RegularExpressions;

namespace Fundamentals;

public class LicensePlate
{
    public static void Execute()
    {
        Console.WriteLine("Write a license plate with 7 chars below:");
        var plate = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(plate) || plate.Length < 7)
        {
            Console.WriteLine("Please write 7 chars below:");
            plate = Console.ReadLine();
        }

        Regex onlyLettersRegex = new Regex(@"^[a-zA-Z]+$");

        Regex onlyNumbersRegex = new Regex(@"^[0-9]+$");

        Console.WriteLine(onlyLettersRegex.IsMatch(plate.AsSpan(0, 3)) && onlyNumbersRegex.IsMatch(plate.AsSpan(3, 4)));
    }
}
