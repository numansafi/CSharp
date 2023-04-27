namespace TodoApp;

internal class Program
{
    static void Main(string[] args)
    {
        string? userChoice;

        List<string> todoList = new List<string>();

        do
        {
            UserInterface.ShowMenu();
            userChoice = Console.ReadLine().ToUpper();

            switch (userChoice)
            {
                case "S":
                    TodoCommands.SeeAllTodoItems(todoList);
                    break;
                case "A":
                    string item = TodoCommands.GetTodoItem();
                    TodoCommands.AddTodoItem(item, todoList);
                    break;
                case "R":
                case "E":
                    break;
            }
        } while (!Validation.IsUserChoiceValid(userChoice));


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
    public static bool IsUserChoiceValid(string userChoice)
    {
        string[] menuButtons = { "S", "A", "R", "E" };

        if (userChoice.Length == 1 && menuButtons.Contains(userChoice))
        {
            return true;
        }

        Console.WriteLine("Invalid Choice\n");
        return false;
    }
}

class TodoCommands
{
    public static string GetTodoItem()
    {
        string userTodoItem;

        do
        {
            Console.WriteLine("Enter the TODO item Description");
            userTodoItem = Console.ReadLine();
        } while (string.IsNullOrEmpty(userTodoItem));

        return userTodoItem;

        
    }
    public static void AddTodoItem(string itemToAdd, List<string> TodoList)
    {
        if (TodoList.Contains(itemToAdd))
        {
            Console.WriteLine("Todo description must be unique!");
            return;
        }

        TodoList.Add(itemToAdd);
    }

    public static void SeeAllTodoItems(List<string> todoList)
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{todoList[i]}");
        }
    }
}
