namespace UnderstandingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 5);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculateCircumference());



        }
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;


    public MedicalAppointment() : this ("Numan", 7)
    {

    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);

    }

    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
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

    public int CalculateCircumference()
    {
        return (2 * Width) + (2 * Height);
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}
