internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("перше число:");
        string input1 = Console.ReadLine();

        Console.WriteLine("друге число:");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"Сума двох чисел: {sum}");
        }
        else
        {
            Console.WriteLine("Введено некоректні числа. Будь ласка, введіть числа коректно.");
        }

        Console.ReadLine();
    }
}