namespace DiceRollGame;
public class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Dice
{
    private readonly Random _random;
    private const int NumberOfSides = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, NumberOfSides + 1);
}
