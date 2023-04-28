namespace TodoApp.Src;

class Validation
{
    public static bool IsUserChoiceValid(string userChoice)
    {
        string[] menuButtons = { "S", "A", "R", "E" };

        if (userChoice.Length == 1 && menuButtons.Contains(userChoice))
        {
            return true;
        }

        return false;
    }

    public static bool IsDescriptionValid(string? description, List<string?> todoList)
    {
        if (string.IsNullOrEmpty(description))
        {
            Console.WriteLine("The description cannot be empty!\n");
            return false;
        }

        if (todoList.Contains(description))
        {
            Console.WriteLine("Todo description must be unique!\n");
            return false;
        }
        return true;
    }

    public static bool IsIndexValid(string? userInput, List<string?> todoList, out int index)
    {
        index = 0;
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Selected Index cannot be empty");
            return false;
        }
        if (!int.TryParse(userInput, out index))
        {
            Console.WriteLine("Selected Index not is not valid whole number");
            return false;
        }

        if (index <= 0 || (index > todoList.Count))
        {
            Console.WriteLine("The given index is out of range");
            return false;
        }

        return true;
    }
}