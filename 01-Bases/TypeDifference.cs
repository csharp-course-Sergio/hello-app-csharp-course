partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;

        WriteLine($"{x}, {y}");

        Person p1 = new()
        {
            Name = "Sergio"
        };

        Person p2 = p1;
        p2.Name = "Jesús";

        WriteLine(p1.Name);
    }
}

class Person
{
    public string? Name { get; set; }
}