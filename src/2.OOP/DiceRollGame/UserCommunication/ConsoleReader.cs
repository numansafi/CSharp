namespace DiceRollGame.UserCommunication;

public class ConsoleReader
{
    public int AskUserForInput(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        } while (!ToInt(Console.ReadLine(), out result));

        return result;
    }

    private bool ToInt(string? str, out int result)
    {
        return int.TryParse(str, out result);
    }
}