namespace Fundamentals;

public class CurrentDate
{
    public static void Execute()
    {
        DateTime dateTime = DateTime.Now;

        Console.WriteLine(dateTime.ToString("F"));
        Console.WriteLine(dateTime.ToString("d"));
        Console.WriteLine(dateTime.ToString("HH"));
        Console.WriteLine(dateTime.ToString("dd/MMMM/yyyy"));
    }
}
