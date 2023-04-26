namespace CalculatorApp.src
{
    internal static class Validation
    {
        public static bool IsNumber(string? value)
        {
            return decimal.TryParse(value, out _);
        }

        public static bool ValidateUserChoice(string? value)
        {
            string[] options = { "A", "S", "M", "D" };

            return value!.Length == 1 && options.Contains(value.ToUpper());
        }
    }
}
