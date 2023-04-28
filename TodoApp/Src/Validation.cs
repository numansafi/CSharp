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
}