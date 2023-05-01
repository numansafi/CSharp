namespace UnderstandingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 5);
            Console.WriteLine(rectangle.Width);
            Console.WriteLine(rectangle.Height);

            
        }
    }
}

class Rectangle
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}