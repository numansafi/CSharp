namespace TodoApp;

internal class Program
{
    static void Main(string[] args)
    {
        string? userChoice;

        do
        {
            UserInterface.ShowMenu();
            userChoice = Console.ReadLine().ToUpper();
        } while (!Validation.ValidateUserChoice(userChoice));

    }




}

class UserInterface
{
    public static void ShowMenu()
    {
        Console.WriteLine("Hello, There!");
        Console.WriteLine("Please Select one of the options below: ");
        Console.WriteLine("[S]ee all Todo items");
        Console.WriteLine("[A]dd a Todo item");
        Console.WriteLine("[R]emove a Todo item");
        Console.WriteLine("[E]xit");
    }
}

class Validation
{
    public static bool ValidateUserChoice(string userChoice)
    {
        string[] menuButtons = { "S", "A", "R", "E" };

        return userChoice.Length == 1 && menuButtons.Contains(userChoice);
    }
}
