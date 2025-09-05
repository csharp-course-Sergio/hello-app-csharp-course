partial class Program
{
    static void DataStructures()
    {
        User pedro = new()
        {
            Name = "Pedro",
            Age = 33
        };

        pedro.Greet();

        Point punto = new()
        {
            X = 30,
            Y = 20
        };

        WriteLine($"Punto ({punto.X}, {punto.Y})");

        CellPhone nokia = new("Nokia 225", 2024);
        WriteLine(nokia);
    }
}

// Objetos complejos
class User
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public void Greet()
    {
        WriteLine($"Hola soy el usuario {Name} y tengo {Age} años");
    }
}

// Objetos ligeros
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

// Datos inmutables
record CellPhone(string Model, int Year);