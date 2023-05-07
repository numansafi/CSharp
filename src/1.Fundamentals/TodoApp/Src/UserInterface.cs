namespace TodoApp.Src;

class UserInterface
{
    public static void ShowMenu()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("                                           ||");
        Console.WriteLine("Hello, There!                              ||");
        Console.WriteLine("                                           ||");
        Console.WriteLine("[S]ee all Todo items                       ||");
        Console.WriteLine("                                           ||");
        Console.WriteLine("[A]dd a Todo item                          ||");
        Console.WriteLine("                                           ||");
        Console.WriteLine("[R]emove a Todo item                       ||");
        Console.WriteLine("                                           ||");
        Console.WriteLine("[E]xit                                     ||");
        Console.WriteLine("===========================================");

        Console.Write("Please Select one of the options below:  ");

    }
}