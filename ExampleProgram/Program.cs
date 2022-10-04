using ExampleProgram;

public class Program
{
    public static void Main()
    {

        Consultant joe = new Consultant("Joe", "PXEL", 15);
        Consultant jimmy = new Manager("Jimmy", "PXEL", 15, 5);

        ICollection<Consultant> consultants = new List<Consultant>()
        {
            joe,
            jimmy
        };

        foreach (var consultant in consultants)
        {
            Console.WriteLine(consultant);
        }

        //Joe is in the PXEL practice with a compensation of  15.
        //Jimmy is in the PXEL practice with a compensation of  20.
    }
}
