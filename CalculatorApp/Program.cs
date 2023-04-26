namespace CalculatorApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, There!");

        string? firstNumber, secondNumber, userChoice;

        do
        {
            firstNumber = UiOptions.AskForUserInput("first");
        } while (!Validation.IsNumber(firstNumber));


        do
        {
            secondNumber = UiOptions.AskForUserInput("second");
        } while (!Validation.IsNumber(secondNumber)) ;

        do
        {
            UiOptions.CalculatorOptions();
            userChoice = Console.ReadLine();
        } while (!Validation.ValidateUserChoice(userChoice));

        var firstNumberToInt = decimal.Parse(firstNumber!);
        var secondNumberToInt = decimal.Parse(secondNumber!);

        switch (userChoice!.ToUpper())
        {
            case "A":
                var result = CalculatorOperations.AddNumbers(firstNumberToInt, secondNumberToInt);
                UiOptions.PrintResults(firstNumberToInt, secondNumberToInt, "+", result);
                break;
            case "S":
                result = CalculatorOperations.SubtractNumbers(firstNumberToInt, secondNumberToInt);
                UiOptions.PrintResults(firstNumberToInt, secondNumberToInt, "-", result);
                break;
            case "M":
                result = CalculatorOperations.MultiplyNumbers(firstNumberToInt, secondNumberToInt);
                UiOptions.PrintResults(firstNumberToInt, secondNumberToInt, "*", result);
                break;
            case "D":
                result = CalculatorOperations.DivideNumbers(firstNumberToInt, secondNumberToInt);
                UiOptions.PrintResults(firstNumberToInt, secondNumberToInt, "/", result);
                break;
        }


    }

}