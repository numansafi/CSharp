namespace TodoApp.Src;

class TodoCommands
{
    public static void AddTodoItem(List<string?> todoList)
    {
        string? description;
        do
        {
            Console.Write("Enter Todo item Description: ");
            description = Console.ReadLine();
        } while (!Validation.IsDescriptionValid(description, todoList));

        todoList.Add(description);
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
        string? userInput;
        var index = 0;
        do
        {
            SeeAllTodoItems(todoList);
            Console.Write("Select the index of the Todo item you want to remove: ");
            userInput = Console.ReadLine();
        } while (!Validation.IsIndexValid(userInput, todoList, out index)
);

        Console.WriteLine("Todo Item being deleted......");
        todoList.RemoveAt(index - 1);
        SeeAllTodoItems(todoList);
    }
}