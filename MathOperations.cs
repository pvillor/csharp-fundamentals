namespace Fundamentals;

public class MathOperations
{
    public static void Execute()
    {
        Console.WriteLine("Write your first number below:");
        var firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Write your second number below:");
        var secondNumber = Convert.ToDouble(Console.ReadLine());

        if (secondNumber == 0)
        { 
            Console.WriteLine("You cannot select 0 as your second number.");
            Console.WriteLine("Write your second number below:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
        }

        double sum = firstNumber + secondNumber;
        double subtraction = firstNumber - secondNumber;
        double multiplication = firstNumber * secondNumber;
        double division = firstNumber / secondNumber;
        double average = sum / 2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");
        Console.WriteLine($"Division: {division}");
        Console.WriteLine($"Average: {average}");
    }
}
