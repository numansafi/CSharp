using TodoApp.Src;

namespace TodoApp;

internal class Program
{
    public static void Main()
    {
        var todoList = new List<string?>();
        var shouldExit = false;

        while (!shouldExit)
        {
            string? userChoice;
            do
            {
                UserInterface.ShowMenu();
                userChoice = Console.ReadLine()?.ToUpper();

                switch (userChoice)
                {
                    case "S":
                        TodoCommands.SeeAllTodoItems(todoList);
                        break;
                    case "A":
                        TodoCommands.AddTodoItem(todoList);
                        break;
                    case "R":
                        TodoCommands.RemoveTodoItem(todoList);
                        break;
                    case "E":
                        shouldExit = true;
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice\n");
                        break;
                }
            } while (userChoice != null && !Validation.IsUserChoiceValid(userChoice));
        }

    }

}