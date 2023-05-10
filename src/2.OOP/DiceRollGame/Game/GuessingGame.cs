using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game;

public class GuessingGame
{
    private readonly Dice _dice;
    private readonly ConsoleReader _consoleReader;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice, ConsoleReader consoleReader)
    {
        _dice = dice;
        _consoleReader = consoleReader;
    }

    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine("Dice Rolled! Guess what number it shows in 3 tries");

        var triesLeft = InitialTries;

        while (triesLeft > 0)
        {
            var guess = _consoleReader.AskUserForInput("Enter a number: ");
            if (guess == diceRollResult)
            {
                return GameResult.Win;
            }

            triesLeft--;
            Console.WriteLine($"Wrong Number. Tries left: {triesLeft}");
        }

        return GameResult.Lose;
    }

    public void PrintResults(GameResult gameResult)
    {
        var message = gameResult == GameResult.Win ? "You Win!!" : "You Lose :(";
        Console.WriteLine(message);
    }
}