namespace CalculatorApp.src
{
    internal class UiOptions
    {
        public static void CalculatorOptions()
        {
            Console.WriteLine("\nWhat operation would you like to perform?");
            Console.WriteLine("[A]dd numbers");
            Console.WriteLine("[S]ubtract numbers");
            Console.WriteLine("[M]ultiply numbers");
            Console.WriteLine("[D]ivide numbers");
        }

        public static string? AskForUserInput(string choice)
        {
            Console.WriteLine($"Input {choice} Number: ");
            var numberChoice = Console.ReadLine();
            return numberChoice;
        }

        public static void PrintResults(decimal num1, decimal num2, string sign, decimal result)
        {
            Console.WriteLine($"{num1} {sign} {num2} = {result}");
        }
    }
}
