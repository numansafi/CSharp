namespace TodoApp.Src;

class TodoCommands
{
    public static string? AskUserForTodoItem()
    {
        string? userTodoItem = null;
        var isDescriptionEmpty = true;

        while (isDescriptionEmpty)
        {
            Console.Write("Enter Todo item Description: ");
            userTodoItem = Console.ReadLine();

            if (string.IsNullOrEmpty(userTodoItem))
            {
                Console.WriteLine("The description cannot be empty!");
                continue;
            }
            isDescriptionEmpty = false;
        }

        return userTodoItem;
    }

    public static void AddTodoItem(string? itemToAdd, List<string?> todoList)
    {
        while (todoList.Contains(itemToAdd))
        {
            Console.WriteLine("Todo description must be unique!");
            itemToAdd = AskUserForTodoItem();
        }

        todoList.Add(itemToAdd);
    }

    public static void SeeAllTodoItems(List<string?> todoList)
    {
        Console.WriteLine("\n\t\tTodo List");
        Console.WriteLine("------------------------------------");
        for (int i = 0; i < todoList.Count; i++)
        {

            Console.WriteLine($"{i + 1}|\t{todoList[i]}");
            Console.WriteLine("------------------------------------");

        }
    }

    public static void RemoveTodoItem(List<string?> todoList)
    {
        var index = 0;
        var isIndexValid = false;

        while (!isIndexValid)
        {
            SeeAllTodoItems(todoList);
            Console.Write("Select the index of the Todo item you want to remove: ");
            var userTodoItem = Console.ReadLine();

            if (string.IsNullOrEmpty(userTodoItem))
            {
                Console.WriteLine("Selected Index cannot be empty");
            }
            else if (!int.TryParse(userTodoItem, out index))
            {
                Console.WriteLine("Selected Index must be a number");
            }
            else if (index <= 0 || (index > todoList.Count))
            {
                Console.WriteLine("The given index is out of range");
            }
            else
            {
                isIndexValid = true;
            }
        }

        Console.WriteLine("Todo Item being deleted......");
        todoList.RemoveAt(index - 1);
        SeeAllTodoItems(todoList);
    }
}