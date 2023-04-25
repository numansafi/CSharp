namespace TodoApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, There!");
        Console.WriteLine("Please Select one of the options below: ");
        Console.WriteLine("[S]ee all Todo items");
        Console.WriteLine("[A]dd a Todo item");
        Console.WriteLine("[R]emove a Todo item");
        Console.WriteLine("[E]xit");

        var userChoice = Console.ReadLine();
        PrintSelectedOptions(userChoice);
        Console.WriteLine(StringToInt(userChoice));
    }

    private static bool IsLong(string input)
    {
        return input.Length > 10;
    }

    private static void PrintSelectedOptions(string selectedOptions)
    {
        Console.WriteLine($"Selected Options: {selectedOptions}");
    }

    private static int SumOfTwoNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    static int StringToInt(string value)
    {
        return int.Parse(value);
    }

}