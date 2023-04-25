using System.ComponentModel.DataAnnotations;

namespace CalculatorApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, There!");
        Console.WriteLine("Input First Number: ");
        
        var firstNumber = Console.ReadLine();
        while (!IsNumber(firstNumber))
        {
            Console.WriteLine("Input First Number: ");
            firstNumber = Console.ReadLine();
        }

        Console.WriteLine("Input Second Number: ");

        var secondNumber = Console.ReadLine();
        while (!IsNumber(secondNumber))
        {
            Console.WriteLine("Input Second Number: ");
            secondNumber = Console.ReadLine();
        }

        CalculatorOptions();

        var userChoice = Console.ReadLine();
        while (!ValidateUserChoice(userChoice))
        {
            CalculatorOptions();
            userChoice = Console.ReadLine();
        }

        int firstNumberToInt = int.Parse(firstNumber);
        int secondNumberToInt = int.Parse(secondNumber);

        switch (userChoice.ToUpper())
        {
            case "A":
                var result = AddNumbers(firstNumberToInt, secondNumberToInt);
                PrintResults(firstNumberToInt, secondNumberToInt, "+", result);
                break;
            case "S":
                result = SubtractNumbers(firstNumberToInt, secondNumberToInt);
                PrintResults(firstNumberToInt, secondNumberToInt, "-", result);
                break;
            case "M":
                result = MultiplyNumbers(firstNumberToInt, secondNumberToInt);
                PrintResults(firstNumberToInt, secondNumberToInt, "*", result);
                break;
            case "D":
                result = DivideNumbers(firstNumberToInt, secondNumberToInt);
                PrintResults(firstNumberToInt, secondNumberToInt, "/", result);
                break;

        }


    }

    private static bool IsNumber(string value)
    {
        return int.TryParse(value, out int number);
    }

    private static void CalculatorOptions()
    {
        Console.WriteLine("\nWhat operation would you like to perform?");
        Console.WriteLine("[A]dd numbers");
        Console.WriteLine("[S]ubtract numbers");
        Console.WriteLine("[M]ultiply numbers");
        Console.WriteLine("[D]ivide numbers");
    }

    private static bool ValidateUserChoice(string value)
    {
        string[] options = { "A", "S", "M", "D" };

        if (value.Length == 1)
        {
            if (options.Contains(value.ToUpper())) return true;
            
        }

        return false;
    }

    private static void PrintResults(int num1, int num2, string sign, int result)
    {
        Console.WriteLine($"{num1} {sign} {num2} = {result}");
    }

    private static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    private static int SubtractNumbers(int num1, int num2)
    {
        return num1 - num2;
    }

    private static int MultiplyNumbers(int num1, int num2)
    {
        return num1 * num2;
    }

    private static int DivideNumbers(int num1, int num2)
    {
        return num1 / num2;
    }


}