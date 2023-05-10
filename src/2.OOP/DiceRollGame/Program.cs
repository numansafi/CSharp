using DiceRollGame.Game;
using DiceRollGame.UserCommunication;

namespace DiceRollGame;
public class Program
{ 
    static void Main(string[] args)
    {
        var random = new Random();
        var dice = new Dice(random);
        var consoleReader = new ConsoleReader();
        var guessingGame = new GuessingGame(dice, consoleReader);
        var gameResult = guessingGame.Play();
        guessingGame.PrintResults(gameResult);
    }
}