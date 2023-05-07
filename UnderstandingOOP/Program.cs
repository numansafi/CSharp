namespace UnderstandingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 5);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculateCircumference());

            // var person = new Person("Numan Safi", 1996);

            var person1 = new Person
            {
                Name = "Numan",
                YearOfBirth = 1996
            };

            var d = DateTime.Now.Day;
        }
    }
}

public static class NumberToDayOfWeekTranslator
{
    public static string Translate(int day)
    {
        switch (day)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid day of the week";
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    // public Person(string name, int yearOfBirth)
    // {
    //     Name = name;
    //     YearOfBirth = yearOfBirth;
    // }

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
    private const int NumberOfSides = 4;
    public int Width { get; }
    public int Height { get; }

    public DateTime Date
    {
        get => Date;
        set
        {
            if (DateTime.Now.Year != value.Day)
            {
                Date = value;
            }
        }
    }

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(width, nameof(Height));
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int DefaultValueIfNonPositive = 1;

        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number");
            length = DefaultValueIfNonPositive;
        }

        return length;
    }

    public int CalculateCircumference() => (2 * Width) + (2 * Height);
    

    public int CalculateArea() => Width * Height;

    
}
